using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        private static System.Collections.ArrayList list1 = new System.Collections.ArrayList();
        private static System.Collections.Generic.LinkedList<IncreaseCost> list2 = new LinkedList<IncreaseCost>();

        static void Main(string[] args)
        {

            IncreaseCost[] applications = new IncreaseCost[4];
            IncreaseCost app0 = new Game("Heroes3", 15, 200, "No license");
            IncreaseCost app1 = new Game("Disciples", 5, 500, "Official license");
            IncreaseCost app2 = new Software("Util_1", 0, 30);
            IncreaseCost app3 = new Software("Util_1", 0, 40);

            applications[0] = app0;
            applications[1] = app1;
            applications[2] = app2;
            applications[3] = app3;

            list1.AddRange(applications);

            list2.AddFirst(app0);
            list2.AddAfter(list2.First,app1);
            list2.AddLast(app2);
            list2.AddAfter(list2.Last,app3);

            //list1.Add(new Game("Heroes3", 15, 200, "No license"));

            int flag = 100;
            while (flag != 0)
            {
                Console.Clear();
                Console.WriteLine("Меню : ");
                Console.WriteLine("1 – просмотр коллекции");
                Console.WriteLine("2 – добавление элемента (используйте конструктор с 1-2 параметрами)");
                Console.WriteLine("3 – добавление элемента по указанному индексу");
                Console.WriteLine("4 – нахождение элемента с начала коллекции (переопределить метод Equals или оператор == для вашего класса – сравнение только по полю name)");
                Console.WriteLine("5 – нахождение элемента с конца коллекции");
                Console.WriteLine("6 – удаление элемента по индексу");
                Console.WriteLine("7 – удаление элемента по значению");
                Console.WriteLine("8 – реверс коллекции");
                Console.WriteLine("9 – сортировка");
                Console.WriteLine("10 – выполнение методов всех объектов, поддерживающих Interface2");

                Console.WriteLine("11 – LinkedList просмотр коллекции");
                Console.WriteLine("12 – LinkedList добавление элемента (используйте конструктор с 1-2 параметрами)");
                Console.WriteLine("13 – LinkedList добавление элемента по указанному индексу");
                Console.WriteLine("14 – LinkedList нахождение элемента с начала коллекции (переопределить метод Equals или оператор == для вашего класса – сравнение только по полю name)");
                Console.WriteLine("15 – LinkedList нахождение элемента с конца коллекции");
                Console.WriteLine("16 – LinkedList удаление элемента по индексу");
                Console.WriteLine("17 – LinkedList удаление элемента по значению");
                Console.WriteLine("18 – LinkedList реверс коллекции");
                Console.WriteLine("19 – LinkedList сортировка");
                Console.WriteLine("20 – LinkedList выполнение методов всех объектов, поддерживающих Interface2");

                Console.WriteLine("0 – выход");
                flag = Convert.ToInt32(Console.ReadLine());

                switch (flag)
                {
                    //просмотр коллекции
                    case (1):
                        {
                            Console.Clear();

                            if (Program.list1.Count > 0)
                            {
                                Console.WriteLine("list1 содержит : " + list1.Count);
                                foreach (Object obj in Program.list1)
                                {
                                    Console.WriteLine("************************************************************");
                                    Console.WriteLine(obj.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("list1 пустой");
                            }

                            Console.ReadLine();
                            break;
                        }
                    //добавление элемента
                    case (2):
                        {
                            Console.Clear();

                            Console.WriteLine("Теперь создаем обьект");
                            Console.WriteLine("Введите name");
                            String name = Console.ReadLine();
                            Console.WriteLine("Введите bugs");
                            int bugs = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите cost");
                            double cost = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите licenseAgreement");
                            String licenseAgreement = Console.ReadLine();

                            if (licenseAgreement.Equals("0"))
                            {
                                list1.Add(new Software(name, bugs, cost));
                                Console.WriteLine("Done");
                                Console.WriteLine("создали Software");
                            }
                            else
                            {
                                list1.Add(new Game(name, bugs, cost, licenseAgreement));
                                Console.WriteLine("Done");
                                Console.WriteLine("создали Game");
                            }
                            Console.WriteLine("И добавили в list1");

                            Console.ReadLine();
                            break;
                        }
                    //добавление элемента по указанному индексу
                    case (3):
                        {
                            Console.Clear();
                            try
                            {
                                Console.WriteLine("Теперь создаем обьект");
                                Console.WriteLine("Введите name");
                                String name = Console.ReadLine();
                                Console.WriteLine("Введите bugs");
                                int bugs = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите cost");
                                double cost = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите licenseAgreement");
                                String licenseAgreement = Console.ReadLine();
                                Console.WriteLine("Введите index");
                                int index = Convert.ToInt32(Console.ReadLine());

                                if (licenseAgreement.Equals("0"))
                                {
                                    list1.Insert(index, new Software(name, bugs, cost));
                                    Console.WriteLine("Done");
                                    Console.WriteLine("создали Software");
                                }
                                else
                                {
                                    list1.Insert(index, new Game(name, bugs, cost, licenseAgreement));
                                    Console.WriteLine("Done");
                                    Console.WriteLine("создали Game");
                                }
                                Console.WriteLine("И добавили в list1");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Не могу выполнить");
                            }

                            Console.ReadLine();
                            break;
                        }
                    //нахождение элемента с начала коллекции
                    case (4):
                        {
                            Console.Clear();

                            Console.WriteLine("Находим элемент по имени name с начала");
                            Console.WriteLine("Введите name");
                            String name = Console.ReadLine();
                            Software finding = null;
                            for (int i = 0; i < list1.Count; i++)
                            {
                                if (name.Equals(((Software)list1[i]).getName()))
                                {
                                    finding = (Software)list1[i];
                                    break;
                                }
                            }

                            if (finding != null)
                            {
                                Console.WriteLine("Нашел");
                                if (finding is Game)
                                {
                                    Console.WriteLine(((Game)finding).ToString());
                                }
                                else
                                {
                                    Console.WriteLine(((Software)finding).ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("Не нашел");
                            }

                            Console.ReadLine();
                            break;
                        }
                    //нахождение элемента с конца коллекции
                    case (5):
                        {
                            Console.Clear();

                            Console.WriteLine("Находим элемент по имени name с конца");
                            Console.WriteLine("Введите name");
                            String name = Console.ReadLine();
                            Software finding = null;

                            for (int i = list1.Count - 1; i >= 0; i--)
                            {
                                if (name.Equals(((Software)list1[i]).getName()))
                                {
                                    finding = (Software)list1[i];
                                    break;
                                }
                            }

                            if (finding != null)
                            {
                                Console.WriteLine("Нашел");
                                if (finding is Game)
                                {
                                    Console.WriteLine(((Game)finding).ToString());
                                }
                                else
                                {
                                    Console.WriteLine(((Software)finding).ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("Не нашел");
                            }

                            Console.ReadLine();
                            break;
                        }
                    //удаление элемента по индексу
                    case (6):
                        {
                            Console.Clear();

                            try
                            {
                                Console.WriteLine("Удалим элемент по индексу");
                                Console.WriteLine("Введите индекс");
                                int index = Convert.ToInt32(Console.ReadLine());
                                list1.RemoveAt(index);
                                Console.WriteLine("Эх жаль элемента");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Че-то пошло не так :)");
                            }

                            Console.ReadLine();
                            break;
                        }
                    //удаление элемента по значению
                    case (7):
                        {
                            Console.Clear();

                            try
                            {
                                Console.WriteLine("Удалим элемент по значению");
                                Console.WriteLine("Введите name");
                                String name = Console.ReadLine();
                                for (int i = 0; i < list1.Count; i++)
                                {
                                    if (name.Equals(((Software)list1[i]).getName()))
                                    {
                                        list1.RemoveAt(i);
                                        Console.WriteLine("Эх жаль элемента");
                                        break;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Че-то пошло не так :)");
                            }

                            Console.ReadLine();
                            break;
                        }
                    //реверс коллекции
                    case (8):
                        {
                            Console.Clear();

                            Console.WriteLine("Произведем реверс list1");
                            list1.Reverse();
                            Console.WriteLine("Готово :)");

                            Console.ReadLine();
                            break;
                        }
                    //сортировка
                    case (9):
                        {
                            Console.Clear();

                            Console.WriteLine("Отсортируем по name list1");
                            list1.Sort();
                            Console.WriteLine("Готово )");

                            Console.ReadLine();
                            break;
                        }
                    //выполнение методов всех объектов, поддерживающих Interface2
                    case (10):
                        {
                            Console.Clear();

                            foreach (IncreaseCost obj in list1)
                            {
                                if (obj is DecreaseCost)
                                {
                                    Console.WriteLine("Ура");
                                    Console.WriteLine("************************************************************");
                                    ((DecreaseCost)obj).decreaseCost();
                                    ((DecreaseCost)obj).information();
                                    ((DecreaseCost)obj).statistic();
                                    ((DecreaseCost)obj).info();
                                }
                            }


                            Console.ReadLine();
                            break;
                        }


                    //LinkedList просмотр коллекции
                    case (11):
                        {
                            Console.Clear();

                            if (Program.list2.Count > 0)
                            {
                                Console.WriteLine("list2 содержит : " + list2.Count);
                                foreach (Object obj in Program.list2)
                                {
                                    Console.WriteLine("************************************************************");
                                    Console.WriteLine(obj.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("list2 пустой");
                            }

                            Console.ReadLine();
                            break;
                        }
                    //LinkedList добавление элемента
                    case (12):
                        {
                            Console.Clear();

                            Console.WriteLine("Теперь создаем обьект");
                            Console.WriteLine("Введите name");
                            String name = Console.ReadLine();
                            Console.WriteLine("Введите bugs");
                            int bugs = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите cost");
                            double cost = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите licenseAgreement");
                            String licenseAgreement = Console.ReadLine();

                            if (licenseAgreement.Equals("0"))
                            {
                                list2.AddFirst(new Software(name, bugs, cost));
                                Console.WriteLine("Done");
                                Console.WriteLine("создали Software");
                            }
                            else
                            {
                                list2.AddFirst(new Game(name, bugs, cost, licenseAgreement));
                                Console.WriteLine("Done");
                                Console.WriteLine("создали Game");
                            }
                            Console.WriteLine("И добавили в list2");

                            Console.ReadLine();
                            break;
                        }
                    //LinkedList добавление элемента по указанному индексу
                    case (13):
                        {
                            Console.Clear();
                            try
                            {
                                Console.WriteLine("Теперь создаем обьект");
                                Console.WriteLine("Введите name");
                                String name = Console.ReadLine();
                                Console.WriteLine("Введите bugs");
                                int bugs = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите cost");
                                double cost = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите licenseAgreement");
                                String licenseAgreement = Console.ReadLine();
                                Console.WriteLine("Введите index обьекта после котрого вставим этот");
                                int index = Convert.ToInt32(Console.ReadLine());
                                IncreaseCost obj = list2.ElementAt(index);


                                if (licenseAgreement.Equals("0"))
                                {
                                    list2.AddAfter(list2.Find(obj), new Software(name, bugs, cost));
                                    Console.WriteLine("Done");
                                    Console.WriteLine("создали Software");
                                }
                                else
                                {
                                    list2.AddAfter(list2.Find(obj), new Game(name, bugs, cost, licenseAgreement));
                                    Console.WriteLine("Done");
                                    Console.WriteLine("создали Game");
                                }
                                Console.WriteLine("И добавили в list2");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Не могу выполнить");
                            }

                            Console.ReadLine();
                            break;
                        }
                    //LinkedList нахождение элемента с начала коллекции
                    case (14):
                        {
                            Console.Clear();

                            Console.WriteLine("Находим элемент по имени name с начала");
                            Console.WriteLine("Введите name");
                            String name = Console.ReadLine();
                            Software finding = null;

                            LinkedListNode<IncreaseCost> node = list2.First;
                            for (int i = 0; i < list2.Count; i++)
                            {
                                IncreaseCost obj = node.Value;
                                if (name.Equals(((Software)obj).getName()))
                                {
                                    finding = (Software)obj;
                                }
                                node = node.Next;
                            }

                            if (finding != null)
                            {
                                Console.WriteLine("Нашел");
                                if (finding is Game)
                                {
                                    Console.WriteLine(((Game)finding).ToString());
                                }
                                else
                                {
                                    Console.WriteLine(((Software)finding).ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("Не нашел");
                            }

                            Console.ReadLine();
                            break;
                        }
                    //LinkedList нахождение элемента с конца коллекции
                    case (15):
                        {
                            Console.Clear();

                            Console.WriteLine("Находим элемент по имени name с начала");
                            Console.WriteLine("Введите name");
                            String name = Console.ReadLine();
                            Software finding = null;

                            LinkedListNode<IncreaseCost> node = list2.Last;
                            for (int i = 0; i < list2.Count; i++)
                            {
                                IncreaseCost obj = node.Value;
                                if (name.Equals(((Software)obj).getName()))
                                {
                                    finding = (Software)obj;
                                }
                                node = node.Previous;
                            }

                            if (finding != null)
                            {
                                Console.WriteLine("Нашел");
                                if (finding is Game)
                                {
                                    Console.WriteLine(((Game)finding).ToString());
                                }
                                else
                                {
                                    Console.WriteLine(((Software)finding).ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("Не нашел");
                            }

                            Console.ReadLine();
                            break;
                        }
                    //LinkedList удаление элемента по индексу
                    case (16):
                        {
                            Console.Clear();

                            try
                            {
                                Console.WriteLine("Удалим элемент по индексу");
                                Console.WriteLine("Введите индекс");
                                int index = Convert.ToInt32(Console.ReadLine());
                                list2.Remove(list2.ElementAt(index));
                                Console.WriteLine("Эх жаль элемента");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Че-то пошло не так :)");
                            }

                            Console.ReadLine();
                            break;
                        }
                    //LinkedList удаление элемента по значению
                    case (17):
                        {
                            Console.Clear();

                            try
                            {
                                Console.WriteLine("Удалим элемент по значению");
                                Console.WriteLine("Введите name");
                                String name = Console.ReadLine();
                                LinkedListNode<IncreaseCost> node = list2.First;
                                for (int i = 0; i < list2.Count; i++)
                                {
                                    IncreaseCost obj = node.Value;
                                    if (name.Equals(((Software)obj).getName()))
                                    {
                                        list2.Remove(obj);
                                        Console.WriteLine("Эх жаль элемента");
                                        break;
                                    }
                                    node = node.Next;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Че-то пошло не так :)");
                            }

                            Console.ReadLine();
                            break;
                        }
                    //LinkedList реверс коллекции
                    case (18):
                        {
                            Console.Clear();

                            Console.WriteLine("Произведем реверс list2");
                            IncreaseCost[] array = list2.ToArray();
                            LinkedList<IncreaseCost> list3 = new LinkedList<IncreaseCost>();
                            foreach (IncreaseCost obj in list2)
                            {
                                list3.AddFirst(obj);
                            }
                            list2 = list3;
                            Console.WriteLine("Готово :)");

                            Console.ReadLine();
                            break;
                        }
                    //LinkedList сортировка
                    case (19):
                        {
                            Console.Clear();

                            Console.WriteLine("Отсортируем по name list2");
                            IncreaseCost[] array = new IncreaseCost[list2.Count];
                            int i = 0;
                            foreach (IncreaseCost obj in list2)
                            {
                                array[i] = obj;
                                i++;
                            }
                            Array.Sort(array);
                            list2.Clear();
                            for (int q = 0; q < array.Length; q++)
                            {
                                list2.AddLast(array[q]);
                            }
                            Console.WriteLine("Готово )");

                            Console.ReadLine();
                            break;
                        }
                    //выполнение методов всех объектов, поддерживающих Interface2
                    case (20):
                        {
                            Console.Clear();

                            foreach (IncreaseCost obj in list2)
                            {
                                if (obj is DecreaseCost)
                                {
                                    Console.WriteLine("Ура");
                                    Console.WriteLine("************************************************************");
                                    ((DecreaseCost)obj).decreaseCost();
                                    ((DecreaseCost)obj).information();
                                    ((DecreaseCost)obj).statistic();
                                    ((DecreaseCost)obj).info();
                                }
                            }

                            Console.ReadLine();
                            break;
                        }




                    case (0):
                        {
                            Console.Clear();
                            break;
                        }
                }
            }
        }
    }
}
