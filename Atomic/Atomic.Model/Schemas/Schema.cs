using Atomic.Interfaces.Model.Fields;
using Atomic.Interfaces.Model.Schemas;
using Atomic.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atomic.Model.Schemas
{
    /// <summary>
    /// Schemas are used to structure content in atomic through definition of its fields.
    /// </summary>
    public abstract class Schema : Atom, ISchema
    {
        public string Name { get; set; }

        public abstract bool Validate()
        {
            throw new NotImplementedException();
        }

        public int AddField<T>(string fieldName, IField<T> field) where T : IFieldType
        {
            throw new NotImplementedException();
        }

        public bool HasField(int id)
        {
            throw new NotImplementedException();
        }

        public IField<T> GetField<T>(int id) where T : IFieldType
        {
            throw new NotImplementedException();
        }

        public void UpdateField<T>(IField<T> field) where T : IFieldType
        {
            throw new NotImplementedException();
        }

        public IField<T> RemoveField<T>(int id) where T : IFieldType
        {
            throw new NotImplementedException();
        }

        public IField<T> RemoveField<T>(IField<T> field) where T : IFieldType
        {
            throw new NotImplementedException();
        }
    }
}
