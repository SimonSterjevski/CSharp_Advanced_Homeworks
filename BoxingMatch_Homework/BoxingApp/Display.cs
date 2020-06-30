using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Text;

namespace BoxingApp
{
    public class Display
    {
        Random random = new Random();
        public StreamWriter sw = new StreamWriter("report.txt");
        public void CalcAndDisplayInfo(Boxer attacker, Boxer defender)
        {
            int typeNum = random.Next(0, 4);
            string punchType = null;
            int attackerStrength = 0;
            int defenceAgility = 0;
            switch (typeNum)
            {
                case 0:
                    {
                        attackerStrength = attacker.Strength["Cross"];
                        defenceAgility = random.Next(0, defender.Agility["Cross"] + 1);
                        punchType = "Cross";
                        break;
                    };
                case 1:
                    {
                        attackerStrength = attacker.Strength["Jab"];
                        defenceAgility = random.Next(0, defender.Agility["Jab"] + 1);
                        punchType = "Jab";
                        break;
                    }
                case 2:
                    {
                        attackerStrength = attacker.Strength["Uppercut"];
                        defenceAgility = random.Next(0, defender.Agility["Uppercut"] + 1);
                        punchType = "Uppercut";
                        break;
                    }
                case 3:
                    {
                        attackerStrength = attacker.Strength["Hook"];
                        defenceAgility = random.Next(0, defender.Agility["Hook"] + 1);
                        punchType = "Hook";
                        break;
                    }
            }

            Console.WriteLine($"{attacker.Name} throw {punchType} with strenght {attackerStrength}");
            sw.WriteLine($"{attacker.Name} throw {punchType} with strenght {attackerStrength}");
            if (attackerStrength > defenceAgility)
            {
                defender.Hitpoints -= attackerStrength - defenceAgility;
                if (defender.Hitpoints < 1)
                {
                    Console.WriteLine($"Knockout!!! {defender.Name} is on the floor");
                    sw.WriteLine($"Knockout!!! {defender.Name} is on the floor");
                } else
                {
                    Console.WriteLine($"{defender.Name} was hit for {attackerStrength - defenceAgility} damage.");
                    Console.WriteLine($"{defender.Name}: Hitpoints left: {defender.Hitpoints}");
                    sw.WriteLine($"{defender.Name} was hit for {attackerStrength - defenceAgility} damage.");
                    sw.WriteLine($"{defender.Name}: Hitpoints left: {defender.Hitpoints}");
                }
               
            }
            else
            {
                Console.WriteLine($"{defender.Name} escaped the punch!");
                sw.WriteLine($"{defender.Name} escaped the punch!");
            }
           
            //attacker.Attacker = false;
            //defender.Attacker = true;
        }
       
        } 
    }

