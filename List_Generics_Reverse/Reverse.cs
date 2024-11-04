
public class Example
{
    public static void Main()
    {
        List<string> dinosaurs =
        [
            "Pachycephalosaurus",
            "Parasauralophus",
            "Mamenchisaurus",
            "Amargasaurus",
            "Coelophysis",
            "Oviraptor",
        ];

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        dinosaurs.Reverse();

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        dinosaurs.Reverse(1, 4);

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
    }
}
