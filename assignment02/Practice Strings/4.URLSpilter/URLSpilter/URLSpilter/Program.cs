using System;
using System.Text;

class Program
{
    public static void Main()
    {
        string url = "https://www.apple.com/iphone";

        string protocol = "";
        string server = "";
        string resource = "";

        int serverStart = url.IndexOf("://") + 3;
        int resourceStart = url.IndexOf("/", serverStart);
        Console.WriteLine(resourceStart);

        if (serverStart > 3 && resourceStart > serverStart)
        {
            protocol = url.Substring(0, serverStart - 3);
            server = url.Substring(serverStart, resourceStart - serverStart);
            resource = url.Substring(resourceStart + 1);
        }
        else if (serverStart > 3)
        {
            protocol = url.Substring(0, serverStart - 3);
            server = url.Substring(serverStart);
        }
        else if (resourceStart > 0)
        {
            server = url.Substring(0, resourceStart);
            resource = url.Substring(resourceStart + 1);
        }
        else
        {
            server = url;
        }
        Console.WriteLine("[protocol] = " +  protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " +  resource);
    }
}


/*
public static void Main()
{
    String url = "https://google.com";

    string protocol = findProtocol(url);
    Console.WriteLine("[protocol] = " + protocol);
    string server = findServer(url);
    Console.WriteLine("[server] = " + server);
    string resource = findResource(url);
    Console.WriteLine("[resource] = " + resource);


}

public static string findProtocol(string url)
{
    StringBuilder sb = new StringBuilder();
    Char[] urlArray = url.ToCharArray();
    if (url.Contains("://"))
    {
        for (int i = 0; i < urlArray.Length; i++)
        {
            if (urlArray[i].Equals(':'))
            {
                break;
            }
            sb.Append(urlArray[i]);
        }
    }

    if (sb.Length == 0)
    {
        return "";
    }
    return sb.ToString();


}

public static string findServer(string url)
{
    StringBuilder sb = new StringBuilder();
    Char[] urlArray = url.ToCharArray();
    string server;
    int pointer = 0;
    if (url.Contains("://"))
    {
        int serverStart = url.IndexOf("://") + 3;
        int resourceStart = url.IndexOf("/", serverStart);
        server = url.Substring(serverStart, resourceStart - serverStart);

    }
    else
    {
        int serverStart = 0;
        int resourceStart = url.IndexOf("/", serverStart);
        server = url.Substring(0, resourceStart);
    }
    return server;
}

public static string findResource(string url)
{

    string server = "";
    string resource = "";
    if (url.Contains("://"))
    {
        int serverStart = url.IndexOf("://") + 3;
        int resourceStart = url.IndexOf("/", serverStart);
        server = url.Substring(serverStart, resourceStart - serverStart);
        resource = url.Substring(resourceStart + 1);

    }
    else
    {
        int serverStart = 0;
        int resourceStart = url.IndexOf("/", serverStart);
        server = url.Substring(0, resourceStart);
        resource = url.Substring(resourceStart + 1);
    }
    return resource;

}
*/





