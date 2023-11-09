// Definição da interface IUnitOfWork que representa uma unidade de trabalho para operações de transação.

public interface IUnitOfWork
{
    // Método para realizar o commit da transação.

    Task Commit(CancellationToken cancellationToken);
}

// tratando operações a transação
