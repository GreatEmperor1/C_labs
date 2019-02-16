using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Chars
    {
        //качестве поля – массив символов
        private char[] array = new char[10];

        //свойства
        public char[] ArrayContent
        {
            get
            {
                return this.array;
            }
            set
            {
                this.array = value;

                if (CheckRepeats(array) == true)
                {
                    //Console.WriteLine("Множество корректно"); // CUSTOM EXCEPTION
                }
                else
                {
                    //Console.WriteLine("Множество не корректно!"); //THROW CUSTOM EXCEPTION
                }
            }
        }
        public int Length { get; private set; }

        //конструкторы
        public Chars(char[] array)
        {
            ArrayContent = array;
        }

        public Chars() : this(new char[] { 'a' })
        {
        }

        public Chars(char a) : this(new char[] { a })
        {
        }

        //ИНДЕКСАТОР
        public char this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                if (isCorrectChar(value))
                {
                    array[i] = value;
                    // CUSTOM EXCEPTION
                }
                else
                {
                    //THROW CUSTOM EXCEPTION
                }
            }

        }

        //ПЕЧАТЬ МАССИВА
        public void PrintArray()
        {
            for (int i = 0; i < array.Length && array[i] != '\0'; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        //ПЕРЕОПРЕДЕЛЁННЫЙ ToString
        public override string ToString()
        {
            string str2 = new string(this.array);
            return str2;
        }

        //Преобразовать в String – неявно, назад – явно.
        public static implicit operator string(Chars a)
        {
            return a.ToString();
        }

        //Преобразовать  String назад – явно.
        public static explicit operator Chars(string a)
        {
            return new Chars(a.ToCharArray());
        }


        //ПЕРЕГРУЖЕННЫЙ +
        public static Chars operator +(Chars a1, Chars a2)
        {
            //return new Chars(a1.array.Concat(a2.array).ToArray());
            char[] newContent1 = new char[500];
            newContent1 = a1.array.Concat(a2.array).ToArray();
            char[] newContent = new char[500];
            int index = 0;
            for (int i = 0; i < newContent1.Length; i++)
            {

                bool isCurrentElementDuplicate = false;

                for (int j = 0; j < index; j++)
                {
                    if (newContent1[i] == newContent[j] || newContent1[i] == '\0')
                    {

                        isCurrentElementDuplicate = true;
                        break;
                    }


                }
                if (!isCurrentElementDuplicate)
                {
                    newContent[index] = newContent1[i];
                    index++;
                }
            }
            //newContent[index] = '\0';
            return new Chars(newContent);
        }

        //ПЕРЕГРУЖЕННЫЙ -
        public static Chars operator -(Chars a1, Chars a2)
        {
            string s1 = a1.ToString();
            string s2 = a2.ToString();

            StringBuilder sb = new StringBuilder(s1);

            foreach (char ch in s2)
            {
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] == ch)
                    {
                        sb.Remove(i, 1);
                        break;
                    }
                }
            }

            s1 = sb.ToString();
            return new Chars(s1.ToCharArray());
        }

        //ПЕРЕГРУЖЕННЫЙ *
        public static Chars operator *(Chars a1, Chars a2)
        {
            var intersect = a1.array.Intersect(a2.array);
            return new Chars(intersect.ToArray());

        }

        //ПЕРЕГРУЖЕННЫЙ ==
        public static bool operator ==(Chars a1, Chars a2)
        {
            if (a1.Length != a2.Length)
            {
                return false;
            }

            for (int i = 0; i < a1.array.Length; i++)
            {
                if (a1.array[i] != a2.array[i])
                {
                    return false;
                }
            }
            return true;
        }

        //ПЕРЕГРУЖЕННЫЙ !=
        public static bool operator !=(Chars a1, Chars a2)
        {
            if (a1.Length != a2.Length)
            {
                return true;
            }

            for (int i = 0; i < a1.array.Length; i++)
            {
                if (a1.array[i] != a2.array[i])
                {
                    return true;
                }
            }
            return false;
        }

        //ПЕРЕГРУЖЕННЫЙ true (если множество пустое, оно false)
        public static bool operator true(Chars a)
        {
            if (a.array.Length != 0) { return true; }
            return false;
        }

        //ПЕРЕГРУЖЕННЫЙ false
        public static bool operator false(Chars a)
        {
            if (a.array.Length == 0) { return false; }
            return true;
        }


        //МЕТОД ПРОВЕРЯЮЩИЙ КОРРЕКТНОСТЬ МНОЖЕСТВА
        public Boolean CheckRepeats(char[] array)
        {
            Boolean flag = true;
            char[] newContent = new char[10];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isCurrentElementDuplicate = false;

                for (int j = 0; j < index; j++)
                {
                    if (array[i] == newContent[j])
                    {
                        flag = false;
                        isCurrentElementDuplicate = true;
                        break;
                    }
                }
                if (!isCurrentElementDuplicate)
                {
                    newContent[index] = array[i];
                    index++;
                }
            }
            newContent[index] = '\0';
            this.array = newContent;

            return flag;
        }


        // проверяем есть ли такой символ в массиве
        private Boolean isCorrectChar(char ch)
        {
            Boolean flag = true;
            for (int i = 0; i < this.array.Length; i++)
            {
                if ((int)array[i] == (int)ch)
                    flag = false;
            }
            return flag;
        }
        // добавляем новый символ в массив
        public void addCharacter(char ch)
        {
            if (this.isCorrectChar(ch))
                for (int i = 0; i < this.array.Length; i++)
                {
                    if (this.array[i] == '\0')
                    {
                        this.array[i] = ch;
                        break;
                    }
                }
            else
            {
                //THROW CUSTOM EXCEPTION
            }

            }


    }
}

