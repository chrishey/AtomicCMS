using Atomic.Interfaces.Model.Core;
using Atomic.Interfaces.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atomic.Interfaces.Model.Schemas
{
    /// <summary>
    /// Interface for defining a schema - used to structure content or media through its collection of fields.
    /// New schemas can be created by inheriting from this interface.
    /// </summary>
    public interface ISchema : IObject
    {
        string Name { get; set; }
        bool Validate();

        # region Field methods
        int AddField<T>(string fieldName, IField<T> field) where T : class;
        bool HasField(int id);      
        IField<T> GetField<T>(int id) where T : class;
        void UpdateField<T>(IField<T> field) where T : class;  
        IField<T> RemoveField<T>(int id) where T : class;
        IField<T> RemoveField<T>(IField<T> field) where T : class;
        #endregion
    }
}
