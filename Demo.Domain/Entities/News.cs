using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Entities
{
    public class News : EntityBase
    {
        public string Title { get; set; }

        public string Desctiption { get; set; }

        public User User { get; set; }
    }
}
