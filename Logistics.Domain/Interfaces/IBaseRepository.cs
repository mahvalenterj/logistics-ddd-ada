//Garante que T deve ser uma classe que herda de BaseEntity. Isso cria uma restrição no tipo de entidades que podem ser usadas com esse repositório.

using Logistica.Domain.Entities;

public interface IBaseRepository<T> where T : BaseEntity
{
    //As operações Create, Update e Delete são genéricas e operam em entidades do tipo T, que, por restrição, deve ser uma subclasse de BaseEntity.
    //Operações de crud de forma generica
    public void Create(T entity);
    public void Update(T entity);
    public void Delete(T entity);

    //As operações de leitura (Get e GetAll) são definidas como operações assíncronas usando Task para permitir o uso em ambientes assíncronos. Isso é útil em situações em que as operações podem ser lentas, como acesso a um banco de dados.

    //Task - Assincronicidade - Camadas independentes enquanto a query está sendo realizada
    public Task<T> Get(Guid id, CancellationToken cancellationToken);
    public Task<List<T>> GetAll(CancellationToken cancellationToken);
}

// As interfaces estarão fazendo vinculação do dominio com as demais camadas
// garantindo um escopo pré definido para qualquer entidade

// ESTA TRATANDO O DADO EM SI
// OPERAÇÕES AO DADO


//Essa interface serve como um contrato que define as operações básicas que qualquer repositório que lida com entidades derivadas de BaseEntity deve fornecer. Isso facilita a consistência e a padronização na interação com diferentes entidades e também permite a implementação de repositórios específicos para diferentes tipos de entidades, mantendo uma estrutura comum.
