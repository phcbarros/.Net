using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace CompresaoWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            using(WebApp.Start<Startup>("http://localhost:55042/"))
            {
                Console.WriteLine("Serviço de consulta de produtos em execução");
                Console.WriteLine("Pressione qualquer tecla para encerar este");
                Console.ReadKey();
            }
        }
    }
}
