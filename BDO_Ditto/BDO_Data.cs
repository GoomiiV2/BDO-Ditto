using System.Collections.Generic;

namespace BDO_Ditto.BDO
{
    public static class StaticData
    {
        public static readonly List<uint> SuportedVersions = new List<uint> { 17, 18 };

        #region Class id hex values
        public static readonly Dictionary<ulong, string> ClassIdLookup = new Dictionary<ulong, string>
        {
            { 1251758517271041305,      "Sorcerer"      },
            { 10777537339687380824,     "Valkyrie"      },
            { 17145927421228022900,     "Ranger"        },
            { 10764718972524210919,     "Witch"         },
            { 15499404728391803384,     "Tamer"         },
            { 17759858246325470518,     "Wizard"        },
            { 4956354676860611428,      "Warrior"       },
            { 9287506164331278002,      "Berserker"     },
            { 7011772489808301336,      "Blader"        }, // Below are new, test em
            { 10613727790916565293,     "Plum"          },
            { 17453010291577773289,     "Kunoichi"      },
            { 10978699858950456037,     "Ninja"         },
            { 7534873226274538481,      "Dark Knight"   },
            { 1286660139353111900,      "Striker"       },
            { 13903222370355958151,     "Mystic"        }, 
            { 13298706715706332932,     "Lahn"          }
        };
        #endregion

        public static BDO_DataBlock GameVersion     = new BDO_DataBlock(4, 12);
        public static BDO_DataBlock ClassId         = new BDO_DataBlock(68, 8);

        #region Offsets in the file for certain apperance data
        public static readonly Dictionary<string, BDO_DataBlock> ApperanceSections = new Dictionary<string, BDO_DataBlock>
        {
            { "HairAndFace",        new BDO_DataBlock(76,   8)      },
            { "HairColors",         new BDO_DataBlock(92,   8)      },
            { "Skin",               new BDO_DataBlock(100,  8)      },
            { "EyeMakeup",          new BDO_DataBlock(108,  24)     },
            { "EyeLine",            new BDO_DataBlock(140,  8)      },
            { "Eyes",               new BDO_DataBlock(148,  40)     },
            { "FaceShape",          new BDO_DataBlock(220,  392)    },
            { "BodyShape",          new BDO_DataBlock(604,  96)     },
            { "StandbyExpression",  new BDO_DataBlock(884,  8)      },
            { "Voice",              new BDO_DataBlock(892,  8)      }
        };
        #endregion
    }
}
