using System;

namespace ConvertDoc
{
    public class Signature1
    {
        public Int32 id { get; set; }
        public String name { get; set; }
        public Int32 kind { get; set; }
        public String kindString { get; set; }
        public Flags flags { get; set; }
        public Comment2 comment { get; set; }
        public Parameter1[] parameters { get; set; }
        public Type3 type { get; set; }
    }
}