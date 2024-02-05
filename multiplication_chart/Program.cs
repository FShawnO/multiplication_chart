using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_chart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i<10; i++){
            int i = 1;
            while (i < 10)
            {
                //string strTMP = "";
                int j = 1;
                //int temp;
                //for (int j = 1; j<10; j++){
                while (j < 10)
                {
                    //   int temp = i*j;
                    string temp = (i * j).ToString();
                    //Console.WriteLine(temp);
                    string temp2 = temp.PadLeft(2, '0');
                    //temp = i*j;
                    //char temp2 = temp.PadLeft(2,'0');
                    Console.Write($"({i}X{j}={temp2})"); //,i,j,temp.PadLeft(2,'0'));
                                                         //Console.Write ("({0}X{1}={2})",i,j,temp.PadLeft(2,'0'));
                                                         //if (j==9) 
                    /*string[] digits = { i.ToString(), "X", "brown", "fox", "jumps", "over", "the", "lazy", "dog." };*/

                    // string+= i.ToString() 
                    j++;
                }
                Console.WriteLine("");
                i++;
            }
        }
    }
}
