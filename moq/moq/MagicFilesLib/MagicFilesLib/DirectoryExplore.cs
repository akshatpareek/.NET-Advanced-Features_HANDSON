using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MagicFilesLib
{

    public interface IDirectoryExplorer
    {
        ICollection<string> GetFiles(string path);
    }

    public class DirectoryExplorer :IDirectoryExplorer
    {
        IDirectoryExplorer directoryExplorer;
        public DirectoryExplorer(IDirectoryExplorer directoryExplorer)
        {
            this.directoryExplorer = directoryExplorer;
        }

        public ICollection<string> GetFiles(string path)
        {
            return directoryExplorer.GetFiles(path);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
