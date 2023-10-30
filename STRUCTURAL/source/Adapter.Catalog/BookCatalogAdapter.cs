
namespace Adapter.Catalog
{
    public class BookCatalogAdapter : CatalogAdapter
    {
        private Book book;
        public BookCatalogAdapter (Book book)=> this.book = book;
        public string getCatalogTitle()=> $"{book.getTitle()} by {book.getAuthor()}";
    }
}