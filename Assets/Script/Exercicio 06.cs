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
        EscolherPersonagem("Guerreiro"); 
    }

    void EscolherPersonagem(string tipo)
       
    {
      
        personagem = new Personagem(tipo); 

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

