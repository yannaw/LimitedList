using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedList {
    class Program {
        static void Main(string[] args) {


            var values = GetSomeValues(); // returnerar enumerator
            
            foreach(var item in values) {
                Console.WriteLine(item);
            }
            return;

            var list = new LimitedList<string>(6);
            Console.WriteLine(list.Add("111"));
            list.Add("222");
            list.Add("333");

            //           Console.WriteLine(list[1]);

            Inventory(list); // Ctr+R Ctr+M

            Console.WriteLine(list.Add("444"));
            Inventory(list);


        }

        private static void Inventory(LimitedList<string> list) {
            Console.WriteLine("Innehåll ({0})", list.Count);
            foreach(var item in list) {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<int> GetSomeValues() {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
        }
    }
}
