using System;

public class Class1
{
    internal class Roman : Livre
    {

        public double PrixLiteraire { get; set; }
    public Roman(string titre, int nbPage, string auteur, double prixLiteraire) : base(titre, nbPage, auteur)
    {
        PrixLiteraire = prixLiteraire;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nPrix literiaire : {PrixLiteraire}";
    }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj.GetType() != this.GetType()) return false;
        Roman r = (Roman)obj;
        return r.PrixLiteraire == PrixLiteraire && base.Equals(r);
    }
}
}
