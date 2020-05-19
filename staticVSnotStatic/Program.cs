using System;

namespace objekter_via_static
{
    class Program //C# 
    {
        static void Main(string[] args)
        {
            var place = new Place("Verningen", "Larvik", "Vestfold");
            var place2 = new Place("Haukerød", "Sandefjord", "Vestfold");
            var place3 = new Place("Øygarden", "Bergen", "Hordaland");

            place.ShowPlace();
            place2.ShowPlace();
            place3.ShowPlace();
            /*Console.WriteLine("******************************");
            Console.WriteLine("       Navn:       Stavern");
            Console.WriteLine("       Kommune:    Larvik");
            Console.WriteLine("       Fylke:      Vestfold");
            Console.WriteLine("******************************");*/
        }

    }
}