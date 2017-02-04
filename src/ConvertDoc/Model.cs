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
            public Group2[] Groups { get; set; }
        }

    public class Child1
        {
            public Int32 Id { get; set; }
            public String Name { get; set; }
            public Int32 Kind { get; set; }
            public String KindString { get; set; }
            public Flags2 Flags { get; set; }
            public Comment Comment { get; set; }
            public Typeparameter[] TypeParameter { get; set; }
            public Child2[] Children { get; set; }
            public Group[] Groups { get; set; }
            public Source4[] Sources { get; set; }
            public Signature3[] Signatures { get; set; }
        }

        public class Flags2
        {
            public Boolean isExported { get; set; }
        }

        public class Comment
        {
            public String shortText { get; set; }
        }

        public class Typeparameter
        {
            public Int32 id { get; set; }
            public String name { get; set; }
            public Int32 kind { get; set; }
            public String kindString { get; set; }
            public Flags3 flags { get; set; }
        }

        public class Flags3
        {
        }

        public class Child2
        {
            public Int32 id { get; set; }
            public String name { get; set; }
            public Int32 kind { get; set; }
            public String kindString { get; set; }
            public Flags4 flags { get; set; }
            public Comment1 comment { get; set; }
            public Signature1[] signatures { get; set; }
            public Source3[] sources { get; set; }
            public Type type { get; set; }
            public String defaultValue { get; set; }
        }

        public class Flags4
        {
            public Boolean isExported { get; set; }
            public Boolean isPrivate { get; set; }
            public Boolean isConstructorProperty { get; set; }
        }

        public class Comment1
        {
            public Tag[] tags { get; set; }
            public String shortText { get; set; }
        }

        public class Tag
        {
            public String tag { get; set; }
            public String text { get; set; }
        }

        public class Type
        {
            public String type { get; set; }
            public String name { get; set; }
            public Typeargument[] typeArguments { get; set; }
            public Declaration declaration { get; set; }
            public Int32 id { get; set; }
        }

        public class Declaration
        {
            public Int32 id { get; set; }
            public String name { get; set; }
            public Int32 kind { get; set; }
            public String kindString { get; set; }
            public Flags5 flags { get; set; }
            public Signature[] signatures { get; set; }
            public Source1[] sources { get; set; }
        }

        public class Flags5
        {
        }

        public class Signature
        {
            public Int32 id { get; set; }
            public String name { get; set; }
            public Int32 kind { get; set; }
            public String kindString { get; set; }
            public Flags6 flags { get; set; }
            public Parameter[] parameters { get; set; }
            public Type1 type { get; set; }
        }

        public class Flags6
        {
        }

        public class Type1
        {
            public String type { get; set; }
            public String name { get; set; }
        }

        public class Parameter
        {
            public Int32 id { get; set; }
            public String name { get; set; }
            public Int32 kind { get; set; }
            public String kindString { get; set; }
            public Flags7 flags { get; set; }
            public Type2 type { get; set; }
        }

        public class Flags7
        {
        }

        public class Type2
        {
            public String type { get; set; }
            public String name { get; set; }
        }

        public class Source1
        {
            public String FileName { get; set; }
            public Int32 Line { get; set; }
            public Int32 Character { get; set; }
        }

        public class Typeargument
        {
            public String type { get; set; }
            public String name { get; set; }
        }

        public class Signature1
        {
            public Int32 id { get; set; }
            public String name { get; set; }
            public Int32 kind { get; set; }
            public String kindString { get; set; }
            public Flags8 flags { get; set; }
            public Comment2 comment { get; set; }
            public Parameter1[] parameters { get; set; }
            public Type3 type { get; set; }
        }

        public class Flags8
        {
        }

        public class Comment2
        {
            public Tag1[] tags { get; set; }
            public String shortText { get; set; }
        }

        public class Tag1
        {
            public String tag { get; set; }
            public String text { get; set; }
        }

        public class Type3
        {
            public String type { get; set; }
            public String name { get; set; }
            public Int32 id { get; set; }
            public Type4[] types { get; set; }
            public Typeargument2[] typeArguments { get; set; }
            public Boolean isArray { get; set; }
            public Element[] elements { get; set; }
        }

        public class Type4
        {
            public String type { get; set; }
            public String name { get; set; }
            public Int32 id { get; set; }
            public Typeargument1[] typeArguments { get; set; }
            public Boolean isArray { get; set; }
        }

        public class Typeargument1
        {
            public String type { get; set; }
            public String name { get; set; }
        }

        public class Typeargument2
        {
            public String type { get; set; }
            public String name { get; set; }
        }

        public class Element
        {
            public String type { get; set; }
            public String name { get; set; }
        }

        public class Parameter1
        {
            public Int32 id { get; set; }
            public String name { get; set; }
            public Int32 kind { get; set; }
            public String kindString { get; set; }
            public Flags9 flags { get; set; }
            public Comment3 comment { get; set; }
            public Type5 type { get; set; }
        }

        public class Flags9
        {
            public Boolean isOptional { get; set; }
        }

        public class Comment3
        {
            public String shortText { get; set; }
        }

        public class Type5
        {
            public String type { get; set; }
            public String name { get; set; }
            public Typeargument3[] typeArguments { get; set; }
            public Element1[] elements { get; set; }
            public Int32 id { get; set; }
            public Boolean isArray { get; set; }
            public Declaration1 declaration { get; set; }
        }

        public class Declaration1
        {
            public Int32 id { get; set; }
            public String name { get; set; }
            public Int32 kind { get; set; }
            public String kindString { get; set; }
            public Flags flags { get; set; }
            public Signature2[] signatures { get; set; }
            public Source2[] sources { get; set; }
        }
    

        public class Signature2
        {
            public Int32 id { get; set; }
            public String name { get; set; }
            public Int32 kind { get; set; }
            public String kindString { get; set; }
            public Flags flags { get; set; }
            public Parameter2[] parameters { get; set; }
            public Type6 type { get; set; }
        }
    

        public class Type6
        {
            public String type { get; set; }
            public String name { get; set; }
        }

        public class Parameter2
        {
            public Int32 id { get; set; }
            public String name { get; set; }
            public Int32 kind { get; set; }
            public String kindString { get; set; }
            public Flags flags { get; set; }
            public Type7 type { get; set; }
        }
    

        public class Type7
        {
            public String type { get; set; }
            public String name { get; set; }
        }

        public class Source2
        {
            public String fileName { get; set; }
            public Int32 line { get; set; }
            public Int32 character { get; set; }
        }

        public class Typeargument3
        {
            public String type { get; set; }
            public String name { get; set; }
        }

        public class Element1
        {
            public String type { get; set; }
            public String name { get; set; }
        }

        public class Source3
        {
            public String fileName { get; set; }
            public Int32 line { get; set; }
            public Int32 character { get; set; }
        }

        public class Group
        {
            public String title { get; set; }
            public Int32 kind { get; set; }
            public Int32[] children { get; set; }
        }

        public class Source4
        {
            public String fileName { get; set; }
            public Int32 line { get; set; }
            public Int32 character { get; set; }
        }

        public class Signature3
        {
            public Int32 id { get; set; }
            public String name { get; set; }
            public Int32 kind { get; set; }
            public String kindString { get; set; }
            public Flags13 flags { get; set; }
            public Parameter3[] parameters { get; set; }
            public Type8 type { get; set; }
        }

        public class Flags13
        {
        }

        public class Type8
        {
            public String type { get; set; }
            public String name { get; set; }
            public Int32 id { get; set; }
        }

        public class Parameter3
        {
            public Int32 id { get; set; }
            public String name { get; set; }
            public Int32 kind { get; set; }
            public String kindString { get; set; }
            public Flags14 flags { get; set; }
            public Type9 type { get; set; }
        }

        public class Flags14
        {
        }

        public class Type9
        {
            public String type { get; set; }
            public String name { get; set; }
            public Int32 id { get; set; }
        }

        public class Group2
        {
            public String Title { get; set; }
            public Int32 Kind { get; set; }
            public Int32[] Children { get; set; }
        }
}