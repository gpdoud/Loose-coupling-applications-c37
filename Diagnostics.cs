namespace testconsole {

    internal class Diagnostics : ILogger {

        public void Log(object message) {
            System.Diagnostics.Debug.WriteLine(message.ToString());
        }

    }
}