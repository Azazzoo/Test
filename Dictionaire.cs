using System;

public class Class1
{
    internal class Dictionaire : Document
    {

         public string Langue { get; set; }
    public Dictionaire(string titre, int nbPage, string langue) : base(titre, nbPage)
    {
        Langue = langue;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nLangue : {Langue}";
    }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj.GetType() != this.GetType()) return false;
        Dictionaire d = (Dictionaire)obj;
        return d.Langue == this.Langue && base.Equals(d);
    }
}
}
