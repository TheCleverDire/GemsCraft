//Copyright (C) <2012>  <Jon Baker, Glenn Mariën and Lao Tszy>

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using RandomMaze;
using fCraft.Events;

namespace fCraft
{
    internal static class FunCommands
    {
        internal static void Init()
        {
            CommandManager.RegisterCommand(CdRandomMaze);
            CommandManager.RegisterCommand(CdMazeCuboid);
            CommandManager.RegisterCommand(CdFirework);
            CommandManager.RegisterCommand(CdLife);
            CommandManager.RegisterCommand(CdPossess);
            CommandManager.RegisterCommand(CdUnpossess);

            CommandManager.RegisterCommand(CdThrow);
            CommandManager.RegisterCommand(CdInsult);


            CommandManager.RegisterCommand(CdSetModel);
            CommandManager.RegisterCommand(CdBot);
            //Games moved to seperate Game Category
            CommandManager.RegisterCommand(CdDragon);
            CommandManager.RegisterCommand(CdJoke);
            CommandManager.RegisterCommand(CdStab);
            CommandManager.RegisterCommand(CdColorMode);
            CommandManager.RegisterCommand(CdEndColorMode);
            Player.Moving += startDragon;
            Player.Moving += PlayerMoved;
        }
        
        private static readonly CommandDescriptor CdColorMode = new CommandDescriptor
        {
            Name = "EnableColorMode",
            Category = CommandCategory.Fun | CommandCategory.Chat,
            Aliases = new[] { "setcolormode", "skittles", "rainbow" },
            Permissions = new[] { Permission.UseColorCodes, Permission.ColorMode },
            Usage = "/EnableColorMode [Null = Self/SetUser/All] [Specific Player if SetUser]",
            IsConsoleSafe = true,
            Help = "&1C&2O&3L&4O&5R&6! &f&eSee the rainbow &bTaste the rainbow",
            Handler = ColorModeHandler
        };

        private static void ColorModeHandler(Player source, Command cmd)
        {
            string arg = cmd.Next();
            string arg2 = cmd.Next();
            if (arg == null)
            {
                var loopCount = 0;
                foreach (var p in Server.Players)
                {
                    if (p.Info.Name == source.Info.Name)
                    {
                        Server.Players[loopCount].ColorModeEnabled = true;
                    }
                    loopCount++;
                }
                source.Message("&eColorMode is now enabled for just you.");
            }
            else if (arg.ToLower() == "setuser")
            {
                if (arg2 == null)
                {
                    CdColorMode.PrintUsage(source);
                }
                else
                {
                    var player = Server.FindPlayerOrPrintMatches(source, arg2, false, true);
                    if (player != null)
                    {
                        var loopCount = 0;
                        foreach (var p in Server.Players)
                        {
                            if (p.Info.Name == player.Info.Name)
                            {
                                Server.Players[loopCount].ColorModeEnabled = true;
                            }
                            loopCount++;
                        }
                        source.Message("&eColorMode is now enabled for " + player.Info.Name);
                    }
                }
            }
            else if (arg.ToLower() == "all") // Oh my
            {
                for (var x = 0; x <= Server.Players.Length - 1; x++)
                {
                    Server.Players[x].ColorModeEnabled = true;
                }
                source.Message("&eColorMode is now set for all players.");
            }
        }

        private static readonly CommandDescriptor CdEndColorMode = new CommandDescriptor
        {
            Name = "DisableColorMode",
            Category = CommandCategory.Fun | CommandCategory.Chat,
            Aliases = new[] { "endcolormode", "eatskittles", "killrainbow" },
            Permissions = new[] { Permission.UseColorCodes, Permission.ColorMode },
            Usage = "/DisableColorMode [Null = Self/User/All] [Specific Player if User]",
            IsConsoleSafe = true,
            Help = "Disables ColorMode",
            Handler = endColorModeHandler
        };

        private static void endColorModeHandler(Player source, Command cmd)
        {
            string arg = cmd.Next();
            string arg2 = cmd.Next();
            if (arg == null)
            {
                var loopCount = 0;
                foreach (var p in Server.Players)
                {
                    if (p.Info.Name == source.Info.Name)
                    {
                        Server.Players[loopCount].ColorModeEnabled = false;
                    }
                    loopCount++;
                }
                source.Message("&eColorMode is now disabled for just you.");
            }
            else if (arg.ToLower() == "setuser")
            {
                if (arg2 == null)
                {
                    CdEndColorMode.PrintUsage(source);
                }
                else
                {
                    var player = Server.FindPlayerOrPrintMatches(source, arg2, false, true);
                    if (player != null)
                    {
                        var loopCount = 0;
                        foreach (var p in Server.Players)
                        {
                            if (p.Info.Name == player.Info.Name)
                            {
                                Server.Players[loopCount].ColorModeEnabled = false;
                            }
                            loopCount++;
                        }
                        source.Message("&eColorMode is now enabled for " + player.Info.Name);
                    }
                }
            }
            else if (arg.ToLower() == "all") // Oh my
            {
                for (var x = 0; x <= Server.Players.Length - 1; x++)
                {
                    Server.Players[x].ColorModeEnabled = false;
                }
                source.Message("&eColorMode is now set for all players.");
            }
        }

        private static readonly CommandDescriptor CdStab = new CommandDescriptor
        {
            Name = "Stab",
            Category = CommandCategory.Fun | CommandCategory.Chat,
            Permissions = new[] { Permission.Kill },
            Usage = "/stab Player",
            Help = "Stabs the specificed player",
            Handler = StabHandler
        };

        static void StabHandler(Player player, Command cmd)
        {
            var chosenPlayer = cmd.Next();
            if (chosenPlayer == null) player.PrintUsage(CdStab);
            else
            {
                var selected = Server.FindPlayerOrPrintMatches(player, chosenPlayer, false, true);
                if (selected == null) return;
                ContinueStab(player, selected);
            }
        }

