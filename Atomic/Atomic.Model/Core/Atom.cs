using Atomic.Interfaces.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atomic.Model.Core
{
    /// <summary>
    /// Everything in Atomic is treated as an atom of a wider system
    /// </summary>
    internal abstract class Atom : IAtom
    {
        public int Id
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime Created
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime Modified
        {
            get { throw new NotImplementedException(); }
        }

        public abstract string ToJson();
    }
}
