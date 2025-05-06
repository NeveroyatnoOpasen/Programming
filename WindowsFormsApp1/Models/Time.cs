using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Time
    {
        private int _Hours; //0 23
        private int _Minutes; // 0 60
        private int _Seconds; //0 60

        // Setters
        /*
        public void SetHours(int Hours)
        {
            if(Hours > 23 || Hours<0)
                throw new ArgumentException();
            _Hours = Hours;
        }*/
        public int Hours
        {
            get { return _Hours; }
            set
            {
                if (value >= 0 && value < 24)
                    _Hours = value;
                else
                    throw new ArgumentOutOfRangeException("Hours must be between 0 and 23.");
            }
        }
        /*
        public void SetMinutes(int Minutes)
        {
            if (Minutes > 60 || Minutes < 0)
                throw new ArgumentException();
            _Minutes = Minutes;
        }*/
        public int Minutes
        {
            get { return _Minutes; }
            set
            {
                if (value >= 0 && value < 60)
                    _Minutes = value;
                else
                    throw new ArgumentOutOfRangeException("Minutes must be between 0 and 59.");
            }
        }

        // Свойство для секунд
        public int Seconds
        {
            get { return _Seconds; }
            set
            {
                if (value >= 0 && value < 60)
                    _Seconds = value;
                else
                    throw new ArgumentOutOfRangeException("Seconds must be between 0 and 59.");
            }
        }
        //Возможно все сеттеры можно было оформить в одну функцию,
        //Оставить на подумать
    }
}

