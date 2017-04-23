// Copyright 2009-2012 Matvei Stefarov <me@matvei.org>

using fCraft;
using static GemsCraftGUI.Program;
namespace GemsCraftGUI
{
    partial class MainForm
    {

        void FillToolTipsGeneral()
        {

            toolTip.SetToolTip(GeneralScreen.lServerName, ConfigKey.ServerName.GetDescription());
            toolTip.SetToolTip(GeneralScreen.tServerName, ConfigKey.ServerName.GetDescription());
            toolTip.SetToolTip(MiscScreen.CustomName, ConfigKey.CustomChatName.GetDescription());
            toolTip.SetToolTip(MiscScreen.CustomAliases, ConfigKey.CustomAliasName.GetDescription());
            toolTip.SetToolTip(MiscScreen.SwearBox, ConfigKey.SwearName.GetDescription());

            toolTip.SetToolTip(GeneralScreen.lMOTD, ConfigKey.MOTD.GetDescription());
            toolTip.SetToolTip(GeneralScreen.tMOTD, ConfigKey.MOTD.GetDescription());

            toolTip.SetToolTip(GeneralScreen.lMaxPlayers, ConfigKey.MaxPlayers.GetDescription());
            toolTip.SetToolTip(GeneralScreen.nMaxPlayers, ConfigKey.MaxPlayers.GetDescription());

            toolTip.SetToolTip(GeneralScreen.lMaxPlayersPerWorld, ConfigKey.MaxPlayersPerWorld.GetDescription());
            toolTip.SetToolTip(GeneralScreen.nMaxPlayersPerWorld, ConfigKey.MaxPlayersPerWorld.GetDescription());

            toolTip.SetToolTip(GeneralScreen.lDefaultRank, ConfigKey.DefaultRank.GetDescription());
            toolTip.SetToolTip(GeneralScreen.cDefaultRank, ConfigKey.DefaultRank.GetDescription());

            toolTip.SetToolTip(GeneralScreen.lPublic, ConfigKey.IsPublic.GetDescription());
            toolTip.SetToolTip(GeneralScreen.cPublic, ConfigKey.IsPublic.GetDescription());

            toolTip.SetToolTip(GeneralScreen.nPort, ConfigKey.Port.GetDescription());
            toolTip.SetToolTip(GeneralScreen.lPort, ConfigKey.Port.GetDescription());

            toolTip.SetToolTip(GeneralScreen.nUploadBandwidth, ConfigKey.UploadBandwidth.GetDescription());
            toolTip.SetToolTip(GeneralScreen.lUploadBandwidth, ConfigKey.UploadBandwidth.GetDescription());

            toolTip.SetToolTip(GeneralScreen.bMeasure,
@"Test your connection's upload speed with speedtest.net
Note: to convert from megabits to kilobytes, multiply the
number by 128");

            toolTip.SetToolTip(GeneralScreen.bRules,
@"Edit the list of rules displayed by the ""/Rules"" command.
This list is stored in rules.txt, and can also be edited with any text editor.
If rules.txt is missing or empty, ""/Rules"" shows this message:
""Use common sense!""");

            const string tipAnnouncements =
@"Show a random announcement every once in a while.
Announcements are shown to all players, one line at a time, in random order.";
            toolTip.SetToolTip(GeneralScreen.xAnnouncements, tipAnnouncements);

            toolTip.SetToolTip(GeneralScreen.nAnnouncements, ConfigKey.AnnouncementInterval.GetDescription());
            toolTip.SetToolTip(GeneralScreen.lAnnouncementsUnits, ConfigKey.AnnouncementInterval.GetDescription());

            toolTip.SetToolTip(GeneralScreen.bAnnouncements,
@"Edit the list of announcements (announcements.txt).
One line is shown at a time, in random order.
You can include any color codes in the announcements.
You can also edit announcements.txt with any text editor.");

            toolTip.SetToolTip(GeneralScreen.bGreeting,
@"Edit a custom greeting that's shown to connecting players.
You can use any color codes, and these special variables:
    {SERVER_NAME} = server name (as defined in config)
    {RANK} = connecting player's rank");

            toolTip.SetToolTip(MiscScreen.SwearEditor,
@"Edit the list of Swearwords (swearwords.txt).
Each swearword should be on a seperate line.");

            toolTip.SetToolTip(MiscScreen.ReqsEditor,
@"Edit the list of requirements for the ranks
on your server.");

        }


        void FillToolTipsChat()
        {

            toolTip.SetToolTip(ChatScreen.xRankColorsInChat, ConfigKey.RankColorsInChat.GetDescription());

            toolTip.SetToolTip(ChatScreen.xRankColorsInWorldNames, ConfigKey.RankColorsInWorldNames.GetDescription());

            toolTip.SetToolTip(ChatScreen.xRankPrefixesInChat, ConfigKey.RankPrefixesInChat.GetDescription());

            toolTip.SetToolTip(ChatScreen.xRankPrefixesInList, ConfigKey.RankPrefixesInList.GetDescription());

            toolTip.SetToolTip(ChatScreen.xShowConnectionMessages, ConfigKey.ShowConnectionMessages.GetDescription());

            toolTip.SetToolTip(ChatScreen.xShowJoinedWorldMessages, ConfigKey.ShowJoinedWorldMessages.GetDescription());

            toolTip.SetToolTip(ChatScreen.bColorSys, ConfigKey.SystemMessageColor.GetDescription());
            toolTip.SetToolTip(ChatScreen.lColorSys, ConfigKey.SystemMessageColor.GetDescription());

            toolTip.SetToolTip(ChatScreen.bColorHelp, ConfigKey.HelpColor.GetDescription());
            toolTip.SetToolTip(ChatScreen.lColorHelp, ConfigKey.HelpColor.GetDescription());

            toolTip.SetToolTip(ChatScreen.bColorSay, ConfigKey.SayColor.GetDescription());
            toolTip.SetToolTip(ChatScreen.lColorSay, ConfigKey.SayColor.GetDescription());

            toolTip.SetToolTip(ChatScreen.bColorAnnouncement, ConfigKey.AnnouncementColor.GetDescription());
            toolTip.SetToolTip(ChatScreen.lColorAnnouncement, ConfigKey.AnnouncementColor.GetDescription());

            toolTip.SetToolTip(ChatScreen.bColorPM, ConfigKey.PrivateMessageColor.GetDescription());
            toolTip.SetToolTip(ChatScreen.lColorPM, ConfigKey.PrivateMessageColor.GetDescription());

            toolTip.SetToolTip(ChatScreen.bColorMe, ConfigKey.MeColor.GetDescription());
            toolTip.SetToolTip(ChatScreen.lColorMe, ConfigKey.MeColor.GetDescription());

            toolTip.SetToolTip(ChatScreen.bColorWarning, ConfigKey.WarningColor.GetDescription());
            toolTip.SetToolTip(ChatScreen.lColorWarning, ConfigKey.WarningColor.GetDescription());
        }


        void FillToolTipsWorlds()
        {
            toolTip.SetToolTip(WorldScreen.bAddWorld, "Add a new world to the list.");
            toolTip.SetToolTip(WorldScreen.bWorldEdit, "Edit or replace an existing world.");
            toolTip.SetToolTip(WorldScreen.cMainWorld, "Main world is the first world that players see when they join the server.");
            toolTip.SetToolTip(WorldScreen.bWorldDelete, "Delete a world from the list.");

            toolTip.SetToolTip(WorldScreen.lDefaultBuildRank, ConfigKey.DefaultBuildRank.GetDescription());
            toolTip.SetToolTip(WorldScreen.cDefaultBuildRank, ConfigKey.DefaultBuildRank.GetDescription());

            toolTip.SetToolTip(WorldScreen.tMapPath, ConfigKey.MapPath.GetDescription());
            toolTip.SetToolTip(WorldScreen.xMapPath, ConfigKey.MapPath.GetDescription());

            toolTip.SetToolTip(WorldScreen.xWoMEnableEnvExtensions, ConfigKey.WoMEnableEnvExtensions.GetDescription());
        }


        void FillToolTipsRanks()
        {

            toolTip.SetToolTip(RankScreen.xAllowSecurityCircumvention,
@"Allows players to manupulate whitelists/blacklists or rank requirements
in order to join restricted worlds, or to build in worlds/zones. Normally
players with ManageWorlds and ManageZones permissions are not allowed to do this.
Affected commands:
    /WAccess
    /WBuild
    /WMain
    /ZEdit");

            toolTip.SetToolTip(RankScreen.bAddRank, "Add a new rank to the list.");
            toolTip.SetToolTip(RankScreen.bDeleteRank,
@"Delete a rank from the list. You will be prompted to specify a replacement
rank - to be able to convert old references to the deleted rank.");
            toolTip.SetToolTip(RankScreen.bRaiseRank,
@"Raise a rank (and all players of the rank) on the hierarchy.
The hierarchy is used for all permission checks.");
            toolTip.SetToolTip(RankScreen.bLowerRank,
@"Lower a rank (and all players of the rank) on the hierarchy.
The hierarchy is used for all permission checks.");

            const string tipRankName =
"Name of the rank - between 2 and 16 alphanumeric characters.";
            toolTip.SetToolTip(RankScreen.lRankName, tipRankName);
            toolTip.SetToolTip(RankScreen.tRankName, tipRankName);

            const string tipRankColor =
@"Color associated with this rank.
Rank colors may be applied to player and world names.";
            toolTip.SetToolTip(RankScreen.lRankColor, tipRankColor);
            toolTip.SetToolTip(RankScreen.bColorRank, tipRankColor);

            const string tipPrefix =
@"1-character prefix that may be shown above player names.
The option to show prefixes in chat is on ""General"" tab.";
            toolTip.SetToolTip(RankScreen.lPrefix, tipPrefix);
            toolTip.SetToolTip(RankScreen.tPrefix, tipPrefix);



            toolTip.SetToolTip(_permissionLimitBoxes[Permission.Kick],
@"Limit on who can be kicked by players of this rank.
By default, players can only kick players of same or lower rank.");

            toolTip.SetToolTip(_permissionLimitBoxes[Permission.Ban],
@"Limit on who can be banned by players of this rank.
By default, players can only ban players of same or lower rank.");

            toolTip.SetToolTip(_permissionLimitBoxes[Permission.Promote],
@"Limit on how much can players of this rank promote others.
By default, players can only promote up to the same or lower rank.");

            toolTip.SetToolTip(_permissionLimitBoxes[Permission.Demote],
@"Limit on whom players of this rank can demote.
By default, players can only demote players of same or lower rank.");

            toolTip.SetToolTip(_permissionLimitBoxes[Permission.Hide],
@"Limit on whom can players of this rank hide from.
By default, players can only hide from players of same or lower rank.");

            toolTip.SetToolTip(_permissionLimitBoxes[Permission.Freeze],
@"Limit on who can be frozen by players of this rank.
By default, players can only freeze players of same or lower rank.");

            toolTip.SetToolTip(_permissionLimitBoxes[Permission.Mute],
@"Limit on who can be muted by players of this rank.
By default, players can only mute players of same or lower rank.");

            toolTip.SetToolTip(_permissionLimitBoxes[Permission.Bring],
@"Limit on who can be brought (forcibly teleported) by players of this rank.
By default, players can only bring players of same or lower rank.");

            toolTip.SetToolTip(_permissionLimitBoxes[Permission.Spectate],
@"Limit on who can be spectated by players of this rank.
By default, players can only bring players of same or lower rank.");

            toolTip.SetToolTip(_permissionLimitBoxes[Permission.UndoOthersActions],
@"Limit on whose actions players of this rank can undo.
By default, players can only undo actions of players of same or lower rank.");



            toolTip.SetToolTip(RankScreen.xReserveSlot,
@"Allows players of this rank to join the server
even if it reached the maximum number of players.");

            const string tipKickIdle = "Allows kicking players who have been inactive/AFK for some time.";
            toolTip.SetToolTip(RankScreen.xKickIdle, tipKickIdle);
            toolTip.SetToolTip(RankScreen.nKickIdle, tipKickIdle);
            toolTip.SetToolTip(RankScreen.lKickIdleUnits, tipKickIdle);

            toolTip.SetToolTip(RankScreen.xAntiGrief,
@"Antigrief is an automated system for kicking players who build
or delete at abnormally high rates. This helps stop certain kinds
of malicious software (like MCTunnel) from doing large-scale damage
to server maps. False positives can sometimes occur if server or
player connection is very laggy.");

            toolTip.SetToolTip(RankScreen.nAntiGriefBlocks,
@"Maximum number of blocks that players of this rank are
allowed to build in a specified time period.");

            toolTip.SetToolTip(RankScreen.nAntiGriefBlocks,
@"Minimum time interval that players of this rank are
expected to spent to build a specified number of blocks.");

            const string tipDrawLimit =
@"Limit on the number of blocks that a player is
allowed to affect with drawing or copy/paste commands
at one time. If unchecked, there is no limit.";
            toolTip.SetToolTip(RankScreen.xDrawLimit, tipDrawLimit);
            toolTip.SetToolTip(RankScreen.nDrawLimit, tipDrawLimit);
            toolTip.SetToolTip(RankScreen.lDrawLimitUnits, tipDrawLimit);


            RankScreen.vPermissions.Items[(int) Permission.PrisonAdd].ToolTipText =
                @"Ability to throw people in prison";
            RankScreen.vPermissions.Items[(int) Permission.PrisonBail].ToolTipText =
                @"Ability to bail people out of prison";
            RankScreen.vPermissions.Items[(int) Permission.PrisonCivilian].ToolTipText =
                @"Ability to visit the prison as a civilian";
            RankScreen.vPermissions.Items[(int) Permission.PrisonFree].ToolTipText =
                @"Ability to free a person from prison";

            RankScreen.vPermissions.Items[(int)Permission.Ban].ToolTipText =
@"Ability to ban/unban other players from the server.
Affected commands:
    /Ban
    /Banx
    /Unban";

            RankScreen.vPermissions.Items[(int)Permission.BanAll].ToolTipText =
@"Ability to ban/unban a player account, his IP, and all other accounts that used the IP.
BanAll/UnbanAll commands can be used on players who keep evading bans.
Required permissions: Ban & BanIP
Affected commands:
    /BanAll
    /UnbanAll";

            RankScreen.vPermissions.Items[(int)Permission.BanIP].ToolTipText =
@"Ability to ban/unban players by IP.
Required permission: Ban
Affected commands:
    /BanIP
    /UnbanIP";

            RankScreen.vPermissions.Items[(int)Permission.Basscannon].ToolTipText =
@"Ability to kick a player with stlye.
Affected command:
    /Basscannon";

            RankScreen.vPermissions.Items[(int)Permission.Bring].ToolTipText =
@"Ability to bring/summon other players to your location.
This works a bit like reverse-teleport - other player is sent to you.
Affected commands:
    /Bring
    /BringAll";

            RankScreen.vPermissions.Items[(int)Permission.BringAll].ToolTipText =
@"Ability to bring/summon many players at a time to your location.
Affected command:
    /BringAll";

            RankScreen.vPermissions.Items[(int)Permission.BroMode].ToolTipText =
@"Ability to activate BroMode.
Affected command:
    /BroMode";

            RankScreen.vPermissions.Items[(int)Permission.Build].ToolTipText =
@"Ability to place blocks on maps. This is a baseline permission
that can be overridden by world-specific and zone-specific permissions.";

            RankScreen.vPermissions.Items[(int)Permission.Chat].ToolTipText =
@"Ability to chat and PM players. Note that players without this
permission can still type in commands, receive PMs, and read chat.
Affected commands:
    /Say
    @ (pm)
    @@ (rank chat)";

            RankScreen.vPermissions.Items[(int)Permission.ChatWithCaps].ToolTipText =
@"Ability to chat with caps without restrictions.";

            RankScreen.vPermissions.Items[(int)Permission.CopyAndPaste].ToolTipText =
@"Ability to copy (or cut) and paste blocks. The total number of
blocks that can be copied or pasted at a time is affected by
the draw limit.
Affected commands:
    /Copy
    /Cut
    /Mirror
    /Paste, /PasteNot
    /Rotate";

            RankScreen.vPermissions.Items[(int)Permission.Delete].ToolTipText =
@"Ability to delete or replace blocks on maps. This is a baseline permission
that can be overridden by world-specific and zone-specific permissions.";

            RankScreen.vPermissions.Items[(int)Permission.DeleteAdmincrete].ToolTipText =
@"Ability to delete admincrete (aka adminium) blocks. Even if someone
has this permission, it can be overridden by world-specific and
zone-specific permissions.
Required permission: Delete";

            RankScreen.vPermissions.Items[(int)Permission.Demote].ToolTipText =
@"Ability to demote other players to a lower rank.
Affected commands:
    /Rank
    /MassRank";

            RankScreen.vPermissions.Items[(int)Permission.Draw].ToolTipText =
@"Ability to use drawing tools (commands capable of affecting many blocks
at once). This permission can be overridden by world-specific and
zone-specific permissions.
Required permission: Build, Delete
Affected commands:
    /Cuboid, /CuboidH, and /CuboidW
    /Ellipsoid and /EllipsoidH
    /Line
    /Replace and /ReplaceNot
    /Undo and /Redo";

            RankScreen.vPermissions.Items[(int)Permission.DrawAdvanced].ToolTipText =
@"Ability to use advanced drawing tools, such as brushes.
Required permission: Build, Delete, Draw
Affected commands:
    /Brush
    /ReplaceBrush
    /Restore
    /Sphere and /SphereH
    /Torus";

            RankScreen.vPermissions.Items[(int)Permission.EditPlayerDB].ToolTipText =
@"Ability to edit the player database directly. This also adds the ability to
promote/demote players by name, even if they have not visited the server yet.
Also allows to manipulate players' records, and to promote/demote players in batches.
Affected commands:
    /PruneDB
    /AutoRankAll
    /MassRank
    /SetInfo
    /Nick
    /InfoSwap
    /DumpStats";

            RankScreen.vPermissions.Items[(int)Permission.Fireworks].ToolTipText =
@"Ability to create fireworks.
Affected command:
    /Firework";

            RankScreen.vPermissions.Items[(int)Permission.Freeze].ToolTipText =
@"Ability to freeze/unfreeze players. Frozen players cannot
move or build/delete.
Affected commands:
    /Freeze
    /Unfreeze";

            RankScreen.vPermissions.Items[(int)Permission.Gtfo].ToolTipText =
@"Ability to kick a player without saving it to the DB.
Affected command:
    /Gtfo";

            RankScreen.vPermissions.Items[(int)Permission.Gun].ToolTipText =
@"Ability to use a gun.
Affected command:
    /Gun";

            RankScreen.vPermissions.Items[(int)Permission.Hide].ToolTipText =
@"Ability to appear hidden from other players. You can still chat,
build/delete blocks, use all commands, and join worlds while hidden.
Hidden players are completely invisible to other players.
Affected commands:
    /Hide
    /Unhide";

            RankScreen.vPermissions.Items[(int)Permission.HideRanks].ToolTipText =
@"Ability to hide ranks from the /ranks list.
Affected command:
    /RankHide";

            RankScreen.vPermissions.Items[(int)Permission.HighFive].ToolTipText =
@"Ability to give a player a HighFive.
Affected command:
    /High5";

            RankScreen.vPermissions.Items[(int)Permission.Import].ToolTipText =
@"Ability to import rank and ban lists from files. Useful if you
are switching from another server software.
Affected commands:
    /Import";

            RankScreen.vPermissions.Items[(int)Permission.Immortal].ToolTipText =
@"Ability to become immortal.
Affected command:
    /Immortal";

            RankScreen.vPermissions.Items[(int)Permission.Kick].ToolTipText =
@"Ability to kick players from the server.
Affected commands:
    /Kick";

            RankScreen.vPermissions.Items[(int)Permission.Kill].ToolTipText =
@"Ability to kill players.
Affected command:
    /Kill";

            RankScreen.vPermissions.Items[(int)Permission.Lock].ToolTipText =
@"Ability to lock/unlock maps (locking puts a world into read-only state.)
Affected commands:
    /WLock
    /WUnlock";

            RankScreen.vPermissions.Items[(int)Permission.MakeVoteKicks].ToolTipText =
@"Ability to vote to kick a player.
Affected command:
    /Vote";

            RankScreen.vPermissions.Items[(int)Permission.MakeVotes].ToolTipText =
@"Ability to create votes.
Affected command:
    /Vote";

            RankScreen.vPermissions.Items[(int)Permission.ManageWorlds].ToolTipText =
@"Ability to manipulate the world list: adding, renaming, and deleting worlds,
loading/saving maps, change per-world permissions, and using the map generator.
Affected commands:
    /WLoad
    /WUnload
    /WRename
    /WMain
    /WAccess and /WBuild
    /WFlush
    /Gen";


            RankScreen.vPermissions.Items[(int)Permission.ManageBlockDB].ToolTipText =
@"Ability to enable/disable, clear, and configure BlockDB.
Affected command:
    /BlockDB";

            RankScreen.vPermissions.Items[(int)Permission.ManagePortal].ToolTipText =
@"Ability to create, edit, and delete portals.
Affected command:
    /Portal";

            RankScreen.vPermissions.Items[(int)Permission.ManageZones].ToolTipText =
@"Ability to manipulate zones: adding, editing, renaming, and removing zones.
Affected commands:
    /ZAdd
    /ZEdit
    /ZRemove
    /ZRename";

            RankScreen.vPermissions.Items[(int)Permission.Moderation].ToolTipText =
@"Ability to mute everyone in the server, useful for announcements.
Affected command:
    /Moderate";

            RankScreen.vPermissions.Items[(int)Permission.Mute].ToolTipText =
@"Ability to temporarily mute players. Muted players cannot write chat or 
send PMs, but they can still type in commands, receive PMs, and read chat.
Affected commands:
    /Mute
    /Unmute";

            RankScreen.vPermissions.Items[(int)Permission.Patrol].ToolTipText =
@"Ability to patrol lower-ranked players. ""Patrolling"" means teleporting
to other players to check on them, usually while hidden.
Required permission: Teleport
Affected commands:
    /Patrol
    /SpecPatrol";

            RankScreen.vPermissions.Items[(int)Permission.Physics].ToolTipText =
@"Ability to activate Physics on a world.
Affected command:
    /Physics";

            RankScreen.vPermissions.Items[(int)Permission.PlaceAdmincrete].ToolTipText =
@"Ability to place admincrete/adminium. This also affects draw commands.
Required permission: Build
Affected commands:
    /Solid
    /Bind";

            RankScreen.vPermissions.Items[(int)Permission.PlaceGrass].ToolTipText =
@"Ability to place grass blocks. This also affects draw commands.
Required permission: Build
Affected commands:
    /Grass
    /Bind";

            RankScreen.vPermissions.Items[(int)Permission.PlaceLava].ToolTipText =
@"Ability to place lava blocks. This also affects draw commands.
Required permission: Build
Affected commands:
    /Lava
    /Bind";

            RankScreen.vPermissions.Items[(int)Permission.PlaceWater].ToolTipText =
@"Ability to place water blocks. This also affects draw commands.
Required permission: Build
Affected commands:
    /Water
    /Bind";

            RankScreen.vPermissions.Items[(int)Permission.Possess].ToolTipText =
        @"Ability to possess a player.
Affected commands:
    /Possess
    /unpossess";

            RankScreen.vPermissions.Items[(int)Permission.Promote].ToolTipText =
@"Ability to promote players to a higher rank.
Affected commands:
    /Rank";

            RankScreen.vPermissions.Items[(int)Permission.RageQuit].ToolTipText =
@"Ability to ragequit from the server.
Affected command:
    /Ragequit";

            RankScreen.vPermissions.Items[(int)Permission.ReadAdminChat].ToolTipText =
@"Ability to read Admin chat.";

            RankScreen.vPermissions.Items[(int)Permission.ReadCustomChat].ToolTipText =
@"Ability to read Custom chat.";

            RankScreen.vPermissions.Items[(int)Permission.ReadStaffChat].ToolTipText =
@"Ability to read staff chat.";

            RankScreen.vPermissions.Items[(int)Permission.Realm].ToolTipText =
@"Ability to create realms.
Affected command:
    /Realm";

            RankScreen.vPermissions.Items[(int)Permission.ReloadConfig].ToolTipText =
@"Ability to reload the configuration file without restarting.
Affected commands:
    /Reload";

            RankScreen.vPermissions.Items[(int)Permission.Say].ToolTipText =
@"Ability to use /Say command.
Required permission: Chat
Affected commands:
    /Say";

            RankScreen.vPermissions.Items[(int)Permission.SetSpawn].ToolTipText =
@"Ability to change the spawn point of a world or a player.
Affected commands:
    /SetSpawn";

            RankScreen.vPermissions.Items[(int)Permission.ShutdownServer].ToolTipText =
@"Ability to shut down or restart the server remotely.
Useful for servers that run on dedicated machines.
Affected commands:
    /Shutdown
    /Restart";

            RankScreen.vPermissions.Items[(int)Permission.Slap].ToolTipText =
@"Ability to slap players.
Affected command:
    /Slap";

            RankScreen.vPermissions.Items[(int)Permission.Spectate].ToolTipText =
@"Ability to spectate/follow other players in first-person view.
Affected commands:
    /Spectate";

            RankScreen.vPermissions.Items[(int)Permission.Swear].ToolTipText =
@"Ability to use swear words without restrictions";

            RankScreen.vPermissions.Items[(int)Permission.Teleport].ToolTipText =
@"Ability to teleport to other players.
Affected commands:
    /TP";

            RankScreen.vPermissions.Items[(int)Permission.TempBan].ToolTipText =
@"Ability to temporarily ban a player.
Affected command:
    /Tempban";

            RankScreen.vPermissions.Items[(int)Permission.Tower].ToolTipText =
@"Ability to create a Tower.
Affected command:
    /Tower";

            RankScreen.vPermissions.Items[(int)Permission.Tree].ToolTipText =
@"Ability to create a tree.
Affected command:
    /Tree";

            RankScreen.vPermissions.Items[(int)Permission.Troll].ToolTipText =
@"Ability to troll players.
Affected command:
    /Troll";

            RankScreen.vPermissions.Items[(int)Permission.UndoOthersActions].ToolTipText =
@"Ability to undo actions of other players, using the BlockDB.
Affected commands:
    /UndoArea
    /UndoPlayer";

            RankScreen.vPermissions.Items[(int)Permission.UseColorCodes].ToolTipText =
@"Ability to use color codes in chat messages.";

            RankScreen.vPermissions.Items[(int)Permission.UsePortal].ToolTipText =
@"Ability to use portals (not be confused with ManagePortal).";

            RankScreen.vPermissions.Items[(int)Permission.UseSpeedHack].ToolTipText =
@"Ability to move at a faster-than-normal rate (using hacks).
WARNING: Speedhack detection is often inaccurate, and may produce many
false positives - especially on laggy servers.";

            RankScreen.vPermissions.Items[(int)Permission.Warn].ToolTipText =
@"Ability to warn a player.
Affected command:
    /Warn";

            RankScreen.vPermissions.Items[(int)Permission.ViewOthersInfo].ToolTipText =
@"Ability to view extended information about other players.
Affected commands:
    /Info
    /BanInfo
    /Where";

            RankScreen.vPermissions.Items[(int)Permission.ViewPlayerIPs].ToolTipText =
@"Ability to view players' IP addresses.
Affected commands:
    /Info
    /BanInfo
    /BanIP, /BanAll, /UnbanIP, /UnbanAll";
        }


        void FillToolTipsSecurity()
        {
            toolTip.SetToolTip(SecurityScreen.lVerifyNames, ConfigKey.VerifyNames.GetDescription());
            toolTip.SetToolTip(SecurityScreen.cVerifyNames, ConfigKey.VerifyNames.GetDescription());

            toolTip.SetToolTip(SecurityScreen.xMaxConnectionsPerIP, ConfigKey.MaxConnectionsPerIP.GetDescription());
            toolTip.SetToolTip(SecurityScreen.nMaxConnectionsPerIP, ConfigKey.MaxConnectionsPerIP.GetDescription());

            toolTip.SetToolTip(SecurityScreen.xAllowUnverifiedLAN, ConfigKey.AllowUnverifiedLAN.GetDescription());

            toolTip.SetToolTip(SecurityScreen.xRequireBanReason, ConfigKey.RequireBanReason.GetDescription());
            toolTip.SetToolTip(SecurityScreen.xRequireKickReason, ConfigKey.RequireKickReason.GetDescription());
            toolTip.SetToolTip(SecurityScreen.xRequireRankChangeReason, ConfigKey.RequireRankChangeReason.GetDescription());

            toolTip.SetToolTip(SecurityScreen.xAnnounceKickAndBanReasons, ConfigKey.AnnounceKickAndBanReasons.GetDescription());
            toolTip.SetToolTip(SecurityScreen.xAnnounceRankChanges, ConfigKey.AnnounceRankChanges.GetDescription());
            toolTip.SetToolTip(SecurityScreen.xAnnounceRankChangeReasons, ConfigKey.AnnounceRankChanges.GetDescription());


            toolTip.SetToolTip(SecurityScreen.lPatrolledRank, ConfigKey.PatrolledRank.GetDescription());
            toolTip.SetToolTip(SecurityScreen.cPatrolledRank, ConfigKey.PatrolledRank.GetDescription());
            toolTip.SetToolTip(SecurityScreen.lPatrolledRankAndBelow, ConfigKey.PatrolledRank.GetDescription());

            toolTip.SetToolTip(SecurityScreen.nAntispamMessageCount, ConfigKey.AntispamMessageCount.GetDescription());
            toolTip.SetToolTip(SecurityScreen.lAntispamMessageCount, ConfigKey.AntispamMessageCount.GetDescription());
            toolTip.SetToolTip(SecurityScreen.nAntispamInterval, ConfigKey.AntispamInterval.GetDescription());
            toolTip.SetToolTip(SecurityScreen.lAntispamInterval, ConfigKey.AntispamInterval.GetDescription());

            toolTip.SetToolTip(SecurityScreen.xAntispamKicks, "Kick players who repeatedly trigger antispam warnings.");
            toolTip.SetToolTip(SecurityScreen.nAntispamMaxWarnings, ConfigKey.AntispamMaxWarnings.GetDescription());
            toolTip.SetToolTip(SecurityScreen.lAntispamMaxWarnings, ConfigKey.AntispamMaxWarnings.GetDescription());

            toolTip.SetToolTip(SecurityScreen.xBlockDBEnabled, ConfigKey.BlockDBEnabled.GetDescription());
            toolTip.SetToolTip(SecurityScreen.xBlockDBAutoEnable, ConfigKey.BlockDBAutoEnable.GetDescription());
            toolTip.SetToolTip(SecurityScreen.cBlockDBAutoEnableRank, ConfigKey.BlockDBAutoEnableRank.GetDescription());
        }


        void FillToolTipsSavingAndBackup()
        {

            toolTip.SetToolTip(SavingBackupScreen.xSaveInterval, ConfigKey.SaveInterval.GetDescription());
            toolTip.SetToolTip(SavingBackupScreen.nSaveInterval, ConfigKey.SaveInterval.GetDescription());
            toolTip.SetToolTip(SavingBackupScreen.lSaveIntervalUnits, ConfigKey.SaveInterval.GetDescription());

            toolTip.SetToolTip(SavingBackupScreen.xBackupOnStartup, ConfigKey.BackupOnStartup.GetDescription());

            toolTip.SetToolTip(SavingBackupScreen.xBackupOnJoin, ConfigKey.BackupOnJoin.GetDescription());

            toolTip.SetToolTip(SavingBackupScreen.xBackupInterval, ConfigKey.DefaultBackupInterval.GetDescription());
            toolTip.SetToolTip(SavingBackupScreen.nBackupInterval, ConfigKey.DefaultBackupInterval.GetDescription());
            toolTip.SetToolTip(SavingBackupScreen.lBackupIntervalUnits, ConfigKey.DefaultBackupInterval.GetDescription());

            toolTip.SetToolTip(SavingBackupScreen.xBackupOnlyWhenChanged, ConfigKey.DefaultBackupInterval.GetDescription());

            toolTip.SetToolTip(SavingBackupScreen.xMaxBackups, ConfigKey.MaxBackups.GetDescription());
            toolTip.SetToolTip(SavingBackupScreen.nMaxBackups, ConfigKey.MaxBackups.GetDescription());
            toolTip.SetToolTip(SavingBackupScreen.lMaxBackups, ConfigKey.MaxBackups.GetDescription());

            toolTip.SetToolTip(SavingBackupScreen.xMaxBackupSize, ConfigKey.MaxBackupSize.GetDescription());
            toolTip.SetToolTip(SavingBackupScreen.nMaxBackupSize, ConfigKey.MaxBackupSize.GetDescription());
            toolTip.SetToolTip(SavingBackupScreen.lMaxBackupSize, ConfigKey.MaxBackupSize.GetDescription());
        }


        void FillToolTipsLogging()
        {
            toolTip.SetToolTip(LoggingScreen.lLogMode, ConfigKey.LogMode.GetDescription());
            toolTip.SetToolTip(LoggingScreen.cLogMode, ConfigKey.LogMode.GetDescription());

            toolTip.SetToolTip(LoggingScreen.xLogLimit, ConfigKey.MaxLogs.GetDescription());
            toolTip.SetToolTip(LoggingScreen.nLogLimit, ConfigKey.MaxLogs.GetDescription());
            toolTip.SetToolTip(LoggingScreen.lLogLimitUnits, ConfigKey.MaxLogs.GetDescription());

            LoggingScreen.vLogFileOptions.Items[(int)LogType.ConsoleInput].ToolTipText = "Commands typed in from the server console.";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.ConsoleOutput].ToolTipText =
@"Things sent directly in response to console input,
e.g. output of commands called from console.";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.Debug].ToolTipText = "Technical information that may be useful to find bugs.";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.Error].ToolTipText = "Major errors and problems.";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.SeriousError].ToolTipText = "Errors that prevent server from starting or result in crashes.";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.GlobalChat].ToolTipText = "Normal chat messages written by players.";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.IRC].ToolTipText =
@"IRC-related status and error messages.
Does not include IRC chatter (see IRCChat).";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.PrivateChat].ToolTipText = "PMs (Private Messages) exchanged between players (@player message).";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.RankChat].ToolTipText = "Rank-wide messages (@@rank message).";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.SuspiciousActivity].ToolTipText = "Suspicious activity - hack attempts, failed logins, unverified names.";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.SystemActivity].ToolTipText = "Status messages regarding normal system activity.";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.UserActivity].ToolTipText = "Status messages regarding players' actions.";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.UserCommand].ToolTipText = "Commands types in by players.";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.Warning].ToolTipText = "Minor, recoverable errors and problems.";
            LoggingScreen.vLogFileOptions.Items[(int)LogType.ChangedWorld].ToolTipText = "Logs when a player changes world.";

            for (var i = 0; i < LoggingScreen.vConsoleOptions.Items.Count; i++)
            {
                LoggingScreen.vConsoleOptions.Items[i].ToolTipText = LoggingScreen.vLogFileOptions.Items[i].ToolTipText;
            }
        }


        void FillToolTipsIrc()
        {
            toolTip.SetToolTip(IrcScreen.xIRCBotEnabled, ConfigKey.IRCBotEnabled.GetDescription());

            const string tipIRCList =
@"Choose one of these popular IRC networks,
or type in address/port manually below.";
            toolTip.SetToolTip(IrcScreen.lIRCList, tipIRCList);
            toolTip.SetToolTip(IrcScreen.cIRCList, tipIRCList);

            toolTip.SetToolTip(IrcScreen.lIRCBotNick, ConfigKey.IRCBotNick.GetDescription());
            toolTip.SetToolTip(IrcScreen.tIRCBotNick, ConfigKey.IRCBotNick.GetDescription());

            toolTip.SetToolTip(IrcScreen.lIRCBotNetwork, ConfigKey.IRCBotNetwork.GetDescription());
            toolTip.SetToolTip(IrcScreen.tIRCBotNetwork, ConfigKey.IRCBotNetwork.GetDescription());

            toolTip.SetToolTip(IrcScreen.lIRCBotPort, ConfigKey.IRCBotPort.GetDescription());
            toolTip.SetToolTip(IrcScreen.nIRCBotPort, ConfigKey.IRCBotPort.GetDescription());

            toolTip.SetToolTip(IrcScreen.lIRCDelay, ConfigKey.IRCDelay.GetDescription());
            toolTip.SetToolTip(IrcScreen.nIRCDelay, ConfigKey.IRCDelay.GetDescription());
            toolTip.SetToolTip(IrcScreen.lIRCDelayUnits, ConfigKey.IRCDelay.GetDescription());

            toolTip.SetToolTip(IrcScreen.tIRCBotChannels, ConfigKey.IRCBotChannels.GetDescription());

            toolTip.SetToolTip(IrcScreen.xIRCRegisteredNick, ConfigKey.IRCRegisteredNick.GetDescription());

            toolTip.SetToolTip(IrcScreen.lIRCNickServ, ConfigKey.IRCNickServ.GetDescription());
            toolTip.SetToolTip(IrcScreen.tIRCNickServ, ConfigKey.IRCNickServ.GetDescription());

            toolTip.SetToolTip(IrcScreen.lIRCNickServMessage, ConfigKey.IRCNickServMessage.GetDescription());
            toolTip.SetToolTip(IrcScreen.tIRCNickServMessage, ConfigKey.IRCNickServMessage.GetDescription());

            toolTip.SetToolTip(IrcScreen.lColorIRC, ConfigKey.IRCMessageColor.GetDescription());
            toolTip.SetToolTip(IrcScreen.bColorIRC, ConfigKey.IRCMessageColor.GetDescription());

            toolTip.SetToolTip(IrcScreen.xIRCBotForwardFromIRC, ConfigKey.IRCBotForwardFromIRC.GetDescription());
            toolTip.SetToolTip(IrcScreen.xIRCBotAnnounceIRCJoins, ConfigKey.IRCBotAnnounceIRCJoins.GetDescription());

            toolTip.SetToolTip(IrcScreen.xIRCBotForwardFromServer, ConfigKey.IRCBotForwardFromServer.GetDescription());
            toolTip.SetToolTip(IrcScreen.xIRCBotAnnounceServerJoins, ConfigKey.IRCBotAnnounceServerJoins.GetDescription());
            toolTip.SetToolTip(IrcScreen.xIRCBotAnnounceServerEvents, ConfigKey.IRCBotAnnounceServerEvents.GetDescription());

            // TODO: IRCThreads

            toolTip.SetToolTip(IrcScreen.xIRCUseColor, ConfigKey.IRCUseColor.GetDescription());
        }

         
        void FillToolTipsAdvanced()
        {
            toolTip.SetToolTip(AdvancedScreen.xRelayAllBlockUpdates, ConfigKey.RelayAllBlockUpdates.GetDescription());

            toolTip.SetToolTip(AdvancedScreen.xNoPartialPositionUpdates, ConfigKey.NoPartialPositionUpdates.GetDescription());

            toolTip.SetToolTip(AdvancedScreen.xLowLatencyMode, ConfigKey.LowLatencyMode.GetDescription());

            toolTip.SetToolTip(AdvancedScreen.lProcessPriority, ConfigKey.ProcessPriority.GetDescription());
            toolTip.SetToolTip(AdvancedScreen.cProcessPriority, ConfigKey.ProcessPriority.GetDescription());


            toolTip.SetToolTip(AdvancedScreen.lThrottling, ConfigKey.BlockUpdateThrottling.GetDescription());
            toolTip.SetToolTip(AdvancedScreen.nThrottling, ConfigKey.BlockUpdateThrottling.GetDescription());
            toolTip.SetToolTip(AdvancedScreen.lThrottlingUnits, ConfigKey.BlockUpdateThrottling.GetDescription());

            toolTip.SetToolTip(AdvancedScreen.lTickInterval, ConfigKey.TickInterval.GetDescription());
            toolTip.SetToolTip(AdvancedScreen.nTickInterval, ConfigKey.TickInterval.GetDescription());
            toolTip.SetToolTip(AdvancedScreen.lTickIntervalUnits, ConfigKey.TickInterval.GetDescription());

            toolTip.SetToolTip(AdvancedScreen.xMaxUndo, ConfigKey.MaxUndo.GetDescription());
            toolTip.SetToolTip(AdvancedScreen.nMaxUndo, ConfigKey.MaxUndo.GetDescription());
            toolTip.SetToolTip(AdvancedScreen.lMaxUndoUnits, ConfigKey.MaxUndo.GetDescription());

            toolTip.SetToolTip(AdvancedScreen.xIP, ConfigKey.IP.GetDescription());
            toolTip.SetToolTip(AdvancedScreen.tIP, ConfigKey.IP.GetDescription());

        }


        void FillToolTipsCpe()
        {
            toolTip.SetToolTip(CpeScreen.gboClickDistance, ConfigKey.ClickDistanceEnabled.GetDescription());
            toolTip.SetToolTip(CpeScreen.gboCustomBlocks, ConfigKey.CustomBlocksEnabled.GetDescription());
        }
    }
}