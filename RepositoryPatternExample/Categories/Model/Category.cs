using System.Collections.Generic;

namespace RepositoryPatternExample.Categories.Model
{
    public class Category
    {
        private string _name;
        private List<string> _words;
        public string Name { get => _name; private set => _name = value; }
        public List<string> Words { get => _words; private set => _words = value; }
        public Category(string name)
        {
            Name = name;
            Words = new List<string>();
        }

        public void AddWordsToList(string word)
        {
            Words.Add(word.ToUpper());
        }
    }
}
