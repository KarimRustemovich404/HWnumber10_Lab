using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWnumber10_Lab.Classes
{
    internal class Library
    {
        private List<Book> books;
        #region Constructors
        public Library()
        {
            books = new List<Book>();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Метод для добавления книг
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        /// <summary>
        /// Метод для удаления книг
        /// </summary>
        /// <param name="book"></param>
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        /// <summary>
        /// Метод для сравнения 
        /// </summary>
        /// <param name="o"></param>
        public void Compare(object? o)
        {

        }

        /// <summary>
        /// Метод для отображения информации о книгах
        /// </summary>
        public void DisplayLibrary()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}\nAuthor: {book.Author}\nPublisher: {book.Publisher}\n");
            }
        }
        #endregion

    }
}
