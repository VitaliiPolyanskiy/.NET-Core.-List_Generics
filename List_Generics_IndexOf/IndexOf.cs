public class Example
{
    public static void Main()
    {
        List<string> dinosaurs =
        [
            "Tyrannosaurus",
            "Amargasaurus",
            "Mamenchisaurus",
            "Brachiosaurus",
            "Deinonychus",
            "Tyrannosaurus",
            "Compsognathus",
        ];

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        Console.WriteLine("\nIndexOf(\"Tyrannosaurus\"): {0}",
            dinosaurs.IndexOf("Tyrannosaurus"));

        Console.WriteLine("\nIndexOf(\"Tyrannosaurus\", 3): {0}",
            dinosaurs.IndexOf("Tyrannosaurus", 3));

        Console.WriteLine("\nIndexOf(\"Tyrannosaurus\", 2, 3): {0}",
            dinosaurs.IndexOf("Tyrannosaurus", 2, 3));
    }
}
