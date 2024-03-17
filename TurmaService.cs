using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{
    public class TurmaService
    {

        private List<Turma> turmas;


        public TurmaService()
        {
            turmas = new List<Turma>();
        }

        public string AddAluno(Turma turma, Aluno aluno)
        {
            if (turma.Alunos.Count >= 10)
            {
                return $"O Aluno {aluno.Nome} não pode ser adicionado, pois a Turma está cheia";
            }

            turma.Alunos.Add(aluno);
            return "Aluno adicionado";
        }

        public string AbrirTurma(Turma turma)
        {
            if (turma.Alunos.Count < 2)
            {
                return "A turma deve ter pelo menos 2 alunos para ser aberta.";
            }
            else if (turma.Alunos.Count > 10)
            {
                return "A turma não pode ter mais de 10 alunos.";
            }
            else
            {
                // A turma pode ser aberta com sucesso
                return "Turma aberta com sucesso.";
            }
        }

        public string GerarPauta(Turma turma)
        {
            string pauta = $"Turma: {turma.Codigo}\nDisciplina: {turma.Disciplina.Nome}\nProfessor: {turma.Professor.Nome}\nAlunos:\n";
            foreach (var aluno in turma.Alunos)
            {
                pauta += $"- {aluno.Nome}\n";
            }
            return pauta;
        }

        public string RemoveAlunoPorMatricula(Turma turma, int matricula)
        {
            var aluno = turma.Alunos.FirstOrDefault(a => a.Matricula == matricula);
            if (aluno != null)
            {
                return RemoveAluno(turma, aluno);
            }

            return $"Aluno com matrícula {matricula} não encontrado na turma.";
        }

        public string RemoveAlunoPorNome(Turma turma, string nome)
        {
            var aluno = turma.Alunos.FirstOrDefault(a => a.Nome == nome);
            if (aluno != null)
            {
                return RemoveAluno(turma, aluno);
            }

            return $"Aluno com nome {nome} não encontrado na turma.";
        }

        private string RemoveAluno(Turma turma, Aluno aluno)
        {
            turma.Alunos.Remove(aluno);
            if (turma.Alunos.Count < 2)
            {
                return $"Aluno {aluno.Nome} removido. A turma foi encerrada por ter menos de 2 alunos.";
            }
            return $"Aluno {aluno.Nome} removido com sucesso.";
        }

        public void AddTurma(Turma turma)
        {
            turmas.Add(turma);
        }
    }
}
