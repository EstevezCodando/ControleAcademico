using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{
    public class Disciplina
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }

        public Disciplina(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Nome: {Nome}";
        }
    }
}
