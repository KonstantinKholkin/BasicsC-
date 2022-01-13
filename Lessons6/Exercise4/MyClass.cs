
using System.Diagnostics;


namespace Exercise4
{
    internal class MyClass
    {
        

        public void ReadRecordFile()
        {
        long kbyte = 1024;
        long mbyte = 1024 * kbyte;
        long gbyte = 1024 * mbyte;
        long size = mbyte;

        Console.WriteLine("Запись файлов при помощи разных потоков:");
        Console.WriteLine("FileStream. Milliseconds:{0}", FileStreamSampleWrite("D:\\temp\\bigdata0.bin", size));
        Console.WriteLine("BinaryStream. Milliseconds:{0}", BinaryStreamSampleWrite("D:\\temp\\bigdata1.bin", size));
        Console.WriteLine("StreamWriter. Milliseconds:{0}", StreamWriterSampleWrite("D:\\temp\\bigdata2.bin", size));
        Console.WriteLine("BufferedStream. Milliseconds:{0}", BufferedStreamSampleWrite("D:\\temp\\bigdata3.bin", size));

        Console.WriteLine("Чтения файлов при помощи разных потоков:");
        byte[] bytesFromFileStream = FileStreamSampleRead("D:\\temp\\bigdata0.bin");
        int[] integersFromBinatyStream = BinaryStreamSampleRead("D:\\temp\\bigdata1.bin");
        string stringFromSreamReader = StreamReaderSample("D:\\temp\\bigdata2.bin");
        byte[] bytesFromBufferedStream = BufferedStreamSampleRead("D:\\temp\\bigdata3.bin");


        }

        //Метод записи в файл при помощи FileStream

        static long FileStreamSampleWrite(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            

            for (int i = 0; i < size; i++)
                fs.WriteByte(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        //Метод чтения из файла при помощи FileStream

        static byte[] FileStreamSampleRead(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] byteArray = new byte[fs.Length];
            for (int i = 0; i < fs.Length; i++)
                byteArray[i] = (byte)fs.ReadByte();
            fs.Close();
            return byteArray;
        }

        //Метод записи в файл при помощи BinaryStream

        static long BinaryStreamSampleWrite(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < size; i++)
                bw.Write((byte)0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        //Метод чтения из файла при помощи BinaryStream

        static int[] BinaryStreamSampleRead(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int[] intArr = new int[fs.Length / 4];
            BinaryReader br = new BinaryReader(fs);
            for (int i = 0; i < fs.Length / 4; i++)
                intArr[i] = br.ReadInt32();
            fs.Close();
            return intArr;
        }

        //Метод записи в файл при помощи StreamReader

        static long StreamWriterSampleWrite(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < size; i++)
                sw.Write(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        //Метод чтения из файла при помощи StreamReader

        static string StreamReaderSample(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string result = sr.ReadToEnd();
            fs.Close();
            return result;
        }

        //Метод записи в файл при помощи BufferedStream

        static long BufferedStreamSampleWrite(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Write(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        // Метод чтения из файла при помощи BufferedStream

        static byte[] BufferedStreamSampleRead(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int countPart = 4;//количество частей
            int bufsize = (int)(fs.Length / countPart);
            byte[] buffer = new byte[fs.Length];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            for (int i = 0; i < countPart; i++)
                bs.Read(buffer, 0, (int)bufsize);
            fs.Close();
            return buffer;
        }
    }
}
