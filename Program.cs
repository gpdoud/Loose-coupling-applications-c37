

testconsole.Console CONSOLE = new();
testconsole.Diagnostics DIAGNOSTICS = new();
testconsole.File FILE = new();

void Log(ILogger logger, string message) {
    logger.Log(message);
}

Log(CONSOLE, "Console message");

Log(DIAGNOSTICS, "Debug message");

Log(FILE, "File message");