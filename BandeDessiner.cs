using System;

public class Class1
{
    internal class BandeDessiner : Livre
    {

         public bool Couleur { get; set; }
    public BandeDessiner(string titre, int nbPage, string auteur, bool couleur) : base(titre, nbPage, auteur)
    {
        Couleur = couleur;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nCouleur : {Couleur}";
    }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj.GetType() != this.GetType()) return false;
        BandeDessiner BD = (BandeDessiner)obj;
        return BD.Couleur == this.Couleur && base.Equals(BD);
    }
}
}
