using System;

namespace ConvertDoc
{
    public class Signature
    {
        public Int32 id { get; set; }
        public String name { get; set; }
        public Int32 kind { get; set; }
        public String kindString { get; set; }
        public Flags flags { get; set; }
        public Parameter[] parameters { get; set; }
        public TypeClass type { get; set; }
    }
}