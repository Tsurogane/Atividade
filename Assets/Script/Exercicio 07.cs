using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;

public class Exercicio07 : MonoBehaviour
{

   

    [SerializeField] int faces;

    void Start()
    {
        

        print(faces == 0 ? ("O número de faces do dado não pode ser: " + faces) : (Random.Range(1, faces)));
    }

    void Update()
    {

    }
}