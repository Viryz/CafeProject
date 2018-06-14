using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProject
{
    enum Mood
    {
        Happy = 0,
        Neutral = 1,
        Cry = 2,
        Angry = 3
    }

    class Client
    {
        public Mood Mood { get; private set; }

        Random r = new Random();

        public Client()
        {
            
            this.Mood = (Mood)r.Next(1, 2);
        }

        int GetRequest()
        {
            return r.Next(0, 2);
        }

        void Check() { }

        int Out()
        {
            switch (Mood)
            {
                case Mood.Happy:
                    return 30;
                case Mood.Neutral:
                    return 20;
                case Mood.Cry:
                    return 10;
                case Mood.Angry:
                    return -10;
                default:
                    return 0;
            }
        }

    }
}
