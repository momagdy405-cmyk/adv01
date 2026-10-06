using System.Buffers.Text;
using System.Security.Cryptography.X509Certificates;

namespace adv01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generic is a feature of C# that allows you to create classes, methods, and data structures that can work with any data type. This means that you can create a single class or method that can be used with different types of data, without having to write separate code for each type.
            //we use generics to create a method that can work with any data type
            //the multipletype parameter is a feature of C# that allows you to create a method that can work with multiple data types. This means that you can create a single method that can be used with different types of data, without having to write separate code for each type.
            //the generic interface is using <t> to work with any datatype
            int x = 5;
            int y = 9;
            swap<int>(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);


            int j = 90;
            string s = "ss";
            pair<int, string> p = new pair<int, string>(j, s);
            Console.WriteLine($"{p.First} {p.Second}");


            int u = 80;
            Container<int> c = new Container<int>();
            c.add(u);
            Console.WriteLine(c.get());


            int[] numbers = { 1, 2, 3, 4 };
            Console.WriteLine(findmax<int>(numbers));


            
            safelist<int> lt = new safelist<int> ();
            lt.get(5);

            IEnumerable<dog> dg = new doger();
            IEnumerable<animal> an = dg;

            Iconsumer<animal> ani = new animaler();
            Iconsumer<dog> dgg = ani;




        }
        internal class Container<T>
        {
            private T item;

            public void add(T item)
            {
                this.item = item;
            }
            public T get()
            {
                return item;
            }
        }

        public class pair<Tkey, Tvalue>
        {
            public pair(Tkey first, Tvalue second)
            {
                First = first;
                Second = second;
            }
            public Tkey First { get; set; }
            public Tvalue Second { get; set; }
        }

        public static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static T findmax<T>(T[] item) where T : IComparable
        {
            T maxi = item[0];
            for (int i = 0; i < item.Length; i++)
            {
                if (item[i].CompareTo(maxi) > 0)
                {
                    maxi = item[i];
                }
            }
            return maxi;
        }

        public interface Ireposatory<T>
        {
            void add(T item);
            T get(T id);
        }
        public static void hamada<T>(T item) where T : struct
        {

        }
        public static void amada<T>(T item)where T : class
        {

        }
        public static void mada<T>(T item) where T : new()
        {

        }
        public static void ada<T>(T item) where T : Ireposatory<T>
        {

        }
        public class Base
        {

        }

        public static void da<T>(T item) where T :Base
        {

        }

        public class megoz<T>where T:Ireposatory<T>,ICloneable
        {

        }
        public class safelist<T> 
        {
            T[] items;
            public T get(int index)
            {
                if (index < 0 || index > items.Length)
                {
                    return default;
                }
                return items[index];
            }
        }
        //convariance:allows generic type with derived to work with base..out
        //contravarense:allows generic type with base to accept the derived..in
        interface IEnumerable<out T>{
            T get();
        }
        interface Iconsumer<in T> {
            void add(T item);
        }
        public class dog :animal
        { 
        }
        public class animal { }

        public class doger : IEnumerable<dog>
        { 
            public dog get()
            {
                return new dog();
            }
        }
        public class animaler : Iconsumer<animal>
        {
            public void add(animal item)
            {
                Console.WriteLine("---------");
            }
        }
         public class geni<T>
        {
            static int k;
        }
        public class geno<T> : geni<T> { static int v; }


       







    }
}

    
