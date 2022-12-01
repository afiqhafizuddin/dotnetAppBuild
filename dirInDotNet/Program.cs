// Work with the file system

// .NET Contains built-in type for working with file systwm thru System.IO namespace
// 

using System.IO;

//IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("directories\\stores");
IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("stores");

foreach (var directory in listOfDirectories)
{
    Console.WriteLine(directory);
}

IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("stores", "*.txt", SearchOption.AllDirectories);
foreach (var file in allFilesInAllFolders)
{
    Console.WriteLine(file);
}