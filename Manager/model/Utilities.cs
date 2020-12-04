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
        public static int get_random_number(int max)
        {
            var random = new Random();
            int ran = random.Next(max);
            return ran;
        }
        public static int get_random_number(int max, Random random)
        {
            int ran = random.Next(max);
            return ran;
        }
            public static Player getRandomPlayer(string str)
        {
            string name = "";
            string surname = "";

            try
            {
                using (var text = new StreamReader("../../data/" + str + "/names.txt"))
                {
                    //var rand = new Random();
                    int ran = get_random_number(101);
                    for (var a = 1; a < ran+2; a++)
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
                    //var rand = new Random();
                    int ran = get_random_number(1001);
                    for (var a = 1; a < ran+2; a++)
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
            int random_skill = get_random_number(100);
            return new Player(name, surname, random_skill, str);
        }
        public static Player getRandomPlayer(Random random)
        {
            string str = "";
            string name = "";
            string surname = "";
            int nat = get_random_number(3, random);
            if (nat == 1) str = "pl";
            else if (nat == 2) str = "de";
            else str = "en"; 
            try
            {
                using (var text = new StreamReader("../../data/" + str + "/names.txt"))
                {
                    //var rand = new Random();
                    int ran = get_random_number(101, random);
                    for (var a = 1; a < ran+2; a++)
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
                    //var rand = new Random();
                    int ran = get_random_number(1001, random);
                    for (var a = 1; a < ran+2; a++)
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
            int random_skill = get_random_number(100, random);
            return new Player(name, surname, random_skill, str);
        }


    }
}
