namespace BDO_Ditto.BDO
{
    public enum Classes
    {
        Blader,
        Plum,
        Kunoichi,
        Ninja,
        Ranger,
        Sorcerer,
        Tamer,
        Valkyrie,
        Warrior,
        Wizard,
        Witch,
        Berserker,
        Unkown
    }

    public static class StaticData
    {
        public const uint SupportedVersion = 18;

        #region Class id hex values
        public const ulong SorcererClassId  =   1251758517271041305;
        public const ulong ValkyrieClassId  =   10777537339687380824;
        public const ulong RangerClassId    =   17145927421228022900;
        public const ulong WitchClassId     =   10764718972524210919;
        public const ulong TamerClassId     =   15499404728391803384;
        public const ulong WizardClassId    =   17759858246325470518;
        public const ulong WarriorClassId   =   4956354676860611428;
        public const ulong BerserkerClassId =   9287506164331278002;
        #endregion

        public static BDO_DataBlock GameVersion = new BDO_DataBlock(4, 12);

        #region Offsets in the file for certain apperance data
        public static BDO_DataBlock ClassId             =   new BDO_DataBlock(68, 8);
        public static BDO_DataBlock HairAndFace         =   new BDO_DataBlock(76, 8);
        public static BDO_DataBlock HairColors          =   new BDO_DataBlock(92, 8);
        public static BDO_DataBlock Skin                =   new BDO_DataBlock(100, 8);
        public static BDO_DataBlock EyeMakeUp           =   new BDO_DataBlock(108, 24);
        public static BDO_DataBlock EyeLine             =   new BDO_DataBlock(140, 8);
        public static BDO_DataBlock Eyes                =   new BDO_DataBlock(148, 40);
        public static BDO_DataBlock FaceShape           =   new BDO_DataBlock(220, 392);
        public static BDO_DataBlock BodyShape           =   new BDO_DataBlock(604, 96);
        public static BDO_DataBlock StandByExpression   =   new BDO_DataBlock(884, 8);
        public static BDO_DataBlock Voice               =   new BDO_DataBlock(892, 8);
        #endregion
    }
}
