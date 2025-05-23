using System.Reflection.Emit;

namespace ShowPlaces
{
    class Program
    {
        static void Main(string[] args)
        {


            //var label = "Navn";
            //var fieldValue = "Stavern";
            var place = "Stavern";
            var kommune = "Larvik";
            var fylke = "Vestfold";
            ShowPlace("Fall", "Søndre Land", "Innlandet");
            ShowPlace("Stavern", "Larvik", "Vestfold");
            ShowPlace("Oslo", "Oslo", "Oslo");
            ShowPlace("Bergen", "Bergen", "Vestland");
        }

        private static void ShowPlace(string place, string kommune, string fylke)
        {
            var odstep = 8;
            ShowSeparatorRow(8);
            ShowFieldNameAndValue("Navn", odstep, place);

            ShowFieldNameAndValue("Kommune", odstep, kommune);
            ShowFieldNameAndValue("Fylke", odstep, fylke);


            ShowSeparatorRow(odstep);
        }

        static void ShowFieldNameAndValue(string label, int odstep, string fieldValue)
        {
            odstep -= label.Length;
            Console.WriteLine(" " + label + " : " + "".PadLeft(odstep, ' ') + fieldValue);
        }

        static void ShowSeparatorRow(int odstep)
        {
            odstep += 20;
            Console.WriteLine(string.Empty.PadLeft(odstep, '*'));
        }
    }
}