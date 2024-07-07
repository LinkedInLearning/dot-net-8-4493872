namespace Entites;

class Program
{
    static void Main(string[] args)
    {
        var p0 = new ProduitRec("A000", "Casserole", 20.50m);
        var p1 = p0 with { Prix = p0.Prix * 1.1m };

        // p1.Prix *= 1.1m;
        Console.WriteLine("p0 : {0:.00}", p0.Prix);
    }

    public record ProduitRec(string Ref, string Nom, decimal Prix)
    {

    }
    public struct Produit
    {
        public Produit(string Ref)
        {
            this.Ref = Ref;
        }
        public Produit(string Ref, string Nom, decimal Prix)
        {
            this.Ref = Ref;
            this.Nom = Nom;
            this.Prix = Prix;
        }
        public Produit(string Ref, string Nom) : this(Ref, Nom, 0.0m)
        {
        }

        public string Ref { get; private set; }
        public required string Nom { get; init; }
        public decimal Prix { get; set; }
    }
}
