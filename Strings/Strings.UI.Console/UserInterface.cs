using Strings.Core;

var myStrings = new MyString[]
{
    new MyString("A mamá Roma le aviva el amor a papá y a papá Roma le aviva el amor a mamá"),
    new MyString("Anita, la gorda lagartona, no traga la droga latina"),
    new MyString("Madam, I'm Adam"),
    new MyString("Oye, sí. Versos revisé yo"),
};

foreach (var myString in myStrings)
{
    Console.WriteLine(myString.IsPalindrome());
}