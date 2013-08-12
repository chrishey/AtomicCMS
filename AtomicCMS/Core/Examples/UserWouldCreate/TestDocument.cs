using Core.Interfaces;

namespace Core.Examples
{
    public class TestDocument : IAtomicDocumentType
    {        
        public string DocumentName { get { return "Test Document"; } }
        public string ViewName { get { return "TestView"; } }


        // Below are properties for the document type. This allows us to be strongly typed in the views.
        // We add the 'AtomicDocumentProperty' to them to allow us to discover them when storing them to the database etc

        [AtomicDocumentProperty]
        public string Title { get; set; }

        [AtomicDocumentProperty]
        public string MainContent { get; set; }

    }
}
