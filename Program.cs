// See https://aka.ms/new-console-template for more information

using Assignment4;

List<Products> products = new List<Products>()
{
    new Products(){Pname="Mobile",Pprice=90000,Pbrand="iphone",Mfdate=new DateTime(day:15,month:12,year:2020),Exdate=new DateTime(day:15,month:12,year:2020)},
    new Products(){Pname="Laptop",Pprice=80000,Pbrand="Asus",Mfdate=new DateTime(day:01,month:01,year:2024),Exdate=new DateTime(day:15,month:09,year:2050)},
    new Products(){Pname="Earbuds",Pprice=1000,Pbrand="boat",Mfdate=new DateTime(day:15,month:12,year:2019),Exdate=new DateTime(day:31,month:12,year:2024)},
    new Products(){Pname="Speaker",Pprice=25000,Pbrand="boat",Mfdate=new DateTime(day:02,month:06,year:2020),Exdate=new DateTime(day:21,month:12,year:2040)},
    new Products(){Pname="Monitor",Pprice=32000,Pbrand="Dell",Mfdate=new DateTime(day:10,month:05,year:2020),Exdate=new DateTime(day:01,month:12,year:2050)},
    new Products(){Pname="mouse",Pprice=2000,Pbrand="HP",Mfdate=new DateTime(day:10,month:05,year:2020),Exdate=new DateTime(day:01,month:12,year:2050)}
};

Console.WriteLine("Name \t Price \t Brand \t MfDate \t\t ExpDate");
foreach (Products pro in products)
{
    Console.Write(pro.Pname + "\t ");
    Console.Write(pro.Pprice + "\t ");
    Console.Write(pro.Pbrand + "\t ");
    Console.Write(pro.Mfdate.ToLongDateString()+"\t\t");
    Console.Write(pro.Exdate.ToLongDateString());
    Console.Write("\n");
}
