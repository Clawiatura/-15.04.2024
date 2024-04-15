//Напишите программу, которая просит пользователя ввести путь к файлу на
//компьютере. Затем программа должна проверить, существует ли
//указанный файл, и вывести соответствующее сообщение. Если файл
//существует, программа должна также вывести его размер в байтах, дату
//последнего изменения и расширение файла

using System.IO;

Console.WriteLine("Введите путь к файлу: ");
string fileUser = Console.ReadLine();
if (File.Exists(fileUser))
{
    FileInfo fileInfo = new FileInfo(fileUser);
    Console.WriteLine($"Файл существует: Размер: {fileInfo.Length} байт. Дата последнего изменения: {fileInfo.LastWriteTime}. Расширение файла: {fileInfo.Extension}\");");


}
else
{
    Console.WriteLine("Файл не существует.");
}