Aluno aluno1 = new Aluno(
    "Arthur Morgan",
    "AL000001"
);

Livro livro1 = new Livro(
    "Código Limpo",
    "Robert C. Martin"
);

//Emprestimo emprestimo1 = new Emprestimo( aluno1,livro1, new DateOnly(2026, 10, 1), new DateOnly(2026, 10, 8));

//Emprestimo emprestimo3 = new Emprestimo(aluno1, null!, new DateOnly(2026, 10, 1), new DateOnly(2026, 10, 8));

//Emprestimo emprestimo4 = new Emprestimo(aluno1, livro1, new DateOnly(2026, 10, 10), new DateOnly(2026, 10, 5));

//emprestimo4.ExibirResumo();

/*Emprestimo emprestimo5 = new Emprestimo(aluno1, livro1, new DateOnly(2026, 10, 1), new DateOnly(2026, 10, 10));

emprestimo5.RegistrarDevolucao(new DateOnly(2026, 10, 5));

emprestimo5.ExibirResumo(); */

/*Emprestimo emprestimo6 = new Emprestimo(aluno1, livro1, new DateOnly(2026, 10, 1), new DateOnly(2026, 10, 10));

emprestimo6.RegistrarDevolucao(new DateOnly(2026, 10, 10));

emprestimo6.ExibirResumo();*/

/*Emprestimo emprestimo7 = new Emprestimo(aluno1, livro1, new DateOnly(2026, 10, 1), new DateOnly(2026, 10, 8));

emprestimo7.RegistrarDevolucao(new DateOnly(2026, 10, 12));

emprestimo7.ExibirResumo();*/

/*Emprestimo emprestimo8 = new Emprestimo(aluno1, livro1, new DateOnly(2026, 10, 5), new DateOnly(2026, 10, 12));

emprestimo8.RegistrarDevolucao(new DateOnly(2026, 10, 3));*/

/*Emprestimo emprestimo9 = new Emprestimo(aluno1, livro1, new DateOnly(2026, 10, 1), new DateOnly(2026, 10, 8));

emprestimo9.RegistrarDevolucao(new DateOnly(2026, 10, 7));

emprestimo9.RegistrarDevolucao(new DateOnly(2026, 10, 9));*/


/*Emprestimo emprestimo10 = new Emprestimo(aluno1, livro1, new DateOnly(2025, 01, 01), new DateOnly(2025, 01, 10));

emprestimo10.ExibirResumo();*/

Emprestimo emprestimo11 = new Emprestimo(aluno1, livro1, DateOnly.FromDateTime(DateTime.Now), new DateOnly(2030, 10, 20));

emprestimo11.ExibirResumo();