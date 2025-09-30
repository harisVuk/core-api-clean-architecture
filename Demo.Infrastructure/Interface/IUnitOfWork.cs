using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Interface
{
    public interface IUnitOfWork
    {
        INewsRepository NewsRepository { get; }
        /*Task SaveChangesAsync(CancellationToken token);
        Task ExecuteTransactionAsync(Action action, CancellationToken token);
        Task ExecuteTransactionAsync(Func<Task> action, CancellationToken token);*/
    }
}
