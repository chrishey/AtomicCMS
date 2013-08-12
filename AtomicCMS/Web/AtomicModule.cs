using Core;
using Core.Interfaces;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web
{
    public class AtomicModule : NancyModule
    {
        public AtomicModule()
        {
            var documentDictionary = new AtomicDictionary(new TestDatabase());

            Get["/"] = _ =>
            {
                var thisDocument = documentDictionary.GetItemFromRoute(Request.Path);
                return View[thisDocument.Document.ViewName, thisDocument.Document];
            };

            Get["/{route1}"] = _ =>
            {
                var thisDocument = documentDictionary.GetItemFromRoute(Request.Path);
                return View[thisDocument.Document.ViewName, thisDocument.Document];
            };

            Get["/{route1}/{route2}"] = _ =>
            {
                var thisDocument = documentDictionary.GetItemFromRoute(Request.Path);
                return View[thisDocument.Document.ViewName, thisDocument.Document];
            };
        }
    }
}