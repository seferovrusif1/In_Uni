using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practiceTask.Models
{
    internal class Library
    {
        public Book[] Books = new Book[0];

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);  
            Books[Books.Length - 1] = book;            

            Console.WriteLine("Book Aded\n");
        }


        public void GetAllBooksId()
        {
            foreach (var item in Books)
            {
                Console.WriteLine(item.Id);
            }
        }


        public void GetBookById(int id)
        {
            foreach (var item in Books)
            {
                if (item.Id==id)
                {
                    Console.WriteLine(item);
                }
            }

        }
        //public  void Sell(int id)
        //{
        //    foreach (var item in Books)
        //    {
        //        if (item.Id == id)
        //        {
        //            item.Count--;
        //            item.TotalInCome += item.Price;
        //            Console.WriteLine(item.TotalInCome);
        //        }
        //    }
            
        //}

        //public override void ShowInfo()
        //{
        //    Console.WriteLine(this);
        //}
        //public override string ToString()
        //{
        //    return $"\n Book Id: {Id}\nBook Name: {Name}\nAuthor Name: {AuthorName}\nPage Count: {PageCount}\nBook Price: {Price}\nBook Count: {Count}\nTotalInCome: {TotalInCome}";
        //}

    }
}
