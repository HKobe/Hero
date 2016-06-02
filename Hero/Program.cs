using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * <summary>
 * This is the driver class.
 * </summary>
 * @Author Name & StudentNumber: Hassan Kobeissi- 300847239
 * @Last Modified: June 3rd, 2016.
 * @Program Description: Create a Hero 
 */
namespace Hero
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Create new instance of Hero*/
            Hero Kobe = new Hero("Kobe");

            /*Display Hero Statistics*/
            Kobe.Show();
            Console.WriteLine();

            /*Fight Prompt*/
            Kobe.BeginFight();

            Console.WriteLine();

            /*Attacks*/
            for (int i = 0; i < 20 ; i++)
            {
            Kobe.Fight();
            }
            
            
            
            
            
        }
    }
}
