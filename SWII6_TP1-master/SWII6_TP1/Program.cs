using Microsoft.AspNetCore.Hosting;
using System;
using System.Threading;
using SWII6_TP1;

namespace SWII6_TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();

            Author[] at = new Author[2];
            Author a = new Author("Douglas Adams", "douglasadams@mochileiro.com", 'm');
            Author a1 = new Author("E. Lockhart", "lockhart@seguinte.com", 'f');
            at.SetValue(a, 0);
            at.SetValue(a1, 1);
            Book b = new Book("O Guia do Mochileiro das Galáxias",at,2.00,0);
            Console.WriteLine(b.ToString());
            Console.WriteLine();
            Console.WriteLine(b.getAuthorNames());            

            Console.ReadKey();
        }
    }
}
