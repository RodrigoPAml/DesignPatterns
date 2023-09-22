using DesignPatterns.Behavioral.Memento.Memento;

namespace DesignPatterns.Behavioral.Memento.Originator
{
    // Originator: TextEditor, the object whose state needs to be saved and restored
    class TextEditor
    {
        private string _content;

        public void Write(string content)
        {
            _content = content;
        }

        public void Erase(int number)
        {
            _content = _content.Substring(_content.Length - number);
        }

        public void RestoreMemento(EditorMemento memento)
        {
            _content = memento.Content;
        }

        public EditorMemento GetMemento() => new EditorMemento(_content);

        public string GetContent() => _content;
    }
}
