using UnityEngine;

public class Exercicio05 : MonoBehaviour
{
    public class Jogador
    {
        public int Pontos { get; private set; }

        public Jogador()
        {
            Pontos = 0; 
        }

        public void AdicionarPontos(int pontos)
        {
            Pontos += pontos; 
        }
    }
    private Jogador jogador;

    void Start()
    {
        jogador = new Jogador();

       
        CompletarMissao(60); 
    }

    void CompletarMissao(int pontosGanho)
    {
        jogador.AdicionarPontos(pontosGanho); // Adiciona os pontos ao jogador
        VerificarMissao(); // Verifica se a miss�o foi bem-sucedida
    }

    void VerificarMissao()
    {
        if (jogador.Pontos >= 50)
        {
            print("Miss�o bem-sucedida"); 
        }
        else
        {
            print("Miss�o incompleta");
        }
    }
}
