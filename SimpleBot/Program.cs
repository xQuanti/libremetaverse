﻿//This is merely a template for building upon. I currently have no plans to add anything further to it. It is intended to serve as a simple, expandable base for projects.
using LibreMetaverse;
using OpenMetaverse;

class Program
{
    static void Main(string[] args)
    {
        GridClient client = new GridClient();

        string firstName = Environment.GetEnvironmentVariable("FIRST_NAME");
        string lastName = Environment.GetEnvironmentVariable("LAST_NAME");
        string password = Environment.GetEnvironmentVariable("PASSWORD");
        string mac = Environment.GetEnvironmentVariable("MAC");
        string id0 = Environment.GetEnvironmentVariable("ID0");
        string channel = Environment.GetEnvironmentVariable("CHANNEL");
        string version = Environment.GetEnvironmentVariable("VERSION");

        LoginParams lParams = new LoginParams(client, firstName, lastName, password, channel, version);

        if (mac != null)
        {
            lParams.MAC = mac;
        }

        if (id0 != null)
        {
            lParams.ID0 = id0;
        }
        
        client.Network.Login(lParams);
        client.Network.LoginProgress += new EventHandler<LoginProgressEventArgs>(Network_LoginProgress);
    }

    static void Network_LoginProgress(object sender, LoginProgressEventArgs e)
    {
        if (e.Status == LoginStatus.Success)
        {
            Console.WriteLine("Login successful");
        }
        else
        {
            Console.WriteLine("Login failed");
        }
    }
}
