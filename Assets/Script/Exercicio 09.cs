using System;
using Unity.VisualScripting;
using UnityEngine;

public class Exercicio09 : MonoBehaviour
{
    

    [SerializeField] int placarTimeA;
    [SerializeField] int placarTimeB;

    void Start()
    {
        placarTimeA = UnityEngine.Random.Range(1, 5);
        placarTimeB = UnityEngine.Random.Range(1, 5);

        if (placarTimeA > placarTimeB)
        {
            print("Vitória do Time A!");
        }
        else if (placarTimeB > placarTimeA)
        {
            print("Vitória do Time B!");
        }
        else 
        {
            if (placarTimeA > 3 && placarTimeB > 3)
            {
                print("Foi um empate emocionante!");
            }
            else
            {
                print("Foi um empate!");
            }
        }
    }


    void Update()
    {

    }
}