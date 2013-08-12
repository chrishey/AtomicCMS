using Core.Examples;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Core
{
    public class AtomicDictionary : IAtomicDictionary
    {
        public IList<IAtomicDictionaryItem> Items{ get; set; }
        
        private IAtomicDatabase _database;
        
        public AtomicDictionary(IAtomicDatabase database)
        {
            _database = database;
            Items = _database.GetDocuments();
        }

        public IAtomicDictionaryItem GetItemFromRoute(string route)
        {
            var routeParts = Regex.Split(route, @"(?<=[/])")
                .Where(x => !string.IsNullOrEmpty(x)).ToArray();

            var routesAvailable = Items;
            for (int i = 0; i < routeParts.Length; i++)
            {
                routesAvailable = routesAvailable.Where(
                        x => x.Route[i].ToUpper() == routeParts[i].ToUpper() 
                        && x.Route.Length == routeParts.Length 
                    ).ToList();
            }

            if (routesAvailable.Count() != 1)
                throw new Exception("Wrong number of routes, should do something");

            return routesAvailable.First();
        }
    }
}
