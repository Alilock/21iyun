using System;
using System.Collections.Generic;
using System.Text;

namespace _21iyun
{
    internal class Book
    {
        public readonly int No;
        private int _totolcount = 0;
        public Book()
        {
            _totolcount++;
            No = _totolcount;
        }
        public string Name;
        public string AuthorName;
        public int PageCount;
    }
}
