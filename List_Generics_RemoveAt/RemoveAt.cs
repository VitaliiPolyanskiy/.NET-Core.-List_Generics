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

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
        Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
        Console.WriteLine("Count: {0}", dinosaurs.Count);
        Console.WriteLine("\nRemoveAt(3)");
        dinosaurs.RemoveAt(3);

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
        Console.WriteLine("Count: {0}", dinosaurs.Count);

    }
}
