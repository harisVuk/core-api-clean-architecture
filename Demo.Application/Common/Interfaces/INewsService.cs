using Demo.Infrastructure.Shared;
using Demo.Infrastructure.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Common.Interfaces
{
    public interface INewsService
    {
        Task<Pagination<NewsVM>> Get(int pageIndex, int pageSize);
    }
}
