using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio05 : MonoBehaviour
{
    

    [SerializeField] int pontos = 0;

    void Start()
    {
        if (pontos >= 50)
        {
            print("Missão bem - sucedida");
        }
        else
        {
            print("Missão incompleta");
        }

        // condição ? caso vdd : caso falso (Ternario)
        print(pontos >= 50 ? "Missão bem - sucedida" : "Missão incompleta");
    }

    // Update is called once per frame
    void Update()
    {

    }
}