using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXAMPLO.POO.src
{
    public class Inimigo : Herois
    {
        public Inimigo(string Nome, string Classe) : base(Nome, Classe)
        {
            this.Nome = Nome;
            this.Classe = Classe;
            this.Nivel = 1;
            this.PontosdeVida = 80;
            this.PontosdeMagia = 0;
        }

        public override string Atacar()
        {
            Random dado = new Random();
            int ForcadoAtaque = this.Nivel + dado.Next(1, 15);
            this.UltimoAtaque = ForcadoAtaque;
            
            return this.Nome + " Ataca e da  " + ForcadoAtaque + " de dano ";
        }
    }
}