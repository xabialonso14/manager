using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model
{
    class Utilities
    {
        public static Player getRandomPlayer(string str)
        {
            string name = "";
            string surname = "";

            try
            {
                using (var text = new StreamReader("../../data/" + str + "/names.txt"))
                {
                    var rand = new Random();
                    int ran = rand.Next(101);
                    for (var a = 1; a < ran; a++)
                    {
                        var line = text.ReadLine();
                        name = line;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                name = ex.Message;
            }
            try
            {
                using (var text = new StreamReader("../../data/" + str + "/surnames.txt"))
                {
                    var rand = new Random();
                    int ran = rand.Next(1001);
                    for (var a = 1; a < ran; a++)
                    {
                        var line = text.ReadLine();
                        surname = line;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                surname = ex.Message;

            }

            return new Player(name, surname, 0, str);
        }
            

    }
}
