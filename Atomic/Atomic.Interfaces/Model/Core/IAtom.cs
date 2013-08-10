using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atomic.Interfaces.Model.Core
{
    /// <summary>
    /// Everything in Atomic is treated as an atom of a wider system.
    /// </summary>
    public interface IAtom
    {
        int Id { get; }
        DateTime Created { get; }
        DateTime Modified { get; }
        string ToJson();
    }
}
