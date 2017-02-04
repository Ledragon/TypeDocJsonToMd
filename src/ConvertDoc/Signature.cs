using System;

namespace ConvertDoc
{
    public class Signature
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Int32 Kind { get; set; }
        public String KindString { get; set; }
        public Flags Flags { get; set; }
        public Comment2 comment { get; set; }
        public Parameter[] Parameters { get; set; }
        public TypeClass Type { get; set; }
    }
}