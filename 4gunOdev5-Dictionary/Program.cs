using System;
using System.Collections.Generic;

namespace _4gunOdev5_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> takımlar = new List<string>();
            takımlar.Add("Galarasaray");
            Console.WriteLine(takımlar.Count);

            MyDİctionary<int,string> takımlar2 = new MyDİctionary<int,String>();
            takımlar2.Add(1,"Galatasaray");
            takımlar2.Add(2,"Fenerbahçe");
            takımlar2.Add(3,"Beşiktaş");
            takımlar2.Add(4,"Trabzonspor");
            takımlar2.Add(5,"Başakşehir");
            for (int i = 0; i < takımlar2.Items.Length ; i++)
            {
                Console.WriteLine(i+1+ takımlar2.Items[i]);
            }
            takımlar2.Add(6, "Ankaragücü");
            Console.WriteLine(takımlar2.Length + takımlar2.Items[takımlar2.Length-1]);

        }
    }
}
class MyDİctionary<Tkey,Tvalue> //Generic Class
{
    Tkey[] sırala;
    Tvalue[] kulüp;
    public MyDİctionary()
    {
        sırala = new Tkey[0];
        kulüp = new Tvalue[0];
    }
    public void Add(Tkey sıra , Tvalue item)
    {
        Tkey[] tempSırala=sırala;
        Tvalue[] tempKulüp = kulüp;
        sırala = new Tkey[sırala.Length+1];
        kulüp = new Tvalue[kulüp.Length + 1];
        for (int i = 0; i < tempSırala.Length; i++)
        {
            sırala[i] = tempSırala[i];
        }
        for (int i = 0; i < tempKulüp.Length; i++)
        {
            kulüp[i] = tempKulüp[i];
        }
        sırala[sırala.Length - 1] = sıra;
        kulüp[kulüp.Length - 1] = item;
    }

    public int Length
    {
        get { return sırala.Length; }
    }
   
    public Tvalue[] Items
    {
        get { return kulüp; }
    }

}