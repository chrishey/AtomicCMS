
namespace Core.Interfaces
{
    public interface IAtomicDictionaryItem
    {
        string[] Route { get; set; }
        IAtomicDocumentType Document { get; set; }
    }

}
