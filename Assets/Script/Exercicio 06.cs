using UnityEngine;

public class Exercicio06 : MonoBehaviour
{
    public class Personagem
    {
        public string Tipo { get; private set; }

        public Personagem(string tipo)
        {
            Tipo = tipo;
        }
    }

    private Personagem personagem;

    void Start()
    {
        EscolherPersonagem("Guerreiro"); // Simulando a escolha do personagem
        // Você pode mudar para "Mago" para testar a outra opção
    }

    void EscolherPersonagem(string tipo)
       
    {
      
        personagem = new Personagem(tipo); // Cria o personagem baseado na escolha

        if (personagem.Tipo == "Guerreiro")
        {
            print("Guerreiro escolhido");
        }
        else if (personagem.Tipo == "Mago")
        {
            print("Mago escolhido");
        }
        else
        {
            print("Tipo de personagem inválido");
        }
    }
}

