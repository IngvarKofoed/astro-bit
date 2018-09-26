using System;
using System.Collections.Generic;
using System.Linq;

namespace AstroBit.HumanDesign
{
    public static class DefinedGateExtensions
    {
        private static readonly Dictionary<int, int> OppositeGateLookup = new Dictionary<int, int>
        {
            { 1, 2 },
            { 43, 23 },
            { 14, 8 },
            { 34, 20 },
            { 9, 16 },
            { 5, 35 },
            { 26, 45 },
            { 11, 12 },

            { 10, 15 },
            { 58, 52 },
            { 38, 39 },
            { 54, 53 },
            { 61, 62 },
            { 60, 56 },
            { 41, 31 },
            { 19, 33 },

            { 13, 7 },
            { 49, 4 },
            { 30, 29 },
            { 55, 59 },
            { 37, 40 },
            { 63, 64 },
            { 22, 47 },
            { 36, 6 },

            { 25, 46 },
            { 17, 18 },
            { 21, 48 },
            { 51, 57 },
            { 42, 32 },
            { 3, 50 },
            { 27, 28 },
            { 24, 44 }
        };

        public static DefinedGate GetOppositeGate(this DefinedGate definedGate) =>
            OppositeGateLookup.Keys.Contains(definedGate.GateNumber)
            ? new DefinedGate(OppositeGateLookup.Single(x => x.Key == definedGate.GateNumber).Value, definedGate.LineNumber)
            : new DefinedGate(OppositeGateLookup.Single(x => x.Value == definedGate.GateNumber).Key, definedGate.LineNumber);
    }
}
