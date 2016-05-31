using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * <summary>
 * This is my driver class.
 * </summary>
 * @Author Name & StudentNumber: Hassan Kobeissi- 300847239
 * @Last Modified: June 3rd, 2016.
 * @Program Description: Create a Hero, 
 */
namespace Hero
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Kobe = new Hero("Kobe");
            Kobe.Show();
            Console.WriteLine();
            Kobe.Fight();
            
            
            
            
        }
    }
}
