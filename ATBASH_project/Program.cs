using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATBASH_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DangerPoints( Decryption("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb."));
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

        static string[] DangerPoints(string decrypted)
        {
            int points = 0;
            string[] arrayDecrypted = decrypted.Split(' ');

            string[] triggerWords = { "bomb", "nukhba", "fighter", "rocket", "secret" };

            foreach (string word in arrayDecrypted)
            {
                if (triggerWords.Contains(word))
                {
                     points++;
                }
            }
            string strPoints = Convert.ToString(points);
            string[] final = { strPoints, decrypted };
            return final;

        }


    }
}
