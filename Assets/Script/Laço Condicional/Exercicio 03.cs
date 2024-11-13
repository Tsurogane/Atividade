using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Exercicio03 : MonoBehaviour
{
   

   

    [SerializeField] bool playerVivo; 
    [SerializeField] bool powerUp; 
    double vidaPlayer = 100;

    int vidaPlayerIncial = 100;
    double vidaplayerAtual = 100;

    void Start()
    {
        if (playerVivo == false && powerUp == true)
        {
            vidaPlayer = vidaPlayer * 0.5;
            print("Ainda não, vida atual " + vidaPlayer);
        }
        else
        {
            print("Game Over");
        }

        


    }


    void Update()
    {

    }
}