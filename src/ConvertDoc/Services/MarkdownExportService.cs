using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ConvertDoc.Services
{
    public class MarkdownExportService
    {
        private static readonly String[] ExportedKinds = {"External module", "Class"};

        public void Export(Descriptor descriptor, String outputDirectory)
        {
            var stringBuilder = new StringBuilder();
            var name = String.Concat(descriptor.Name.Split(Path.GetInvalidFileNameChars()));
            stringBuilder.AppendLine($"# {name}");
            if (descriptor.Comment != null)
            {
                stringBuilder.Append($"{descriptor.Comment.ShortText}");
            }
            File.WriteAllText(Path.Combine(outputDirectory, $"{name}.md"), stringBuilder.ToString());
            if (descriptor.Children != null)
            {
                foreach (var child in descriptor.Children.Where(c=>ExportedKinds.Contains(c.KindString)))
                {
                    this.Export(child, outputDirectory);
                }
            }
        }

        private void PrintClass()
        {
            
        }
        private void PrintConstructor()
        {

        }

        private void PrintMethod()
        {

        }
    }
}