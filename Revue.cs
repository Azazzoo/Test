using System;

public class Class1
{
    internal class Revue : Document
    {

        public double Prix { get; set; }
    public int Mois { get; set; }
    public int Annee { get; set; }
    public Revue(string titre, int nbPage, double prix, int mois, int annee) : base(titre, nbPage)
    {
        Prix = prix;
        Mois = mois;
        Annee = annee;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nPrix : {Prix}\n" +
            $"Mois : {Mois}\n" +
            $"Annee : {Annee}";
    }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj.GetType() != this.GetType()) return false;
        Revue r = (Revue)obj;
        return r.Prix == this.Prix && r.Mois == this.Mois && base.Equals(r);
    }
}
}
