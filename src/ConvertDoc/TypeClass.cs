using System;

namespace ConvertDoc
{
    public class TypeClass
    {
        public String Type { get; set; }
        public String Name { get; set; }
        public Typeargument[] TypeArguments { get; set; }
        public Declaration Declaration { get; set; }
        public Int32 Id { get; set; }
        public Element1[] Elements { get; set; }
        public Boolean IsArray { get; set; }
    }
}