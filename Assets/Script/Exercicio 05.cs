using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio05 : MonoBehaviour
{
    

    [SerializeField] int pontos = 0;

    void Start()
    {
        if (pontos >= 50)
        {
            print("Miss�o bem - sucedida");
        }
        else
        {
            print("Miss�o incompleta");
        }

        // condi��o ? caso vdd : caso falso (Ternario)
        print(pontos >= 50 ? "Miss�o bem - sucedida" : "Miss�o incompleta");
    }

    // Update is called once per frame
    void Update()
    {

    }
}