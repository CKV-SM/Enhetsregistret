namespace Enhetsregistret;

public static class Prisberakningar
{
    // Inmatningen kontrollerar pris >= 0 och rabatt mellan 0 och 100.
    // Metoderna gör enbart beräkningar och använder inte konsolen.
    public static decimal BeraknaRabatteratPris(decimal pris, decimal rabattProcent)
    {
        return pris - pris * (rabattProcent / 100m);
    }

    public static decimal BeraknaMomsbelopp(decimal pris)
    {
        return pris * 0.25m;
    }

    public static decimal BeraknaPrisMedMoms(decimal pris)
    {
        return pris + BeraknaMomsbelopp(pris);
    }
}
