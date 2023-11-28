using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Library librarycs = new Library();
            do
            {

                Console.WriteLine("Choose the operation 1.Add Books 2.View All Books 3.SearchById 4.SearchByName 5.Exit the Program");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Book id");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Book Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Author name");
                            string author = Console.ReadLine();
                            Console.WriteLine("Enter Genre");
                            string genre = Console.ReadLine();
                            Console.WriteLine("Is Book Available to Borrow?");
                            bool avail = bool.Parse(Console.ReadLine());
                            librarycs.AddBook(id, name, author, genre, avail);
                            break;
                        }
                    case 2:
                        {
                            librarycs.PrintAllBooks();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Id to be searched");
                            int id = int.Parse(Console.ReadLine());
                            librarycs.SearchById(id);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter name to be searched");
                            string name = Console.ReadLine();
                            librarycs.SearchByTitle(name);
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Operation Choice");
                            break;
                        }
                }
                Console.WriteLine("Do You wanna Continue? press y/n");
                choice = Console.ReadLine();
            } while (choice == "y");
        }
    }
}
