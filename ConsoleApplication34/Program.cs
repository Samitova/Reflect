using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {           
            Book testBook = new Book()
            {
                Author="Alex",
                Year = 1998,
                Text = "dhjkhf"
            };

            string serializeedBook = CsvSelialize.Serialise<Book>(testBook);

            Console.WriteLine(serializeedBook);

            Book newBook = CsvSelialize.Deserialize<Book>(serializeedBook);

            Console.WriteLine(newBook.ToString());
         
        }

    }
}
