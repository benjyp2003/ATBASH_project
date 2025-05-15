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
            Console.WriteLine(Decryption("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb."));
        }


        static string Decryption(string cipher)
        {
            string decrypted = "";

            foreach (char letter in cipher)
            {
                if (char.IsUpper(letter))
                {
                    decrypted += (char)('A' + (char)('Z' - letter));
                }
                else if (char.IsLower(letter))
                {
                    decrypted += (char)('a' + (char)('z' - letter));
                }
                else
                { decrypted += letter; }
            }

            return decrypted;

        }

        static string DangerPoints(string decrypted)
        {
            int points = 0;
            string[] arrayDecrypted = decrypted.Split(' ');
            foreach (string word in arrayDecrypted)
            { 
                if (word == bomb || word == nukhba || word == fighter || word == rocket || word == secret )
                    points++;
            }
            string strPoints = Convert.ToString(points);
            return strPoints, decrypted;

        }



    }
}
