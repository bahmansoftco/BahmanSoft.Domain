using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BahmanSoft.Doamin.Common
{
    public class Entity : Entity<int>, IEntity
    {
    }

    public class Entity<T>
    {
        public T Id { get; set; }
    }
}
