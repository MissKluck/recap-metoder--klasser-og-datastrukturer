namespace recap_metoder__klasser_og_datastrukturer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // decimal mer presis, om vi skriver et program som skal gjøre trigonometri og bruke sinus, samt bruke i finans
        // for vanlig programmering er double og int nok
        // float er mindre presis igjen, mindre i størrelse
        // long er større, men ikke nødvendig i vanlig data
        // med de primitive dataklassene kan vi gjøre ganske mye


        Person person = new Person(); //henter inn klassen person så vi kan bruke de funksjonene her
        person.Name = "John Doe";
        person.Age = 30;
        person.Hobby = "coding";
        
        List<Person> someGenericTypeObject = new List<Person>(); //Da har vi en liste av generic type object som er person og alt som er inne i person
        someGenericTypeObject.Add(person);

        foreach (var people in someGenericTypeObject)
        {
            Console.WriteLine($"{people.Name} {person.Age} {person.Hobby}");
        }
    }
}
