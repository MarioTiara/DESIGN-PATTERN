using System.Globalization;
using Adapter.Catalog;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Object> list = new List<object>();

        list.Add (new Book(title:"Pemrogramman C#", Author:"mario"));
        list.Add ( new Book (title:"Pemrogramman C++", Author:"tiara"));
        list.Add (new Book (title:"Pemrogramman Golang", Author:"Tia"));


        list.Add ( new Screencast (title:"Dotnet MVC", Author:"Agustina", duration:100));
        list.Add ( new Screencast (title:"Fast API", Author:"Putri", duration:200));
        list.Add ( new Screencast (title:"Flask Web", Author:"Icha", duration:150));


        //old solution -> check manually

        foreach (var item in list){
            if (typeof(Book)==item.GetType()){
                Book book= (Book) item;
                Console.WriteLine(book.getTitle(), " by "+ book.getAuthor());
            }else if (typeof(Screencast)==item.GetType()){
                Screencast screencast = (Screencast) item;
                Console.WriteLine(screencast.getTitle()+ " by "+screencast.getAuthor());           
            }
        }
    }
}