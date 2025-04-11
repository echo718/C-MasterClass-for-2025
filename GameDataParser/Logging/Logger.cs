namespace GameDataParser
{
    public class Logger
    {
        private string _logFileName;
        public Logger(string loFileName)
        {
            _logFileName = loFileName;
        }

        public void Log(Exception ex)
        {
            var entry =
                    $@"[{DateTime.Now}]
                    Exception message: {ex.Message}
                    Stack track:{ex.StackTrace}
                    
                    ";

            File.AppendAllText(_logFileName, entry);

        }
    }
}