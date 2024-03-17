using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaAcademico
{
    public class Turma
    {
        public string Codigo { get; private set; }
        public Professor Professor { get; private set; }
        public Disciplina Disciplina { get; private set; }
        public List<Aluno> Alunos { get; private set; }

        public Turma(string codigo, Professor professor, Disciplina disciplina)
        {
            Codigo = codigo;
            Professor = professor;
            Disciplina = disciplina;
            Alunos = new List<Aluno>();
        }
    }
}
