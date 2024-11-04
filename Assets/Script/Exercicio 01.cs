using System;
using UnityEngine;
public class Exercicio01 : MonoBehaviour
{

    // 1° (Verificaão de pontos de vida) um personagem perde pontos de vida  apos uma batalha. verifique
    // se ele ainda esta vivo caso tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso contrario Game Over.

    [SerializeField]
    int vidaPlayer = 100;
    string resultado;

    void Start()
    {
        if (vidaPlayer > 0)
        {
            print("Personagem vivo! :)");
        }
        else
        {
            print("Game Over");
        }

        // codinção ? valor a ser chamado caso verdadeiro : caso falso
        resultado = (vidaPlayer > 0) ? "Personagem Vivo!" : "Game Over! ;-;";
        print(resultado);
    }

    void Update()
    {
        
    }
}



 

