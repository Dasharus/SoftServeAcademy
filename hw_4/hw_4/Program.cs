using System;
using System.Collections;

namespace hw_4
{
    interface IFlyable
    {
        void Fly()
        {
            Console.WriteLine("Fly method is called");
        }
    }

    interface IPhone
    {
        void Info() { }

    }

    class MobilePhone : IPhone, IComparable<MobilePhone>
    {
        protected string name;
        protected double price;

        public MobilePhone(string n, double pr)
        {
            name = n;
            price = pr;
        }

        public void Info()
        {
            Console.WriteLine($"name:{name}, price:{price}");
        }

        public double Price { get; set; }

        public int CompareTo(MobilePhone other)
        {
            return this.price.CompareTo(other.price);
        }

    }

    class RadioPhone : IPhone, IComparable<RadioPhone>
    {
        protected string name;
        protected bool autoAnswer;
        protected double price;

        public RadioPhone(string n, bool a, double pr)
        {
            name = n;
            autoAnswer = a;
            price = pr;
        }

        public double Price { get; set; }

        public void Info()
        {
            Console.WriteLine($"name:{name}, auto answer:{autoAnswer.ToString()}, price:{price}");
        }
        public int CompareTo(RadioPhone other)
        {
            return this.price.CompareTo(other.price);
        }
    }


    class Bird : IFlyable
    {
        public string name;
        public bool canFly;

        public Bird(string n, bool c)
        {
            name = n;
            canFly = c;
        }
    }

    class Plane : IFlyable
    {
        public string mark;
        public bool highFly;

        public Plane(string m, bool h)
        {
            mark = m;
            highFly = h;
        }
    }


    interface IDeveloper
    {
        string Tool { get; set; }
        void Create()
        {
            Console.WriteLine("Create method is called");
        }
        void Destroy()
        {
            Console.WriteLine("Dstroy method is called");
        }

    }
    class Programmer : IDeveloper, IComparable<Programmer>
    {
        public string language;

        public string Tool { get; set; }

        public Programmer(string l, string t)
        {
            language = l;
            Tool = t;
        }

        public int CompareTo(Programmer p)
        {
            return this.Tool.CompareTo(p.Tool);
        }
    }

    class Builder : IDeveloper, IComparable<Builder>
    {
        public string Tool { get; set; }
        public Builder(string t)
        {
            Tool = t;
        }

        public int CompareTo(Builder b)
        {
            return this.Tool.CompareTo(b.Tool);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            IPhone[] phone_arr = { new MobilePhone("mobile phone1", 1200),
                new MobilePhone("mobile phone 2", 1300),
                new RadioPhone("radio phone1", true, 1000) };

            Console.WriteLine("After sorting by price");
            //Array.Sort(phone_arr);
            foreach(var item in phone_arr)
            {
                item.Info();
            }


            ArrayList ifly_arr = new ArrayList()
            {
                new Bird("bird1", true),
                new Bird("bird2", false),
                new Plane("mark1",false),
                new Plane("mark2",true)
            };


            foreach (IFlyable item in ifly_arr)
            {
                item.Fly();
            }

            var idev_arr = new IDeveloper[]
            {
                new Programmer("english","btoool"),
                new Programmer("c sharp","atool"),
                new Builder("tool1"),
            };

            foreach (var item in idev_arr)
            {
                item.Create();
                item.Destroy();
            }
            foreach (var item in idev_arr)
            {
                Console.WriteLine(item.Tool);
            }


            //Array.Sort(idev_arr);
            //foreach (var item in idev_arr)
            //{
            //    Console.WriteLine(item.Tool);
            //}


        }
    }
}
