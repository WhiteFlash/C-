using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDate.Classes
{
    /// <summary>
    ///             TASK
    /// Даны положительные действительные числа a, b,c. 
    /// Выяснить, существует ли треугольник с длинами сторон a, b,c. 
    /// Если существует, определить его тип по углам (остроугольный, прямоугольный, тупоугольный).
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// 3 fields that descripe variables
        /// </summary>
        private int a;
        private int b;
        private int c;

        /// <summary>
        /// 3 properties that set and get the values.
        /// Before set the value it has to be greater then 0.
        /// </summary>
        public int A 
        { 
            get => this.a;            
            set 
            { 
                if(value <= 0)
                {
                    throw new Exception($"Value for the side can not be 0 or less. Your value {value}");
                }
                this.a = value;
            } 
        }
        public int B 
        {
            get => this.b;
            set
            {
                if (value <= 0)
                {
                    throw new Exception($"Value for the side can not be 0 or less. Your value {value}");
                }
                this.b = value;
            }
        }
        public int C 
        {
            get => this.c;
            set
            {
                if (value <= 0)
                {
                    throw new Exception($"Value for the side can not be 0 or less. Your value {value}");
                }
                this.c = value;
            }
        }

        /// <summary>
        /// Function check if the triengle exists.
        /// If yes then return true.
        /// </summary>
        /// <returns></returns>
        public bool CheckExisting()
        {
            bool flag = false;
            if(this.A + this.B > this.C)
            {
                return true;
            }
            else if(this.B + this.C > this.A)
            {
                return true;
            }
            else if (this.A + this.C > this.B)
            {
                return true;
            }
            return flag;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Triangle() { }

        /// <summary>
        /// Initialize fields on when the object is created
        /// </summary>        
        public Triangle(int side1, int side2, int side3)
        {
            this.a = side1;
            this.b = side2;
            this.c = side3;
        }

        /// <summary>
        /// Define type of the triangle.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public string GetToKnowType(int a, int b, int c)
        {            
            a = Convert.ToInt32(Math.Pow(a, 2));
            b = Convert.ToInt32(Math.Pow(b, 2));
            c = Convert.ToInt32(Math.Pow(c, 2));

            if(c == a + b)
            {
                return "Right-angled";
            }
            else if(c > a + b)
            {
                return "Obtuse triangle";
            }
            return "Actual triangle";
        }

        /// <summary>
        /// Function that sorts numbers in order from lowest to highest.
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public int[] CheckNumber(int side1, int side2, int side3)
        {
            int[] matrix = { side1, side2, side3 };
            Array.Sort(matrix);
            return matrix;
        }

        /// <summary>
        /// Method where all the logic is contained.
        /// In the main program it has to be called in order to use the program.
        /// </summary>
        public static async Task ExecuteProgram()
        {
            int count = 0;
            while (count <= 10)
            {

                Console.WriteLine("This program can tell if the triangle exists and if so will tell the type");
                var triengle = new Triangle();
                Console.WriteLine("Please provide side's length");
                triengle.A = int.Parse(Console.ReadLine());
                triengle.B = int.Parse(Console.ReadLine());
                triengle.C = int.Parse(Console.ReadLine());

                bool checkTask = triengle.CheckExisting();
                bool exists = checkTask;

                if (exists)
                {
                    Console.WriteLine("Triangle exists");
                    string message = triengle.GetToKnowType(triengle.A, triengle.B, triengle.C);
                    Console.WriteLine($"Type is {message}");
                }
                else
                    Console.WriteLine("Triengle does not exists");
                count++;
            }
        }
    }
}
