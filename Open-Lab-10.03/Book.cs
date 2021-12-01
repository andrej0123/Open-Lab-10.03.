using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._03
{
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;
        
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public int ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                if (value > 2021 || value < 1450)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }
        }
    }
 }

