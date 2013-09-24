using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication2
{
    class Person
    {
        public string Name { get; set; }
    }

    public class test
    {
        static void Main(string[] args)
        {

            var names = new[] { "Bessie", "Vashti", "Frederica", "Nisha", "Kendall", "Magdalena", "Brendon", "Eve", "Manda", "Elvera", "Miquel", "Tyra", "Lucie", "Marvella", "Tracee", "Ramiro", "Irene", "Davina", "Jeromy", "Siu" };
            //Create a list of Persons, each with one of the names.           


            var personlist = from c in names
                             select new Person { Name = c };

            var increasingOrder = from itm in personlist
                                  orderby itm.Name ascending
                                  select itm;

            Console.WriteLine("Increasing order");
            foreach (var itm in increasingOrder)
            {
                Console.WriteLine(itm.Name);
            }
            Console.WriteLine();
            Console.Write('\n');


            //Create the same list then get a subset with only people whose names start with “M”
            var list = from b in names
                       where b.StartsWith("M")
                       select b;
            foreach (string el in list)
            {
                Console.WriteLine(el);
            }
            Console.Write('\n');

            //Create the same list then get a list everyone’s names in uppercase
            foreach (string el in names)
            {
                Console.WriteLine(el.ToUpper());
            }

            Console.Write('\n');
            //Console.Read();

            //Create the same list then get a list everyone’s names in uppercase

            var result = names.Select(element => element.ToUpper());

            foreach (string value in result)
            {
                Console.WriteLine(value);
            }

            var lengths = from k in names
                          select k.Length;
            Console.WriteLine(string.Join(",", lengths.ToArray()));


          
            //shorting by name wise....

            string[] a = new string[]
	                {
	                   "Bessie", "Vashti", "Frederica", "Nisha", "Kendall", "Magdalena", "Brendon", "Eve", "Manda", "Elvera", "Miquel", "Tyra", "Lucie", "Marvella", "Tracee", "Ramiro", "Irene", "Davina", "Jeromy", "Siu"
	                };
            var sort = from s in a
                       orderby s
                       select s;

            foreach (string c in sort)
            {
                Console.WriteLine(c);
            }
            Console.Read();
        }


    }


}
