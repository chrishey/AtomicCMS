using Core.Interfaces;

namespace Core
{
    public class AtomicDictionaryItem : IAtomicDictionaryItem
    {
        public string[] Route { get; set; }
        public IAtomicDocumentType Document { get; set; }
    }
}
