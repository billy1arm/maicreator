using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatureAI
{
    public class Script
    {
        public long ScriptId { get; set; }
        public long CreatureId { get; set; }
        public short EventType { get; set; }
        public int InversePhase { get; set; }
        public short Chance { get; set; }
        public int Flags { get; set; }
        public int[] EventParameters { get; set; }
        public short ActionType { get; set; }
        public int[] ActionParameters { get; set; }
        public string Comment { get; set; }

        public Script()
        {
            EventParameters = new int[3];
            ActionParameters = new int[3];
        }
    }
}
