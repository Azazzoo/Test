using System;

public class Class1
{
    internal class Livre : Document
    {

         public string Auteur { get; set; }
    public Livre(string titre, int nbPage, string auteur) : base(titre, nbPage)
    {
        Auteur = auteur;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nAuteur : {Auteur}";
    }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj.GetType() != this.GetType()) return false;
        Livre l = (Livre)obj;
        return base.Equals(l) && l.Auteur.Equals(this.Auteur);
    }
}
}
