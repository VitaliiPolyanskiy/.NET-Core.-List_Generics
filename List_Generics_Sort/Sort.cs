public class Example
{
    public static void Main()
    {
        List<string> dinosaurs =
        [
            "Pachycephalosaurus",
            "Amargasaurus",
            "Mamenchisaurus",
            "Deinonychus",
        ];

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        Console.WriteLine("\nSort");
        dinosaurs.Sort();

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
    }
}
