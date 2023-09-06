using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            point point = new point(7, 11);
            Circle circle = new Circle(22,8,3.5);
            Cylinder cylinder = new Cylinder(10, 10, 3.3, 10);
            Shape[] arrayOfshapes = new Shape[3];
            arrayOfshapes[0] = point;
            arrayOfshapes[1] = circle;
            arrayOfshapes[2] = cylinder;
            Console.WriteLine(point.Name+" : "+point+"\n"+circle.Name+" : "+circle+"\n"+cylinder.Name+" : "+cylinder+"\n");
            foreach(Shape shape in arrayOfshapes)
            {
                Console.WriteLine("\n\n"+shape.Name+" : "+shape+"\narea = "+ shape.area().ToString("F")+"\nvolume = "+shape.volume().ToString("F"));
            }
            //DerivedClass d = new DerivedClass();
            //BaseClass c = new BaseClass();
            //Console.WriteLine(d.display());
            //Console.WriteLine("\n"+ c.display());
            //Console.WriteLine("\n"+d.show());
            //Console.WriteLine("\n"+c.show());
            //c = d;
            //Console.WriteLine("\nPolymorphism : " + c.show());
            //Console.WriteLine("\nNon polymorphism :"+c.display());
            //EmployeeService emp = new EmployeeService();
            //emp.EmpNum = 100;
            //emp.EmpSal = 5000000;
            //emp.EmpReg = 2;
            //Console.WriteLine("Service Employee information : \n");
            //Console.WriteLine("number is : "+emp.EmpNum.ToString()+"\n");
            //Console.WriteLine("Salary is : "+ emp.EmpSal.ToString()+"\n");
            //Console.WriteLine("Region is : "+ emp.EmpReg.ToString());
            Console.ReadKey();
        }
    }
}
