using System;
using System.Collections.Generic;
using System.Text;

namespace Outros.Object_Pool
{
    class ClientMain
    {
        public /*static*/ void Main(string[] args)
        {
            ObjectPool<Livro> objPool = new ObjectPool<Livro>();
            Livro obj1 = objPool.Get();          
            objPool.Release(obj1);
            Livro obj2 = objPool.Get();
            Livro obj3 = objPool.Get();
            Livro obj4 = objPool.Get();
            objPool.Release(obj3);
            objPool.Release(obj3);
            Livro obj5 = objPool.Get();


            #region exemplo um pouquinho mais complexos
            Console.WriteLine("----------------------- Reservado");

            var listaDevolver = new List<Livro>();
            for (int i = 0; i < 12; i++)
            {
                listaDevolver.Add(objPool.Get());
            }
            Console.WriteLine("----------------------- Devolvendo");
            foreach (var item in listaDevolver)
            {
                objPool.Release(item);
            }
            Console.WriteLine("-----------------------Reservando");
            for (int i = 0; i < 10; i++)
            {
                listaDevolver.Add(objPool.Get());
            }
            #endregion
            Console.Read();
        }
    }
}
