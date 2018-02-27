using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    class RollDice
    {
        Random rand = new Random();

        int number1 = 0;
        int number2 = 0;
        int number3 = 0;

        public int getNum1()
        {
            number1 = rand.Next(6) + 1;
            return number1;
        }

        public int getNum2()
        {
            number2 = rand.Next(6) + 1;
            return number2;
        }


    }
}
