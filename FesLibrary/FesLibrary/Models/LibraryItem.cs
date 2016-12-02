using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FesLibrary.Models
{
    public class LibraryItem
    {
        private int _index;
        private string _title;

        public string Title
        {
            get { return _title; }
        }

        public int Index
        {
            get { return _index; }
        }


        public LibraryItem(int index, string title)
        {
            _index = index;
            _title = title;
        }

    }
}