using System.IO;
using System.Collections.Generic;


var salesFiles = FindFiles("stores");
foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}
IEnumerable<string> FindFiles(string folderNames)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderNames, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        // The file name will contain full path, so just the check the end of it
        if (file.EndsWith("sales.json"))
        {
            salesFiles.Add(file);
        }
    }
    return salesFiles;
}

Console.WriteLine(Directory.GetCurrentDirectory());

string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
Console.WriteLine(documentPath);