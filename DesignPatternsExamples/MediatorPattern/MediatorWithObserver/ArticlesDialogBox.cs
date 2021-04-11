using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.MediatorWithObserver
{
    class ArticlesDialogBox
    {
        private ListBox _articlesListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public ArticlesDialogBox()
        {
            _articlesListBox = new ListBox();
            _titleTextBox = new TextBox();
            _saveButton = new Button();
            
            _articlesListBox.AddEventHandler(ArticleSelected);
            _titleTextBox.AddEventHandler(TitleChanged);
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
