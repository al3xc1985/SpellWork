﻿namespace SpellWork.DBC.Structures
{
    public sealed class SpellTargetRestrictionsEntry
    {
        public uint SpellID;
        public float ConeAngle;
        public float Width;
        public uint Targets;
        public ushort TargetCreatureType;
        public byte DifficultyID;
        public byte MaxAffectedTargets;
        public uint MaxTargetLevel;
    }
}
