namespace DesignPatterns.Behavioral.ChainsOfResponsability.Request
{
    public class InvoiceNoteRequest
    {
        public string Name { get; set; }

        public int Value { get; set; }

        public InvoiceNoteRequest(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
