using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TestNetUtils
{
    public static class FileUtils
    {
        public static StreamReader OpenText(string source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            var file = (IsPath(source) == true) ? source : FindFileProject(source);

            if(file != null)
               return new StreamReader(file);

            return null;
        }

        public static string PathFile(string name){
            return null;
        }

        public static string OpenStringText(string source){
            return null;
        }

        private static string DirectoryBrowser(string name){
            return null;
        }

        public static bool FileExists(string name){
            return false;
        }
        
        private static bool IsPath(string directory) => directory.Contains("\\") || directory.Contains(":");
        
        private static string FindFileProject(string name)
        {
            var project = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            var files = DirSearch(project);

            return files.Where(x => x.Contains(name)).First();
        }

        private static List<String> DirSearch(string sDir)
        {
            var files = new List<String>();
            foreach (var f in Directory.GetFiles(sDir))
            {
                files.Add(f);
            }
            foreach (var d in Directory.GetDirectories(sDir))
            {
                files.AddRange(DirSearch(d));
            }
            return files;
        }


    }
}
