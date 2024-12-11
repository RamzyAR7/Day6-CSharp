using System;

namespace Day6_CSharp
{
    struct Point1
    {
        int x;
        int y;

        public Point1(int x, int y)
        {
            this.x = x;
            this.y = y;
        } 
        public override string ToString()
        {
            return $"the value of X = {x} and value of y = {y}";
        }
    }
    class TypeA
    {
        private int F; // filed
        private int G;
        private int H;

        public TypeA(int F, int G, int H)
        {
            this.F = F;
            this.G = G;
            this.H = H;
        }

        public int f // property
        {
            get { return F; }
            set { F = value; }
        }
        public int g // property
        {
            get { return G; }
            set { G = value; }
        }

        public int h // property
        {
            get { return H; }
            set { H = value; }
        }
    }
    struct Employee
    {
        private int Emp_Id;
        private string Name;
        private double Salary;

        public Employee(int Emp_Id, string Name, double Salary)
        {
            this.Emp_Id = Emp_Id;
            this.Name = Name;
            this.Salary = Salary;
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string value)
        {
            Name = value;
        }

        public int emp_id
        {
            get { return Emp_Id; }
            set { Emp_Id = value; }
        }
        public double salary
        {
            get { return Salary; }
            set { Salary = value; }
        }
    }

    struct Point2
    {
        int X;
        int Y;

        public Point2(int X)
        {
            this.X = X;
            Y = 0;
        }

        public Point2(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Print()
        {
            Console.WriteLine($"Point(X: {X}, Y: {Y})");
        }

        public override string ToString()
        {
            return $"Point(X: {X}, Y: {Y})";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 01
            //Point1 P1 = new Point1(2, 3);
            //Console.WriteLine(P1);

            /**
             *  Why can't a struct inherit from another struct or class in C#?
             *  
             *  Structs in C# can't inherit from other structs or classes
             *  because they are value types designed for efficiency and simplicity.
             *  Inheritance would add complexity, require polymorphism, and disrupt their fixed memory layout and copying semantics.
             */
            #endregion

            #region Problem 02
            //TypeA T1 = new TypeA(1, 2, 3);
            //Console.WriteLine(T1.f);
            //Console.WriteLine(T1.g);
            //Console.WriteLine(T1.h);
            //T1.f = 88;
            //Console.WriteLine(T1.f);

            /**
             *  How do access modifiers impact the scope and visibility of a class member? 
             *  
             *  Private: Accessible only within the same class.
             *  
             *  Protected:
             *   Accessible in the same class and derived classes.
             *   Enables inheritance while keeping details hidden from others.
             *   
             *  Public:
             *   Accessible everywhere.
             *   Used for APIs and widely usable members.
             *   
             *  Internal:
             *   Accessible within the same assembly.
             *   Good for components that shouldn't be exposed outside.
             *   
             *  Protected Internal:
             *   Accessible in derived classes or the same assembly.
             *   Combines protected and internal.
             *   
             *  Private Protected:
             *    Accessible in the same class or derived classes in the same assembly.
             *    Tighter control than protected internal.
             */
            #endregion

            #region Problem 03
            //Employee employee = new Employee(1, "Ahmed", 5000.00);

            //Console.WriteLine("Original Name: " + employee.GetName());
            //employee.SetName("Youssef");
            //Console.WriteLine("Updated Name: " + employee.GetName());

            //Console.WriteLine("Employee ID: " + employee.emp_id);
            //employee.emp_id = 2;
            //Console.WriteLine("Updated Employee ID: " + employee.emp_id);

            //Console.WriteLine("Original Salary: " + employee.salary);
            //employee.salary = 6000.00;
            //Console.WriteLine("Updated Salary: " + employee.salary);

            /**
             * Why is encapsulation critical in software design? 
             * 
             * Protects Data: Prevents unauthorized access and modifications by restricting direct access to class members.
             * Improves Maintainability: Allows changes to implementation without affecting external code.
             * Enhances Reusability: Encapsulated components are modular and easier to reuse.
             * Supports Abstraction: Hides complexity, exposing only what is necessary.
             * Promotes Security: Reduces the risk of unintended interactions and errors.
             */

            #endregion

            #region Problem 04
            //Point2 p1 = new Point2(5);
            //p1.Print();
            //Point2 p2 = new Point2(6, 7);
            //p2.Print();

            /**
             * what is constructors in structs?
             * 
             * constructors in structs are special methods used to initialize new instances of a struct.
             * They allow you to set the initial values of the struct's fields when an object is created.
             * Unlike classes, structs don't have a default constructor
             * 
             */
            #endregion

            #region Problem 05
            //Point2 p1 = new Point2(5);
            //Console.WriteLine(p1);
            //Point2 p2 = new Point2(6, 7);
            //Console.WriteLine(p2);

            /**
             *  How does overriding methods like ToString() improve code readability?
             *  
             *  Overriding methods like ToString() in C# improves code readability by providing a custom,
             *  human-readable string representation of an object. Instead of the default output (e.g., type name or memory address),
             *  you can format the output to show meaningful data, making the code easier to understand when logging, debugging,
             *  or displaying object information.
             *  
             *  
             */
            #endregion
        }
    }
}
