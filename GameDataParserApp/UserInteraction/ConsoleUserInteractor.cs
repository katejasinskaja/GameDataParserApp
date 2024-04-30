public class ConsoleUserInteractor : IUserInteractor
{
    
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public void PrintError(string message)
    {
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);       
        Console.ForegroundColor = originalColor;
    }
    public string ReadFilePath()
    {
        bool isFilePathValid = false;
        string fileName = default;

        do
        {
            Console.WriteLine("Enter the name of the file you want to read:");
            fileName = Console.ReadLine();
            if (fileName == null)
            {
                Console.WriteLine("The file name cannot be null");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("The file name cannot be empty");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine("The file does not exist");
            }
            else
            {

                isFilePathValid = true;
            }

        }
        while (!isFilePathValid);
        return fileName;
    }
}
