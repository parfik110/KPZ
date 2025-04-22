using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        private readonly TextDocument _document;
        private readonly Stack<DocumentMemento> _history = new();

        public TextEditor(TextDocument document)
        {
            _document = document;
        }

        public void TypeText(string newText)
        {
            Save(); // Save state before changing
            _document.Content += newText;
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _document.Content = memento.SavedContent;
            }
        }

        private void Save()
        {
            _history.Push(new DocumentMemento(_document.Content));
        }

        public void ShowDocument() => _document.Print();
    }
}
