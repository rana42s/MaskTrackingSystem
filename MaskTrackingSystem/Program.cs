using Business.Concrete;
using Entities.Concrete;

SelamVer(isim:"Rana");
SelamVer();


static void SelamVer(string isim = "isimisiz")  //SelamVer Metodu
{
    Console.WriteLine("Merhaba" + " " + isim);
}

Person person1 = new Person();
person1.FirstName = "Rana Gül";
person1.LastName = "AYYILDIZ";
person1.DateOfBirthYear = 2003;
person1.NationalIdentity = 123;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();