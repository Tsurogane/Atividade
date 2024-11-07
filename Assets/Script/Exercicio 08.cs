using System;
using Unity.Collections;
using UnityEditor;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio08 : MonoBehaviour
{
    

    [SerializeField] int dias;
    [SerializeField] int horas;
    [SerializeField] float segundos;

    void Start()
    {

    }


    void Update()
    {
        segundos += Time.deltaTime;

        if (segundos >= 10f)
        {
            horas++;
            segundos = 0;
            if (horas == 4)
            {
                dias++;
                horas = 0;
                print(dias);
            }
        }
    }
}