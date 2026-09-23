# Enhetsregistret efter självstudiedagen 22 september 2026

Färdig exempellösning till grundfunktionerna i självstudierna ”Metoder och kodstruktur”. Startvärden: Laptop, 1 000 kr exklusive moms, Aktiv.

## Starta

1. Packa upp hela ZIP-filen.
2. Öppna `Enhetsregistret.sln` i Visual Studio med stöd för .NET 8.
3. Starta med Ctrl+F5.

Via terminal, från mappen med lösningsfilen: `dotnet run --project Enhetsregistret`.

## Ansvar och funktioner

- `Program.cs`: lokala enhetsuppgifter, menyloop och samordning av metodanrop.
- `UI.cs`: all menyvisning, inmatning, validering och presentation i en enda UI-fil.
- `Prisberakningar.cs`: rabatt, momsbelopp och pris inklusive moms.

Programmet hanterar en enhet i minnet. Ändra pris, förhandsvisa rabatt utan att spara den och byt mellan Aktiv, Inaktiv och Service. Avbryt i statusmenyn behåller aktuell status. Pris noll och rabatt 0–100 är tillåtna. Skriv decimaler med komma, exempelvis 199,50. Belopp presenteras med två decimaler.

Detta är grundversionen inför onsdagens lektion. Den frivilliga fördjupningen med menytext som returvärde ingår inte. Separata debuggerövningar och personliga felsökningsanteckningar ligger utanför själva registerprojektet. Listor, egna enhetsobjekt, repository och fillagring har ännu inte införts. Värden återställs när programmet startas om.

## Kontrollera i Visual Studio

Koden är granskad mot uppgiften men har inte kompilerats eller körts i framställningsmiljön, eftersom .NET SDK saknas där. Följande är förväntade resultat, inte en rapport om genomförda körningar.

| Test | Förväntat resultat |
|---|---|
| Visa startvärden | Laptop, Aktiv, 1000,00 kr exkl. och 1250,00 kr inkl. moms |
| Ändra pris: abc, tomt svar, -10, därefter 200 | Fråga igen för felaktiga svar; spara 200 |
| Visa efter prisbyte | 200,00 kr exkl. och 250,00 kr inkl. moms |
| Pris 1000 och rabatt 10 | 900,00 kr efter rabatt, 225,00 kr moms, 1125,00 kr totalt |
| Visa efter förhandsvisningen | Originalpris fortfarande 1000,00 kr |
| Rabatt 100, därefter 0 | Totalpris 0,00 respektive 1250,00 kr |
| Pris 0 och rabatt 25 | Samtliga belopp 0,00 kr |
| Rabatt -1, 101, hej eller tomt svar | Fråga igen |
| Alla tre statusval | Vald status syns vid nästa enhetsvisning |
| Status Service, öppna statusmeny och välj 4 | Service behålls |
| Menyval text, tomt, 1,5 eller utanför intervallet | Fråga igen |
| Huvudmenyval 5 | Programmet avslutas |

Följ exempelvis `pris = UI.LasaPris()` med debuggern: användarens text blir ett decimalvärde, returneras och sparas i Program. Vid rabattförhandsvisning används i stället en separat variabel så att `pris` behålls.
