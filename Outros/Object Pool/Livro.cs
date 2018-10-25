using System;
using System.Collections.Generic;
using System.Text;

namespace Outros.Object_Pool
{
    public class Livro
    {
        public string Nome { get; set; }
        public bool EstaEmprestado { get; set; }
        public string DescricaoSituacao { get { return EstaEmprestado ? "Emprestado" : "Disponivel"; } }

    }
}
