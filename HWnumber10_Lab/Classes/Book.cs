using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWnumber10_Lab.Classes
{
    internal class Book
    {
        #region Fields
        public string Title {  get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        #endregion

        #region Constructors
        public Book(string name, string author, string publisher)
        {
            Title = name;
            Author = author;
            Publisher = publisher; 
        }
        #endregion

    }
}
