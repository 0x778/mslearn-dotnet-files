using System.IO;
using System.Collections.Generic;
//Get specifec File that is inside The funcation
var salesFiles = FindFiles("stores");

foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}
//Get current path
Console.WriteLine(Directory.GetCurrentDirectory());
string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
////////////////////////////////////////////////////////////////////////////
Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");

// returns:
// stores\201 on Windows
// stores/201 on macOS

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        // The file name will contain the full path, so only check the end of it
        if (file.EndsWith("sales.json"))
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}