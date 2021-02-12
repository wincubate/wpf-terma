namespace Wincubate.DataBindingCollectionsExamples.Data
{
    public class Slide
    {
        private static int Next; // <-- To make sure that all slide numbers are unique
        
        public string Number { get; set; }

        public Slide()
        {
            Number =  $"Slide {++Next}";
        }
    }
}
