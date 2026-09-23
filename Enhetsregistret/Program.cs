using System.Globalization;

string namn = "Laptop";
string status = "Aktiv";
decimal pris = 1000m;


List<int> IDs = [];
List<string> names = [];
List<decimal> prices = [];
List<string> statuses = [];

CreateMenu(["Visa Produkter", "Skapa produkt", "Avsluta"]);
/*
 * 
 * Samma sak som:
 * string[] menyVal = ["Visa Produkter", "Skapa Produkt", "Avsluta"];
 * CreateMenu(menyVal);
 * 
 * */
Console.ReadLine();
while (true)
{
    Console.Clear();
    Console.WriteLine("Vänligen lägg in i ny produkt");
        
    var inputID = ReadInteger("Vänligen skriv in ett ID");
    var inputName = ReadString("Vänligen skriv in ett namn");
    var inputPrice = ReadDecimal("Vänligen skriv in ett pris");
    var inputStatus = ReadString("Vänligen skriv in en status");

    IDs.Add(inputID);
    names.Add(inputName);
    prices.Add(inputPrice);
    statuses.Add(inputStatus);

    int latestIndex = (IDs.Count - 1);
    for (int i = 0; i < IDs.Count; i++)
    {
        var currentID = IDs[i];
        var currentName = names[i];
        var currentPrice = prices[i];
        var currentStatus = statuses[i];

        Console.WriteLine($"Row {i} : {currentID} : {currentName} : {currentPrice:C2} : {currentStatus}");
    }

    var addedID = IDs[latestIndex];
    var addedName = names[latestIndex];
    var addedPrice = prices[latestIndex];
    var addedStatus = statuses[latestIndex];

    Console.WriteLine($"The last product you added is : {addedID} : {addedName} : {addedPrice} : {addedStatus}");
    Console.ReadLine();
}

static void CreateMenu(string[] items) {

    int index = 0;

    foreach (var row in items) {
        ++index;
        Console.WriteLine($"{index}. {row}");
    }
}

static string ReadString(string message)
{
    while (true)
    {
        Console.Clear();
        Console.Write(message+": ");
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Ogiltigt värde. Försök igen");
        }
        else { 
            return input; 
        }
    }
}

static decimal ReadDecimal(string message)
{
    while (true)
    {
        Console.Clear();
        Console.Write(message+": ");
        string? input = Console.ReadLine();
        decimal value = 0;
        if (!decimal.TryParse(input, out value))
        {
            Console.WriteLine("Ogiltigt värde. Försök igen");
        }
        else
        {
            return value;
        }
    }
}

static int ReadInteger(string message)
{
    while (true)
    {
        Console.Clear();
        Console.Write(message +": ");
        string? input = Console.ReadLine();
        int value = 0;
        if (!int.TryParse(input, out value))
        {
            Console.WriteLine("Ogiltigt värde. Försök igen");
        }
        else
        {
            return value;
        }
    }
}

























/*        string[] produktLista = new string[100];

        var lästVärde = produktLista[0];
        Console.WriteLine($"Värdet vi läste är: {lästVärde}");

        produktLista[0] = "Mitt nya värde";
        produktLista[99] = "Sista värdet i listan";

        Console.WriteLine($"Värdet vi läste är: {produktLista[0]}");


        for (int i = 0; i < produktLista.Length; i++ )
        {
            var currentItem = produktLista[i];
            if (!string.IsNullOrWhiteSpace(currentItem))
            {
                Console.WriteLine(produktLista[i]);
            }
        }
        
        List<int> unknownLengthList = [ 
            100, 300
        ];

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Använda en lista");

        unknownLengthList.Add(500);
        // var myNewArray = unknownLengthList.ToArray();

        int sum = 0;
        int index = 0;
        foreach(int value in unknownLengthList) {
            ++index;
            sum = sum + value;
            Console.WriteLine($"{index}. Current value of Sum is {sum}");
        }*/

while (true)
{
    Console.ReadLine();
}

/*
        while (true)
        {
            UI.VisaHuvudmeny();
            int val = UI.LasaHeltal("Välj alternativ: ", 1, 5);

            switch (val)
            {
                case 1:
                    {
                        decimal prisMedMoms = Prisberakningar.BeraknaPrisMedMoms(pris);
                        UI.VisaEnhet(namn, status, pris, prisMedMoms);
                        break;
                    }
                case 2:
                    // Returvärdet måste sparas för att priset ska ändras.
                    pris = UI.LasaPris();
                    UI.VisaMeddelande("Priset har ändrats.");
                    break;
                case 3:
                    {
                        decimal rabatt = UI.LasaRabatt();

                        decimal rabatteratPris = Prisberakningar.BeraknaRabatteratPris(pris, rabatt);
                        decimal moms = Prisberakningar.BeraknaMomsbelopp(rabatteratPris);
                        decimal totalpris = Prisberakningar.BeraknaPrisMedMoms(rabatteratPris);
                        UI.VisaPrisforhandsvisning(pris, rabatt, rabatteratPris, moms, totalpris);

                        break;
                    }
                case 4:
                    {
                        UI.VisaStatusmeny();
                        int statusval = UI.LasaHeltal("Välj status: ", 1, 4);
                        switch (statusval)
                        {
                            case 1:
                                status = "Aktiv";
                                break;
                            case 2:
                                status = "Inaktiv";
                                break;
                            case 3:
                                status = "Service";
                                break;
                            case 4:
                                UI.VisaMeddelande("Statusbytet avbröts.");
                                break;
                        }
                        break;
                    }
                case 5:
                    UI.VisaMeddelande("Enhetsregistret avslutas.");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
*/