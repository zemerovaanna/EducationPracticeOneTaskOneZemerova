using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOneCreateCat
{
    class Cat
    {
        private string name;
        private double weight;

        public Cat(string CatName, double CatWeight)
        {
            Name = CatName;
            Weight = CatWeight;
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                bool OnlyDouble = true;
                if(value == 0 || value < 0)
                {
                    OnlyDouble = false;
                }

                if(OnlyDouble == true)
                {
                    weight = value;
                }
                else
                {
                    Console.Write($". Вес {value} - не может быть отрицательный или равен нулю!!");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                bool OnlyLetters = true;
                foreach (var ch in value)
                {
                    if(!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.Write($"{value} - неправильное имя!!");
                }
            }
        }
        public void Meow()
        {
            Console.WriteLine( );
            Console.Write($"{name}: МЯЯЯУ!");
            Console.Write($"Мой вес: {weight}:");
        }
        /*public void SetCatName (string CatName)
        {
            bool OnlyLetters = true;

            foreach ( var ch in CatName )
            {
                if ( !char.IsLetter(ch) )
                {
                    OnlyLetters = false;
                }
            }

            if ( OnlyLetters ) name = CatName;
            else Console.WriteLine($"{CatName} - неправильное имя!!");
        }*/
    }
}
