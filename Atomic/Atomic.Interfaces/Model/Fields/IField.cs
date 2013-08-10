using Atomic.Interfaces.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atomic.Interfaces.Model.Fields
{   
    /// <summary>
    /// Interface for defining generic fields that can be used to structure schemas
    /// </summary>
    /// <typeparam name="T">The field type</typeparam>
    public interface IField<T> : IAtom where T : IFieldType
    {
        bool IsOptional { get; set; }                
        bool Validate();
    }
}
