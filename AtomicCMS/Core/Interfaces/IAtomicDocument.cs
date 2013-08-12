using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAtomicDocumentType
    {
        string DocumentName { get; }
        string ViewName { get; }
    }
}
