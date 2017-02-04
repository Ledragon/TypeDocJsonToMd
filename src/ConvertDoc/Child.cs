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
        public String OriginalName { get; set; }
        public Source[] Sources { get; set; }
        public Child1[] Children { get; set; }
        public Group[] Groups { get; set; }
    }
}