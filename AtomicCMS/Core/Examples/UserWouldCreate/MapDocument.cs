using Core.Interfaces;

namespace Core.Examples
{
    public class MapDocument : IAtomicDocumentType
    {
        public string DocumentName { get { return "Map Page Document"; } }
        public string ViewName { get { return "MapView"; } }

        // Below are properties for the document type. This allows us to be strongly typed in the views.
        // We add the 'AtomicDocumentProperty' to them to allow us to discover them when storing them to the database etc

        [AtomicDocumentProperty]
        public string MapTitle { get; set; }
    }
}
