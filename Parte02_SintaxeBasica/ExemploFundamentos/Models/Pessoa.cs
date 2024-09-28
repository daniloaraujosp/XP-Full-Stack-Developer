using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar() //(string @class) // uso de palavras registradas com @ (não recomendável)
        {
            // Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");

            /*
            Console.WriteLine($"Olá, meu nome é" + //sinal de + concatenar
            $"{Nome} e tenho {Idade} anos");
            */
            //@class = "teste"; 
            Console.WriteLine($"Olá, meu nome é {Nome} \n e tenho {Idade} anos"); // \n quebra de linha

        }
    }
}