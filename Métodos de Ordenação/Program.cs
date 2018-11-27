using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Criarvetores();
            ;
        }

       
        public static void Criarvetores()
        {
            int[] vetor1;
            Random rm = new Random();
            vetor1 = new int[10000];
            

            for (int i=0; i< 10000; i++)
            {
                vetor1[i] = i + 1;
            }

           

            int[] vetor2;
            vetor2 = new int[10000];
            

            for (int i = 10000; i >= 10000; i--)
            {
                vetor2[i] = i -1;
            }



            int[] vetor3;
            vetor3 = new int[10000];
           

            for (int i = 0; i < 10000; i++)
            {
                vetor3[i] = rm.Next(1, 10000);
            }

            
        }

    }
}
