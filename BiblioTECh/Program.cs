using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BiblioTECh // Note: actual namespace depends on the project name.
{
    public class Program
    {
        Menu menu;
        private SalvarDados salvar = new SalvarDados();
        public Program()
        {  
            salvar.Lerdados();
        menu = new Menu(); 
        }
        static void Main(string[] args)
        {
           Program ini = new Program();
        }
    }
}