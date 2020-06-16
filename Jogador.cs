using System;

namespace Aula18Dojo1
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime Nascimento { get; set; }
        public string Nacionalidade { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }

        public string MostrarDados(){
                return $"Nome: {Nome} \nPosição: {Posicao} \nData de Nascimento: {Nascimento} \nNacionalidade: {Nacionalidade} \nAltura: {Altura} \nPeso:{Peso}";
        }
    }
}