using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural
{
    /// <summary>
    ///Intent of this pattern in to decouple an abstraction from its implementation so that the two can vary independently.
    /// </summary>
    /// 
    abstract class View
    {
        protected readonly IResource resource;

        protected View(IResource resource) {
            this.resource = resource;
        }

        public abstract string Show();
    }

    class ListView : View
    {
        ListView(IResource resource) 
            : base(resource) { }

        public override string Show()
        {
            return resource.GetTitle() + resource.GetImage();
        }
    }

    interface IResource
    {
        string GetTitle();
        string GetImage();
    }

    class ArtistResource : IResource
    {
        Artist artist;

        public ArtistResource(Artist artist)
        {
            this.artist = artist;
        }

        public string GetImage()
        {
            return artist.GetPicture();
        }

        public string GetTitle()
        {
            return artist.GetBio();
        }
    }

    class Artist
    {
        public string GetBio() { return ""; }
        public string GetPicture() { return "":}
    }
}
