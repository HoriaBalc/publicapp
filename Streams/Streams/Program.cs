using Streams;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using static System.Console;
using static System.Net.WebRequestMethods;
using File = System.IO.File;






//Write some data
List <Sport> sports = new List <Sport> ();
sports.Add(new Sport("running"));
sports.Add(new Sport("cycling"));
sports.Add(new Sport("hiking"));


using (StreamWriter writer = new StreamWriter(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\data.txt")) 
{
    var list = new List<string>();
    foreach(Sport sport in sports)
    {
       var line = sport.Name;  
       list.Add(line);
    }
    foreach (string s in list) { 
        writer.WriteLine(s);
    }
   
}

//Read some data
//List <Sport> sports2 = new List <Sport> ();
//using (StreamReader reader = new StreamReader(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\data.txt"))
//{
//    while (reader.EndOfStream == false)
//    {
//            sports2.Add(new Sport(reader.ReadLine()));
//    }

//}q

//Compress that data
using (Stream data = new FileStream(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\data.txt", FileMode.OpenOrCreate))
using (Stream s = new FileStream(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\GZipCompressed.txt", FileMode.OpenOrCreate))
{
    using (var gzipStream = new GZipStream(s, CompressionLevel.Optimal))
    {
        data.CopyTo(gzipStream);
    }
}

//Ecrypt the data compress
using (Stream data = new FileStream(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\GZipCompressed.txt", FileMode.OpenOrCreate))

using (Stream s = new FileStream(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\Encription.txt", FileMode.OpenOrCreate))
{
    using (var aes = Aes.Create())
    {

        using (CryptoStream cryptStream = new CryptoStream(s, aes.CreateEncryptor(), CryptoStreamMode.Write))
        {
            data.CopyTo(cryptStream);
        }
    }

}

//using (Stream output = new FileStream(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\output.txt", FileMode.OpenOrCreate))

//using (Stream s = new FileStream(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\Encription.txt", FileMode.OpenOrCreate))
//{
//    using (var aes = Aes.Create())
//    {
//        aes.BlockSize = 128;
//        aes.KeySize = 128;
//        aes.Mode = CipherMode.CBC;
//        aes.Padding = PaddingMode.Zeros;
//        using (CryptoStream cryptStream = new CryptoStream(s, aes.CreateDecryptor(), CryptoStreamMode.Read))
//        {
//            //data.CopyTo(cryptStream);
//                s.CopyTo(cryptStream);
                
//                //var result = Encoding.Unicode.GetString(output.ToArray()); ;
//        }
//    }

//}

//read the data
//string sourceFile = @"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\Encription.txt";
//string dataRead = File.ReadAllText(sourceFile);
//WriteLine(dataRead);






