﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorNuvens gerenciadorNuvens = new GerenciadorNuvens();
            gerenciadorNuvens["padrão"] = new NuvemConcreta("branca", "Azul");
            gerenciadorNuvens["personalizada"] = new NuvemConcreta("branco", "laranja");

            NuvemConcreta um = gerenciadorNuvens["padrão"].Clone() as NuvemConcreta;
            NuvemConcreta dois = gerenciadorNuvens["padrão"].Clone() as NuvemConcreta;
            NuvemConcreta tres = gerenciadorNuvens["personalizada"].Clone() as NuvemConcreta;
            Console.ReadKey();
        }
    }
}
