
using Demo.Application.Common.Exceptions;
using Demo.Infrastructure.Data;
using Demo.Infrastructure.Interface;
using Demo.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DemoContext _context;

        public INewsRepository NewsRepository { get; }
        public UnitOfWork(DemoContext dbContext)
        {
            _context = dbContext;
            NewsRepository = new NewsRepository(_context);
        }
        
        public async Task SaveChangesAsync(CancellationToken token)
       => await _context.SaveChangesAsync(token);

        public async Task ExecuteTransactionAsync(Action action, CancellationToken token)
        {
            using var transaction = await _context.Database.BeginTransactionAsync(token);
            try
            {
                action();
                await _context.SaveChangesAsync(token);
                await transaction.CommitAsync(token);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync(token);
                throw TransactionException.TransactionNotExecuteException(ex);
            }
        }

        public async Task ExecuteTransactionAsync(Func<Task> action, CancellationToken token)
        {
            using var transaction = await _context.Database.BeginTransactionAsync(token);
            try
            {
                await action();
                await _context.SaveChangesAsync(token);
                await transaction.CommitAsync(token);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync(token);
                throw TransactionException.TransactionNotExecuteException(ex);
            }
        }
    }
}
