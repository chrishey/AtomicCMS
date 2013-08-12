using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AtomicDocumentProperty : System.Attribute
    {
        public AtomicDocumentProperty()
        {

        }
    }
}
