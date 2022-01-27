using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXAMPLO.POO.src
{
    public class Mago : Herois
    {

     public Mago(string Nome, string Classe) : base(Nome, Classe)
     {
            this.Nome = Nome;
            this.Classe = Classe;
            this.Nivel = 1;
            this.PontosdeVida = 50;
            this.PontosdeMagia = 50;
     }

     public override string Atacar()
     {
         Random dado = new Random();
            int ForcadoAtaque = this.Nivel + dado.Next(1, 10); // a forca do ataque e igual ao nivel + o numero aleatorio entre 1 a 20.
            this.UltimoAtaque = ForcadoAtaque;
            
            return this.Nome + " Ataca com a sua magia e da " + ForcadoAtaque  + " de dano";
     }

     public string Atacar(int bonus)
     {
         Random dado = new Random();
         int ForcadoAtaque = this.Nivel + dado.Next(1, 10);
         this.UltimoAtaque = ForcadoAtaque;

         return this.Nome + " Ataca com a sua magia e da " + ForcadoAtaque + " de dano de bonus " + bonus;
     }


    }
}