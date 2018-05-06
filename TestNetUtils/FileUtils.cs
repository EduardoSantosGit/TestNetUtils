using System;
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

            if (IsPath(source))
                return new StreamReader(source);

            var file = FindFileAllDirectory(source);

            return null;
            
        }

        private static bool IsPath(string directory)
        {
            return (directory.Contains("\\") || directory.Contains(":"));
        }

        private static string FindFileAllDirectory(string name)
        {

            var location = typeof(FileUtils).GetTypeInfo().Assembly.Location;
            var dirPath = Path.GetDirectoryName(location);

            if (File.Exists(Path.Combine(dirPath, name)) == false)
            {
                if (File.Exists(Path.Combine(dirPath, $"..\\{name}")))
                {
                    name = $"..\\{name}";
                }
                else if (File.Exists(Path.Combine(dirPath, $"{(name.StartsWith("..\\") ? name.Remove(0, 3) : name)}")))
                {
                    name = name.Remove(0, 3);
                }
            }

            return null;
        }

    }
}
