using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.UserInterface
{
    class ArticlesDialogBox : DialogBox
    {
        private ListBox _articlesListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public ArticlesDialogBox()
        {
            _articlesListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
        }

        public override void Changed(UIControl control)
        {
            if (control == _articlesListBox)
            {
                ArticleSelected();
            }
            else if (control == _titleTextBox)
            {
                TitleChanged();
            }
        }

        private void ArticleSelected()
        {
            _titleTextBox.Content = _articlesListBox.Selection;
            _saveButton.IsEnabled = true;
        }

        private void TitleChanged()
        {
            var content = _titleTextBox.Content;
            var isEmpty = string.IsNullOrEmpty(content);
            _saveButton.IsEnabled = !isEmpty;
        }

        public void Simulate()
        {
            _articlesListBox.Selection = "Article 1";
            Console.WriteLine($"TextBox: {_titleTextBox.Content}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled}");
            _titleTextBox.Content = "";
            Console.WriteLine($"TextBox: {_titleTextBox.Content}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled}");
        }
    }
}
