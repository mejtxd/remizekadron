namespace RemizekAdron
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Zadání dat od uživatele
            Console.WriteLine("Zadejte pocatecni zemepisnou sirku (ve formatu desetinnych stupnu):");
            double pocatecniSirka = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte pocatecni zemepisnou delku (ve formatu desetinnych stupnu):");
            double pocatecniDelka = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte koncovou zemepisnou sirku (ve formatu desetinnych stupnu):");
            double koncovaSirka = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte koncovou zemepisnou delku (ve formatu desetinnych stupnu):");
            double koncovaDelka = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte celkovou delku drahy dronu (v metrech):");
            double celkovaDelkaDrahy = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte celkovou dobu letu dronu (v sekundach):");
            double celkovaDobaLetu = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte cas na videu, kde je misto udrzby (v sekundach):");
            double casUdrzby = double.Parse(Console.ReadLine());

            //Výpočet rychlosti dronu (v metrech za sekundu)
            double rychlost = celkovaDelkaDrahy / celkovaDobaLetu;

            //Vypočítaná vzdálenost od počátečního bodu k místu údržby
            double vzdalenostVUdrzbe = rychlost * casUdrzby;

            //Podíl uražené vzdálenosti na celkové vzdálenosti
            double podil = vzdalenostVUdrzbe / celkovaDelkaDrahy;

            //Výpočet hodnot GPS souřadnic
            double sirkaUdrzby = pocatecniSirka + (koncovaSirka - pocatecniSirka) * podil;
            double delkaUdrzby = pocatecniDelka + (koncovaDelka - pocatecniDelka) * podil;

            //Výsledek
            Console.WriteLine("GPS souradnice mista udržby jsou:");
            Console.WriteLine($"Šířka (latitude): {sirkaUdrzby}");
            Console.WriteLine($"Délka (longitude): {delkaUdrzby}");
        }
    }
}
