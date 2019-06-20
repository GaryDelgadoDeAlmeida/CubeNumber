using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            Console.WriteLine("Veuillez insérer le n terme");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                while(choice == 0)
                {
                    try
                    {
                        Console.WriteLine(e.Message + " Veuillez recommencer");
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception exception)
                    {

                    }
                    finally
                    {
                    }
                }
            }

            for(int i = 1; i <= choice; i++)
            {
                Console.WriteLine("Number is : " + i + " and the cube of the " + i + " is : " + Math.Pow(i, 3));
            }

            Console.ReadLine();
        }
    }
}
