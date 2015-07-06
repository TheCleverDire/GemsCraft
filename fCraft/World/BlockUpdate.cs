// Copyright 2009-2012 Matvei Stefarov <me@matvei.org>

using System;
using System.Linq;

namespace fCraft {
    /// <summary> Structure representing a pending update to the map's block array.
    /// Contains information about the block coordinates, type, and change's origin. </summary>
    public struct BlockUpdate {
        public readonly Player Origin; // Used for stat tracking. Can be null (to avoid crediting any stats at all).
        public readonly short X, Y, Z;
        public readonly Block BlockType;

        public BlockUpdate( Player origin, short x, short y, short z, Block block ) {
            Origin = origin;
            X = x;
            Y = y;
            Z = z;
            loopCount = 0;
            BlockType = block;
            BlockType = BlockMe(block);
            if (BlockNeedsFallback(block))
            {
                ShowMessage(origin);
            }
        }

        private Block BlockMe(Block block)
        {
            return !BlockNeedsFallback(block) ? block : BlockConversion.ToFallBackBlock(block);
        }
        private void ShowMessage(Player toP)
        {
            var stop = false;
            // ReSharper disable once LoopCanBePartlyConvertedToQuery
            foreach (var blocks in Origin.FallBackBlockMessages)
            {
                if (BlockType.Equals(blocks))
                {
                    stop = true;
                }
            }
            if (stop) return;
            Origin.FallBackBlockMessages.Add(BlockType);
            toP.Message(
                "&4That block is disabled on this server. &cThe next time the map is saved, it will be a different block.");
        }

        private int loopCount;
        private bool BlockNeedsFallback(Block b)
        {
            bool finalResult = false;
            bool stopLoop = false;
            var customBlocks = Player.CustomPlusNull();
            var customsEnabled = new[]
            {
                ConfigKey.CobbleSlabEnabled, ConfigKey.RopeEnabled, ConfigKey.SandstoneEnabled,
                ConfigKey.SnowEnabled, ConfigKey.FireEnabled, ConfigKey.LightPinkEnabled,
                ConfigKey.DarkGreenEnabled, ConfigKey. BrownEnabled, ConfigKey.DarkBlueEnabled,
                ConfigKey.TurquoiseEnabled, ConfigKey.IceEnabled, ConfigKey.TileEnabled,
                ConfigKey.MagmaEnabled, ConfigKey.PillarEnabled, ConfigKey.CrateEnabled,
                ConfigKey.StoneBrickEnabled, ConfigKey.StoneBrickEnabled
            };
            for (var x = 0; x <= customBlocks.Length; x++)
            {
                try
                {
                    if (!customBlocks[x].Equals(b) || stopLoop) continue;
                    finalResult = !customsEnabled[x].Enabled();
                    stopLoop = true;
                }
                catch (Exception)
                {
                    //Ignored --> I knew it would happen!
                }
            }
            return finalResult;
        }
        public BlockUpdate( Player origin, Vector3I coord, Block block ) {
            loopCount = 0;
            Origin = origin;
            X = (short)coord.X;
            Y = (short)coord.Y;
            Z = (short)coord.Z;
            BlockType = block;
            BlockType = BlockMe(block);
            if (BlockNeedsFallback(block))
            {
                ShowMessage(origin);
            }
        }
    }
}