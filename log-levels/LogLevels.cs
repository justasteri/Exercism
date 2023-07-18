using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(":")[1].Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Split(":")[0].Replace("[","").Replace("]","").ToLower();
        //return logLine;
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string m = Message(logLine);
        string l = LogLevel(logLine);
        return $"{m} ({l})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
