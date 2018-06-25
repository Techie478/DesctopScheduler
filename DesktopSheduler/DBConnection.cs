using System;
using System.IO;

public class DBConnection
{
    private string path = "/resources/eventList.json";
    private DBConnection instance = null;
    private static readonly object padlock = new object();

    public static DBConnection Instance { get { return Nested.Instance; } }

    private class Nested {
        static Nested() {

        }

        internal static readonly DBConnection instance = new DBConnection();
    }

	public DBConnection()
	{
        using (StreamReader reader = new StreamReader(path))
        {
            var json = reader.ReadToEnd();

        }
    }
}
