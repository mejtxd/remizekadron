namespace RemizekAdron
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Zadání vstupních dat od uživatele
            Console.WriteLine("Zadejte počáteční zeměpisnou šířku (ve formátu desetinných stupňů):");
            double pocatecniSirka = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte počáteční zeměpisnou délku (ve formátu desetinných stupňů):");
            double pocatecniDelka = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte koncovou zeměpisnou šířku (ve formátu desetinných stupňů):");
            double koncovaSirka = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte koncovou zeměpisnou délku (ve formátu desetinných stupňů):");
            double koncovaDelka = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte celkovou délku dráhy dronu (v metrech):");
            double celkovaDelkaDrahy = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte celkovou dobu letu dronu (v sekundách):");
            double celkovaDobaLetu = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte čas na videu, kde je místo údržby (v sekundách):");
            double casUdrzby = double.Parse(Console.ReadLine());

            // Výpočet rychlosti dronu (v metrech za sekundu)
            double rychlost = celkovaDelkaDrahy / celkovaDobaLetu;

            // Vypočtená vzdálenost od počátečního bodu k místu údržby
            double vzdalenostVUdrzbe = rychlost * casUdrzby;

            // Podíl urazene vzdálenosti na celkové vzdálenosti
            double podil = vzdalenostVUdrzbe / celkovaDelkaDrahy;

            // Interpolace GPS souřadnic
            double sirkaUdrzby = pocatecniSirka + (koncovaSirka - pocatecniSirka) * podil;
            double delkaUdrzby = pocatecniDelka + (koncovaDelka - pocatecniDelka) * podil;

            // Výstup výsledku
            Console.WriteLine("GPS souřadnice místa údržby jsou:");
            Console.WriteLine($"Šířka (latitude): {sirkaUdrzby}");
            Console.WriteLine($"Délka (longitude): {delkaUdrzby}");
        }
    }
}
