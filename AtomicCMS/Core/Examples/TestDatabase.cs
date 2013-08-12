using Core.Examples;
using Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Core
{
    public class TestDatabase : IAtomicDatabase
    {
        public IList<IAtomicDictionaryItem> GetDocuments()
        {
            return new List<IAtomicDictionaryItem>
            {
                new AtomicDictionaryItem { 
                    Route = new string[] { "/" }, 
                    Document = new TestDocument() { Title = "This is the home page", MainContent = "This is some content" }, 
                },
                
                new AtomicDictionaryItem { 
                    Route = new string[] { "/", "Map" }, 
                    Document = new MapDocument() { MapTitle = "A map would go here" }, 
                },

                new AtomicDictionaryItem { 
                    Route = new string[] { "/", "About" }, 
                    Document = new TestDocument() { Title = "Learn about us", MainContent = "We are AtomicCMS and we are awesome" }, 
                },
            };
        }

        public bool SaveDocuments(IList<IAtomicDictionaryItem> documents)
        {
            // Save the document map to the database
            throw new NotImplementedException();
        }
    }
}
