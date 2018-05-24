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

            var file = default(string);

            if (IsPath(source))
                file = source;

            file = FindFileProject(source);

            if(file != null)
               return new StreamReader(file);

            return null;

        }

        private static bool IsPath(string directory) => directory.Contains("\\") || directory.Contains(":");
        
        private static string FindFileProject(string name)
        {
            var project = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            var files = DirSearch(project);

            var file = files.Where(x => x.Contains(name)).First();

            return file;
        }

        private static List<String> DirSearch(string sDir)
        {
            List<String> files = new List<String>();
            foreach (string f in Directory.GetFiles(sDir))
            {
                files.Add(f);
            }
            foreach (string d in Directory.GetDirectories(sDir))
            {
                files.AddRange(DirSearch(d));
            }
            return files;
        }


    }
}
