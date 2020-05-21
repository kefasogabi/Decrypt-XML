using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = @"C:\Test\card.xml";
            var key = "hwxkwtyp";


            try
            {
                var decrypt = new Decryption();

                decrypt.DecryptFile(path, key);


                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
