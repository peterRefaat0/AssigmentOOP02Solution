using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct PhoneBook
    {

        #region Attributes

        string[] names;
        long[] numbers;
        int size;
        #endregion

        public int Size
        {

            get
            {
                return size;

            }

            private set { size = value; }

        }

        public long GetNumber(string name)
        {

            if (name != null)
            {
                for (int i = 0; i < names?.Length; i++)
                {

                    if (name == names[i])
                        return numbers[i];

                }
            }

            return -1;
        }

        public void SetNumber(string name, long newNumber)
        {

            if (name != null)
            {
                for (int i = 0; i < names?.Length; i++)
                {

                    if (name == names[i])
                    {
                        numbers[i] = newNumber;
                        return;

                    }


                }
            }

        }


        //indexer
        public long this [string name]
            {

            get {



                if (name != null)
                {
                    for (int i = 0; i < names?.Length; i++)
                    {

                        if (name == names[i])
                        {
                        
                            return numbers[i];

                        }

 
                     }
                }

                
                return -1;
                 
            }
            set {


                if (name != null)
                {
                    for (int i = 0; i < names?.Length; i++)
                    {

                        if (name == names[i])
                        {
                            numbers[i] = value;
                            return;

                        }

                    }
                }

            }  
               
            }

        public string this[int index]
        {

            get
            {

                return $"position : {index}\n name : {names[index]}\n Number : {numbers[index]}";


            }
        
        
        
        }


        public PhoneBook(int _size)
        {
            size = _size;

            names = new string[size];
            numbers = new long[size];
        }

        public PhoneBook() { 
        
            size = 0;
            names = default;
            numbers = default;
        
        } 

        public void AddPerson (int position , string name , long number)
        {
            if (name is not null && numbers is not null)
            {
                if (position >=0 && position< size)
                {

                    names[position] = name;
                    numbers[position] = number;

                }

                
            }



        }


    }
}
