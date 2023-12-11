using Kovarijantnost;

Zaposlenik o1 = new()
{
    id = "123"
};
Zaposlenik o2 = o1.Klon();
o1.id = "234";
Console.WriteLine(o2.id);

Student o3 = new() { id = "123" };
Osoba _ = Zaposli(o3);

Grupa<Student> analiza = new()
{
    clanovi = [o3]
};
IDohvati<Osoba> osobe = analiza;
IDodaj<Osoba> osobe2 = new Grupa<Osoba>();
IDodaj<Student> studenti = osobe2;
studenti.Dodaj(new Student { id = "123" });

static Zaposlenik Zaposli(Osoba a)
{
    return new Zaposlenik() { id = a.id, placa = 1000 };
}