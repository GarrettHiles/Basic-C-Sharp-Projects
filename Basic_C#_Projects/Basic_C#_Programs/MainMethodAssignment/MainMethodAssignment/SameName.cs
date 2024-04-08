using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class SameName
    {
        public int Operation(int num)
        {
            int answer = num + 29; // takes in number and adds 29
            return answer;
        }

        public int Operation(decimal num) //takes in a decimal and divides by 4
        {
            int answer = (int)(num / 4); //gives back intger not another deciaml
            return answer;
        }


        public int Operation(string str) //takes a string in
        {
            if (int.TryParse(str, out int num))  //changes string into number
            {
                int answer = num * 2;
                return answer;
            }
            else //if a whole number was not entered returns 0
            {
                return 0;
            }
        }
    }
}
