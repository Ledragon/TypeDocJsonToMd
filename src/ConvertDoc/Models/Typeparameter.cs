using System;

namespace ConvertDoc
{
    public class Typeparameter
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Int32 Kind { get; set; }
        public String KindString { get; set; }
        public Flags Flags { get; set; }
    }
}