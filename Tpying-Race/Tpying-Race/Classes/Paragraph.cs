namespace Tpying_Race
{
    class Paragraph
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public Paragraph(string title, string text)
        {
            this.Title = title;
            this.Text = text;
        }
    }
}
