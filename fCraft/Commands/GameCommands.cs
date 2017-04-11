using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fCraft.Commands
{
    internal static class GameCommands
    {
        internal static void Init()
        {
            CommandManager.RegisterCommand(CdFFAStatistics);
            CommandManager.RegisterCommand(CdFreeForAll);
            CommandManager.RegisterCommand(CdTDStatistics);
            CommandManager.RegisterCommand(CdTeamDeathMatch);
            CommandManager.RegisterCommand(CdInfection);
            CommandManager.RegisterCommand(CdCTF);
            
        }

        
        /* Copyright (c) <2012-2014> <LeChosenOne, DingusBungus>
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/
           #region Gamemodes

        static readonly CommandDescriptor CdCTF = new CommandDescriptor
        {
            Name = "CTF",
            Aliases = new[] { "CaptureTheFlag", "percyjackson", "camphalfblood" },
            Category = CommandCategory.Games,
            Permissions = new Permission[] { Permission.Games },
            IsConsoleSafe = false,
            Usage = "/CTF [Start | Stop | SetSpawn | SetFlag | Help]",
            Help = "Manage the CTF Game!",
            Handler = CTFHandler
        };

        private static void CTFHandler(Player player, Command cmd)
        {
            string option = cmd.Next();
            if (String.IsNullOrEmpty(option))
            {
                player.Message("Please select an option in the CTF menu!");
                return;
            }

            World world = player.World;

            switch (option.ToLower())
            {
                case "begin":
                case "start":

                    if (world.blueCTFSpawn == new Vector3I(0, 0, 0) || world.redCTFSpawn == new Vector3I(0, 0, 0))
                    {
                        player.Message("&cYou must assign spawn points before the game starts! Use /CTF SetSpawn <red | blue>");
                        return;
                    }
                    if (world.blueFlag == new Vector3I(0, 0, 0) || world.redFlag == new Vector3I(0, 0, 0))
                    {
                        player.Message("&cYou must set the flags before play! Use /CTF SetFlag <red | blue>");
                        return;
                    }

                    if (world.Players.Count() < 2)
                    {
                        player.Message("&cYou need at least 2 players to play CTF");
                        return;
                    }

                    try
                    {
                        foreach (Player p in player.World.Players)
                        {
                            p.JoinWorld(player.World, WorldChangeReason.Rejoin);
                        }

                        CTF.GetInstance(world);
                        CTF.Start();
                    }
                    catch (Exception e)
                    {
                        Logger.Log(LogType.Error, "Error: " + e + e.Message);
                    }
                    break;
                case "end":
                case "stop":
                    if (world.gameMode != GameMode.CaptureTheFlag)
                    {
                        player.Message("&cThere is no game of CTF currently going on!");
                        break;
                    }

                    CTF.Stop(player);
                    break;
                case "setspawn":
                    if (world.gameMode != GameMode.Null)
                    {
                        player.Message("&cYou cannot change spawns during the game!");
                        return;
                    }

                    string team = cmd.Next();
                    if (String.IsNullOrEmpty(team))
                    {
                        player.Message("&cPlease select a team to set a spawn for!");
                        break;
                    }

                    if (team.ToLower() == "red")
                    {
                        world.redCTFSpawn = new Vector3I(player.Position.ToBlockCoords().X, player.Position.ToBlockCoords().Y, player.Position.ToBlockCoords().Z + 2);
                        player.Message("&aRed team spawn set.");
                        break;
                    }
                    else if (team.ToLower() == "blue")
                    {
                        world.blueCTFSpawn = new Vector3I(player.Position.ToBlockCoords().X, player.Position.ToBlockCoords().Y, player.Position.ToBlockCoords().Z + 2);
                        player.Message("&aBlue team spawn set.");
                        break;
                    }
                    else
                    {
                        player.Message("&cYou may only select the 'Blue' or 'Red' team!");
                        break;
                    }
                case "setflag":
                    if (world.gameMode != GameMode.Null)
                    {
                        player.Message("&cYou cannot change flags during the game!");
                        return;
                    }

                    string flag = cmd.Next();
                    if (String.IsNullOrEmpty(flag))
                    {
                        player.Message("&cPlease select a flag color to set!");
                        break;
                    }

                    if (flag.ToLower() == "red")
                    {
                        //select red flag
                        player.Message("&fPlease select where you wish to place the &cred&f flag. The &cred&f flag must be red wool.");
                        player.Info.placingRedFlag = true;
                        break;
                    }
                    else if (flag.ToLower() == "blue")
                    {
                        player.Message("&fPlease select where you wish to place the &9blue&f flag. The &9blue&f flag must be blue wool.");
                        player.Info.placingBlueFlag = true;
                        break;
                    }
                    else
                    {
                        player.Message("&cYou may only select a 'Blue' or 'Red' colored flag!");
                        break;
                    }
                case "help":
                case "rules":
                    player.Message("Start: Starts the CTF game.");
                    player.Message("Stop: Ends the CTF game.");
                    player.Message("SetSpawn: Usage is /CTF SetSpawn <Red|Blue>. The spawn for each team will be set at your feet. Both spawns must be set for the game to begin.");
                    player.Message("SetFlag: Usage is /CTF SetFlag <Red|Blue>. The next block clicked will be the corresponding team's flag. The blue flag must be a blue wool block, and the red flag must be a red wool block.");
                    break;
                default:
                    CdCTF.PrintUsage(player);
                    break;
            }
        }

        static readonly CommandDescriptor CdInfection = new CommandDescriptor
        {
            Name = "Infection",
            Aliases = new[] { "ZombieSurvival", "zs" },
            Category = CommandCategory.Games,
            Permissions = new Permission[] { Permission.Games },
            IsConsoleSafe = false,
            Usage = "/Infection [start | stop | custom | help]",
            Help = "Manage the Infection Gamemode!",
            Handler = InfectionHandler
        };

        private static void InfectionHandler(Player player, Command cmd)
        {
            string Option = cmd.Next();
            World world = player.World;

            if (string.IsNullOrEmpty(Option))
            {
                CdInfection.PrintUsage(player);
                return;
            }
            if (Option.ToLower() == "start")
            {
                if (world == WorldManager.MainWorld)
                {
                    player.Message("&SInfection games cannot be played on the main world");
                    return;
                }
                if (world.gameMode != GameMode.Null)
                {
                    player.Message("&SThere is already a game going on");
                    return;
                }
                if (player.World.CountPlayers(true) < 2)
                {
                    player.Message("&SThere must be at least &W2&S players on this world to play Infection");
                    return;
                }

                else
                {
                    try
                    {
                        player.World.Hax = false;
                        foreach (Player p in player.World.Players)
                        {
                            p.JoinWorld(player.World, WorldChangeReason.Rejoin);
                        }

                        fCraft.Games.Infection.GetInstance(world);
                        fCraft.Games.Infection.Start();
                    }
                    catch (Exception e)
                    {
                        Logger.Log(LogType.Error, "Error: " + e + e.Message);
                    }
                    return;
                }
            }
            if (Option.ToLower() == "stop")
            {
                if (world.gameMode == GameMode.Infection)
                {
                    fCraft.Games.Infection.Stop(player);
                    return;
                }
                else
                {
                    player.Message("&SNo games of Infection are going on.");
                    return;
                }
            }
            if (Option.ToLower() == "custom")
            {
                string stringLimit = cmd.Next();
                string stringDelay = cmd.Next();
                int intLimit, intDelay;

                if (String.IsNullOrEmpty(stringLimit) || String.IsNullOrEmpty(stringDelay))
                {
                    player.Message("Usage for '/infection custom' is '/infection custom TimeLimit TimeDelay'.");
                }

                if (!int.TryParse(stringLimit, out intLimit))
                {
                    player.Message("Please select a number for the time limit.");
                    return;
                }

                if (!int.TryParse(stringDelay, out intDelay))
                {
                    player.Message("Please select a number for the time delay.");
                    return;
                }

                if (world == WorldManager.MainWorld)
                {
                    player.Message("&SInfection games cannot be played on the main world");
                    return;
                }
                if (world.gameMode != GameMode.Null)
                {
                    player.Message("&SThere is already a game going on");
                    return;
                }
                if (player.World.CountPlayers(true) < 2)
                {
                    player.Message("&SThere must be at least &W2&S players on this world to play Infection");
                    return;
                }
                if (intLimit > 900 || intLimit < 60)
                {
                    player.Message("&SThe game must be between 60 and 900 seconds! (1 and 15 minutes)");
                    return;
                }
                if (intDelay > 60 || intDelay < 11)
                {
                    player.Message("&SThe game delay must be greater than 10 seconds, but less than 60 seconds!");
                    return;
                }
                else
                {
                    try
                    {
                        player.World.Hax = false;
                        foreach (Player p in player.World.Players)
                        {
                            p.JoinWorld(player.World, WorldChangeReason.Rejoin);
                        }

                        fCraft.Games.Infection.GetInstance(world);
                        fCraft.Games.Infection.Custom(intLimit, intDelay);
                    }
                    catch (Exception e)
                    {
                        Logger.Log(LogType.Error, "Error: " + e + e.Message);
                    }
                    return;
                }
            }
            if (Option.ToLower() == "help")
            {
                player.Message("&SStart: Will begin a game of infection on the current world.\n" +
                    "&SStop: Will end a game of infection on the current world.\n" +
                    "&SCustom: Determines factors in the next Infection game. Factors are TimeLimit and TimeDelay. TimeDelay must be greater than 10.\n" +
                    "&fExample: '/Infection Custom 100 12' would start an Infection game with a game length of 100 seconds, and it will begin in 12 seconds.\n"
                    );

            }
            else
            {
                CdInfection.PrintUsage(player);
                return;
            }
        }
        static readonly CommandDescriptor CdTeamDeathMatch = new CommandDescriptor
        {
            Name = "TeamDeathMatch",            //I think I resolved all of the bugs...
            Aliases = new[] { "td", "tdm" },
            Category = CommandCategory.Games,
            Permissions = new Permission[] { Permission.Games },
            IsConsoleSafe = false,
            Usage = "/TeamDeathMatch [Start | Stop | Time | Score | ScoreLimit | TimeLimit | TimeDelay | Settings | Red | Blue | ManualTeams | About | Help]",
            Help = "Manage the TDM Gamemode!",
            Handler = TDHandler
        };

        private static void TDHandler(Player player, Command cmd)       //For TDM Game: starting/ending game, customizing game options, viewing score, etc.
        {

            string Option = cmd.Next();
            World world = player.World;

            if (string.IsNullOrEmpty(Option))
            {
                CdTeamDeathMatch.PrintUsage(player);
                return;
            }
            if (Option.ToLower() == "start" || Option.ToLower() == "on")    //starts the game
            {
                if (world == WorldManager.MainWorld)
                {
                    player.Message("TDM games cannot be played on the main world");
                    return;
                }
                if (world.gameMode != GameMode.Null)
                {
                    player.Message("There is already a game going on");
                    return;
                }
                if (player.World.CountPlayers(true) < 2)
                {
                    player.Message("There needs to be at least &W2&S players to play TDM");
                    return;
                }
                if (TeamDeathMatch.blueSpawn == Position.Zero || TeamDeathMatch.redSpawn == Position.Zero)
                {
                    player.Message("You must first assign the team's spawn points with &H/TD SetSpawn (Red/Blue)");
                    return;
                }
                else
                {
                    player.World.Hax = false;
                    foreach (Player p in player.World.Players)
                    {
                        p.JoinWorld(player.World, WorldChangeReason.Rejoin);
                    }
                    TeamDeathMatch.GetInstance(player.World);
                    TeamDeathMatch.Start();
                    return;
                }
            }
            if (Option.ToLower() == "stop" || Option.ToLower() == "off") //stops the game
            {
                if (TeamDeathMatch.isOn)
                {
                    TeamDeathMatch.Stop(player);
                    return;
                }
                else
                {
                    player.Message("No games of Team DeathMatch are going on");
                    return;
                }
            }
            if (Option.ToLower() == "manualteams")
            {
                string option = cmd.Next();
                if (string.IsNullOrEmpty(option) || option.Length < 2 || option.Length > 9)
                {
                    player.Message("Use like: /TD ManualTeams (On/Off)");
                    return;
                }
                if (option.ToLower() == "off" || option.ToLower() == "auto" || option.ToLower() == "automatic")
                {
                    if (!TeamDeathMatch.manualTeams)
                    {
                        player.Message("The team assign option is already set to &wAuto");
                        return;
                    }
                    TeamDeathMatch.manualTeams = false;
                    player.Message("The team assign option has been set to &WAuto&s.");
                    return;
                }
                if (option.ToLower() == "on" || option.ToLower() == "manual")
                {
                    if (TeamDeathMatch.manualTeams)
                    {
                        player.Message("The team assign option is already set to &wManual");
                        return;
                    }
                    TeamDeathMatch.manualTeams = true;
                    player.Message("The team assign option has been set to &WManual&s.");
                    return;
                }
            }
            if (TeamDeathMatch.isOn && (Option.ToLower() == "timelimit" || Option.ToLower() == "scorelimit" || Option.ToLower() == "timedelay"))
            {
                player.Message("You cannot adjust game settings while a game is going on");
                return;
            }
            if (!TeamDeathMatch.isOn && (Option.ToLower() == "timelimit" || Option.ToLower() == "scorelimit" || Option.ToLower() == "timedelay"))
            {
                if (Option.ToLower() == "timelimit")    //option to change the length of the game (5m default)
                {
                    string time = cmd.Next();
                    if (time == null)
                    {
                        player.Message("Use the syntax: /TD timelimit (whole number of minutes)\n&HNote: The acceptable times are from 1-20 minutes");
                        return;
                    }
                    int timeLimit = 0;
                    bool parsed = Int32.TryParse(time, out timeLimit);
                    if (!parsed)
                    {
                        player.Message("Enter a whole number of minutes. For example: /TD timelimit 5");
                        return;
                    }
                    if (timeLimit < 1 || timeLimit > 20)
                    {
                        player.Message("The accepted times are between 1 and 20 minutes");
                        return;
                    }
                    else
                    {
                        TeamDeathMatch.timeLimit = (timeLimit * 60);
                        player.Message("The time limit has been changed to &W{0}&S minutes", timeLimit);
                        return;
                    }
                }
                if (Option.ToLower() == "timedelay")    //option to set the time delay for TDM games (20s default)
                {
                    if (TeamDeathMatch.manualTeams)
                    {
                        player.Message("The manual team assign option is enabled so the delay is 30 seconds to enable team assigning");
                        return;
                    }
                    string time = cmd.Next();
                    if (time == null)
                    {
                        player.Message("Use the syntax: /TD timedelay (whole number of seconds)\n&HNote: The acceptable times incriment by 10 from 10 to 60");
                        return;
                    }
                    int timeDelay = 0;
                    bool parsed = Int32.TryParse(time, out timeDelay);
                    if (!parsed)
                    {
                        player.Message("Enter a whole number of minutes. For example: /TD timedelay 20");
                        return;
                    }
                    if (timeDelay != 10 && timeDelay != 20 && timeDelay != 30 && timeDelay != 40 && timeDelay != 50 && timeDelay != 60)
                    {
                        player.Message("The accepted times are 10, 20, 30, 40, 50, and 60 seconds");
                        return;
                    }
                    else
                    {
                        TeamDeathMatch.timeDelay = timeDelay;
                        player.Message("The time delay has been changed to &W{0}&s seconds", timeDelay);
                        return;
                    }
                }
                if (Option.ToLower() == "scorelimit")       //changes the score limit (30 default)
                {
                    string score = cmd.Next();
                    if (score == null)
                    {
                        player.Message("Use the syntax: /TD scorelimit (whole number)\n&HNote: The acceptable scores are from 5-300 points");
                        return;
                    }
                    int scoreLimit = 0;
                    bool parsed = Int32.TryParse(score, out scoreLimit);
                    if (!parsed)
                    {
                        player.Message("Enter a whole number score. For example: /TD scorelimit 50");
                        return;
                    }
                    if (scoreLimit < 5 || scoreLimit > 300)
                    {
                        player.Message("The accepted scores are from 5-300 points");
                        return;
                    }
                    else
                    {
                        TeamDeathMatch.scoreLimit = scoreLimit;
                        player.Message("The score limit has been changed to &W{0}&s points", scoreLimit);
                        return;
                    }
                }
            }
            if (Option.ToLower() == "red")
            {
                string target = cmd.Next();
                if (target == null)
                {
                    player.Message("Use like: /TD Red <PlayerName>");
                    return;
                }
                Player targetP = Server.FindPlayerOrPrintMatches(player, target, true, true);
                if (targetP == null) return;
                if (player.World.gameMode == GameMode.TeamDeathMatch && !TeamDeathMatch.isOn)
                {
                    TeamDeathMatch.AssignRed(targetP);
                    return;
                }
                else
                {
                    player.Message("You can only assign teams during the delay of a Team DeathMatch Game.");
                    return;
                }
            }
            if (Option.ToLower() == "blue")
            {
                string target = cmd.Next();
                if (target == null)
                {
                    player.Message("Use like: /TD Blue <PlayerName>");
                    return;
                }
                Player targetP = Server.FindPlayerOrPrintMatches(player, target, true, true);
                if (targetP == null) return;
                if (player.World.gameMode == GameMode.TeamDeathMatch && !TeamDeathMatch.isOn)
                {
                    TeamDeathMatch.AssignBlue(targetP);
                    return;
                }
                else
                {
                    player.Message("You can only assign teams during the delay of a Team DeathMatch Game.");
                    return;
                }
            }
            if (Option.ToLower() == "setspawn")
            {
                string team = cmd.Next();
                if (string.IsNullOrEmpty(team) || team.Length < 1)
                {
                    player.Message("Use like: /TD SetSpawn (Red/Blue)");
                    return;
                }
                if (TeamDeathMatch.isOn)
                {
                    player.Message("You cannot change the spawn during the game!");
                    return;
                }
                if (!TeamDeathMatch.isOn && player.World != WorldManager.MainWorld)
                {
                    switch (team.ToLower())
                    {
                        default:
                            player.Message("Use like: /TD SetSpawn (Red/Blue)");
                            return;
                        case "red":
                            TeamDeathMatch.redSpawn = player.Position;
                            player.Message("&SSpawn for the &cRed&S team set.");
                            return;
                        case "blue":
                            TeamDeathMatch.blueSpawn = player.Position;
                            player.Message("&SSpawn for the &1Blue&S team set.");
                            return;
                    }
                }
                else
                {
                    if (player.World == WorldManager.MainWorld) { player.Message("You cannot play TDM on the main world"); return; }
                    else if (TeamDeathMatch.isOn)
                    {
                        player.Message("You can only set the team spawns during the delay or before the game");
                        return;
                    }
                }
            }
            if (Option.ToLower() == "score")       //scoreboard for the matchs, different messages for when the game has ended. //td score
            {
                int red = TeamDeathMatch.redScore;
                int blue = TeamDeathMatch.blueScore;

                if (red > blue)
                {
                    if (player.Info.isOnRedTeam)
                    {
                        player.Message("&sYour team is winning {0} to {1}", red, blue);
                        return;
                    }
                    if (player.Info.isOnBlueTeam)
                    {
                        player.Message("&sYour team is losing {0} to {1}", red, blue);
                        return;
                    }
                    else
                    {
                        player.Message("&sThe &cRed Team&s won {0} to {1}", red, blue);
                        return;
                    }
                }
                if (red < blue)
                {
                    if (player.Info.isOnBlueTeam)
                    {
                        player.Message("&sYour team is winning {0} to {1}", blue, red);
                        return;
                    }
                    if (player.Info.isOnRedTeam)
                    {
                        player.Message("&sYour team is losing {0} to {1}", blue, red);
                        return;
                    }
                    else
                    {
                        player.Message("&sThe &1Blue Team&s won {0} to {1}", blue, red);
                        return;
                    }
                }
                if (red == blue)
                {
                    if (player.Info.isPlayingTD)
                    {
                        player.Message("&sThe teams are tied at {0}!", blue);
                        return;
                    }
                    else
                    {
                        player.Message("&sThe teams tied at {0}!", blue);
                        return;
                    }
                }
            }
            if (Option.ToLower() == "about")    //td about
            {
                player.Message("&cTeam Deathmatch&S is a team game where all players are assigned to a red or blue team. Players cannot shoot players on their own team. The game will start the gun physics and do /gun for you. The game keeps score and notifications come up about the score and time left every 30 seconds. The Score Limit, Time Delay, Time Limit, and Team Assigning are customizable. Detailed help is on &H/TD Help"
                + "\n&SDeveloped for &5Legend&WCraft&S by &fDingus&0Bungus&S 2013 - Based on the template of ZombieGame.cs written by Jonty800. Was included into GemsCraft");
                return;
            }
            if (Option.ToLower() == "settings") //shows the current settings for the game (time limit, time delay, score limit, team assigning)
            {
                if (!TeamDeathMatch.manualTeams)
                {
                    player.Message("The Current Settings For TDM: Auto Team Assign: &cOn&s | Time Delay: &c{0}&ss | Time Limit: &c{1}&sm | Score Limit: &c{2}&s points",
                        TeamDeathMatch.timeDelay, (TeamDeathMatch.timeLimit / 60), TeamDeathMatch.scoreLimit);
                    return;
                }
                if (TeamDeathMatch.manualTeams)
                {
                    player.Message("The Current Settings For TDM: Auto Team Assign: &cOff&s | Time Delay: &c30&ss | Time Limit: &c{1}&sm | Score Limit: &c{2}&s points",
                        TeamDeathMatch.timeDelay, (TeamDeathMatch.timeLimit / 60), TeamDeathMatch.scoreLimit);
                    return;
                }
            }
            if (Option.ToLower() == "help") //detailed help for the cmd
            {
                player.Message("Showing Option Descriptions for /TD (Option):"
                + "\n&HTime &f- Tells how much time left in the game"
                + "\n&HScore &f- Tells the score of the game (or last game played)"
                + "\n&HSetSpawn [Red/Blue] &f- Sets the teams spawns"
                + "\n&HScoreLimit [number] &f- Sets score limit (Whole Numbers from 5-300)"
                + "\n&HTimeLimit [time(m)] &f- Sets end time (Whole minutes from 1-15)"
                + "\n&HTimeDelay [time(s)] &f- Sets start delay (10 second incriments from 10-60)"
                + "\n&HManualTeams [On/Off] &f- Create teams manually/automatically"
                + "\n&HRed [PlayerName] &f- Assigns the given player to the red team"
                + "\n&HBlue [PlayerName] &f - Assigns the given player to the blue team"
                + "\n&HSettings&f - Shows the current TDM settings"
                + "\n&HAbout&f - General description and credits");
                return;
            }
            if (Option.ToLower() == "time" || Option.ToLower() == "timeleft")
            {
                if (player.Info.isPlayingTD)
                {
                    player.Message("&fThere are &W{0}&f seconds left in the game.", TeamDeathMatch.timeLeft);
                    return;
                }
                else
                {
                    player.Message("&fThere are no games of Team DeathMatch going on.");
                    return;
                }
            }
            else
            {
                CdTeamDeathMatch.PrintUsage(player);
                return;
            }
        }

        static readonly CommandDescriptor CdFreeForAll = new CommandDescriptor
        {
            Name = "FreeForAll",            //I think I resolved all of the bugs...
            Aliases = new[] { "ffa" },
            Category = CommandCategory.Games,
            Permissions = new Permission[] { Permission.Games },
            IsConsoleSafe = false,
            Usage = "/FFA [Start | Stop | Time | Score | ScoreLimit | TimeLimit | TimeDelay | TNT | Settings | About | Help]",
            Help = "Manage the Free-For-All Gamemode!",
            Handler = FFAHandler
        };

        private static void FFAHandler(Player player, Command cmd)       //For FFA Game: starting/ending game, customizing game options, viewing score, etc.
        {
            string Option = cmd.Next();
            World world = player.World;

            if (string.IsNullOrEmpty(Option))
            {
                CdFreeForAll.PrintUsage(player);
                return;
            }
            if (Option.ToLower() == "start" || Option.ToLower() == "on")    //starts the game
            {
                if (world == WorldManager.MainWorld)
                {
                    player.Message("FFA games cannot be played on the main world");
                    return;
                }
                if (world.gameMode != GameMode.Null)
                {
                    player.Message("There is already a game of FFA going on");
                    return;
                }
                if (player.World.CountPlayers(true) < 2)
                {
                    player.Message("There needs to be at least &W2&S players to play FFA");
                    return;
                }
                else
                {
                    //restart, without hax
                    player.World.Hax = false;
                    foreach (Player p in player.World.Players)
                    {
                        p.JoinWorld(player.World, WorldChangeReason.Rejoin);
                    }

                    FFA.GetInstance(player.World);
                    FFA.Start();
                    return;
                }
            }
            if (Option.ToLower() == "stop" || Option.ToLower() == "off") //stops the game
            {
                if (FFA.isOn())
                {
                    FFA.stoppedEarly = true;
                    FFA.Stop(player);
                    return;
                }
                else
                {
                    player.Message("No games of FFA are going on");
                    return;
                }
            }
            if (FFA.isOn() && (Option.ToLower() == "timelimit" || Option.ToLower() == "scorelimit" || Option.ToLower() == "timedelay" || Option.ToLower() == "tnt"))
            {
                player.Message("You cannot adjust game settings while a game is going on");
                return;
            }
            if (!FFA.isOn() && (Option.ToLower() == "timelimit" || Option.ToLower() == "scorelimit" || Option.ToLower() == "timedelay" || Option.ToLower() == "tnt"))
            {
                if (Option.ToLower() == "timelimit")    //option to change the length of the game (5m default)
                {
                    string time = cmd.Next();
                    if (time == null)
                    {
                        player.Message("Use the syntax: /FFA timelimit (whole number of minutes)\n&HNote: The acceptable times are from 1-20 minutes");
                        return;
                    }
                    int timeLimit = 0;
                    bool parsed = Int32.TryParse(time, out timeLimit);
                    if (!parsed)
                    {
                        player.Message("Enter a whole number of minutes. For example: /FFA timelimit 5");
                        return;
                    }
                    if (timeLimit < 1 || timeLimit > 20)
                    {
                        player.Message("The accepted times are between 1 and 20 minutes");
                        return;
                    }
                    else
                    {
                        FFA.timeLimit = (timeLimit * 60);
                        player.Message("The time limit has been changed to &W{0}&S minutes", timeLimit);
                        return;
                    }
                }
                if (Option.ToLower() == "timedelay")    //option to set the time delay for TDM games (20s default)
                {
                    string time = cmd.Next();
                    if (time == null)
                    {
                        player.Message("Use the syntax: /FFA timedelay (whole number of seconds)\n&HNote: The acceptable times incriment by 10 from 10 to 60");
                        return;
                    }
                    int timeDelay = 0;
                    bool parsed = Int32.TryParse(time, out timeDelay);
                    if (!parsed)
                    {
                        player.Message("Enter a whole number of minutes. For example: /FFA timedelay 20");
                        return;
                    }
                    if (timeDelay != 10 && timeDelay != 20 && timeDelay != 30 && timeDelay != 40 && timeDelay != 50 && timeDelay != 60)
                    {
                        player.Message("The accepted times are 10, 20, 30, 40, 50, and 60 seconds");
                        return;
                    }
                    else
                    {
                        FFA.timeDelay = timeDelay;
                        player.Message("The time delay has been changed to &W{0}&s seconds", timeDelay);
                        return;
                    }
                }
                if (Option.ToLower() == "scorelimit")       //changes the score limit (30 default)
                {
                    string score = cmd.Next();
                    if (score == null)
                    {
                        player.Message("Use the syntax: /FFA scorelimit (whole number)\n&HNote: The acceptable scores are from 5-300 points");
                        return;
                    }
                    int scoreLimit = 0;
                    bool parsed = Int32.TryParse(score, out scoreLimit);
                    if (!parsed)
                    {
                        player.Message("Enter a whole number score. For example: /FFA scorelimit 50");
                        return;
                    }
                    if (scoreLimit < 5 || scoreLimit > 300)
                    {
                        player.Message("The accepted scores are from 5-300 points");
                        return;
                    }
                    else
                    {
                        FFA.scoreLimit = scoreLimit;
                        player.Message("The score limit has been changed to &W{0}&s points", scoreLimit);
                        return;
                    }
                }
                if (Option.ToLower() == "tnt")
                {
                    if (!FFA.tntAllowed)
                    {
                        player.Message("&WTNT blasts are now scored in FFA");
                        FFA.tntAllowed = true;
                        return;
                    }
                    player.Message("&WTNT blasts are no longer scored in FFA");
                    FFA.tntAllowed = false;
                    return;
                }
            }
            if (Option.ToLower() == "score")       //score for the matches
            {
                Player leader = FFA.GetScoreList()[0];
                int leadScore = leader.Info.gameKillsFFA;
                int secondScore = FFA.GetScoreList()[1].Info.gameKillsFFA;

                player.Message("&f{0}&f is winning &c{1}&f to &c{2}.", leader.ClassyName, leadScore, secondScore);
                return;
            }
            if (Option.ToLower() == "about")    //FFA about
            {
                player.Message("&cFree For All&S is a gun game where it is everyone versus everyone. The game will start the gun physics and do /gun for you (also unhides players). The game keeps score and notifications come up about the score and time left every 30 seconds. The Score Limit, Time Delay, and Time Limit are customizable. Detailed help is on &H/FFA Help"
                + "\n&SDeveloped for &5Legend&WCraft&S by &fDingus&0Bungus&S 2013 - Based on the template of ZombieGame.cs written by Jonty800. Was included into GemsCraft");
                return;
            }
            if (Option.ToLower() == "settings") //shows the current settings for the game (time limit, time delay, score limit)
            {

                player.Message("The Current Settings For FFA: Time Delay: &c{0}&ss | Time Limit: &c{1}&sm | Score Limit: &c{2}&s points",
                    FFA.timeDelay, (FFA.timeLimit / 60), FFA.scoreLimit);
                return;

            }
            if (Option.ToLower() == "help") //detailed help for the cmd
            {
                player.Message("Showing Option Descriptions for /FFA (Option):"
                + "\n&HStart &f- Starts a game of FFA on the current world"
                + "\n&HStop &f- Stops a game of FFA"
                + "\n&HTime &f- Tells how much time left in the game"
                + "\n&HScoreLimit [number] &f- Sets score limit (Whole Numbers from 5-300)"
                + "\n&HTimeLimit [time(m)] &f- Sets end time (Whole minutes from 1-15)"
                + "\n&HTimeDelay [time(s)] &f- Sets start delay (10 second incriments from 10-60)"
                + "\n&HSettings&f - Shows the current game settings"
                + "\n&HAbout&f - General description and credits");
                return;
            }
            if (Option.ToLower() == "time" || Option.ToLower() == "timeleft")
            {
                if (player.Info.isPlayingFFA)
                {
                    player.Message("&fThere are &W{0}&f seconds left in the game.", FFA.timeLeft);
                    return;
                }
                else
                {
                    player.Message("&fThere are no games of FFA going on.");
                    return;
                }
            }
            else
            {
                CdFreeForAll.PrintUsage(player);
                return;
            }
        }

        static readonly CommandDescriptor CdTDStatistics = new CommandDescriptor
        {
            Name = "TDStatistics",
            Aliases = new[] { "tdstats" },
            Category = CommandCategory.Games,
            Permissions = new Permission[] { Permission.Chat },
            IsConsoleSafe = false,
            Usage = "/TDStats (AllTime|TopKills|TopDeaths|Help)\n&HNote: Leave Blank For Current Game Stats.",
            Handler = TDStatisticsHandler
        };

        private static void TDStatisticsHandler(Player player, Command cmd)
        {
            string option = cmd.Next();
            double TDMKills = player.Info.gameKills;    //for use in division (for precision)
            double TDMDeaths = player.Info.gameDeaths;

            if (string.IsNullOrEmpty(option)) //user does /TDstats
            {
                double gameKDR = 0;
                if (TDMDeaths == 0 && TDMKills == 0)
                {
                    gameKDR = 0;
                }
                else if (TDMKills == 0 && TDMDeaths > 0)
                {
                    gameKDR = 0;
                }
                else if (TDMDeaths == 0 && TDMKills > 0)
                {
                    gameKDR = player.Info.gameKills;
                }
                else if (TDMDeaths > 0 && TDMKills > 0)
                {
                    gameKDR = TDMKills / TDMDeaths;
                }
                if (player.Info.isPlayingTD)
                {
                    player.Message("&sYou have &W{0}&s Kills and &W{1}&s Deaths. Your Kill/Death Ratio is &W{2:0.00}&s.", player.Info.gameDeaths, player.Info.gameDeaths, gameKDR);
                }
                else
                {
                    player.Message("&sYou had &W{0}&s Kills and &W{1}&s Deaths. Your Kill/Death Ratio was &W{2:0.00}&s.", player.Info.gameKills, player.Info.gameDeaths, gameKDR);
                }
                return;
            }
            else
            {
                switch (option.ToLower())
                {
                    default:
                        if (option.Length < 2)
                        {
                            player.Message("Invalid /TDStats option. Do &H/TDStats Help&s for all /TDStats options.");
                            return;
                        }
                        PlayerInfo tar = PlayerDB.FindPlayerInfoOrPrintMatches(player, option);
                        if (tar == null) { return; }
                        else
                        {
                            double tarKills = tar.gameKills;
                            double tarDeaths = tar.gameDeaths;    //for use in division (for precision)
                            double gameKDR = 0;
                            string opt = cmd.Next();
                            if (opt == null)
                            {
                                player.Message("By default, checking TDM game stats for {0}", tar.ClassyName);
                                if (tarKills == 0)
                                {
                                    gameKDR = 0;
                                }
                                else if (tarDeaths == 0 && tarKills > 0)
                                {
                                    gameKDR = tarKills;
                                }
                                else if (tarDeaths > 0 && tarKills > 0)
                                {
                                    gameKDR = tarKills / tarDeaths;
                                }
                                if (tar.isPlayingTD)
                                {
                                    player.Message("&s{0}&S has &W{1}&s Kills and &W{2}&s Deaths. Their Kill/Death Ratio is &W{3:0.00}&s.", tar.ClassyName, tarKills, tarDeaths, gameKDR);
                                }
                                else
                                {
                                    player.Message("&s{0}&S had &W{1}&s Kills and &W{2}&s Deaths. Their Kill/Death Ratio was &W{3:0.00}&s.", tar.ClassyName, tarKills, tarDeaths, gameKDR);
                                }
                                return;
                            }
                            switch (opt.ToLower())
                            {
                                default:
                                    player.Message("By default, checking game stats for {0}", tar.ClassyName);
                                    if (tarKills == 0)
                                    {
                                        gameKDR = 0;
                                    }
                                    else if (tarDeaths == 0 && tarKills > 0)
                                    {
                                        gameKDR = tarKills;
                                    }
                                    else if (tarDeaths > 0 && tarKills > 0)
                                    {
                                        gameKDR = tarKills / tarDeaths;
                                    }
                                    if (tar.isPlayingTD)
                                    {
                                        player.Message("&s{0}&S has &W{1}&s Kills and &W{2}&s Deaths. Their Kill/Death Ratio is &W{3:0.00}&s.", tar.ClassyName, tarKills, tarDeaths, gameKDR);
                                    }
                                    else
                                    {
                                        player.Message("&s{0}&S had &W{1}&s Kills and &W{2}&s Deaths. Their Kill/Death Ratio was &W{3:0.00}&s.", tar.ClassyName, tarKills, tarDeaths, gameKDR);
                                    }
                                    break;

                                case "alltime":

                                    double alltimeKDR = 0;
                                    double dubKills = tar.totalKillsTDM;
                                    double dubDeaths = tar.totalDeathsTDM;
                                    if (tar.totalKillsTDM == 0)
                                    {
                                        alltimeKDR = 0;
                                    }
                                    else if (dubDeaths == 0 && dubKills > 0)
                                    {
                                        alltimeKDR = dubKills;
                                    }
                                    else if (dubDeaths > 0 && dubKills > 0)
                                    {
                                        alltimeKDR = dubKills / dubDeaths;
                                    }
                                    player.Message("&sIn all &WTeam Deathmatch&S games {0}&S has played, they have gotten: &W{1}&S Kills and &W{2}&s Deaths giving them a Kill/Death ratio of &W{3:0.00}&S.",
                                        tar.ClassyName, dubKills, dubDeaths, alltimeKDR);
                                    break;
                            }
                        }
                        return;

                    case "alltime": //user does /TDstats alltime

                        double allKills = player.Info.totalKillsTDM;
                        double allDeaths = player.Info.totalDeathsTDM; //for use in the division for KDR (int / int = int, so no precision), why we convert to double here
                        double totalKDR = 0;

                        if (player.Info.totalDeathsTDM == 0 && player.Info.totalKillsTDM == 0)
                        {
                            totalKDR = 0;
                        }
                        else if (player.Info.totalDeathsTDM == 0 && player.Info.totalKillsTDM > 0)
                        {
                            totalKDR = player.Info.totalKillsTDM;
                        }
                        else if (player.Info.totalKillsTDM == 0 && player.Info.totalDeathsTDM > 0)
                        {
                            totalKDR = 0;
                        }
                        else if (player.Info.totalKillsTDM > 0 && player.Info.totalDeathsTDM > 0)
                        {
                            totalKDR = allKills / allDeaths;
                        }
                        player.Message("&sIn all &WTeam Deathmatch&S games you have played, you have gotten: &W{0}&S Kills and &W{1}&s Deaths giving you a Kill/Death ratio of &W{2:0.00}&S.",
                                        player.Info.totalKillsTDM, player.Info.totalDeathsTDM, totalKDR);
                        return;

                    case "topkills": //user does /TDstats topkills
                        List<PlayerInfo> TDPlayers = new List<PlayerInfo>(PlayerDB.PlayerInfoList.ToArray().OrderBy(r => r.totalKillsTDM).Reverse());
                        player.Message("&HShowing the players with the most all-time TDM Kills:");
                        if (TDPlayers.Count() < 10)
                        {
                            for (int i = 0; i < TDPlayers.Count(); i++)
                            {
                                player.Message("{0}&s - {1} Kills", TDPlayers[i].ClassyName, TDPlayers[i].totalKillsTDM);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                player.Message("{0}&s - {1} Kills", TDPlayers[i].ClassyName, TDPlayers[i].totalKillsTDM);
                            }
                        }
                        return;

                    case "topdeaths": //user does /TDstats topdeaths
                        List<PlayerInfo> TDPlayers2 = new List<PlayerInfo>(PlayerDB.PlayerInfoList.ToArray().OrderBy(r => r.totalDeathsTDM).Reverse());
                        player.Message("&HShowing the players with the most all-time TDM Deaths:");
                        if (TDPlayers2.Count() < 10)
                        {
                            for (int i = 0; i < TDPlayers2.Count(); i++)
                            {
                                player.Message("{0}&s - {1} Deaths", TDPlayers2[i].ClassyName, TDPlayers2[i].totalDeathsTDM);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                player.Message("{0}&s - {1} Deaths", TDPlayers2[i].ClassyName, TDPlayers2[i].totalDeathsTDM);
                            }
                        }
                        return;

                    case "scoreboard": //user does /TDstats scoreboard
                        List<PlayerInfo> TDPlayersRed = new List<PlayerInfo>(PlayerDB.PlayerInfoList.Where(r => r.isPlayingTD).Where(r => r.isOnRedTeam).ToArray().OrderBy(r => r.totalKillsTDM).Reverse());
                        List<PlayerInfo> TDPlayersBlue = new List<PlayerInfo>(PlayerDB.PlayerInfoList.Where(r => r.isPlayingTD).Where(r => r.isOnBlueTeam).ToArray().OrderBy(r => r.totalKillsTDM).Reverse());
                        if (TeamDeathMatch.redScore >= TeamDeathMatch.blueScore)
                        {
                            player.Message("&CRed Team &f{0}&1:", TeamDeathMatch.redScore);
                            for (int i = 0; i < TDPlayersRed.Count(); i++)
                            {
                                string sbNameRed = TDPlayersRed[i].Name;
                                if (TDPlayersRed[i].Name.Contains('@'))
                                {
                                    sbNameRed = TDPlayersRed[i].Name.Split('@')[0];
                                }
                                player.Message("&C{0} &f| &c{1} &fKills - &c{2} &fDeaths",
                                    sbNameRed, TDPlayersRed[i].gameKills, TDPlayersRed[i].gameDeaths);
                            }
                            player.Message("&f--------------------------------------------");
                            player.Message("&1Blue Team &f{0}&1:", TeamDeathMatch.blueScore);
                            for (int i = 0; i < TDPlayersBlue.Count(); i++)
                            {
                                string sbNameBlue = TDPlayersBlue[i].Name;
                                if (TDPlayersBlue[i].Name.Contains('@'))
                                {
                                    sbNameBlue = TDPlayersBlue[i].Name.Split('@')[0];
                                }
                                player.Message("&1{0} &f| &c{1} &fKills - &c{2} &fDeaths",
                                    sbNameBlue, TDPlayersBlue[i].gameKills, TDPlayersBlue[i].gameDeaths);
                            }
                        }
                        if (TeamDeathMatch.redScore < TeamDeathMatch.blueScore)
                        {
                            player.Message("&1Blue Team &f{0}&1:", TeamDeathMatch.blueScore);
                            for (int i = 0; i < TDPlayersBlue.Count(); i++)
                            {
                                string sbNameBlue = TDPlayersBlue[i].Name;
                                if (TDPlayersBlue[i].Name.Contains('@'))
                                {
                                    sbNameBlue = TDPlayersBlue[i].Name.Split('@')[0];
                                }
                                player.Message("&1{0} &f| &c{1} &fKills - &c{2} &fDeaths",
                                    sbNameBlue, TDPlayersBlue[i].gameKills, TDPlayersBlue[i].gameDeaths);
                            }
                            player.Message("&f--------------------------------------------");
                            player.Message("&CRed Team &f{0}&1:", TeamDeathMatch.redScore);
                            for (int i = 0; i < TDPlayersRed.Count(); i++)
                            {
                                string sbNameRed = TDPlayersRed[i].Name;
                                if (TDPlayersRed[i].Name.Contains('@'))
                                {
                                    sbNameRed = TDPlayersRed[i].Name.Split('@')[0];
                                }
                                player.Message("&C{0} &f| &c{1} &fKills - &c{2} &fDeaths",
                                    sbNameRed, TDPlayersRed[i].gameKills, TDPlayersRed[i].gameDeaths);
                            }
                        }
                        return;

                    case "help": //user does /TDstats help
                        player.Message("&HDetailed help for the /TDStats (options):");
                        player.Message("&HAllTime&S - Shows your all time TD stats.");
                        player.Message("&HTopKills&S - Show the players with the most all time kills");
                        player.Message("&HTopDeaths&S - Show the players with the most all time Deaths.");
                        player.Message("&HScoreBoard&S - Shows a scoreboard of the current TDM game.");
                        player.Message("&H(PlayerName) (Alltime|Game) - Shows the alltime or game stats of a player");
                        player.Message("&HNote: Leave Blank For Current Game Stats");
                        return;
                }
            }
        }

        static readonly CommandDescriptor CdFFAStatistics = new CommandDescriptor
        {
            Name = "FFAStatistics",
            Aliases = new[] { "ffastats" },
            Category = CommandCategory.Games,
            Permissions = new Permission[] { Permission.Chat },
            IsConsoleSafe = false,
            Usage = "/FFAStats (AllTime|TopKills|TopDeaths|ScoreBoard|Help)\n&HNote: Leave Blank For Current Game Stats. Can look up others stats "
            + " by using /FFAStats (PlayerName) (AllTime) where alltime is Optional (left blank gives current game stats).",
            Handler = FFAStatsHandler
        };

        private static void FFAStatsHandler(Player player, Command cmd)
        {
            string option = cmd.Next();
            double FFAKills = player.Info.gameKillsFFA;    //for use in division (for precision)
            double FFADeaths = player.Info.gameDeathsFFA;

            if (string.IsNullOrEmpty(option)) //user does /FFAstats
            {
                double gameKDR = 0;
                if (FFAKills == 0 && FFAKills == 0)
                {
                    gameKDR = 0;
                }
                else if (FFAKills == 0 && FFADeaths > 0)
                {
                    gameKDR = 0;
                }
                else if (FFADeaths == 0 && FFAKills > 0)
                {
                    gameKDR = player.Info.gameKillsFFA;
                }
                else if (FFADeaths > 0 && FFAKills > 0)
                {
                    gameKDR = FFAKills / FFADeaths;
                }
                if (player.Info.isPlayingFFA)
                {
                    player.Message("&sYou have &W{0}&s Kills and &W{1}&s Deaths. Your Kill/Death Ratio is &W{2:0.00}&s.", player.Info.gameKillsFFA, player.Info.gameDeathsFFA, gameKDR); //use int forms for display
                }
                else
                {
                    player.Message("&sYou had &W{0}&s Kills and &W{1}&s Deaths. Your Kill/Death Ratio was &W{2:0.00}&s.", player.Info.gameKillsFFA, player.Info.gameDeathsFFA, gameKDR);
                }
                return;
            }
            else
            {
                switch (option.ToLower())
                {
                    default:
                        if (option.Length < 2)
                        {
                            player.Message("Invalid /FFAStats option. Do &H/FFAStats Help&s for all /FFAStats options.");
                            return;
                        }
                        PlayerInfo tar = PlayerDB.FindPlayerInfoOrPrintMatches(player, option);
                        if (tar == null) { return; }
                        else
                        {
                            double tarKills = tar.gameKillsFFA;
                            double tarDeaths = tar.gameDeathsFFA;    //for use in division (for precision)
                            double gameKDR = 0;
                            string opt = cmd.Next();
                            if (opt == null)
                            {
                                player.Message("By default, checking FFA game stats for {0}", tar.ClassyName);
                                if (tarKills == 0)
                                {
                                    gameKDR = 0;
                                }
                                else if (tarDeaths == 0 && tarKills > 0)
                                {
                                    gameKDR = tarKills;
                                }
                                else if (tarDeaths > 0 && tarKills > 0)
                                {
                                    gameKDR = tarKills / tarDeaths;
                                }
                                if (tar.isPlayingFFA)
                                {
                                    player.Message("&s{0}&S has &W{1}&s Kills and &W{2}&s Deaths. Their Kill/Death Ratio is &W{3:0.00}&s.", tar.ClassyName, tarKills, tarDeaths, gameKDR);
                                }
                                else
                                {
                                    player.Message("&s{0}&S had &W{1}&s Kills and &W{2}&s Deaths. Their Kill/Death Ratio was &W{3:0.00}&s.", tar.ClassyName, tarKills, tarDeaths, gameKDR);
                                }
                                return;
                            }
                            switch (opt.ToLower())
                            {
                                default:
                                    player.Message("By default, checking game stats for {0}", tar.ClassyName);
                                    if (tarKills == 0)
                                    {
                                        gameKDR = 0;
                                    }
                                    else if (tarDeaths == 0 && tarKills > 0)
                                    {
                                        gameKDR = tarKills;
                                    }
                                    else if (tarDeaths > 0 && tarKills > 0)
                                    {
                                        gameKDR = tarKills / tarDeaths;
                                    }
                                    if (tar.isPlayingFFA)
                                    {
                                        player.Message("&s{0}&S has &W{1}&s Kills and &W{2}&s Deaths. Their Kill/Death Ratio is &W{3:0.00}&s.", tar.ClassyName, tarKills, tarDeaths, gameKDR);
                                    }
                                    else
                                    {
                                        player.Message("&s{0}&S had &W{1}&s Kills and &W{2}&s Deaths. Their Kill/Death Ratio was &W{3:0.00}&s.", tar.ClassyName, tarKills, tarDeaths, gameKDR);
                                    }
                                    break;

                                case "alltime":

                                    double alltimeKDR = 0;
                                    double dubKills = tar.totalKillsFFA;
                                    double dubDeaths = tar.totalDeathsFFA;
                                    if (dubKills == 0)
                                    {
                                        alltimeKDR = 0;
                                    }
                                    else if (dubDeaths == 0 && dubKills > 0)
                                    {
                                        alltimeKDR = dubKills;
                                    }
                                    else if (dubDeaths > 0 && dubKills > 0)
                                    {
                                        alltimeKDR = dubKills / dubDeaths;
                                    }
                                    player.Message("&sIn all &WFree For All&S games {0}&S has played, they have gotten: &W{1}&S Kills and &W{2}&s Deaths giving them a Kill/Death ratio of &W{3:0.00}&S.",
                                        tar.ClassyName, dubKills, dubDeaths, alltimeKDR);
                                    break;
                            }
                        }
                        return;

                    case "alltime": //user does /FFAstats alltime

                        double allKills = player.Info.totalKillsFFA;
                        double allDeaths = player.Info.totalDeathsFFA; //for use in the division for KDR (int / int = int, so no precision), why we convert to double here
                        double totalKDR = 0;

                        if (allDeaths == 0 && allKills == 0)
                        {
                            totalKDR = 0;
                        }
                        else if (allDeaths == 0 && allKills > 0)
                        {
                            totalKDR = player.Info.totalKillsTDM;
                        }
                        else if (allKills == 0 && allDeaths > 0)
                        {
                            totalKDR = 0;
                        }
                        else if (allKills > 0 && allDeaths > 0)
                        {
                            totalKDR = allKills / allDeaths;
                        }
                        player.Message("&sIn all &WFree For All&S games you have played, you have gotten: &W{0}&S Kills and &W{1}&s Deaths giving you a Kill/Death ratio of &W{2:0.00}&S.",
                                        allKills, allDeaths, totalKDR);
                        return;

                    case "topkills": //user does /FFAstats topkills
                        List<PlayerInfo> FFAPlayers = new List<PlayerInfo>(PlayerDB.PlayerInfoList.ToArray().OrderBy(r => r.totalKillsFFA).Reverse());
                        player.Message("&HShowing the players with the most all-time FFA Kills:");
                        if (FFAPlayers.Count() < 10)
                        {
                            for (int i = 0; i < FFAPlayers.Count(); i++)
                            {
                                player.Message("{0}&s - {1} Kills", FFAPlayers[i].ClassyName, FFAPlayers[i].totalKillsFFA);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                player.Message("{0}&s - {1} Kills", FFAPlayers[i].ClassyName, FFAPlayers[i].totalKillsFFA);
                            }
                        }
                        return;

                    case "topdeaths": //user does /FFAstats topdeaths
                        List<PlayerInfo> FFAPlayers2 = new List<PlayerInfo>(PlayerDB.PlayerInfoList.ToArray().OrderBy(r => r.totalDeathsFFA).Reverse());
                        player.Message("&HShowing the players with the most all-time TDM Deaths:");
                        if (FFAPlayers2.Count() < 10)
                        {
                            for (int i = 0; i < FFAPlayers2.Count(); i++)
                            {
                                player.Message("{0}&s - {1} Deaths", FFAPlayers2[i].ClassyName, FFAPlayers2[i].totalDeathsFFA);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                player.Message("{0}&s - {1} Deaths", FFAPlayers2[i].ClassyName, FFAPlayers2[i].totalDeathsFFA);
                            }
                        }
                        return;

                    case "scoreboard": //user does /FFAstats scoreboard
                        if (!FFA.isOn())
                        {
                            player.Message("There are no games of FFA going on");
                            return;
                        }
                        List<PlayerInfo> FFAScoreBoard = new List<PlayerInfo>(PlayerDB.PlayerInfoList.Where(r => r.isPlayingFFA).ToArray().OrderBy(r => r.gameKillsFFA).Reverse());
                        for (int i = 0; i < FFAScoreBoard.Count(); i++)
                        {
                            string sbName = FFAScoreBoard[i].Name;
                            string color = "&c";
                            if (FFAScoreBoard[i].Name.Contains('@'))
                            {
                                sbName = FFAScoreBoard[i].Name.Split('@')[0];
                            }
                            if (FFAScoreBoard.Count() > 3 && i > 2)
                            {
                                color = "&f";
                            }
                            player.Message("{3}{0} &f| &c{1} &fKills - &c{2} &fDeaths",
                                sbName, FFAScoreBoard[i].gameKillsFFA, FFAScoreBoard[i].gameDeathsFFA, color);
                        }
                        return;

                    case "help": //user does /FFAstats help
                        player.Message("&HDetailed help for the /FFAStats (options):");
                        player.Message("&HAllTime&S - Shows your all time FFA stats");
                        player.Message("&HTopKills&S - Show the players with the most all time kills");
                        player.Message("&HTopDeaths&S - Show the players with the most all time Deaths");
                        player.Message("&HScoreBoard&S - Shows a scoreboard of the current FFA game");
                        player.Message("&H(PlayerName) (Alltime|Game) - Shows the alltime or game stats of a player");
                        player.Message("&HNote: Leave Blank For Current Game Stats");
                        return;
                }
            }
        }

        #endregion
    }
}
