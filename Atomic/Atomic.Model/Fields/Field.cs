using Atomic.Interfaces.Model.Fields;
using Atomic.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atomic.Model.Fields
{
    /// <summary>
    /// Fields can be used to structure a Schema.
    /// </summary>
    /// <typeparam name="T">Type of field</typeparam>
    public abstract class Field<T> : Atom, IField<T> where T : IFieldType
    {
        public bool IsOptional { get; set; }       

        public abstract bool Validate();

        public override string ToJson()
        {
            throw new NotImplementedException();
        }
    }
}
