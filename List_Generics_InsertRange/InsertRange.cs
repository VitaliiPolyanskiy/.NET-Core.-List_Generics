public class Example
{
    public static void Main()
    {
        string[] input = [ "Brachiosaurus", 
                           "Amargasaurus", 
                           "Mamenchisaurus" ];

        List<string> dinosaurs = new(input);

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
             
        input = [ "Tyrannosaurus","Deinonychus","Velociraptor"];

        Console.WriteLine("\nInsertRange(1, input)");
        dinosaurs.InsertRange(1, input);

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

      
    }
}

