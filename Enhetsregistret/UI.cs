namespace Enhetsregistret;

public static class UI
{
    public static void VisaHuvudmeny()
    {
        Console.WriteLine("\nENHETSREGISTRET");
        Console.WriteLine("1. Visa enhet");
        Console.WriteLine("2. Ändra pris");
        Console.WriteLine("3. Förhandsvisa rabatt");
        Console.WriteLine("4. Ändra status");
        Console.WriteLine("5. Avsluta");
    }

    public static void VisaStatusmeny()
    {
        Console.WriteLine("\nÄNDRA STATUS");
        Console.WriteLine("1. Aktiv");
        Console.WriteLine("2. Inaktiv");
        Console.WriteLine("3. Service");
        Console.WriteLine("4. Avbryt");
    }

    public static int LasaHeltal(string fraga, int min, int max)
    {
        while (true)
        {
            Console.Write(fraga);
            string? svar = Console.ReadLine();
            if (int.TryParse(svar, out int tal) && tal >= min && tal <= max)
            {
                return tal;
            }
            Console.WriteLine($"Ange ett heltal mellan {min} och {max}.");
        }
    }

    public static decimal LasaPris()
    {
        while (true)
        {
            Console.Write("Nytt pris exklusive moms (t.ex. 1000 eller 199,50): ");
            string? svar = Console.ReadLine();
            if (decimal.TryParse(svar, out decimal pris) && pris >= 0)
            {
                return pris;
            }
            Console.WriteLine("Ange ett giltigt pris som är noll eller större.");
        }
    }

    public static decimal LasaRabatt()
    {
        while (true)
        {
            Console.Write("Rabatt i procent (0–100): ");
            string? svar = Console.ReadLine();
            if (decimal.TryParse(svar, out decimal rabatt) && rabatt >= 0 && rabatt <= 100)
            {
                return rabatt;
            }
            Console.WriteLine("Ange en rabatt mellan 0 och 100 procent.");
        }
    }

    public static void VisaEnhet(string namn, string status, decimal pris, decimal prisMedMoms)
    {
        Console.WriteLine($"\nEnhet: {namn}");
        Console.WriteLine($"Status: {status}");
        Console.WriteLine($"Pris exklusive moms: {pris:F2} kr");
        Console.WriteLine($"Pris inklusive moms: {prisMedMoms:F2} kr");
    }

    public static void VisaPrisforhandsvisning(
        decimal originalpris, 
        decimal rabatt,
        decimal rabatteratPris, 
        decimal moms, 
        decimal totalpris
       )
    {
        Console.WriteLine("\nPRISFÖRHANDSVISNING");
        Console.WriteLine($"Originalpris exklusive moms: {originalpris:F2} kr");
        Console.WriteLine($"Rabatt: {rabatt:F2} %");
        Console.WriteLine($"Pris efter rabatt exklusive moms: {rabatteratPris:F2} kr");
        Console.WriteLine($"Moms (25 %): {moms:F2} kr");
        Console.WriteLine($"Totalpris inklusive moms: {totalpris:F2} kr");
        Console.WriteLine("Förhandsvisningen ändrar inte enhetens sparade pris.");
    }

    public static void VisaMeddelande(string meddelande) => Console.WriteLine(meddelande);
}
