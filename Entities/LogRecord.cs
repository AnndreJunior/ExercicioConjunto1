namespace Conjuntos.Entities;

public class LogRecord
{
    public string Username { get; set; } = string.Empty;
    public DateTime Instant { get; set; }

    public override int GetHashCode()
    {
        return Username.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj is not LogRecord)
            return false;

        LogRecord other = obj as LogRecord ?? new LogRecord();
        return Username.Equals(other.Username);
    }
}
