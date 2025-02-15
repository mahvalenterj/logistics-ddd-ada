﻿
// Responsabilidade: gerenciar as transações e o commit das operações de BD
using Microsoft.EntityFrameworkCore;
using techLogistica.Domain.Interfaces;


namespace techLogistica.Persistence.Repositories

{
    public class UnitOfWork : IUnitOfWork
    {

        readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); // representaçção de banco de dados
        }

        public async Task Commit(CancellationToken cancellationToken)
        {
            // esse método ele vai comitar e salvar as alterações no BD
            await _context.SaveChangesAsync(cancellationToken);
        }
    }

}