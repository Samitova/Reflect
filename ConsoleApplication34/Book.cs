using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Book
    {
        public string Author { get; set; }
        public int Year { get; set; }

        [NoCsv]
        public string Text { get; set; }

        public override string ToString()
        {
            return string.Format("{ 0}, { 1}, { 2}", Author, Year, Text);
        }
    }
}
