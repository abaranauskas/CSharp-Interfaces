using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class StandardCatalog: ISaveable, IPersistable
    {
        public void Load()
        {

        }

        public string Save()
        {
            return "Catalog saved!";
        }
               
    }

    public class ExplicitCatalog : ISaveable, IPersistable
    {

        public string Save()
        {
            return "Catalog saved!";
        }
        

        string ISaveable.Save()
        {
            return "ISaveable Save!";
        }
        //Negalima prideti access modifyer public private

        string IPersistable.Save()
        {
            return "IPersistable Save!";
        }
        //Negalima prideti access modifyer public private
    }

    public class Catalog : ISaveable, IVoidSaveable
    {
        string ISaveable.Save()
        {
            throw new NotImplementedException();
        }

        void IVoidSaveable.Save()
        {
            throw new NotImplementedException();
        }
    }

    public class EnumerableCatalog : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            //kai negeneriniam returninam i sita metoda
            //tada visa koda galima rasyti cia

            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
