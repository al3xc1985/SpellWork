﻿namespace SpellWork.DBC.Structures
{
    public class SpellCastingRequirementsEntry
    {
        public uint SpellID;
        public ushort MinFactionID;
        public ushort RequiredAreasID;
        public ushort RequiresSpellFocus;
        public byte FacingCasterFlags;
        public byte MinReputation;
        public byte RequiredAuraVision;
    }
}
