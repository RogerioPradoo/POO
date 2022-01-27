using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXAMPLO.POO.src
{
    public class Herois
    {

        public Herois(string Nome, string Classe)
        {
            this.Nome = Nome;
            this.Classe = Classe;
            this.Nivel = 1;
            this.PontosdeVida = 50;
            this.PontosdeMagia = 50;
            // salva os dados que você vai criando...
            // this e para se referir a classe que você está
        }

        public string Nome { get; set; }
        public int    Nivel { get; set; }
        public int    PontosdeVida { get; set; }
        public int    PontosdeMagia { get; set; }
        public string Classe { get; set; }
        public int UltimoAtaque { get; set; } 
        

        public override string ToString(){
            return "Meu Nome é: " + this.Nome          + "\n"
            + "Nivel: "           + this.Nivel         + "\n"
            + "Classe: "          + this.Classe        + "\n"
            + "Ponto de Vida: "   + this.PontosdeVida  + "\n"
            + "Ponto de Magia: "  + this.PontosdeMagia + "\n";
        }

        public virtual string Atacar()
        {
            Random dado = new Random();
            int ForcadoAtaque = this.Nivel + dado.Next(1, 20); // a forca do ataque e igual ao nivel + o numero aleatorio entre 1 a 20.
            this.UltimoAtaque = ForcadoAtaque;
            
            return this.Nome + " Ataca com sua espada e da "
                             + ForcadoAtaque  + " de dano";
        }

        public void ReceberDano(int danosRecebido)
        {
            this.PontosdeVida = this.PontosdeVida - danosRecebido;
        }
    }
}