//This source code was generated using Visual Studio Design Patterns add-in
//You can find the source code and binaries at http://VSDesignPatterns.codeplex.com

//Singleton: //Ensure a class only has one instance, and provide a global point of access to it.
using System;
using System.Collections.Generic;
using System.Threading;

namespace MaintinfoBo
{

    public sealed class Catalogue
    {


        private static readonly Lazy<Catalogue> _instance
              = new Lazy<Catalogue>(() => new Catalogue(), LazyThreadSafetyMode.PublicationOnly);


        private Catalogue() { }
        private List<Article> Cat = new List<Article>();

        public static Catalogue Instance
        {
            get
            {

                return _instance.Value;
            }
        }
    public static  void RemplirCatalogue(List<Article> arts)
        {
            ViderCatalogue();
            Instance.Cat.AddRange(arts);
        }
        public List<Article> RecupererCatalogue()
        {
            return Instance.Cat;
        }
        public static void ViderCatalogue()
        {
            Instance.Cat.Clear();
        }
    }

}
