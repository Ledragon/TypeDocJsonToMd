using System;

namespace ConvertDoc
{
    public class Signature3
    {
        public Int32 id { get; set; }
        public String name { get; set; }
        public Int32 kind { get; set; }
        public String kindString { get; set; }
        public Flags flags { get; set; }
        public Parameter3[] parameters { get; set; }
        public TypeClass type { get; set; }
    }
}