using System;

namespace ConvertDoc
{
    public class Parameter
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Int32 Kind { get; set; }
        public String KindString { get; set; }
        public Flags Flags { get; set; }
        public Comment Comment { get; set; }
        public TypeClass Type { get; set; }
    }
}