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

// work with file paths in .NET

Console.WriteLine(Directory.GetCurrentDirectory());

string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
Console.WriteLine(documentPath);

Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
Console.WriteLine(Path.Combine("stores", "201"));
Console.WriteLine(Path.GetExtension("sales.json"));

string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

FileInfo info = new FileInfo(fileName);

Console.WriteLine($"Full name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Create date: {info.CreationTime}");

// create and delete files and driectories

// use Directory and File classes to create dir & files

Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newDir"));


// make sure sub directories exists

bool doesDirectoryExist = Directory.Exists("C:\\Users\\10103207\\src\\dotnetAppBuild\\dirInDotNet\\stores\\203");
Console.WriteLine(value: doesDirectoryExist);

// create files
File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greetings.txt"), "Hello World!");

