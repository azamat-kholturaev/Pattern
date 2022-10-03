// See https://aka.ms/new-console-template for more information
using Pattern.example_4;

//var name = new Car();
//name.Move();
//Console.ReadKey();


Console.WriteLine();


//developer dev = new paneldeveloper("ооо кирпич строй");
//house house2 = dev.create();

//dev = new wooddeveloper("частный застройщик");
//house house = dev.create();


//-------------------------------------------------------

//Hero elf = new Hero(new ElfFactory());
//elf.Hit();
//elf.Run();

//Hero voin = new Hero(new VoinFactory());
//voin.Hit();
//voin.Run();

//-------------------------------------------------------

(new Thread(() =>
{
    Computer comp2 = new Computer();
    comp2.OS = OS.getInstance("Windows 10");
    Console.WriteLine(comp2.OS.Name);

})).Start();

Computer comp = new Computer();
comp.Launch("Windows 8.1");
Console.WriteLine(comp.OS.Name);
Console.ReadLine();



//Console.ReadLine();



Console.ReadKey();