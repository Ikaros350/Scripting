using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chance
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] winNum = new int[4];
            int[] num = new int[4];

            int cont = 0;

            int betVal=0;
            for (int i = 0; i < winNum.Length; i++)
            {
                winNum[i] = random.Next(0, 10);
                
            }
            Console.WriteLine("Aca se ingresa el numero digito en dijitos de una unidad");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine("Aca se ingresa lo que se quiere apostar");
            betVal = int.Parse(Console.ReadLine());
            for (int i = 0; i < winNum.Length; i++)
            {
                Console.WriteLine("El ganador es: "+winNum[i].ToString());
            }
           

            Console.WriteLine("Dinero ganado: " + GetPrize(num, winNum, betVal).ToString());

            int GetPrize(int[] num_1, int[] winNum_1, int betVal_1)
            {
                int resultado = 0;
                if (num_1[0] == winNum_1[0] && num_1[1] == winNum_1[1] && num_1[2] == winNum_1[2] && num_1[3] == winNum_1[3] && num_1[4] == winNum_1[4])
                {
                    resultado = 4500 * betVal_1;
                }
                else
                {
                    if(num_1[1]==winNum_1[1]&&num_1[2]==winNum_1[2]&& num_1[3] == winNum_1[3]) // si tiene los ultimos 3
                    {
                        resultado = 400 * betVal_1;
                    }
                    else if(num_1[2] == winNum_1[2] && num_1[3] == winNum_1[3]) // si tiene los ultimos 2
                    {
                        resultado = 50 * betVal_1;
                    }
                    else if(num_1[3] == winNum_1[3]) // si tiene la ultima cifra
                    {
                        resultado = 5 * betVal_1;
                    }
                    for (int i = 0; i < winNum_1.Length; i++)
                    {
                        for (int j = 0; j < winNum_1.Length-1; j++)
                        {
                            if (num_1[j] > num_1[j+1])
                            {
                                int guardado = num_1[j];
                                num_1[j] = num_1[j+1];
                                num_1[j+1] = guardado;
                            }
                        }
                        Console.WriteLine("Orden del tuyo: " + num_1[i].ToString());
                    }
                    for (int i = 0; i < winNum_1.Length; i++)
                    {
                        for (int j = 0; j < winNum_1.Length - 1; j++)
                        {
                            if (winNum_1[j] > winNum_1[j + 1])
                            {
                                int guardado = winNum_1[j];
                                winNum_1[j] = winNum_1[j + 1];
                                winNum_1[j + 1] = guardado;
                            }
                        }
                        Console.WriteLine("Orden del ganador: " + winNum_1[i].ToString());
                    }
                    for (int i = 0; i < winNum_1.Length; i++)
                    {
                        if (num_1[i] == winNum_1[i])
                            cont += 1;        
                    }
                    if(cont == 4)
                    {
                        resultado = 500 * betVal_1;
                    }
                }
                
                return resultado;
            }

        }
        
    }
}
