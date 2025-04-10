using System;

class Program
{
    static void Main(string[] args)
    {
        var mhs = new DataMahasiswa2311104053();
        mhs.ReadJSON();

         var kuliah = new KuliahMahasiswa2311104053();
        kuliah.ReadJSON();

         DataMahasiswa2311104042.ReadJSON();
        KuliahMahasiswa2311104042.ReadJSON(); 
        Console.ReadLine();

        Console.WriteLine("=== JSON 1 ===");
        DataMahasiswa2311104061.ReadJSON();
        
        Console.WriteLine("\n=== JSON 2 ===");
        KuliahMahasiswa2311104061.ReadJSON();

        Console.WriteLine("\nTekan Enter untuk keluar...");
        Console.ReadLine();

    }
}
