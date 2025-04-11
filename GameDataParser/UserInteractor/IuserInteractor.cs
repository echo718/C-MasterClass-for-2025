namespace GameDataParser.IRepository
{
    public interface IuserInteractor
    {
        string ReadValidFilePath();
        void PrintMessage(string message);
        void PrintError(string message);
    }
}