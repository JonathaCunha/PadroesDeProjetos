using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Outros.Object_Pool
{
    public class ObjectPool<T> where T : Livro, new()
    {
        private readonly ConcurrentBag<T> items = new ConcurrentBag<T>();
        private int MAX = 10;
        public void Release(T item)
        {
            if (items.Count(m => !m.EstaEmprestado) < MAX)
            {
                if (!item.EstaEmprestado)
                    Console.WriteLine(item.Nome + " Já consta devolvido");
                else
                {
                    item.EstaEmprestado = false;
                    Console.WriteLine($"{item.Nome} : Devolvido, {item.DescricaoSituacao} ");
                }
              
            }
            else
            {
                Console.WriteLine($"{item.Nome} : Não devolvido");
            }
        }
        int genereitonCriacao = 1;
        public T Get()
        {
            T item = items.FirstOrDefault(m => !m.EstaEmprestado);
            if (item == null)
            { 
                item = new T();
                item.Nome = "Livro" + genereitonCriacao++;
                items.Add(item);          
            }
            item.EstaEmprestado = true;
            Console.WriteLine($"{item.Nome} : Emprestado");
            return item;
        }
    }
}
