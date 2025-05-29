using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookworm
{
    internal class BookControl
    {
        Stack<string> books = new Stack<string>();

        public void add(string book)
        {
            books.Push(book);
        }

        public string remove(string book)
        {
            return books.Pop();
        }

        public string top()
        {
            return books.First();
        }

        public List<string> all()
        {
            List<string> list = new List<string>();
            foreach (string book in books)
            {
                list.Add(book);
            }
            return list;
        }

    }
}
