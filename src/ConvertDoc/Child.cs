using System;

namespace ConvertDoc
{
    public class Child
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Int32 Kind { get; set; }
        public String KindString { get; set; }
        public Flags Flags { get; set; }
        public Comment Comment { get; set; }
        public Signature[] Signatures { get; set; }
        public Source[] Sources { get; set; }
        public TypeClass Type { get; set; }
        public String DefaultValue { get; set; }
        public Typeparameter[] TypeParameter { get; set; }
        public Child[] Children { get; set; }
        public Group[] Groups { get; set; }
        public String OriginalName { get; set; }
    }
}