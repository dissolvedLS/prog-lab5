using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab5
{

    // класс А
    class A 
    {
        protected int a, b; // поля

        public int C // властивість
        {
            get { return a + b; }
            set { a = value; b = value; }
        }
        
        public A() // конструктор без параметров
        {
            a = 0;
            b = 0;
        }
        public A(int a, int b) // конструктор с параметрами
        {
            this.a = a;
            this.b = b;
        }
        public int M2() // свойство
        {
            return a * b;
        }
    }


    // класс Б
    class B : A 
    {
        private float d;

        public float C2
        {
            get { return d != 0 ? (a + b) / d : 0; } // управляющий оператор  "if else"
            set { a = (int)value; b = (int)value; d = value; }
        }

        public B() // конструктор без параметров (не наследуется)
        {
            a = 0;
            b = 0;
            d = 0;
        }

        public B(int a, int b, int d) : base (a, b) // конструктор с параметрами (наследуется)
        {
            this.d = d;
        }    
    }


    // класс Program
    class Program
    {
        static void Main(string[] args)
        {
            A objA1 = new A();
            Console.WriteLine( "A()         C= " + objA1.C);

            A objA2 = new A(3, 5);
            Console.WriteLine("A(3,5)      C= " + objA2.C);

            B objB1 = new B();
            Console.WriteLine("B()         C= " + objB1.C);

            B objB2 = new B(6, 7, 2);
            Console.WriteLine("B(6, 8, 2)  C= " + objB2.C2);
        }
    }
}
