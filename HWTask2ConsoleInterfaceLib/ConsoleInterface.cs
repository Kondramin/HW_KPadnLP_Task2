using HWTask2Lib;
using System;
using System.Collections.Generic;

namespace HWTask2ConsoleInterfaceLib
{
    /// <summary>
    /// Class realizing UI.
    /// </summary>
    public class ConsoleInterface
    {
        List<Person> PersonList = new List<Person>();
        /// <summary>
        /// Simple initialization.
        /// </summary>
        public ConsoleInterface()
        {
        }
        /// <summary>
        /// Method start UI.
        /// </summary>
        public void StartInterface()
        {
            while (true)
            {
                Console.WriteLine("1. Add new person.");
                Console.WriteLine("2. Show list of persons");
                Console.WriteLine("3. Change person data");
                Console.WriteLine("4. Check person data");
                Console.WriteLine("5. Clear console.");
                Console.WriteLine("6. Close console.");
                Console.WriteLine();
                int start_value = CheckNumber();

                if ((start_value > 0) & (start_value < 7))
                {
                    switch (start_value)
                    {
                        case 1:
                            CreatePerson();
                            break;
                        case 2:
                            ShowPersonLisn();
                            break;
                        case 3:
                            ChangePerson();
                            break;
                        case 4:
                            CheckData();
                            break;
                        case 5:
                            Console.Clear();
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("You need select correct menu item");
                }
            }
        }
        /// <summary>
        /// Creating person and add it in list.
        /// </summary>
        public void CreatePerson()
        {
            Person p = new Person();
            Console.WriteLine("Write name person");
            p.Name = Console.ReadLine();
            Console.WriteLine("Write city person");
            p.Сity = Console.ReadLine();
            Console.WriteLine("Write street person");
            p.Street = Console.ReadLine();
            Console.WriteLine("Write number house person");
            p.Numb_house = Console.ReadLine();
            Console.WriteLine("Write number apartment person");
            p.Num_apartment = CheckNumber();
            Console.WriteLine("Write email person");
            p.Email = Console.ReadLine();
            Console.WriteLine("Write phone number person");
            p.Phone_number = CheckNumber();
            PersonList.Add(p);
        }
        /// <summary>
        /// Show all persons in list.
        /// </summary>
        public void ShowPersonLisn()
        {
            Console.WriteLine();
            if (PersonList.Count < 1)
            {
                Console.WriteLine("List is empty");
                Console.ReadLine();
                return;
            }
            int i = 0;
            foreach (Person person in PersonList)
            {
                Console.WriteLine($"{i}, person {person.Name}");
                i++;
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Changing selected person.
        /// </summary>
        public void ChangePerson()
        {
            if (PersonList.Count < 1)
            {
                Console.WriteLine("List is empty");
                Console.ReadLine();
                return;
            }
            ShowPersonLisn();
            Console.WriteLine("Chose number of person");
            int person_value = PersonValue();

            Console.WriteLine("What you want to change?");
            Console.WriteLine();
            Console.WriteLine($"1. Name ({PersonList[person_value].Name})");
            Console.WriteLine($"2. City ({PersonList[person_value].Сity})");
            Console.WriteLine($"3. Street ({PersonList[person_value].Street})");
            Console.WriteLine($"4. Number of house ({PersonList[person_value].Numb_house})");
            Console.WriteLine($"5. Number of apartment ({PersonList[person_value].Num_apartment})");
            Console.WriteLine($"6. Email ({PersonList[person_value].Email})");
            Console.WriteLine($"7. Phone number ({PersonList[person_value].Phone_number})");
            Console.WriteLine("8. Abort change");


            switch (MenuItem())
            {
                case 1:
                    Console.WriteLine("Write new name");
                    PersonList[person_value].Name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Write new city");
                    PersonList[person_value].Сity = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Write new street");
                    PersonList[person_value].Street = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Write new number of house");
                    PersonList[person_value].Numb_house = Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Write new number of apartment");
                    PersonList[person_value].Num_apartment = CheckNumber();
                    break;
                case 6:
                    Console.WriteLine("Write new email");
                    PersonList[person_value].Email = Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Write new phone number");
                    PersonList[person_value].Phone_number = CheckNumber();
                    break;
                case 8:
                    Console.WriteLine("Changes abort, press any key");
                    Console.ReadKey();
                    break;
            }


        }
        /// <summary>
        /// Realize simple check person info.
        /// </summary>
        public void CheckData()
        {
            if (PersonList.Count<1)
            {
                Console.WriteLine("List is empty");
                Console.ReadLine();
                return;
            }
            ShowPersonLisn();
            Console.WriteLine("Chose person");
            int person_value = PersonValue();
            Console.WriteLine("What you want to check?");
            Console.WriteLine("1. Phone number");
            Console.WriteLine("2. Email");

            switch (CheckNumber())
            {
                case 1:
                    Console.WriteLine($"Email this person is { PersonList[person_value].CheckEmail()}");
                    break;
                case 2:
                    Console.WriteLine($"Phone this person is {PersonList[person_value].CheckPhoneNumber()}");
                    break;
            }
        }
        /// <summary>
        /// Check correct input.
        /// </summary>
        /// <returns>number</returns>
        public int CheckNumber()
        {
            int result;
            while (!Int32.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("You must write number");

            }
            return result;
        }
        /// <summary>
        /// Chose correct person id.
        /// </summary>
        /// <returns>person id (number)</returns>
        public int PersonValue()
        {
            int result;
            do
            {
                Console.WriteLine($"You input number item of persons (from 0 to {PersonList.Count-1})");
                result = CheckNumber();
            } while ((result<0)||(result > (PersonList.Count-1)));
            return result;
        }
        /// <summary>
        /// Chose correct menu item.
        /// </summary>
        /// <returns>menu item(number/id)</returns>
        public int MenuItem()
        {
            int result;
            do
            {
                Console.WriteLine("Input correct number");
                result = CheckNumber();
            } while ((result < 1) || (result > 8));
            return result;
        }

    }
}
