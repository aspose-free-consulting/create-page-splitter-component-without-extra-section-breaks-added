namespace extract_part_of_the_document
{
    using System;
    using System.IO;

    using Aspose.Words;
    using Aspose.Words.Replacing;
    using PageSplitter;

    class Program
    {
        static void Main(string[] args)
        {
            SetupAspose();

            var appSettings = GetAppSettings(args);

            if (appSettings.Range.IsSet)
            {
                var document = new Document(appSettings.File.OpenRead());

                //Replace page break with section break;
                document.Range.Replace("&m", "&b", new FindReplaceOptions());

                var splitter = new DocumentPageSplitter(document);

                document = splitter.GetDocumentOfPageRange(appSettings.Range.From ?? 1, appSettings.Range.To ?? document.PageCount);
                //Remove the extra empty sections
                foreach (Section section in document.Sections)
                {
                    if (section.Body.Paragraphs.Count == 0)
                        section.Remove();
                }
                document.UpdatePageLayout();

                document.Save(Path.Combine(appSettings.File.DirectoryName, "output-doc.docx"), SaveFormat.Docx);
            }
        }

        private static void SetupAspose()
        {
            var license = new Aspose.Words.License();
            license.SetLicense("Aspose.Words.lic");
        }

        private static AppSettings GetAppSettings(string[] args)
        {
            var appSettings = AppSettings.BuildFrom(args);

            if (!appSettings.IsValid)
            {
                appSettings = AppSettings.BuildFrom(GetDocumentPath(), GetPageValue("From"), GetPageValue("To"));
            }

            return appSettings;
        }

        private static string GetDocumentPath()
        {
            string path = null;

            while (!File.Exists(path))
            {
                Console.Clear();

                if (path != null)
                    Console.WriteLine("Invalid path - '{0}'", path);

                Console.WriteLine("Please provide the document full path:");

                path = Console.ReadLine();
            }

            return path;
        }

        private static string GetPageValue(string rangeSideValue)
        {
            string input = null;

            while (!int.TryParse(input, out int result) || result <= 0)
            {
                if(input != null)
                    Console.WriteLine("Invalid '{0}' page value - '{1}'", rangeSideValue, input);

                Console.WriteLine("Please input the '{0}' page value:", rangeSideValue);
                input = Console.ReadLine();
            }

            return input;
        }
    }
}
