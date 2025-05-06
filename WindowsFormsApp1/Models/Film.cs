using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    
    
        class Film
        {
            private string _Title;
            private int _Durability;
            private int _Year;
            private string _Genre;
            private float _Rating;


            public string Title
            {
                get { return _Title; }
                set { _Title = value; } //Что за value?
            }

            public int Durability
            {
                get { return _Durability; }
                set
                {
                    Validator.AssertOnPositiveValue(value, nameof(Durability));
                    _Durability = value;
                }
            }

            public int Year
            {
                get { return _Year; }
                set
                {
                    Validator.AssertOnPositiveValue(value, nameof(_Year));
                    _Year = value;
                }
            }

            public string Genre
            {
                get { return _Genre; }
                set { _Genre = value; }
            }

            public float Rating
            {
                get { return _Rating; }
                set
                {
                    Validator.AssertOnPositiveValue(value, nameof(_Rating));
                    _Rating = value;
                }
            }
        }
    
}
