using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IAtomicDictionary
    {
        IList<IAtomicDictionaryItem> Items { get; set; }
        IAtomicDictionaryItem GetItemFromRoute(string route);
    }
}
