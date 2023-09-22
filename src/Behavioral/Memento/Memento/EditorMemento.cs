namespace DesignPatterns.Behavioral.Memento.Memento
{
    // Memento: EditorMemento, the object that stores the state of the TextEditor
    class EditorMemento
    {
        public string Content { get; }

        public EditorMemento(string content)
        {
            Content = content;
        }
    }
}
