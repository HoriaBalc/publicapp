using System.IO;
using System.IO.Compression;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using static System.Console;

//#region RW Binary data

//WriteLine("\n<--- Read and Write primitive types with BinaryWriter --->");

//FileInfo f = new FileInfo("BinFile.dat");
//using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
//{
//    double aDouble = 1234.67;
//    int anInt = 34567;
//    byte[] arr1 = { 4, 25, 40, 3, 11, 18, 7 };
//    string aString = "Some String";
//    bw.Write(aDouble);
//    bw.Write(anInt);
//    bw.Write(arr1);
//    bw.Write(aString);
//}

//using (BinaryReader br = new BinaryReader(f.OpenRead()))
//{
//    WriteLine(br.ReadDouble());
//    WriteLine(br.ReadInt32());
//    byte[] arr2 = br.ReadBytes(7);
//    Array.ForEach(arr2, item => Write($"{item} ; "));
//    WriteLine();
//    WriteLine(br.ReadString());
//}

//#endregion

//#region Compression

//using (Stream s = File.Create("compressed.dat"))
//    using (Stream ds = new DeflateStream(s, CompressionMode.Compress))
//        for (byte i = 0; i < 100; i++)
//            ds.WriteByte(i);

//    using (Stream s = File.OpenRead("compressed.dat"))
//    using (Stream ds = new DeflateStream(s, CompressionMode.Decompress))
//        for (byte i = 0; i < 100; i++)
//            WriteLine(ds.ReadByte()); // Writes 0 to 99

//#endregion


//#region GZipCompression

//using (Stream s = File.Create("GZipCompressed.dat"))
//{
//    using (var gzipStream = new GZipStream(s, CompressionLevel.Optimal))
//    {
//        for (byte i = 0; i < 100; i++)
//            gzipStream.WriteByte(i);
//    }
//}

//using (Stream s = File.OpenRead("GZipCompressed.dat"))
//{
//    using (var gzipStream = new GZipStream(s, CompressionMode.Decompress))
//    {
//        for (byte i = 0; i < 100; i++)
//            WriteLine(gzipStream.ReadByte());
//    }
//}

//#endregion

#region Encryption

using (Stream s = File.Create("Encription.dat"))
{
    using (var aes = Aes.Create()) {
        
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.None;
        aes.KeySize = 256;
        aes.BlockSize = 128;
        using (CryptoStream cryptStream = new CryptoStream(s, aes.CreateEncryptor(), CryptoStreamMode.Write))
        {
            for (byte i = 0; i < 128; i++)
                if(i<100)
                    cryptStream.WriteByte(i);
                else cryptStream.WriteByte(i);
        }
    }
    
}

using (Stream s = File.OpenRead("GZipCompressed.dat"))
{
    using (var aes = Aes.Create()) 
    {
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.None;
        aes.KeySize = 256;
        aes.BlockSize = 128;
        using (CryptoStream cryptStream = new CryptoStream(s, aes.CreateDecryptor(), CryptoStreamMode.Read))
        {
            for (byte i = 0; i < 100; i++)
                WriteLine(cryptStream.ReadByte());
        }
    }
        
}

#endregion


