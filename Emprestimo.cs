public class Emprestimo
{
    private Aluno _aluno = null!;
    private Livro _livro = null!;
    private DateOnly _dataEmprestimo;
    private DateOnly _dataPrevistaDevolucao;
    private DateOnly? _dataDevolucao;

    public Aluno Aluno
    {
        get => _aluno;
        set => _aluno = value ?? throw new ArgumentException("O empréstimo precisa possuir um aluno.");
    }

    public Livro Livro
    {
        get => _livro;
        set => _livro = value ?? throw new ArgumentException("O empréstimo precisa possuir um livro.");
    }

    public DateOnly DataEmprestimo
    {
        get => _dataEmprestimo;
        private set => _dataEmprestimo = value;
    }

    public DateOnly DataPrevistaDevolucao
    {
        get => _dataPrevistaDevolucao;
        private set
        {
            if (value < DataEmprestimo)
            {
                throw new ArgumentException("A data prevista não pode ser anterior ao empréstimo.");
            }
            _dataPrevistaDevolucao = value;
        }
    }

    public DateOnly? DataDevolucao
    {
        get => _dataDevolucao;
        private set => _dataDevolucao = value;
    }

    public Emprestimo(Aluno aluno, Livro livro, DateOnly dataEmprestimo, DateOnly dataPrevistaDevolucao)
    {
        DataEmprestimo = dataEmprestimo;
        DataPrevistaDevolucao = dataPrevistaDevolucao; // Atribuído antes para validação correta
        Aluno = aluno;
        Livro = livro;
        DataDevolucao = null;
    }

    public void RegistrarDevolucao(DateOnly dataDevolucao)
    {
        if (DataDevolucao != null)
        {
            throw new InvalidOperationException("Este livro já foi devolvido anteriormente.");
        }

        if (dataDevolucao < DataEmprestimo)
        {
            throw new ArgumentException("A data de devolução não pode ser anterior à data do empréstimo.");
        }

        DataDevolucao = dataDevolucao;
    }



    public bool EstaAtrasado()
    {
        DateOnly dataComparacao = DataDevolucao != null ? DataDevolucao.Value : DateOnly.FromDateTime(DateTime.Now);
        return dataComparacao > DataPrevistaDevolucao;
    }

    public int CalcularDiasAtraso()
    {
        DateOnly dataComparacao = DataDevolucao != null ? DataDevolucao.Value : DateOnly.FromDateTime(DateTime.Now);

        if (dataComparacao <= DataPrevistaDevolucao)
        {
            return 0;
        }

        return dataComparacao.DayNumber - DataPrevistaDevolucao.DayNumber;
    }

    public decimal CalcularMulta()
    {
        const decimal VALOR_MULTA_DIA = 2.50m;
        int diasAtraso = CalcularDiasAtraso();
        return diasAtraso * VALOR_MULTA_DIA;
    }

    public void ExibirResumo()
    {
        Console.WriteLine("===== EMPRÉSTIMO =====");
        Console.WriteLine($"Aluno: {Aluno.Nome}");
        Console.WriteLine($"Matrícula: {Aluno.Matricula}");
        Console.WriteLine($"Livro: {Livro.Titulo}");
        Console.WriteLine($"Autor: {Livro.Autor}");
        Console.WriteLine($"Data do empréstimo: {DataEmprestimo:dd/MM/yyyy}");
        Console.WriteLine($"Devolução prevista: {DataPrevistaDevolucao:dd/MM/yyyy}");

        if (DataDevolucao != null)
        {
            Console.WriteLine($"Devolvido em: {DataDevolucao.Value:dd/MM/yyyy}");
        }
        else
        {
            Console.WriteLine("Situação: livro ainda não devolvido.");
        }

        Console.WriteLine($"Está atrasado: {(EstaAtrasado() ? "Sim" : "Não")}");
        Console.WriteLine($"Dias de atraso: {CalcularDiasAtraso()}");
        Console.WriteLine($"Multa: R$ {CalcularMulta():F2}");
    }
}
