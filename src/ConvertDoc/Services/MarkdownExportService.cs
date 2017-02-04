using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConvertDoc.Services
{
    public class MarkdownExportService
    {
        //private static readonly String[] ExportedKinds = {"External module", "Class"};
        private readonly IDictionary<Int32, Action<Descriptor, StringBuilder>> _actions;

        public MarkdownExportService()
        {
            this._actions = new Dictionary<Int32, Action<Descriptor, StringBuilder>>
            {
                //{(Int32) ObjectKind.ExternalModule, this.PrintModule },
                {(Int32) ObjectKind.Class, this.PrintClass},
                {(Int32) ObjectKind.Constructor, this.PrintConstructor},
                {(Int32) ObjectKind.Method, this.PrintMethod},
                {(Int32) ObjectKind.Property, this.PrintProperty}
            };
        }

        public void Export(Descriptor descriptor, String outputDirectory)
        {
            this.CleanDestination(outputDirectory);

            var stringBuilder = new StringBuilder();
            var name = String.Concat(descriptor.Name.Split(Path.GetInvalidFileNameChars()));
            var descriptors = descriptor.Children;
            this.PrintChildren(descriptors, stringBuilder);
            File.WriteAllText(Path.Combine(outputDirectory, $"{name}.md"), stringBuilder.ToString());
            this.PrintModules(outputDirectory, descriptors);
        }

        private void CleanDestination(String outputDirectory)
        {
            var enumerateFiles = Directory.EnumerateFiles(outputDirectory).ToList();
            if (enumerateFiles.Any())
            {
                foreach (var enumerateFile in enumerateFiles)
                {
                    File.Delete(enumerateFile);
                }
            }
        }

        private void PrintModules(String outputDirectory, Descriptor[] descriptors)
        {
            if (descriptors != null)
            {
                foreach (var descriptor in descriptors.Where(d => d.Kind == (Int32) ObjectKind.ExternalModule))
                {
                    var sr = new StringBuilder();
                    this.PrintModule(descriptor, sr);
                    var n =
                        descriptor.Name.Split(Path.GetInvalidFileNameChars(), StringSplitOptions.RemoveEmptyEntries)
                            .Last();
                    File.WriteAllText(Path.Combine(outputDirectory, $"{n}.md"), sr.ToString());
                }
            }
        }

        private void PrintChildren(Descriptor[] descriptors, StringBuilder stringBuilder)
        {
            if (descriptors != null)
            {
                foreach (var child in descriptors) //.Where(c => ExportedKinds.Contains(c.KindString)))
                {
                    if (this._actions.ContainsKey(child.Kind))
                    {
                        this._actions[child.Kind](child, stringBuilder);
                        stringBuilder.AppendLine();
                    }
                }
            }
        }

        private void PrintModule(Descriptor descriptor, StringBuilder stringBuilder)
        {
            var name = descriptor.Name;
            stringBuilder.AppendLine($"# Module {name}");
            if (descriptor.Comment != null)
            {
                stringBuilder.AppendLine($"{descriptor.Comment.ShortText}");
            }
            this.PrintChildren(descriptor.Children, stringBuilder);
        }

        private void PrintClass(Descriptor descriptor, StringBuilder stringBuilder)
        {
            //stringBuilder.AppendLine();
            var name = descriptor.Name;
            stringBuilder.AppendLine($"## Class {name}");
            if (descriptor.Comment != null)
            {
                stringBuilder.AppendLine($"{descriptor.Comment.ShortText}");
            }
            this.PrintChildren(descriptor.Children, stringBuilder);
        }

        private void PrintConstructor(Descriptor descriptor, StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("### Constructor");
            this.PrintCallable(descriptor, stringBuilder);
        }

        private void PrintCallable(Descriptor descriptor, StringBuilder stringBuilder)
        {
            //if (descriptor.Comment != null)
            //{
            //    stringBuilder.AppendLine($"{descriptor.Comment.ShortText}");
            //}
            if (descriptor.Signatures != null)
            {
                foreach (var signature in descriptor.Signatures)
                {
                    PrintSignature(signature, stringBuilder);
                }
            }

            this.PrintChildren(descriptor.Children, stringBuilder);
        }

        private static void PrintSignature(Signature signature, StringBuilder stringBuilder)
        {
            if (signature.Comment != null)
            {
                stringBuilder.AppendLine($"{signature.Comment.ShortText}");
            }
            stringBuilder.AppendLine();
            var parameters = signature.Parameters != null
                ? String.Join(", ", signature.Parameters?.Select(p => $"{p.Name}: {PrintTypeArg(p.Type)}"))
                : String.Empty;
            stringBuilder.AppendLine($"Usage: `{signature.Name}({parameters})`");
            if (signature.Parameters != null)
            {
                stringBuilder.AppendLine();
                foreach (var parameter in signature.Parameters)
                {
                    stringBuilder.AppendLine(
                        $"* {parameter.Name} - {parameter.Type?.Name}: {parameter.Comment?.ShortText}");
                }
            }
            var typeClass = signature.Type;
            if (typeClass != null)
            {
                stringBuilder.AppendLine();
                var typeArg = PrintTypeArg(typeClass);
                stringBuilder.AppendLine($"Return type: `{typeArg}`");
            }
            stringBuilder.AppendLine();
        }

        private static String PrintTypeArg(TypeClass typeClass)
        {
            var typeArguments = typeClass.TypeArguments;
            var gen = typeArguments == null ? String.Empty : String.Join(", ", typeArguments.Select(t => t.Name));
            if (!String.IsNullOrEmpty(gen))
            {
                gen = $"<{gen}>";
            }
            return $"{typeClass.Name}{gen}";
        }

        private void PrintMethod(Descriptor descriptor, StringBuilder stringBuilder)
        {
            var name = descriptor.Name; //String.Concat(descriptor.Name.Split(Path.GetInvalidFileNameChars()));
            stringBuilder.AppendLine($"### {name}");
            this.PrintCallable(descriptor, stringBuilder);
        }

        private void PrintProperty(Descriptor descriptor, StringBuilder stringBuilder)
        {
            var name = descriptor.Name; //String.Concat(descriptor.Name.Split(Path.GetInvalidFileNameChars()));
            stringBuilder.AppendLine($"### Property {name}");
            if (descriptor.Comment != null)
            {
                stringBuilder.AppendLine($"{descriptor.Comment.ShortText}");
            }
            this.PrintChildren(descriptor.Children, stringBuilder);
        }
    }
}