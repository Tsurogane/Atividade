using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    

    [SerializeField] bool pocaoVida;

    void Start()
    {
        

        if (pocaoVida)
        {
            print("Usando Poção de Vida");
        }
        else
        {
            print("Poção indisponível");
        }




    }

    void Update()
    {

    }
}