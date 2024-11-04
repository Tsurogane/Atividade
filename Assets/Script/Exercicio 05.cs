using UnityEngine;

public class Exercicio05 : MonoBehaviour
{
    public class Jogador
    {
        public int Pontos { get; private set; }

        public Jogador()
        {
            Pontos = 0; // Inicializa os pontos como 0
        }

        public void AdicionarPontos(int pontos)
        {
            Pontos += pontos; // Adiciona os pontos ao total
        }
    }
    private Jogador jogador;

    void Start()
    {
        jogador = new Jogador();

        // Simula a conclusão da missão com uma quantidade de pontos
        CompletarMissao(60); // Por exemplo, o jogador ganhou 60 pontos
    }

    void CompletarMissao(int pontosGanho)
    {
        jogador.AdicionarPontos(pontosGanho); // Adiciona os pontos ao jogador
        VerificarMissao(); // Verifica se a missão foi bem-sucedida
    }

    void VerificarMissao()
    {
        if (jogador.Pontos >= 50)
        {
            print("Missão bem-sucedida"); 
        }
        else
        {
            print("Missão incompleta");
        }
    }
}
