using System;

namespace ConvertDoc
{
    public class Type3
    {
        public String Type { get; set; }
        public String Name { get; set; }
        public Int32 Id { get; set; }
        public Type3[] Types { get; set; }
        public Element[] TypeArguments { get; set; }
        public Boolean IsArray { get; set; }
        public Element[] Elements { get; set; }
    }
}