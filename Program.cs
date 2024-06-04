using Conjuntos.Entities;

Console.Clear();

string path = Path.Combine(AppContext.BaseDirectory, "../../../", "log.csv");

HashSet<LogRecord> logRecords = [];

try
{
    using StreamReader sr = File.OpenText(path);
    while (!sr.EndOfStream)
    {
        string[] line = (sr.ReadLine() ?? "").Split(' ');
        string name = line[0];
        DateTime instant = DateTime.Parse(line[1]);
        logRecords.Add(new LogRecord { Username = name, Instant = instant });
    }
    Console.WriteLine($"Total users: {logRecords.Count}");
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}
