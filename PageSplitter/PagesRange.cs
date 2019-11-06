namespace extract_part_of_the_document
{
    class PagesRange
    {
        public bool IsSet => From.HasValue || To.HasValue;

        public int? From { get; private set; }
        public int? To { get; private set; }

        public void Setup(int from, int to)
        {
            if(from <= to)
            {
                From = from;
                To = to;
            }
            else
            {
                From = to;
                To = from;
            }
        }
    }
}
