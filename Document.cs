using System;

public class Class1
{
    internal class Document
    {

         private static int cpt = 0;
    public string Titre { get; set; }
    public int NbPage { get; set; }
    public int Id { get; private set; }

    public Document(string titre, int nbPage)
    {
        Titre = titre;
        NbPage = nbPage;
        Id = ++cpt;
    }

    public override string ToString()
    {
        return $"Id {Id}\n" +
            $"Nombre de pages : {NbPage}\n" +
            $"Titre : {Titre}";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj.GetType() != this.GetType()) return false;
        Document d = (Document)obj;
        return d.Id.Equals(this.Id) && d.Titre.Equals(this.Titre) && d.NbPage.Equals(this.NbPage);
    }
}
}
