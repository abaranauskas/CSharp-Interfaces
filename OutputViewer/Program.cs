using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            var standardCatalog = new StandardCatalog();
            ISaveable savable = new StandardCatalog();
            IPersistable persistable = new StandardCatalog();

            

            Console.WriteLine("Standard Implementation\n");
            Console.WriteLine($"Concrete Class: {standardCatalog.Save()}");
            Console.WriteLine($"ISaveable: {savable.Save()}");
            Console.WriteLine($"IPersistable: {persistable.Save()}");
            Console.WriteLine();

            Console.WriteLine($"Concrete Class: {standardCatalog.Save()}");
            Console.WriteLine($"(ISaveable)standardCatalog: {((ISaveable)standardCatalog).Save()}");
            Console.WriteLine($"(IPersistable)standardCatalog: {((IPersistable)standardCatalog).Save()}");
            Console.WriteLine("------------------------------------------------------");

            
            var explicitCatalog = new ExplicitCatalog();
            savable = new ExplicitCatalog();
            persistable = new ExplicitCatalog();

            Console.WriteLine("Explicit Implementation\n");
            Console.WriteLine($"Concrete Class: {explicitCatalog.Save()}");
            Console.WriteLine($"ISaveable: {savable.Save()}");
            Console.WriteLine($"IPersistable: {persistable.Save()}");
            Console.WriteLine();
            Console.WriteLine($"Concrete Class: {explicitCatalog.Save()}");
            Console.WriteLine($"(ISaveable)standardCatalog: {((ISaveable)explicitCatalog).Save()}");
            Console.WriteLine($"(IPersistable)standardCatalog: {((IPersistable)explicitCatalog).Save()}");

        }
    }
}
