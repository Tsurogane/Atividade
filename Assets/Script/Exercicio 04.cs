using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    

    [SerializeField] bool pocaoVida;

    void Start()
    {
        

        if (pocaoVida)
        {
            print("Usando Po��o de Vida");
        }
        else
        {
            print("Po��o indispon�vel");
        }




    }

    void Update()
    {

    }
}