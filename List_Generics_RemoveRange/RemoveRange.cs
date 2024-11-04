public class Example
{
    public static void Main()
    {
        List<string> dinosaurs =
        [
            "Compsognathus",
            "Amargasaurus",
            "Oviraptor",
            "Velociraptor",
            "Deinonychus",
            "Dilophosaurus",
            "Gallimimus",
            "Triceratops",
        ];

        Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
        Console.WriteLine("\nRemoveRange(2, 2)");
        dinosaurs.RemoveRange(2, 2);

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
    }
}

