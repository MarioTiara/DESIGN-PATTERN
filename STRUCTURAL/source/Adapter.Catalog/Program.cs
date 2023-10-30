using System.Globalization;
using Adapter.Catalog;

internal class Program
{
    private static void Main(string[] args)
    {
        List<CatalogAdapter> list = new List<CatalogAdapter>();

        list.Add ( new BookCatalogAdapter(new Book(title:"Pemrogramman C#", Author:"mario")));
        list.Add ( new BookCatalogAdapter(new Book (title:"Pemrogramman C++", Author:"tiara")));
        list.Add (new BookCatalogAdapter(new Book (title:"Pemrogramman Golang", Author:"Tia")));


        list.Add (new ScreencastAdapter(new Screencast (title:"Dotnet MVC", Author:"Agustina", duration:100)));
        list.Add (new ScreencastAdapter (new Screencast (title:"Fast API", Author:"Putri", duration:200)));
        list.Add (new ScreencastAdapter (new Screencast (title:"Flask Web", Author:"Icha", duration:150)));


        //old solution -> check manually

        foreach (var item in list){
            Console.WriteLine(item.getCatalogTitle());
        }
    }
}