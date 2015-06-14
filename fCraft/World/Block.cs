// Copyright 2009-2012 Matvei Stefarov <me@matvei.org>

namespace fCraft {
    /// <summary> Enumeration of all standard Minecraft Classic block types. </summary>
    public enum Block : byte {
        Undefined = 255, // for error checking

        Air = 0,
        Stone = 1,
        Grass = 2,
        Dirt = 3,
        Cobblestone = 4,
        Wood = 5,
        Plant = 6,
        Admincrete = 7,
        Water = 8,
        StillWater = 9,
        Lava = 10,
        StillLava = 11,
        Sand = 12,
        Gravel = 13,
        GoldOre = 14,
        IronOre = 15,
        Coal = 16,
        Log = 17,
        Leaves = 18,
        Sponge = 19,
        Glass = 20,

        Red = 21,
        Orange = 22,
        Yellow = 23,
        Lime = 24,
        Green = 25,
        Teal = 26,
        Aqua = 27,
        Cyan = 28,
        Blue = 29,
        Indigo = 30,
        Violet = 31,
        Magenta = 32,
        Pink = 33,
        Black = 34,
        Gray = 35,
        White = 36,

        YellowFlower = 37,
        RedFlower = 38,
        BrownMushroom = 39,
        RedMushroom = 40,

        Gold = 41,
        Iron = 42,
        DoubleStair = 43,
        Stair = 44,
        Brick = 45,
        TNT = 46,
        Books = 47,
        MossyRocks = 48,
        Obsidian = 49,

        //ClassiCube Blocks
        CobbleSlab = 50,
        Rope = 51,
        Sandstone = 52,
        Snow = 53,
        Fire = 54,
        LightPink = 55,
        DarkGreen = 56,
        Brown = 57,
        DarkBlue = 58,
        Turquoise = 59,
        Ice = 60,
        Tile = 61,
        Magma = 62,
        Pillar = 63,
        Crate = 64,
        StoneBrick = 65
    }
    /// <summary>
    /// Class for handling conversion between Blocks to Bytes and vise versa
    /// </summary>
    public class BlockConversion
    {
        /// <summary>
        /// Converts byte to block
        /// </summary>
        /// <param name="byteId">byteid of the needed Block</param>
        /// <returns></returns>
        public static Block ToBlock(byte byteId)
        {
            switch (byteId)
            {
                case 255:
                    return Block.Undefined;
                case 0:
                    return Block.Air;
                case 1:
                    return Block.Stone;
                case 2:
                    return Block.Grass;
                case 3:
                    return Block.Dirt;
                case 4:
                    return Block.Cobblestone;
                case 5:
                    return Block.Wood;
                case 6:
                    return Block.Plant;
                case 7:
                    return Block.Admincrete;
                case 8:
                    return Block.Water;
                case 9:
                    return Block.StillWater;
                case 10:
                    return Block.Lava;
                case 11:
                    return Block.StillLava;
                case 12:
                    return Block.Sand;
                case 13:
                    return Block.Gravel;
                case 14:
                    return Block.GoldOre;
                case 15:
                    return Block.IronOre;
                case 16:
                    return Block.Coal;
                case 17:
                    return Block.Log;
                case 18:
                    return Block.Leaves;
                case 19:
                    return Block.Sponge;
                case 20:
                    return Block.Glass;
                case 21:
                    return Block.Red;
                case 22:
                    return Block.Orange;
                case 23:
                    return Block.Yellow;
                case 24:
                    return Block.Lime;
                case 25:
                    return Block.Green;
                case 26:
                    return Block.Teal;
                case 27:
                    return Block.Aqua;
                case 28:
                    return Block.Cyan;
                case 29:
                    return Block.Blue;
                case 30:
                    return Block.Indigo;
                case 31:
                    return Block.Violet;
                case 32:
                    return Block.Magenta;
                case 33:
                    return Block.Pink;
                case 34:
                    return Block.Black;
                case 35:
                    return Block.Gray;
                case 36:
                    return Block.White;
                case 37:
                    return Block.YellowFlower;
                case 38:
                    return Block.RedFlower;
                case 39:
                    return Block.BrownMushroom;
                case 40:
                    return Block.RedMushroom;
                case 41:
                    return Block.Gold;
                case 42:
                    return Block.Iron;
                case 43:
                    return Block.DoubleStair;
                case 44:
                    return Block.Stair;
                case 45:
                    return Block.Brick;
                case 46:
                    return Block.TNT;
                case 47:
                    return Block.Books;
                case 48:
                    return Block.MossyRocks;
                case 49:
                    return Block.Obsidian;
                case 50:
                    return Block.CobbleSlab;
                case 51:
                    return Block.Rope;
                case 52:
                    return Block.Sandstone;
                case 53:
                    return Block.Snow;
                case 54:
                    return Block.Fire;
                case 55:
                    return Block.LightPink;
                case 56:
                    return Block.DarkGreen;
                case 57:
                    return Block.Brown;
                case 58:
                    return Block.DarkBlue;
                case 59:
                    return Block.Turquoise;
                case 60:
                    return Block.Ice;
                case 61:
                    return Block.Tile;
                case 62:
                    return Block.Magma;
                case 63:
                    return Block.Pillar;
                case 64:
                    return Block.Crate;
                case 65:
                    return Block.StoneBrick;
                default:
                    return Block.Undefined;

            }
        }
    }
}