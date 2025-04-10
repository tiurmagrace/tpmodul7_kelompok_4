using System;
using System.IO;
using System.Text.Json;

public class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class MahasiswaData
{
    public Nama nama { get; set; }
    public string nim { get; set; }
    public string fakultas { get; set; }
}

public class DataMahasiswa2311104053
{
    public void ReadJSON()
    {
        string json = File.ReadAllText("tp7_1_2311104053.json");
        MahasiswaData data = JsonSerializer.Deserialize<MahasiswaData>(json);
        Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan NIM {data.nim} dari fakultas {data.fakultas}");
    }
}