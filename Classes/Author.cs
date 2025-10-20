using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Osennikov.Classes
{
    public class Author
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public Author(int Id, string FIO)
        {
            this.Id = Id;
            this.FIO = FIO;
        }

        public static List<Author> AllAuthors()
        {
            List<Author> allAuthors = new List<Author>();
            allAuthors.Add(new Author(1,"Виктор Плевин"));
            allAuthors.Add(new Author(1, "Александра Маринина"));
            allAuthors.Add(new Author(1, "Ольга Герр"));
            return allAuthors;
        }
    }
}
