using System;

namespace ConvertDoc
{
    public class Child2
    {
        public Int32 id { get; set; }
        public String name { get; set; }
        public Int32 kind { get; set; }
        public String kindString { get; set; }
        public Flags flags { get; set; }
        public Comment1 comment { get; set; }
        public Signature[] signatures { get; set; }
        public Source[] sources { get; set; }
        public Type type { get; set; }
        public String defaultValue { get; set; }
    }
}