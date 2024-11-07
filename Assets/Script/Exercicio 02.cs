using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
   


    [SerializeField] bool powerUp;
   

    void Start()
    {
        if (powerUp == true)
        {
            print("Power-up Coletado!");
        }
        else
        {
            print("Nenhum power-up encontrado");
        }

       

        print(powerUp ? "Power-up Coletado!" : "Nenhum power-up encontrado");

    }
    void Update()
    {

    }


}