        static void ContinueStab(Player player, Player selected)
        {
            foreach (var p in Server.Players)
            {
                if (p.Info.Name == selected.Info.Name)
                {
                    p.Kill(p.World, "&cstabbed");
                    p.Message("You have been &4brutally&c stabbed&r by " + player.Info.Name);
                }
                else if (p.Info.Name == player.Info.Name)
                {
                    p.Message("You have &4brutally&r &cstabbed &r" + selected.Info.Name);
                }
                else
                {
                    p.Message(player.Info.Name + " has &4brutally &cstabbed&r " + selected.Info.Name);
                }
            }
        }
        static readonly CommandDescriptor CdJoke = new CommandDescriptor
        {
            Name = "Joke",

            Category = CommandCategory.Chat | CommandCategory.Fun,
            Permissions = new[] { Permission.HighFive },
            IsConsoleSafe = false,
            Usage = "/joke [Optional: Joke ID (28)]",
            Help = "Takes a random joke from a list.",
            NotRepeatable = true,
            Handler = JokeHandler,
        };

        static void JokeHandler(Player player, Command cmd)
        {
            List<String> joke;
            Random randomizer = new Random();

            joke = new List<String>()
            {
                "Dyslexic man walks into a bra",
                "There is 3 types of people in this world, those who can count and those who can't",
                "Pinnochio enteres a lying contest but loses to Obama",
                "Congres.sys is corrupted. Reboot? [Y/N]",
                "Evening news is when they start off with Good Evening and then proceed to telling you why it isn't.",
                "Energizer bunny arrested-charged with battery",
                "There are 3 men. 2 Walk into a bar. The other one ducks.",
                "I totally understand how batteries feel because I'm rarely ever included in things either.",
                "The midget fortune teller who kills his customers is a small medium at large.",
                "What does a nosey pepper do? Get jalapeno business",
                "Why can't you hear a pterodactyl go the bathroom? Because the \"P\" is silent",
                "DO NOT READ \nYou rebel.",
                "CNN says the world is 40 trillion in debt. Who the heck do we owe? Jupiter?",
                "Programmers are a race of people trying to make smarter people. The universe tries to make more stupid people. So far, the universe is winning",
                "Patient: Doctor Doctor! Everyone keeps copying me! \nDoctor: Doctor Doctor! Everyone keeps copying me!",
                "A blonde walks into a bar OUCH!",
                "My boss is so unpopular even his own shadow refuses to follow him",
                "Two peanuts walk into a bar. One was a salted",
                "What do you call a fish with no eyes? A fsh",
                "Why don't aliens eat clowns? Because they taste funny",
                "Congressional Virus: Corrups your computer",
                "Why did the Roman Chicken Cross the Road? To take over the other side",
                "Adam and Eve Virus: Takes a byte out of your apple computer",
                "Superman and Chuck Norris had an arm wrestling match. The loser had to wear his underwear on the outside",
                "Darth Vadar leaves his toast in the toaster for a little longer. He likes it on the Dark Side",
                "Why did the cow cross the raod? To get to the utter side!",
                "I'm Sofa King Happy",
                "The only right way to listen to Justin Beiber is turned completely down",
                "&fMATH = &1M&fental &1A&fbuse &1T&fo &1H&fumans"
            };

            var index = randomizer.Next(0, joke.Count);
            var time = (DateTime.Now - player.Info.LastUsedJoke).TotalSeconds;
            var timeLeft = Math.Round(20 - time);
            var usingExact = false;
            try
            {
                var id = int.Parse(cmd.Next());
                usingExact = true;
                index = id;
            }
            catch (Exception ex)
            {
                // Ignored
                player.Message(ex.ToString());
            }
            if (time < 20)
            {
                if (!usingExact) player.Message("You cannot use this command for another " + timeLeft + " second(s).");
            }
            else
            {
                Server.Message(joke[index]);
                player.Info.LastUsedJoke = DateTime.Now;
            }



        }
        #region Dragon

        static readonly CommandDescriptor CdDragon = new CommandDescriptor
        {
            Name = "Dragon",
            Aliases = new[] { "drag", "firebreather", "fireborn", "dragonborn" },
            Category = CommandCategory.Fun,
            Permissions = new[] { Permission.Dragon },
            IsConsoleSafe = false,
            Usage = "/Dragon [On/Off] [Fire/Lava/Magma/Red]",
            Help = "Run with a trail of fire or lava behind you. Default is Fire.",
            Handler = DragonHandler
        };

        static Player _playerForInit;
        static Block _blockType = Block.Air;
        static Block DefaultBlock()
        {
            var def = ConfigKey.DragonDefault.GetString().ToLower();
            switch (def)
            {
                case "fire":
                    return Block.Fire;
                case "lava":
                    return Block.StillLava;
                case "magma":
                    return Block.Magma;
                case "red":
                    return Block.Red;
                default:
                    return Block.Fire;
            }
        }
        static void MessagePlayer(Player p, String b)
        {
            p.Message("&4Sorry&f, but " + b + " is disabled for dragon");
        }

