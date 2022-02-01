using System;
namespace StrategyDesignPattern
{
    public interface ICompression
    {
        void CompressFolder(string compressedArchiveFileName);
    }
}

namespace StrategyDesignPattern
{
    public class RarCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using Rar approach: '" + compressedArchiveFileName
                 + ".rar' file is created");
        }
    }
}
namespace StrategyDesignPattern
{
    public class ZipCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using zip approach: '" + compressedArchiveFileName
                 + ".zip' file is created");
        }
    }
}
namespace StrategyDesignPattern
{
    public class CompressionContext
    {
        private ICompression Compression;

        public CompressionContext(ICompression Compression)
        {
            this.Compression = Compression;
        }

        public void SetStrategy(ICompression Compression)
        {
            this.Compression = Compression;
        }

        public void CreateArchive(string compressedArchiveFileName)
        {
            Compression.CompressFolder(compressedArchiveFileName);
        }
    }
}

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CompressionContext ctx = new CompressionContext(new ZipCompression());
            ctx.CreateArchive("DotNetDesignPattern");

            ctx.SetStrategy(new RarCompression());
            ctx.CreateArchive("DotNetDesignPattern");

            Console.Read();
        }
    }
}