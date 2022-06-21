using System;
using System.Collections.Generic;
using System.Text;

namespace _21iyun
{
    internal class Library
    {
        List<Book> Books;
        public Library()
        {
            Books = new List<Book>();
        }
       
        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> newBooks = new List<Book>();
            foreach (var item in Books)
            {
                if (item.Name.Contains(value))
                {
                    newBooks.Add(item);

                }
            }

           
            return newBooks;
          
        }

        public void RemoveAllBooksByName(string value)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Name.Contains(value))
                {
                    Books.RemoveAt(i);
                }
            }

            // IEnumeration
            //foreach (var item in Books)
            //{

            //        Books.Remove(item);

            //}
        }
        public List<Book> Search(string value)
        {
            List<Book> newList = new List<Book>();
            foreach (var item in Books)
            {
                string pageCount = item.PageCount.ToString();
                if (item.Name.Contains(value)|| item.AuthorName.Contains(value)|| pageCount.Contains(value) )
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        // for check

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public List<Book> bookList()
        {
            return Books;
        }
    }
}
