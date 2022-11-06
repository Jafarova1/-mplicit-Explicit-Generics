using System;


namespace Implicit_Explicit_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Manat
            //Manat manat = new Manat(100);
            //Dollar dollar = manat;
            //Console.WriteLine(dollar.USD);
            //DateTime date = DateTime.Now;
            //Console.WriteLine(date);
            #endregion
            //        StringList list = new StringList();
            //        list.Add("Qosqar");
            //        list.Add("Ramil");
            //        list.Add("Resul");

            //        list.GetAll();

            //    }
            //}


            //public class StringList
            //{
            //    private string[] _arr;
            //    public StringList()
            //    {
            //        _arr = new string[0];
            //    }

            //  public void Add(string str)
            //    {
            //        Array.Resize(ref _arr,_arr.Length+1);
            //        _arr[_arr.Length - 1] = str;
            //    }

            //    public void GetAll()
            //    {
            //        for(int i = 0; i < _arr.Length; i++)
            //        {
            //            Console.WriteLine(_arr[i]);
            //        }
            //    }


            //DataList<string> names = new DataList<string>();
            //names.Add("Gultaj");
            //names.Add("dddd");

            //Repository<int> number = new Repository<int>();
            //Repository<double> numbers = new Repository<double>();
            //Repository<string> name = new Repository<string>();
            //Repository<Student,Person> stundents = new Repository<Student, Person>();
            //Repository<Employee> employee = new Repository<Employee>();

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddDays(10);
            Console.WriteLine($"{start} - {end}");
            //GetProductbyDate(start, end);

        }
        //public static void GetProductbyDate(DateTime start, DateTime end)
        //{
        //    if (start > end)
        //    {
        //        Console.WriteLine("yes");
        //    }
        //    else
        //    {
        //        Console.WriteLine("no");
        //    }
            #region Manat
        class Dollar
        {
            public double USD { get; set; }
            public Dollar(double usd)
            {
                USD = usd;
            }
        }

        class Manat
        {
            public double AZN { get; set; }
            public Manat(double azn)
            {
                AZN = azn;
            }


            public static implicit operator Dollar(Manat manat)
            {

                return new Dollar(manat.AZN / 1.7);
            }
        }
        #endregion
    }


        public class DataList<T>
        {
            private T[] _datas;
            public DataList()
            {
                _datas = new T[0];
            }
            public void Add(T data)
            {
                Array.Resize(ref _datas, _datas.Length + 1);
                _datas[_datas.Length - 1] = data;
            }

            public void GetAll()
            {
                foreach (var item in _datas)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }

