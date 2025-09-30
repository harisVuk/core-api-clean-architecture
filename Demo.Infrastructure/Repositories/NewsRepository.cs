using Demo.Domain.Entities;
using Demo.Infrastructure.Data;
using Demo.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Repositories
{
    public class NewsRepository(DemoContext context) : GenericRepository<News>(context), INewsRepository { }
}
