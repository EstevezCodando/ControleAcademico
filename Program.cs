using SistemaAcademico;

public class Program
{
    public static void Main(string[] args)
    {
        var turmaService = new TurmaService();
        var professor = new Professor(1, "Luiz Paulo");
        var disciplina = new Disciplina(101, "Desenvolvimento em C");
        var turma = new Turma("Engenharia de Software", professor, disciplina);

        turmaService.AddTurma(turma);

        // Adicionando alunos
        turmaService.AddAluno(turma, new Aluno(201, "Jean Michael"));
        turmaService.AddAluno(turma, new Aluno(202, "Mauricio Mikovisk"));
        turmaService.AddAluno(turma, new Aluno(202, "Josue Eu"));
        turmaService.AddAluno(turma, new Aluno(202, "Galeguinho do Coque"));
        turmaService.AddAluno(turma, new Aluno(202, "Heitor Runar"));
        turmaService.AddAluno(turma, new Aluno(202, "Hermes Mitzu"));
        turmaService.AddAluno(turma, new Aluno(202, "Magti Mirtz"));
        turmaService.AddAluno(turma, new Aluno(202, "Moacir Moar"));
        turmaService.AddAluno(turma, new Aluno(202, "Carananga Caranaua"));
        turmaService.AddAluno(turma, new Aluno(202, "Nefestos Sulib"));
        turmaService.AddAluno(turma, new Aluno(202, "Romiro Ruan"));
       
        // Abrindo a turma 
        Console.WriteLine(turmaService.AbrirTurma(turma));

        // Gerar pauta
        var pauta = turmaService.GerarPauta(turma);
        Console.WriteLine(pauta);

        // Tentar adicionar mais um aluno na turma já com 10 alunos
        var respostaAddAluno = turmaService.AddAluno(turma, new Aluno(202, "Rafa Suares"));
        Console.WriteLine(respostaAddAluno);

        // Removendo um aluno por matrícula e verificando o status da turma
        Console.WriteLine(turmaService.RemoveAlunoPorMatricula(turma, 201));

        // Removendo outro aluno por nome e verificando o status da turma
        Console.WriteLine(turmaService.RemoveAlunoPorNome(turma, "Maracatu Atomico"));

        // Gerar pauta após remoção para verificar o estado da turma
        pauta = turmaService.GerarPauta(turma);
        Console.WriteLine(pauta);
        
    }
}