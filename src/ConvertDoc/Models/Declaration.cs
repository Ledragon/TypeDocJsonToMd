using System;

namespace ConvertDoc
{
    public class Declaration
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Int32 Kind { get; set; }
        public String KindString { get; set; }
        public Flags Flags { get; set; }
        public Signature[] Signatures { get; set; }
        public Source[] Sources { get; set; }
    }
}