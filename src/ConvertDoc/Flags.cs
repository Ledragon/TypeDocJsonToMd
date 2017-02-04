using System;

namespace ConvertDoc
{
    public class Flags
    {
        public Boolean IsExported { get; set; }

        public Boolean IsPrivate { get; set; }
        public Boolean IsConstructorProperty { get; set; }
        public Boolean IsOptional { get; set; }
    }
}