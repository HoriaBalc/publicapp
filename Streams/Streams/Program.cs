using System.IO.Compression;
using System.Security.Cryptography;
using static System.Console;

//Write some data
using (StreamWriter writer = new StreamWriter(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\data.txt")) 
{
    var list = new List<string>();
    for(int i = 1; i < 11; i++)
    {
       list.Add("name" + i);
    }
    foreach (string s in list) { 
        writer.WriteLine(s);
    }
   
}

//Compress that data
using (Stream data = new FileStream(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\data.txt", FileMode.OpenOrCreate))
    using (Stream s = new FileStream(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\GZipCompressed.txt", FileMode.OpenOrCreate))
    {
        using (var gzipStream = new GZipStream(s, CompressionLevel.Optimal))
        {
            data.CopyTo(gzipStream);
        }
    }

//Ecrypt that data
using (Stream data = new FileStream(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\data.txt", FileMode.OpenOrCreate))

    using (Stream s = new FileStream(@"C:\Users\Roxy\Documents\AMDARIS\dev1\publicapp\Streams\Streams\Encription.txt", FileMode.OpenOrCreate))
    {
        using (var aes = Aes.Create()) {
        
            using (CryptoStream cryptStream = new CryptoStream(s, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                data.CopyTo(cryptStream);
            }
        }
    
    }




