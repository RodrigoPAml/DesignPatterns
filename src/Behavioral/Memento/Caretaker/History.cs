using DesignPatterns.Behavioral.Memento.Memento;
using DesignPatterns.Behavioral.Memento.Originator;

namespace DesignPatterns.Behavioral.Memento.Caretaker
{
    // Caretaker: History, the object that keeps track of multiple EditorMementos
    class History
    {
        private Stack<EditorMemento> _mementos { get; } = new Stack<EditorMemento>();

        private TextEditor _textEditor;

        public History(TextEditor textEditor)
        {
            _textEditor = textEditor;
        }

        public void Backup()
        {
            _mementos.Push(_textEditor.GetMemento());
        }

        public void Undo()
        {
            var val = _mementos.Pop();

            if (val != null)
                _textEditor.RestoreMemento(val);
        }
    }
}
