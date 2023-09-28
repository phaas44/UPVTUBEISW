using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(String[] args) {
            List<string> nationalities;
            void initList()
            {
                nationalities = new List<string>()
                {
                     "Australian",
                     "Mongolian",
                     "Russian",
                     "Austrian",
                     "Brazilian",
                     "Spanish"
                 };
            }
            initList();
            nationalities.Sort();
            foreach (string nationality in nationalities)
            {
                Console.WriteLine(nationality);
            }
        }
    }
}


