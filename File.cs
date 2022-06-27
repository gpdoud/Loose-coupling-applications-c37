namespace testconsole {

    internal class File : ILogger {

        public void Log(object message) {
            System.IO.File.AppendAllText(@"c:\repos\testconsole\Logger.txt", message.ToString()+ Environment.NewLine);
        }
    }
}
