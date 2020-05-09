using System;

namespace HWTask2Lib
{
    public class Person
    {
        string name, сity, street, numb_house, email;
        int phone_number, num_apartment;

        /// <summary>
        /// Simple constructor to initialize class.
        /// </summary>
        public Person()
        {
        }

        /// <summary>
        /// Simple constructor to initialize class with all properties.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="сity"></param>
        /// <param name="street"></param>
        /// <param name="email"></param>
        /// <param name="phone_number"></param>
        /// <param name="numb_house"></param>
        /// <param name="num_apartment"></param>
        public Person(string name, string сity, string street, string email, int phone_number, string numb_house, int num_apartment)
        {
            Name = name;
            Сity = сity;
            Street = street;
            Email = email;
            Phone_number = phone_number;
            Numb_house = numb_house;
            Num_apartment = num_apartment;
        }

        /// <summary>
        /// Property by person class by Name. 
        /// If set value will be null, it create ArgumentNullException.
        /// </summary>
        public string Name
        {
            get => name;
            set => name = value ??
                throw new ArgumentNullException(paramName: nameof(value), message: "Name cannot be null");
        }

        /// <summary>
        /// Property by person class by City.
        /// If set value will be null, it create ArgumentNullException.
        /// </summary>
        public string Сity
        {
            get => сity;
            set => сity = value ??
                throw new ArgumentNullException(paramName: nameof(value), message: "City cannot  be null");
        }

        /// <summary>
        /// Property by person class by City.
        /// </summary>
        public string Street { get => street; set => street = value; }

        /// <summary>
        /// Property by person class by phone number.
        /// </summary>
        public int Phone_number
        {
            get => phone_number;
            set
            {
                if (Int32.TryParse(value.ToString(), out int resylt))
                {
                    phone_number = resylt;
                }
                else
                {
                    throw new ArgumentException("Phone number can contain only numbers");
                }
            }
        }

        /// <summary>
        /// Property by person class by email.
        /// </summary>
        public string Email { get => email; set => email = value; }

        /// <summary>
        /// Property by person class by number house.
        /// </summary>
        public string Numb_house { get => numb_house; set => numb_house = value; }

        /// <summary>
        /// Property by person class by number of apartments.
        /// </summary>
        public int Num_apartment { get => num_apartment; set => num_apartment = value; }

        /// <summary>
        /// check length phone number
        /// </summary>
        /// <param name="phone_number"></param>
        /// <returns>true/false</returns>
        public bool CheckPhoneNumber()
        {
            return this.phone_number.ToString().Length == 9;
        }

        /// <summary>
        /// Check email to same content
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true/false</returns>
        public bool CheckEmail()
        {
            char[] letters = this.email.ToCharArray(0, email.Length);
            for (int i = 0; this.email.Length > i; i++)
            {
                if (letters[i] == Convert.ToChar("@"))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
