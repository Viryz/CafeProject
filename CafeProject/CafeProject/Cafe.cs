﻿using System;
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
        //Client client;

        Cafe(int nm, int cm) { needMoney = nm; currentMoney = cm; }
        int Read()
        {
            int n;
            Console.WriteLine("Choice food: (tea - 0, ice cream - 1, coffe - 2)");
            n = int.Parse(Console.ReadLine());

            return n;
        }
    }
}