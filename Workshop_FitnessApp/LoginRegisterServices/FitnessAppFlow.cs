using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodService
{
    public static class FitnessAppFlow
    {
        public static Member StartMenuOption()
        {
            Console.Clear();
            Console.WriteLine("-----FitnessApp-----");
            Console.WriteLine("1)Login 2)Register 3)Leave App");
            if (int.TryParse(Console.ReadLine(), out int answer))
            {
                switch (answer)
                {
                    case 1:
                        Console.Clear();
                       return LoginAndRegister.Login();
                    case 2:
                        Console.Clear();
                        LoginAndRegister.Register();
                        return StartMenuOption();
                    case 3:
                        return null;
                    default:
                        return StartMenuOption();
                }
            }
            else
            {
                return StartMenuOption();
            }
        }
       
        public static void ChooseAction(Member user)
        {
            Console.Clear();
            Console.WriteLine($"Welcome {user.FullName}");
            if (user is Trainer)
            {
                TrainerMenu trainerMenu = new TrainerMenu();
                Console.WriteLine("Choose action: 1)Reschedule training 2)Train 3)SeeAcount 4)Logout");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    switch (input)
                    {
                        case 1:
                            trainerMenu.RescheduleTraining();
                            Console.ReadLine();
                            ChooseAction(user);
                            break;
                        case 2:
                            trainerMenu.Train(user);
                            Console.ReadLine();
                            ChooseAction(user);
                            break;
                        case 3:
                            trainerMenu.SeeAcount(user);
                            Console.ReadLine();
                            ChooseAction(user);
                            break;
                        case 4:
                            trainerMenu.Logout(user);
                            Console.Clear();
                            break;
                        default:
                            ChooseAction(user);
                            break;
                    }
                } else
                {
                    ChooseAction(user);
                }
            }
            if (user is PremiumUser)
            {
                PremiumMenu premiumMenu = new PremiumMenu();
                Console.WriteLine("Choose action: 1)Train 2)SeeAcount 3)Logout");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    switch (input)
                    {
                        case 1:
                            premiumMenu.Train(user);
                            Console.ReadLine();
                            ChooseAction(user);
                            break;
                        case 2:
                            premiumMenu.SeeAcount(user);
                            Console.ReadLine();
                            ChooseAction(user);
                            break;
                        case 3:
                            premiumMenu.Logout(user);
                            Console.Clear();
                            break;
                        default:
                            ChooseAction(user);
                            break;
                    }
                }
                else
                {
                    ChooseAction(user);
                }
            }
            if (user is StandardUser)
            {
                StandardMenu standardMenu = new StandardMenu();
                Console.WriteLine("Choose action: 1)Upgrade to premium 2)Train 3)SeeAcount 4)Logout");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    switch (input)
                    {
                        case 1:
                            if (user is StandardUser standard)
                            {
                                standardMenu.UpgradeToPremium(standard);
                                Console.ReadLine();
                                ChooseAction(standard);
                            }
                            break;
                        case 2:
                            standardMenu.Train(user);
                            Console.ReadLine();
                            ChooseAction(user);
                            break;
                        case 3:
                            standardMenu.SeeAcount(user);
                            Console.ReadLine();
                            ChooseAction(user);
                            break;
                        case 4:
                            standardMenu.Logout(user);
                            Console.Clear();
                            break;
                        default:
                            ChooseAction(user);
                            break;
                    }
                }
                else
                {
                    ChooseAction(user);
                }
            }
        }
            
    }
}
