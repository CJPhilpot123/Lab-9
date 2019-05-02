using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo__9
{
    class Error
    {
        public static int Catcher(int SevenUp)
        {
            {
                try
                {
                    if (SevenUp > 6)
                    {
                        throw new Exception("user input must be < 7");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return SevenUp;
            }

        }
    }
}
