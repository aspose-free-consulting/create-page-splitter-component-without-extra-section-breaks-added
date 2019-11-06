namespace extract_part_of_the_document
{
    using System.IO;
    using System.Linq;

    class AppSettings
    {
        public bool IsValid => File != null && File.Exists;

        public FileInfo File { get; private set; }
        public PagesRange Range { get; private set; }

        private AppSettings()
        {
            Range = new PagesRange();
        }

        public static AppSettings BuildFrom(params string[] args)
        {
            var result = new AppSettings();

            if (args.Any())
            {
                result.File = new FileInfo(args.First());

                if (int.TryParse(args.Skip(1).FirstOrDefault(), out int from)
                    && int.TryParse(args.Skip(2).FirstOrDefault(), out int to))
                {
                    result.Range.Setup(from, to);
                }
            }

            return result;
        }
    }
}
