namespace FactoryMethod;
public static class FileFactory
{
    public static void Save(string filePath, object data) => Console.WriteLine("File saved");

    public static void Delete(string filePath) => Console.WriteLine("File deleted");
}
