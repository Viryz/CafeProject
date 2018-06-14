using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProject
{
    class Cafe
    {
        int needMoney;
        int currentMoney;
        int countTry;
        Client client;

        Cafe(int nm, int cm) { needMoney = nm; currentMoney = cm; countTry = 3; } 

        int Read()
        {
            int n;
            Console.WriteLine("Choice food: (tea - 0, ice cream - 1, coffe - 2)");
            n = int.Parse(Console.ReadLine());

            return n;
        }

        public void Start()
        {

        }
    }
}
