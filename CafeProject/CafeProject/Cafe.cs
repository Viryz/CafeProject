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

        public Cafe(int cm, int nm) { needMoney = nm; currentMoney = cm; countTry = 3; client = new Client(); } 

        int Read()
        {
            int n;
            Console.WriteLine("Choice food: (tea - 0, ice cream - 1, coffe - 2)");
            n = int.Parse(Console.ReadLine());
            return n;
        }

        public void Start()
        {
            while (true)
            {
                int n;
                try
                {
                    n = Read();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                if (client.Check(n, ref currentMoney, ref countTry))
                {
                    Console.WriteLine("Current money: {0}", currentMoney);
                    if (currentMoney >= needMoney)
                    {
                        Console.WriteLine("You win!"); break;
                    }
                    if(currentMoney < 0)
                    { Console.WriteLine("You lose!"); break; }

                    client = new Client();
                    Console.WriteLine("New Client");
                }
            }
            Console.ReadLine();
        }
    }
}
