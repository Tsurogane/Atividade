using UnityEngine;

public class Exercicio06 : MonoBehaviour
{
    

    [SerializeField] bool mago;
    [SerializeField] bool guerreiro;

    void Start()
    {
        if (mago == true && guerreiro == false)
        {
            print("Mago escolhido");
        }
        else if (mago == false && guerreiro == true)
        {
            print("Guerreiro escolhido");
        }
        else if (mago && guerreiro)
        {
            print("Amigo (m�o no ombro) s� um ;)");
        }
        else
        {
            print("Ent�o n�o joga");
        }
    }

    void Update()
    {

    }
}