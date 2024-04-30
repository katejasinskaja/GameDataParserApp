public interface IUserInteractor
{
    string ReadFilePath();
    void ShowMessage(string message);

    void PrintError(string message);
}
