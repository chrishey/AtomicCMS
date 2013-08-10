using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atomic.Interfaces.Model.Core
{
    /// <summary>
    /// Everything in Atomic is treated as an object.
    /// </summary>
    public interface IObject
    {
        int Id { get; }
        DateTime Created { get; }
        DateTime Modified { get; }
        string ToJson();
    }
}
