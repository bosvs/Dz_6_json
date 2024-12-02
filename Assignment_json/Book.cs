using Microsoft.VisualBasic;
using System;

namespace Assignment_json
{
    internal class Book
    {
        private string _title;
        private List<string> _authors;
        private static int _yearOfPublishing = 0;
        private static int id;
        public readonly int _id;
        
        public string Title { get { return _title; } set { if (!String.IsNullOrWhiteSpace(value)) _title = value; } }
        public List<string> Authors { get { return _authors; } set { if (value.Count > 0) _authors = value; } }
        public int YearOfPublishing { get { return _yearOfPublishing; } set { if (value > 0 && value <= DateTime.Now.Year) _yearOfPublishing = value; } }
        public PublishingHouse PublishingHouse { get; set; }

        public Book()
        {
            _id = Convert.ToInt32(Convert.ToString(++id) + Convert.ToString(DateTime.Now.Year));
        }

        public void GetInfo()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("*                  Інформація про книгу          *");
            Console.WriteLine("**************************************************");
            Console.WriteLine($" Id: {_id}");
            Console.WriteLine($" Назва: {Title}");
            if (Authors != null)
            {
                Console.Write($" Автори: ");
                for (int i = 0; i < Authors.Count; i++)
                {
                    if (i < Authors.Count - 1) Console.Write(Authors[i] + ", ");
                    else Console.WriteLine(Authors[i]);
                }
            }
            else Console.WriteLine($" Автори: невідомо");
            Console.WriteLine($" Рік публікації: {YearOfPublishing}");
            PublishingHouse.GetInfo();
        }
    }
}
