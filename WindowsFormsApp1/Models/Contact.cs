using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Contact
    {
        private string _Name;
        private string _Surname;

        public Contact(string name, string surname)
        {
            if (!IsEnglishLettersOnly(name) || !IsEnglishLettersOnly(surname))
            {
                throw new ArgumentException("Имя должен содержать только английские буквы.");
            }
            else
            {
                throw new ArgumentException("фамилия должен содержать только английские буквы.");
            }

            _Name = name;
            _Surname = surname;
        }

        private bool IsEnglishLettersOnly(string input)
        {
            return Regex.IsMatch(input, @"^[A-Za-z]+$");
        }

        public override string ToString()
        {
            return $"{_Name} {_Surname}";
        }
    }
}
