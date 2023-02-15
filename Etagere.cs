using System;

internal class Etagere
{
	public Class1()
	{

        public List<Document> List { get; set; }
    public int NbMax { get; set; }

    public Etagere(int nbMax)
    {
        List = new List<Document>();
        NbMax = nbMax;
    }
    public bool EstPleine()
    {
        return List.Count >= NbMax;
    }
    public void AddDocument(Document d)
    {
        if (this.EstPleine() == false)
        {
            List.Add(d);
        }
    }
    public bool DeleteDocument(Document d)
    {
        return List.Remove(d);
    }
    public void DeleteAllDocement(Document d)
    {
        List.RemoveAll(d => d.Equals(d));
        /*
        bool res;
        do
        {
            res = DeleteDocument(d);
        }while (res);*/
    }
    public Document? FindDocument(int ID)
    {
        return List.Find(d => d.Id == ID);
        /*foreach (Document d in List)
        {
            if(d.Id == ID)  return d;
        }
        return null;*/
    }
    public List<Document> FindDocument(string titre)
    {
        List<Document> list = new List<Document>();
        foreach (Document d in this.List)
        {
            if (d.Titre == titre)
            { list.Add(d); }
        }
        return list;
    }
    public List<Livre> FindLivre()
    {
        List<Livre> list = new List<Livre>();
        foreach (var l in List)
        {
            if (l is Livre) { list.Add((Livre)l); }
        }
        return list;
    }
    public List<Dictionaire> FindDictionnaire()
    {
        List<Dictionaire> dictionaires = new List<Dictionaire>();
        foreach (var d in this.List)
        {
            if (d is Dictionaire) { dictionaires.Add((Dictionaire)d); }
        }
        return dictionaires;
    }
    public bool Existe(Document d)
    {
        return List.Contains(d);
    }
    public int Occurence(Document d)
    {
        int cpt = 0;
        foreach (var l in List)
        {
            if (l.Equals(d)) { cpt++; }
        }
        return cpt;
    }
}
}
