namespace ConvertDoc
{
    public enum ObjectKind
    {
        Root = 0,
        ExternalModule = 1,
        Function = 64,
        Class = 128,
        Interface = 256,
        Constructor = 512,
        Property = 1024,
        Method = 2048,
        CallSignature = 4096,
        ConstructorSignature = 16384,
        Parameter = 32768,
        TypeLiteral = 65536,
        TypeParameter = 131072
    }
}