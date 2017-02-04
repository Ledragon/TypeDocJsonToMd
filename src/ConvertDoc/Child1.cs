using System;

namespace ConvertDoc
{
    public class Child1
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Int32 Kind { get; set; }
        public String KindString { get; set; }
        public Flags Flags { get; set; }
        public Comment Comment { get; set; }
        public Typeparameter[] TypeParameter { get; set; }
        public Child2[] Children { get; set; }
        public Group[] Groups { get; set; }
        public Source[] Sources { get; set; }
        public Signature[] Signatures { get; set; }
    }
}