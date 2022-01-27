using System;
using EXAMPLO.POO.src;

class program
{


    static void Main(string[] args)
    {
         Herois arus = new Herois("Arus", "Guerreiro");
         Mago   wedge = new Mago("wedge", "Mago Negro");
         Inimigo King = new Inimigo("King", "Zumbi");

         Console.WriteLine(arus.Atacar());
         Console.WriteLine(King.Atacar());

         if(arus.UltimoAtaque == King.UltimoAtaque){
             Console.WriteLine(" Empate, ambos deram dano de " + arus.UltimoAtaque);
         }else if(arus.UltimoAtaque > King.UltimoAtaque)
         {
             King.ReceberDano(arus.UltimoAtaque - King.UltimoAtaque);
             Console.WriteLine(arus.Nome + " Venceu !!! ");
         }else
         {
            arus.ReceberDano(King.UltimoAtaque - arus.UltimoAtaque);
             Console.WriteLine(King.Nome + " Venceu !!! ");
         }

         
         //Console.WriteLine(wedge.Atacar(24)); // toda vez que for chamar um metodo usar (), está com numeração por conta do bonus.



        //   Console.WriteLine(arus.Nivel);
        //   Console.WriteLine("wedge", "Mago Negro");
        //   Console.WriteLine(wedge.TroString());

    //  Herois heroi = new Herois(); // nova instancia de classe
    //  heroi.Nome = "Arus";
    //  heroi.Nivel = 1;
    //  heroi.Classe = "Guerreiro";
    //  heroi.PontosdeMagia = 10;
    //  heroi.PontosdeVida = 100;
    //  Console.WriteLine(" O nome do meu heroi é : " + heroi.Nome);
    }
}