        static bool IsEnabledDrag(int i)
        {
            switch (i)
            {
                case 0:
                    return ConfigKey.DragonFire.Enabled();
                case 1:
                    return ConfigKey.DragonMagma.Enabled();
                case 2:
                    return ConfigKey.DragonLava.Enabled();
                case 3:
                    return ConfigKey.DragonRed.Enabled();
                default:
                    return false;
            }
        }
        static void DragonHandler(Player player, Command cmd)
        {
            string cmdBlock = null;
            try
            {
                var cmdNext = cmd.Next();
                try
                {
                    cmdBlock = cmd.Next();
                    // ReSharper disable once PossibleNullReferenceException
                    switch (cmdBlock.ToLower())
                    {
                        case "fire":
                            if (!ConfigKey.DragonFire.Enabled()) cmdBlock = ConfigKey.DragonDefault.GetString();
                            if (!IsEnabledDrag(0)) MessagePlayer(player, ConfigKey.DragonDefault.GetString());
                            break;
                        case "lava":
                            if (!ConfigKey.DragonLava.Enabled()) cmdBlock = ConfigKey.DragonDefault.GetString();
                            if (!IsEnabledDrag(2)) MessagePlayer(player, ConfigKey.DragonDefault.GetString());
                            break;
                        case "magma":
                            if (!ConfigKey.DragonMagma.Enabled()) cmdBlock = ConfigKey.DragonDefault.GetString();
                            if (!IsEnabledDrag(1)) MessagePlayer(player, ConfigKey.DragonDefault.GetString());
                            break;
                        case "red":
                            if (!ConfigKey.DragonRed.Enabled()) cmdBlock = ConfigKey.DragonDefault.GetString();
                            if (!IsEnabledDrag(3)) MessagePlayer(player, ConfigKey.DragonDefault.GetString());
                            break;
                    }
                }
                catch (NullReferenceException)
                {
                    _blockType = DefaultBlock();
                }
                // ReSharper disable once PossibleNullReferenceException
                if (cmdNext.ToLower().Equals("off"))
                {
                    if (!player.IsDragonOn) player.Message("Dragon is already off!");
                    else
                    {
                        player.IsDragonOn = false;
                        _playerForInit = null;
                        _blockType = Block.Undefined; // Don't use it!
                        player.Message("Turned Dragon Off");
                    }
                }
                else if (cmdNext.ToLower().Equals("on"))
                {
                    if (player.IsDragonOn) player.Message("Dragon is already on!");
                    else
                    {
                        _playerForInit = player;
                        if (cmdBlock.ToLower().Equals("fire") || cmdBlock.ToLower().Equals("lava") || cmdBlock.ToLower().Equals("magma") || cmdBlock.ToLower().Equals("red"))
                        {
                            player.IsDragonOn = true;
                            player.Message("Dragon is now on!");
                            switch (cmdBlock.ToLower())
                            {
                                case "fire":
                                    _blockType = Block.Fire;
                                    break;
                                case "lava":
                                    _blockType = Block.StillLava;
                                    break;
                                case "magma":
                                    _blockType = Block.Magma;
                                    break;
                                case "red":
                                    _blockType = Block.Red;
                                    break;
                            }
                        }
                        else
                        {
                            CdDragon.PrintUsage(player);
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                CdDragon.PrintUsage(player);
            }
        }

        public static void startDragon(object sender, PlayerMovingEventArgs e)
        {
            if (!e.Player.IsDragonOn) return;
            var player = _playerForInit;
            var vi = player.Position.ToBlockCoords();
            vi.X--;
            vi.Z--;
            if (player.World == null) return;
            if (player.World.Map != null)
                player.World.Map.QueueUpdate(new BlockUpdate(null, vi, _blockType)); //Thanks to Jonty800. He provided this line
        }
        #endregion
        public static string[] ValidEntities =
            {
                "chicken",
                "creeper",
                "humanoid",
                "human",
                "pig",
                "printer",
                "sheep",
                "skeleton",
                "spider",
                "zombie"
                                     };

        public static void PlayerMoved(object sender, PlayerMovingEventArgs e)
        {
            if (e.Player.Info.IsFrozen || e.Player.SpectatedPlayer != null || !e.Player.SpeedMode)
                return;
            var oldPos = e.OldPosition.ToBlockCoords();
            var newPos = e.NewPosition.ToBlockCoords();
            //check if has moved 1 whole block
            if (newPos.X != oldPos.X + 1 && newPos.X != oldPos.X - 1 && newPos.Y != oldPos.Y + 1 &&
                newPos.Y != oldPos.Y - 1) return;
            Server.Players.Message("Old: " + newPos.ToString());
            var move = newPos - oldPos;
            const int accelerationFactor = 4;
            var acceleratedNewPos = oldPos + move * accelerationFactor;
            //do not forget to check for all the null pointers here - TODO
            if (e.Player.World != null)
            {
                var m = e.Player.World.Map;
                //check if can move through all the blocks along the path
                var normal = move.Normalize();
                var prevBlockPos = e.OldPosition.ToBlockCoords();
                for (var i = 1; i <= accelerationFactor * move.Length; ++i)
                {
                    var pos = (oldPos + i * normal).Round();
                    if (prevBlockPos == pos) //didnt yet hit the next block
                        continue;
                    if (m != null && (!m.InBounds(pos) || m.GetBlock(pos) != Block.Air)) //got out of bounds or some solid block
                    {
                        acceleratedNewPos = (oldPos + normal * (i - 1)).Round();
                        break;
                    }
                    prevBlockPos = pos;
                }
            }
            //teleport keeping the same orientation
            //Server.Players.Message("New: "+ acceleratedNewPos.ToString());
            e.Player.Send(PacketWriter.MakeSelfTeleport(new Position((short)(acceleratedNewPos.X * 32), (short)(acceleratedNewPos.Y * 32), e.Player.Position.Z, e.NewPosition.R, e.NewPosition.L)));
        }
        #region LegendCraft
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

        static readonly CommandDescriptor CdBot = new CommandDescriptor
        {
            Name = "Bot",
            Permissions = new Permission[] { Permission.Bots },
            Category = CommandCategory.Fun,
            IsConsoleSafe = false,
            Usage = "/Bot <create / remove / removeAll / model / clone / explode / list / summon / stop / move>",
            Help = "Commands for manipulating bots. For help and usage for the individual options, use /help bot <option>.",
            HelpSections = new Dictionary<string, string>{
                { "create", "&H/Bot create <botname> <model>\n&S" +
                                "Creates a new bot with the given name. Valid models are chicken, creeper, croc, human, pig, printer, sheep, skeleton, spider, or zombie." },
                { "remove", "&H/Bot remove <botname>\n&S" +
                                "Removes the given bot." },
                { "removeall", "&H/Bot removeAll\n&S" +
                                "Removes all bots from the server."},
                { "model", "&H/Bot model <bot name> <model>\n&S" +
                                "Changes the model of a bot to the given model. Valid models are chicken, creeper, croc, human, pig, printer, sheep, skeleton, spider, or zombie."},
                { "clone", "&H/Bot clone <bot> <player>\n&S" +
                                "Changes the skin of a bot to the skin of the given player. Leave the player parameter blank to reset the skin. Bot's model must be human. Use /bot changeModel to change the bot's model."},
                { "explode", "&H/Bot explode <bot>\n&S" +
                                "Epically explodes a bot, removing it from the server."},
                { "list", "&H/Bot list\n&S" +
                                "Prints out a list of all the bots on the server."},
                { "summon", "&H/Bot summon <botname>\n&S" +
                                "Summons a bot from anywhere to your current position."},
                { "move", "&H/Bot move <botname> <player>\n&S" +
                                "Moves the bot to a specific player."},
                { "stop", "&H/Bot stop <botname>\n&S" +
                                "Stops the bot from doing any of its movement actions."}
            },
            Handler = BotHandler,
        };

        static void BotHandler(Player player, Command cmd)
        {
            var option = cmd.Next(); //take in the option arg
            if (string.IsNullOrEmpty(option)) //empty? return, otherwise continue
            {
                CdBot.PrintUsage(player);
                return;
            }

            //certain options that take in specific params are in here, the rest are in the switch-case
            switch (option.ToLower())
            {
                case "list":
                    player.Message("_Bots on {0}_", ConfigKey.ServerName.GetString());
                    foreach (Bot botCheck in Server.Bots)
                    {
                        player.Message(botCheck.Name + " on " + botCheck.World.Name);
                    }
                    return;
                case "removeall":

                rewipe:
                    Server.Bots.ForEach(botToRemove =>
                    {
                        botToRemove.removeBot();
                    });

                    if (Server.Bots.Count != 0)
                    {
                        goto rewipe;
                    }

                    player.Message("All bots removed from the server.");
                    return;
                case "move":
                    {
                        var targetBot = cmd.Next();
                        if (string.IsNullOrEmpty(targetBot))
                        {
                            CdBot.PrintUsage(player);
                            return;
                        }
                        var targetPlayer = cmd.Next();
                        if (string.IsNullOrEmpty(targetPlayer))
                        {
                            CdBot.PrintUsage(player);
                            return;
                        }

                        if (player.World == null) return;
                        var targetB = player.World.FindBot(targetBot);
                        var targetP = player.World.FindPlayerExact(targetPlayer);

                        if (targetP == null)
                        {
                            player.Message("Could not find {0} on {1}! Please make sure you spelled their name correctly.", targetPlayer, player.World);
                            return;
                        }
                        if (targetB == null)
                        {
                            player.Message("Could not find {0} on {1}! Please make sure you spelled their name correctly.", targetBot, player.World);
                            return;
                        }

                        player.Message("{0} is now moving!", targetB.Name);
                        targetB.isMoving = true;
                        targetB.NewPosition = targetP.Position;
                        targetB.OldPosition = targetB.Position;
                        targetB.timeCheck.Start();
                        return;
                    }
                case "follow":
                    {
                        return; // not used for now

                        var targetBot = cmd.Next();
                        if (string.IsNullOrEmpty(targetBot))
                        {
                            CdBot.PrintUsage(player);
                            return;
                        }
                        var targetPlayer = cmd.Next();
                        if (string.IsNullOrEmpty(targetPlayer))
                        {
                            CdBot.PrintUsage(player);
                            return;
                        }

                        var targetB = player.World.FindBot(targetBot);
                        var targetP = player.World.FindPlayerExact(targetPlayer);

                        if (targetP == null)
                        {
                            player.Message("Could not find {0} on {1}! Please make sure you spelled their name correctly.", targetPlayer, player.World);
                            return;
                        }
                        if (targetB == null)
                        {
                            player.Message("Could not find {0} on {1}! Please make sure you spelled their name correctly.", targetBot, player.World);
                            return;
                        }

                        player.Message("{0} is now following {1}!", targetB.Name, targetP.Name);
                        targetB.isMoving = true;
                        targetB.followTarget = targetP;
                        targetB.OldPosition = targetB.Position;
                        targetB.timeCheck.Start();
                        return;
                    }
            }

            //finally away from the special cases
            var botName = cmd.Next(); //take in bot name arg
            if (string.IsNullOrEmpty(botName)) //null check
            {
                CdBot.PrintUsage(player);
                return;
            }

            var bot = new Bot();
            if (option != "create")//since the bot wouldn't exist for "create", we must check the bot for all cases other than "create"
            {
                bot = Server.FindBot(botName.ToLower()); //Find the bot and assign to bot var

                if (bot == null) //If null, return and yell at user
                {
                    player.Message("Could not find {0}! Please make sure you spelled the bot's name correctly. To view all the bots, type /Bot list.", botName);
                    return;
                }
            }

            //now to the cases - additional args should be taken in at the individual cases
            switch (option.ToLower())
            {
                case "create":
                    var requestedModel = cmd.Next();
                    if (string.IsNullOrEmpty(requestedModel))
                    {
                        player.Message("Usage is /Bot create <bot name> <bot model>. Valid models are chicken, creeper, croc, human, pig, printer, sheep, skeleton, spider, or zombie.");
                        return;
                    }

                    if (!ValidEntities.Contains(requestedModel))
                    {
                        player.Message("That wasn't a valid bot model! Valid models are chicken, creeper, croc, human, pig, printer, sheep, skeleton, spider, or zombie.");
                        return;
                    }

                    //if a botname has already been chosen, ask player for a new name
                    var matchingNames = from b in Server.Bots
                                        where b.Name.ToLower() == botName.ToLower()
                                        select b;

                    if (matchingNames.Any())
                    {
                        player.Message("A bot with that name already exists! To view all bots, type /bot list.");
                        return;
                    }

                    player.Message("Successfully created a bot.");
                    var botCreate = new Bot();
                    botCreate.setBot(botName, player.World, player.Position, LegendCraft.getNewID());
                    botCreate.createBot();
                    botCreate.changeBotModel(requestedModel);
                    break;
                case "remove":
                    player.Message("{0} was removed from the server.", bot.Name);
                    bot.removeBot();
                    break;
                case "fly":

                    if (bot.isFlying)
                    {
                        player.Message("{0} can no longer fly.", bot.Name);
                        bot.isFlying = false;
                        break;
                    }

                    player.Message("{0} can now fly!", bot.Name);
                    bot.isFlying = true;
                    break;
                case "model":

                    if (bot.Skin != "steve")
                    {
                        player.Message("Bots cannot change model with a skin! Use '/bot clone' to reset a bot's skin.");
                        return;
                    }

                    var model = cmd.Next();
                    if (string.IsNullOrEmpty(model))
                    {
                        player.Message("Usage is /Bot model <bot> <model>. Valid models are chicken, creeper, croc, human, pig, printer, sheep, skeleton, spider, or zombie.");
                        break;
                    }

                    if (model == "human")//lazy parse
                    {
                        model = "humanoid";
                    }
                    if (!ValidEntities.Contains(model))
                    {
                        player.Message("Please use a valid model name! Valid models are chicken, creeper, croc, human, pig, printer, sheep, skeleton, spider, or zombie.");
                        break;
                    }

                    player.Message("Changed bot model to {0}.", model);
                    bot.changeBotModel(model);

                    break;
                case "clone":

                    if (bot.Model != "humanoid")
                    {
                        player.Message("A bot must be a human in order to have a skin. Use '/bot model <bot> <model>' to change a bot's model.");
                        return;
                    }

                    string playerToClone = cmd.Next();
                    if (string.IsNullOrEmpty(playerToClone))
                    {
                        player.Message("{0}'s skin was reset!", bot.Name);
                        bot.Clone("steve");
                        break;
                    }
                    PlayerInfo targetPlayer = PlayerDB.FindPlayerInfoExact(playerToClone);
                    if (targetPlayer == null)
                    {
                        player.Message("That player doesn't exists! Please use a valid playername for the skin of the bot.");
                        break;
                    }

                    player.Message("{0}'s skin was updated!", bot.Name);
                    bot.Clone(playerToClone);
                    break;
                case "explode":

                    Server.Message("{0} exploded!", bot.Name);
                    bot.explodeBot(player);
                    break;
                case "summon":

                    if (player.World != bot.World)
                    {
                        bot.tempRemoveBot(); //remove the entity
                        bot.World = player.World; //update variables
                        bot.Position = player.Position;
                        bot.updateBotPosition(); //replace the entity
                    }
                    else
                    {
                        bot.Position = player.Position;
                        bot.teleportBot(player.Position);
                    }

                    if (bot.Model != "human")
                    {
                        bot.changeBotModel(bot.Model); //replace the model, if the model is set
                    }
                    if (bot.Skin != "steve")
                    {
                        bot.Clone(bot.Skin); //replace the skin, if a skin is set
                    }
                    break;
                case "stop":

                    player.Message("{0} is no longer moving.", bot.Name);
                    bot.isMoving = false;
                    bot.timeCheck.Stop();
                    bot.timeCheck.Reset();
                    bot.followTarget = null;
                    break;
                default:
                    CdBot.PrintUsage(player);
                    break;
            }
        }

        static readonly CommandDescriptor CdSetModel = new CommandDescriptor
        {
            Name = "SetModel",
            Permissions = new[] { Permission.Troll },
            Category = CommandCategory.Fun,
            IsConsoleSafe = false,
            Usage = "/SetModel [Player] [Model]",
            Help = "Changes the model of a target player Valid models are chicken, creeper, croc, human, pig, printer, sheep, skeleton, spider, or zombie. If the model is empty, the player's model will reset.",
            Handler = ModelHandler,
        };

        static void ModelHandler(Player player, Command cmd)
        {
            string target = cmd.Next();
            if (string.IsNullOrEmpty(target))
            {
                CdSetModel.PrintUsage(player);
                return;
            }

            Player targetPlayer = Server.FindPlayerOrPrintMatches(player, target, false, true);
            if (targetPlayer == null)
            {
                return;
            }

            string model = cmd.Next();
            if (string.IsNullOrEmpty(model))
            {
                player.Message("Reset the model for {0}.", targetPlayer.Name);
                targetPlayer.Model = player.Name; //reset the model to the player's name
                return;
            }

            if (model == "human")//execute super lazy parse
            {
                model = "humanoid";
            }
            if (!ValidEntities.Contains(model))
            {
                player.Message("Please choose a valid model! Valid models are chicken, creeper, croc, human, pig, printer, sheep, skeleton, spider, or zombie.");
                return;
            }

            player.Message("{0} has been changed into a {1}!", targetPlayer.Name, model);
            targetPlayer.Model = model;
        }

        static readonly CommandDescriptor CdTroll = new CommandDescriptor //Troll is an old command from 800craft that i have rehashed because of its popularity
        {                                                                 //The original command and the idea for the command were done by Jonty800 and Rebelliousdude.
            Name = "Troll",
            Permissions = new[] { Permission.Moderation },
            Category = CommandCategory.Chat | CommandCategory.Fun,
            IsConsoleSafe = true,
            Usage = "/Troll (playername) (message-type) (message)",
            Help = "Allows you impersonate others in the chat. Available chat types are msg, st, ac, pm, rq, and leave.",
            NotRepeatable = true,
            Handler = Troll,
        };

        static void Troll(Player p, Command c)
        {
            string name = c.Next();
            string chatType = c.Next();
            string msg = c.NextAll();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(chatType))
            {
                p.Message("Use like : /Troll (playername) (chat-type) (message)");
                return;
            }
            Player tgt = Server.FindPlayerOrPrintMatches(p, name, false, true);
            if (tgt == null) { return; }
            switch (chatType)
            {
                default:
                    p.Message("The available chat types are: st, ac, pm, msg, rq and leave");
                    break;
                case "leave":
                    Server.Message("&SPlayer {0}&S left the server.", tgt.ClassyName);
                    break;
                case "ragequit":
                case "rq":
                    string quitMsg = "";
                    if (msg.Length > 1) { quitMsg = ": &C" + msg; }
                    Server.Message("{0}&4 Ragequit from the server{1}", tgt.ClassyName, quitMsg);
                    Server.Message("&SPlayer {0}&S left the server.", tgt.ClassyName);
                    break;
                case "st":
                case "staffchat":
                case "staff":
                    if (string.IsNullOrEmpty(msg))
                    {
                        p.Message("The st option requires a message: /troll (player) st (message)");
                        return;
                    }
                    Server.Message("&P(staff){0}&P: {1}", tgt.ClassyName, msg);
                    break;
                case "pm":
                case "privatemessage":
                case "private":
                case "whisper":
                    if (string.IsNullOrEmpty(msg))
                    {
                        p.Message("The pm option requires a message: /troll (player) pm (message)");
                        return;
                    }
                    Server.Message("&Pfrom {0}: {1}", tgt.Name, msg);
                    break;
                case "ac":
                case "adminchat":
                case "admin":
                    if (string.IsNullOrEmpty(msg))
                    {
                        p.Message("The ac option requires a message: /troll (player) ac (message)");
                        return;
                    }
                    Server.Message("&9(Admin){0}&P: {1}", tgt.ClassyName, msg);
                    break;
                case "msg":
                case "message":
                case "global":
                case "server":
                    if (string.IsNullOrEmpty(msg))
                    {
                        p.Message("The msg option requires a message: /troll (player) msg (message)");
                        return;
                    }
                    Server.Message("{0}&f: {1}", tgt.ClassyName, msg);
                    break;
            }
            return;
        }



        static readonly CommandDescriptor CdInsult = new CommandDescriptor
        {
            Name = "Insult",
            Aliases = new string[] { "MakeFun", "MF" },
            Category = CommandCategory.Chat | CommandCategory.Fun,
            Permissions = new Permission[] { Permission.HighFive },
            IsConsoleSafe = true,
            Usage = "/Insult playername",
            Help = "Takes a random insult from a list and insults a player.",
            NotRepeatable = true,
            Handler = InsultHandler,
        };

        static void InsultHandler(Player player, Command cmd)
        {
            List<String> insults;
            string name = cmd.Next();
            Random randomizer = new Random();

            insults = new List<String>()
            {
                "{0}&s pooped on {1}&s's mom's face.",
                "{0}&s spit in {1}&s's drink.",
                "{0}&s threw a chair at {1}&s.",
                "{0}&s rubbed their butt on {1}&s",
                "{0}&s flicked off {1}&s.",
                "{0}&s pulled down their pants and flashed {1}&s.",
                "{0}&s went into {1}&s's house on their birthday, locked them in the closet, and ate their birthday dinner.",
                "{0}&s went up to {1}&s and said 'mama, mama, mama, mama, mommy, mommy, mommy, mommy, ma, ma, ma, ma, mum, mum, mum, mum. Hi! hehehehe'",
                "{0}&s asked {1}&s if they were single, just to hear them say a painful 'yes'...",
                "{0}&s shoved a pineapple up {1}&s's butt",
                "{0}&s beat {1}&s with a cane.",
                "{0}&s put {1}&s in a boiling pot and started chanting.",
                "{0}&s ate cheetos then wiped their hands all over {1}&s's white clothes",
                "{0}&s sprayed {1}&s's crotch with water, then pointed and laughed.",
                "{0}&s tied up {1}&s and ate their last candy bar right in front of them.",
                "{0}&s gave {1}&s a wet willy.",
                "{0}&s gave {1}&s a wedgie.",
                "{0}&s gave {1}&s counterfeit money and then called the Secret Service on them.",
                "{0}&s beats {1}&s with a statue of Alex.",
                "{0}&s shot {1}&s in the knee with an arrow.",
                "{0}&s called {1}&s a disfigured, bearded clam.",
                "{0}&s flipped a table onto {1}&s.",
                "{0}&s smashed {1}&s over the head with their vintage record.",
                "{0}&s dropped a piano on {1}&s.",
                "{0}&s burned {1}&s with a cigarette.",
                "{0}&s incinerated {1}&s with a Kamehameha!"
            };

            int index = randomizer.Next(0, insults.Count);
            double time = (DateTime.Now - player.Info.LastUsedInsult).TotalSeconds;

            if (string.IsNullOrEmpty(name))
            {
                player.Message("/Insult (PlayerName)");
                return;
            }
            Player target = Server.FindPlayerOrPrintMatches(player, name, false, true);
            if (target == null)
                return;
            if (target == player)
            {
                player.Message("You cannot /insult yourself.");
                return;
            }
            double timeLeft = Math.Round(20 - time);
            if (time < 20)
            {
                player.Message("You cannot use this command for another " + timeLeft + " second(s).");
                return;
            }
            else
            {
                Server.Message(insults[index], player.ClassyName, target.ClassyName);
                player.Info.LastUsedInsult = DateTime.Now;
                return;
            }

        }




        static readonly CommandDescriptor CdThrow = new CommandDescriptor
        {
            Name = "Throw",
            Aliases = new string[] { "Toss" },
            Category = CommandCategory.Chat | CommandCategory.Fun,
            Permissions = new Permission[] { Permission.Mute },
            IsConsoleSafe = true,
            Usage = "/Throw playername",
            Help = "Throw's a player.",
            NotRepeatable = true,
            Handler = ThrowHandler,
        };

        static void ThrowHandler(Player player, Command cmd)
        {
            string name = cmd.Next();
            string item = cmd.Next();
            if (name == null)
            {
                player.Message("Please enter a name");
                return;
            }
            Player target = Server.FindPlayerOrPrintMatches(player, name, false, true);
            if (target == null) return;
            if (target.Immortal)
            {
                player.Message("&SYou failed to throw {0}&S, they are immortal", target.ClassyName);
                return;
            }
            if (target == player)
            {
                player.Message("&sYou can't throw yourself... It's just physically impossible...");
                return;
            }
            double time = (DateTime.Now - player.Info.LastUsedThrow).TotalSeconds;
            if (time < 10)
            {
                player.Message("&WYou can use /Throw again in " + Math.Round(10 - time) + " seconds.");
                return;
            }
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            player.Info.LastUsedThrow = DateTime.Now;

            if (randomNumber == 1)
                if (player.Can(Permission.Slap, target.Info.Rank))
                {
                    Position slap = new Position(target.Position.Z, target.Position.X, (target.World.Map.Bounds.YMax) * 32);
                    target.TeleportTo(slap);
                    Server.Players.CanSee(target).Except(target).Message("&SPlayer {0}&S was &eThrown&s by {1}&S.", target.ClassyName, player.ClassyName);
                    IRC.PlayerSomethingMessage(player, "thrown", target, null);
                    target.Message("&sYou were &eThrown&s by {0}&s.", player.ClassyName);
                    return;
                }
                else
                {
                    player.Message("&sYou can only Throw players ranked {0}&S or lower",
                                   player.Info.Rank.GetLimit(Permission.Slap).ClassyName);
                    player.Message("{0}&S is ranked {1}", target.ClassyName, target.Info.Rank.ClassyName);
                }



            if (randomNumber == 2)
                if (player.Can(Permission.Slap, target.Info.Rank))
                {
                    Position slap = new Position(target.Position.X, target.Position.Z, (target.World.Map.Bounds.YMax) * 32);
                    target.TeleportTo(slap);
                    Server.Players.CanSee(target).Except(target).Message("&sPlayer {0}&s was &eThrown&s by {1}&s.", target.ClassyName, player.ClassyName);
                    IRC.PlayerSomethingMessage(player, "thrown", target, null);
                    target.Message("&sYou were &eThrown&s by {0}&s.", player.ClassyName);
                    return;
                }
                else
                {
                    player.Message("&sYou can only Throw players ranked {0}&S or lower",
                                   player.Info.Rank.GetLimit(Permission.Slap).ClassyName);
                    player.Message("{0}&S is ranked {1}", target.ClassyName, target.Info.Rank.ClassyName);
                }

            if (randomNumber == 3)
                if (player.Can(Permission.Slap, target.Info.Rank))
                {
                    Position slap = new Position(target.Position.Z, target.Position.Y, (target.World.Map.Bounds.XMax) * 32);
                    target.TeleportTo(slap);
                    Server.Players.CanSee(target).Except(target).Message("&sPlayer {0}&s was &eThrown&s by {1}&s.", target.ClassyName, player.ClassyName);
                    IRC.PlayerSomethingMessage(player, "thrown", target, null);
                    target.Message("&sYou were &eThrown&s by {0}&s.", player.ClassyName);
                    return;
                }
                else
                {
                    player.Message("&sYou can only Throw players ranked {0}&S or lower",
                                   player.Info.Rank.GetLimit(Permission.Slap).ClassyName);
                    player.Message("{0}&S is ranked {1}", target.ClassyName, target.Info.Rank.ClassyName);
                }

            if (randomNumber == 4)
                if (player.Can(Permission.Slap, target.Info.Rank))
                {
                    Position slap = new Position(target.Position.Y, target.Position.Z, (target.World.Map.Bounds.XMax) * 32);
                    target.TeleportTo(slap);
                    Server.Players.CanSee(target).Except(target).Message("&sPlayer {0}&s was &eThrown&s by {1}&s.", target.ClassyName, player.ClassyName);
                    IRC.PlayerSomethingMessage(player, "thrown", target, null);
                    target.Message("&sYou were &eThrown&s by {0}&s.", player.ClassyName);
                    return;
                }
                else
                {
                    player.Message("&sYou can only Throw players ranked {0}&S or lower",
                                   player.Info.Rank.GetLimit(Permission.Slap).ClassyName);
                    player.Message("{0}&S is ranked {1}", target.ClassyName, target.Info.Rank.ClassyName);
                }
        }
        #endregion



        #region Possess / UnPossess

        static readonly CommandDescriptor CdPossess = new CommandDescriptor
        {
            Name = "Possess",
            Category = CommandCategory.Fun,
            Permissions = new[] { Permission.Possess },
            Usage = "/Possess PlayerName",
            Handler = PossessHandler
        };

        static void PossessHandler(Player player, Command cmd)
        {
            string targetName = cmd.Next();
            if (targetName == null)
            {
                CdPossess.PrintUsage(player);
                return;
            }
            Player target = Server.FindPlayerOrPrintMatches(player, targetName, false, true);
            if (target == null) return;
            if (target.Immortal)
            {
                player.Message("You cannot possess {0}&S, they are immortal", target.ClassyName);
                return;
            }
            if (target == player)
            {
                player.Message("You cannot possess yourself.");
                return;
            }

            if (!player.Can(Permission.Possess, target.Info.Rank))
            {
                player.Message("You may only possess players ranked {0}&S or lower.",
                player.Info.Rank.GetLimit(Permission.Possess).ClassyName);
                player.Message("{0}&S is ranked {1}",
                                target.ClassyName, target.Info.Rank.ClassyName);
                return;
            }

            if (!player.Possess(target))
            {
                player.Message("Already possessing {0}", target.ClassyName);
            }
        }


        static readonly CommandDescriptor CdUnpossess = new CommandDescriptor
        {
            Name = "unpossess",
            Category = CommandCategory.Fun,
            Permissions = new[] { Permission.Possess },
            NotRepeatable = true,
            Usage = "/Unpossess target",
            Handler = UnpossessHandler
        };

        static void UnpossessHandler(Player player, Command cmd)
        {
            string targetName = cmd.Next();
            if (targetName == null)
            {
                CdUnpossess.PrintUsage(player);
                return;
            }
            Player target = Server.FindPlayerOrPrintMatches(player, targetName, true, true);
            if (target == null) return;

            if (!player.StopPossessing(target))
            {
                player.Message("You are not currently possessing anyone.");
            }
        }

        #endregion

        static readonly CommandDescriptor CdLife = new CommandDescriptor
        {
            Name = "Life",
            Category = CommandCategory.Fun,
            Permissions = new[] { Permission.DrawAdvanced },
            IsConsoleSafe = false,
            NotRepeatable = true,
            Usage = "/Life <command> [params]",
            Help = "&SGoogle \"Conwey's Game of Life\"\n'&H/Life help'&S for more usage info\n(c) 2012 LaoTszy",
            UsableByFrozenPlayers = false,
            Handler = LifeHandlerFunc,
        };

        static readonly CommandDescriptor CdFirework = new CommandDescriptor
        {
            Name = "Firework",
            Category = CommandCategory.Fun,
            Permissions = new[] { Permission.Fireworks },
            IsConsoleSafe = false,
            NotRepeatable = false,
            Usage = "/Firework",
            Help = "&SToggles Firework Mode on/off for yourself. " +
            "All Gold blocks will be replaced with fireworks if " +
            "firework physics are enabled for the current world.",
            UsableByFrozenPlayers = false,
            Handler = FireworkHandler
        };

        static void FireworkHandler(Player player, Command cmd)
        {
            if (player.fireworkMode)
            {
                player.fireworkMode = false;
                player.Message("Firework Mode has been turned off.");
                return;
            }
            else
            {
                player.fireworkMode = true;
                player.Message("Firework Mode has been turned on. " +
                    "All Gold blocks are now being replaced with Fireworks.");
            }
        }


        static readonly CommandDescriptor CdRandomMaze = new CommandDescriptor
        {
            Name = "RandomMaze",
            Aliases = new string[] { "3dmaze" },
            Category = CommandCategory.Fun,
            Permissions = new Permission[] { Permission.DrawAdvanced },
            RepeatableSelection = true,
            Help =
                "Choose the size (width, length and height) and it will draw a random maze at the chosen point. " +
                "Optional parameters tell if the lifts are to be drawn and if hint blocks (log) are to be added. \n(C) 2012 Lao Tszy",
            Usage = "/randommaze <width> <length> <height> [nolifts] [hints]",
            Handler = MazeHandler
        };
        static readonly CommandDescriptor CdMazeCuboid = new CommandDescriptor
        {
            Name = "MazeCuboid",
            Aliases = new string[] { "Mc", "Mz", "Maze" },
            Category = CommandCategory.Fun,
            Permissions = new Permission[] { Permission.DrawAdvanced },
            RepeatableSelection = true,
            Help =
                "Draws a cuboid with the current brush and with a random maze inside.(C) 2012 Lao Tszy",
            Usage = "/MazeCuboid [block type]",
            Handler = MazeCuboidHandler,
        };

        private static void MazeHandler(Player p, Command cmd)
        {
            try
            {
                RandomMazeDrawOperation op = new RandomMazeDrawOperation(p, cmd);
                BuildingCommands.DrawOperationBegin(p, cmd, op);
            }
            catch (Exception e)
            {
                Logger.Log(LogType.Error, "Error: " + e.Message);
            }
        }
        private static void MazeCuboidHandler(Player p, Command cmd)
        {
            try
            {
                MazeCuboidDrawOperation op = new MazeCuboidDrawOperation(p);
                BuildingCommands.DrawOperationBegin(p, cmd, op);
            }
            catch (Exception e)
            {
                Logger.Log(LogType.Error, "Error: " + e.Message);
            }
        }
        private static void LifeHandlerFunc(Player p, Command cmd)
        {
            try
            {
                if (!cmd.HasNext)
                {
                    p.Message("&H/Life <command> <params>. Commands are Help, Create, Delete, Start, Stop, Set, List, Print");
                    p.Message("Type /Life help <command> for more information");
                    return;
                }
                LifeHandler.ProcessCommand(p, cmd);
            }
            catch (Exception e)
            {
                p.Message("Error: " + e.Message);
            }
        }


    }
}