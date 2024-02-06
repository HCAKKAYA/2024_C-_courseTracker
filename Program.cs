// See https://aka.ms/new-console-template for more information
using intro.Business;
using intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 10000.5;

// variables -->camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);

//condition = şart
if (isAuthenticated)
{
    Console.WriteLine("Buton-->Hosgeldin Huseyin");
}

else
{
    Console.WriteLine("Buton-->Sisteme giris yapiniz");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" }; // db den gelecek (db = database)

//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

    //start      condition         increment 
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kod bitti");