using System;

namespace TestConsoleAPP
{
    public enum Employees
    {
        emp1 = 2,
        emp3 = 12,
        emp4 = 3,
        emp5 = 23
    }
    public class Program
    {
        public static void Main()
        {
            Store store = new Store("store1");
            store.AddArticle(new Article("article1", 23));
            store.AddArticle(new Article("article2", 45));
            store.AddArticle(new Article("article3", 24));
            Console.WriteLine(store["article1"]);
            Console.WriteLine(store["article2"]);
            Console.WriteLine(store["article3"]);
            Console.WriteLine("================================================");
            int[] arr = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1,12,13,-4 };
            arr.Sort();
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=================================================");
            MyClass c = new MyClass();
            MyStruct s = new MyStruct();
            ClassTaker(c);
            StructTaker(s);
            Console.WriteLine(c.Change + " changed:Reference type");
            Console.WriteLine(s.Change + "{null} not changed:Value type");
            Console.WriteLine("===================================================");
            StaticClassWithPrint.Print("Nice", 2);
            StaticClassWithPrint.Print("Nice", 3);
            StaticClassWithPrint.Print("Nice", 4);
            Console.WriteLine("====================================================");
            Console.WriteLine(Ccauntant.AskForBonus(Employees.emp1, 3));
            Console.WriteLine("====================================================");
            Func<decimal, decimal, decimal> Add = (n1, n2) => n1 + n2;
            Func<decimal, decimal, decimal> Sub = (n1, n2) => n1 - n2;
            Func<decimal, decimal, decimal> Mul = (n1, n2) => n1 * n2;
            Func<decimal, decimal, decimal> Div = (n1, n2) =>
            {
                if (n2 == 0) return 0;
                return n1 / n2;
            };
            ExecuteOperation(Add,2,3);
            ExecuteOperation(Sub,2,3);
            ExecuteOperation(Mul,2,3);
            ExecuteOperation(Div,2,3);
            ExecuteOperation(Div,2,0);//0
            Console.WriteLine("====================================================");
            Func<Func<int>[], decimal> x = (Func<int>[] delegatesArr) =>
            {
                if (delegatesArr.Length == 0) throw new Exception("empty delegates arr");
                return delegatesArr.Sum(d => d.Invoke()) / (decimal)delegatesArr.Length;
            };
            Func<int>[] delArr = new Func<int>[] { () => 3, () => 4, () => 5, () => 1, () => 2 };
            Console.WriteLine(x.Invoke(delArr));
            Console.WriteLine(x.Invoke(new Func<int>[0]));//exception
        }
        public static void ExecuteOperation(Func<decimal,decimal,decimal> func, decimal param1, decimal param2)
        {
            Console.WriteLine(func(param1,param2));
        }
        public static void ClassTaker(MyClass x)
        {
            x.Change = "changed";
        }
        public static void StructTaker(MyStruct x)
        {
            x.Change = "changed";
        }
    }
}