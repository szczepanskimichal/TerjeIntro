using System.Reflection.Emit;

namespace ShowPlaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowSeparator();
            var odstep = 20;
            //var label = "Navn";
            //var fieldValue = "Stavern";
            ShowFieldNameAndValue("Navn", odstep, "Stavern");
            ShowFieldNameAndValue("Kommune", odstep, "Larvik");
            ShowFieldNameAndValue("Fylke", odstep, "Vestfold");

            ShowSeparator();
        }

        static void ShowFieldNameAndValue(string label, int odstep, string fieldValue)
        {
            odstep -= label.Length;
            Console.WriteLine(" " + label + " : " + "".PadLeft(odstep, ' ') + fieldValue);
        }

        static void ShowSeparator()
        {
            Console.WriteLine("************************");
        }
    }
}