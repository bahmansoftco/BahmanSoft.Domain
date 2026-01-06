using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BahmanSoft.Doamin.Common
{
    public interface IHasExtraProperies
    {
        Dictionary<string, string> ExtraProperties { get; set; }
    }
}
