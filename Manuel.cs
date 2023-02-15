using System;

public class Class1
{
    internal class Manuel : Livre
    {

         public string NiveauScolaire { get; set; }
    public Manuel(string titre, int nbPage, string auteur, string niveauScolaire) : base(titre, nbPage, auteur)
    {
        NiveauScolaire = niveauScolaire;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nNiveau scolaire : {NiveauScolaire}";
    }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj.GetType() != this.GetType()) return false;
        Manuel m = (Manuel)obj;
        return m.NiveauScolaire == NiveauScolaire && base.Equals(m);
    }
}
}
