using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BahmanSoft.Doamin.Common
{
    public interface IHasCreationTime
    {
        DateTime CreationTime { get; set; }
    }
}
