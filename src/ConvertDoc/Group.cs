using System;

namespace ConvertDoc
{
    public class Group
    {
        public String Title { get; set; }
        public Int32 Kind { get; set; }
        public Int32[] Children { get; set; }
    }
}