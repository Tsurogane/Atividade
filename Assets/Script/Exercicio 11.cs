using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{

    [SerializeField] int estado;

    void Start()
    {
        switch (estado)
        {
            case 1:
                print("Da para fazer com ternario?");
                break;

            case 2:
                print("Sextooou!");
                break;

            case 3:
                print("Cad� o Thiago?");
                break;

            case 4:
                print("Cad� a Alana?");
                break;

            case 5:
                print("Jucelino, cad� meu aumento?");
                break;

            default:
                print("N�o tenho nada a dizer sobre isso!");
                break;
        }
    }


    void Update()
    {

    }
}