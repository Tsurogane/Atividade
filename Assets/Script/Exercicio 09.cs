using UnityEngine;

public class Exercicio09  : MonoBehaviour 
{
   
    public int pontosTimeA = 0;
    public int pontosTimeB = 0;

    
    void Start()
    {
        
        if (pontosTimeA > pontosTimeB)
        {
            
            print("Vitória do Time A!");
        }
        else if (pontosTimeB > pontosTimeA)
        {
            
            print("Vitória do Time B!");
        }
        else
        {
          
            if (pontosTimeA > 3 && pontosTimeB > 3)
            {
                print("Empate emocionante!");
            }
            else
            {
                print("Empate!");
            }
        }
    }
}
