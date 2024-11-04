using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    // 2° (Detecção de Power Up) Ao coletar  um power-up o personagem aumenta sua velocida. Se o jogador encontrar
    // um  power-up, exiba "Power-Up Coletado".Caso contrario exiba "Nenhum Power Upencontrado".


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

        //condição  Caso vdd : Caso falso 

        print(powerUp ? "Power-up Coletado!" : "Nenhum power-up encontrado");

    }
    void Update()
    {

    }


}
