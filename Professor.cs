using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{
    public class Professor
    {
        public int Matricula { get; private set; }
        public string Nome { get; private set; }

        public Professor(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Matrícula: {Matricula}, Nome: {Nome}";
        }
    }
}
