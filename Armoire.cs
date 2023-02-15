using System;

public class Class1
{
    internal class Armoire
    {

        public List<Etagere> list { get; set; }
    public Armoire(List<Etagere> etageres)
    {
        list = etageres;
    }
    public void AddDocument(Document d)
    {
        foreach (Etagere te in list)
        {
            if (!te.EstPleine())
            {
                te.AddDocument(d);
                break;
            }
        }
    }
    public void DeleteDocument(Document d)
    {
        foreach (Etagere te in list)
        {
            te.DeleteAllDocement(d);
        }
    }
    public List<Livre> FindLivre()
    {
        List<Livre> list2 = new List<Livre>();
        foreach (Etagere et in list)
        {
            list2.AddRange(et.FindLivre());
        }
        return list2;
    }
}
}
