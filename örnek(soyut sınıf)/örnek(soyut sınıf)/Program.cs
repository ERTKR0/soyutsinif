using System.Diagnostics.Metrics;

namespace örnek_soyut_sınıf_;
       public  abstract  class  Hayvan//soyut sınıflardan nesne oluşturulmaz
        {
                public    string Ad { get;set;}
                public  string Cins { get; set;}

                public Hayvan() { }

                public Hayvan (string ad)
                    {
                        this.Ad = ad;
                    }
                //soyut sınfları gövdesi olmaz
                public  abstract string sescıkar();//soyut sınıflar özel olamaz yani(erişim belirteci private veya boş olmamalı protected veya public olmalı)

                public void hayvanbilgisi(Hayvan h)//bu yonteme upcast denir kalıtım olduğu için erişebiliyorum bunun alt sınıflarına
    {
        Console.WriteLine("Adi : " + h.Ad +
            "\nCinsi : "+h.Cins+
            "\nSesi : " +h.sescıkar()
            );


    }

        }

            public  abstract  class Kurt : Hayvan////soyut sınıftan türeyen tüm sınıfların eğer soyut sınıfın soyut metodu varsa o ezilmek zorunda 
            {
                public Kurt(string kurt) : base(kurt)//Özetle, Kopek sınıfı, Hayvan sınıfından türetildiği için, Hayvan sınıfının yapıcı metodunu çağırmak için base anahtar kelimesi kullanılır ve burada kopekAdı parametresi geçilerek Ad özelliği ayarlanır
                {  }

                public override string sescıkar()//bu metotun gözvdesi olmak zorunda yyoksa hata alırsın(tüm metot yolları bir değer döndürmez!!)
                {
                    return "Gırrrrrr";
                }
                public abstract string Uluma();

    
            }

            public class Kırkurdu : Kurt
            {
                public Kırkurdu(string kırkurdu) : base(kırkurdu)
                {   }

                public override string sescıkar()
                {
                    return base.sescıkar();
                }
                public override string Uluma()
                {
                    return "Auuuuuuuu";
                }
                public static string Avlanma()
                {
                    return  "Kurtlar Avlanır..";
                }
            }

            class Kopek : Kırkurdu
{
                 public Kopek(string kopekAdı) : base(kopekAdı)
                    { }
                 public  override string sescıkar() //şimdi burada bunu ezmek zorunda değilim çünkü soytu bir sınıftan türememişi fakat bunu override etmesem kurtan türediği için onun overide calışır
                    {
                        return "Havhav..";

                    }

                    public override string Uluma()
                    {
                        return "Auuuuuuu";
                    }
                public static  string Beslenme()
                {
                    return "Mamasını yiyo....";
                }
             }

            class Kedi:Hayvan
            {
                public Kedi(string kediadi):base(kediadi)
                { }

                public override string sescıkar()
                    {
                        return "Miyavvvv..";
                    }
            }
            class Kus : Hayvan
            {
                public Kus(string kusadi):base(kusadi)//yapıcı metotun parametresindeki isimle aynı olmak zarunda(kusadi)
                { }

                public override string sescıkar()
                    {
                        return "Cik  cikkkk..";
                                }
                public string Ucma()
                {
                    return base.Ad+" Ucuyor..";
                }
            }
            class Hemstir : Hayvan
            {
                public Hemstir(string hemstiradi):base(hemstiradi)
                { }

                public override string sescıkar()
                {
                    return "Vig viggg..";
                }
            }

class test
{
    public static void Main(string[] args)

    {
        Kurt k;//burada soyut kurt sınıfından türemiş bir nesnenin belek adresini göstereceğim demek  !!(bu yeni nesne oluşturmak değil referans vermek sadece)
        k = new Kopek("fifi");//burada kopekin belek adresini belirtiyor
        k.Cins = "kaniş";
        k.sescıkar();
        k.hayvanbilgisi(k);
        
        
       

        Kedi kedi = new Kedi("salca");
        kedi.Cins ="tekir";
        kedi.sescıkar();
        kedi.hayvanbilgisi(kedi);//buraya erişmek istediğim sınıftan bir nesne vermem yeterli bunun sayesinde erişmem dah akolay ve kod kalabalıklığınada gerek yok


        Kırkurdu kırkurdu = new Kırkurdu("Agir");
        kırkurdu.Cins = "kırkurdu";
        kırkurdu.sescıkar();
        kırkurdu.hayvanbilgisi(kırkurdu);

        Kus kus = new Kus("Minik");
        kus.Cins = "Papağan";
        kus.sescıkar();
        kus.Ucma();
        kus.hayvanbilgisi(kus);

        Hemstir hemstir = new Hemstir("beyaz");
        hemstir.Cins="fare";
        hemstir.sescıkar();
        hemstir.hayvanbilgisi(hemstir);

        Console.ReadLine();
        
    }
}