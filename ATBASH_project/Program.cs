using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBASH_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        }

        static int DangerPoints(string decrypted)
        {
            int points = 0;
            string[] arrayDecrypted = decrypted.Split(' ');
            foreach (string word in arrayDecrypted)
            { 
                if (word == bomb || word == nukhba || word == fighter || word == rocket || word == secret )
                    points++;
            }
            return points;

        }



    }
}
