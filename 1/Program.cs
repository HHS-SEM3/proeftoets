using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;

namespace MijnServer
{
    class Program
    {
        static string AdminPassword { get; set; } = "Voetbal123";
        // Vraag 1b: ...
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(new System.Net.IPAddress(new byte[] { 127,0,0,1 }), 8080);
            server.Start();
            while (true)
            {
                using Socket connectie = server.AcceptSocket();
                using (Stream request = new NetworkStream(connectie))
                {
                    using StreamReader requestLezer = new StreamReader(request);
                    string locatie = requestLezer.ReadLine().Split(" ")[1].Substring(1);
                    if (locatie.Contains("?")) {
                        var parameters = locatie.Substring(locatie.IndexOf("?") + 1).Split("&").Select(i => {
                            var ii = i.Split();
                            return new {Param = ii[0], Waarde = ii[1]};
                        }); 
                    }
                    if (locatie == "") locatie = null;
                    string regel = requestLezer.ReadLine();
                    while (regel != "" && !requestLezer.EndOfStream)
                    {
                        string[] stukjes = regel.Split(":");
                        string header = stukjes[0];
                        string waarde = stukjes[1];
                        regel = requestLezer.ReadLine();
                    }
                    var response = "HTTP/1.0 200 OK\r\nContent-Type: text/html\r\n\r\n" + File.ReadAllText((locatie ?? "index") + ".html");
                    connectie.Send(System.Text.Encoding.ASCII.GetBytes(response));
                }
            }
        }
    }
}
