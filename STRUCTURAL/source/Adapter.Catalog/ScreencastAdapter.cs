
namespace Adapter.Catalog
{
    public class ScreencastAdapter : CatalogAdapter
    {
        private Screencast screencast;
        public ScreencastAdapter (Screencast screencast)=> this.screencast=screencast;
        public string getCatalogTitle()=> $"{screencast.getTitle()} by {screencast.getAuthor()}";
    }
}