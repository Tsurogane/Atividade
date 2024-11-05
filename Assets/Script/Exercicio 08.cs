using UnityEngine;

public class Exercicio08 : MonoBehaviour
{
    int hora = 0; // Variável para armazenar as horas
    int dias = 0; // Variável para armazenar os dias
    float timer = 0f; // Temporizador para contar o tempo
    const float incrementoTempo = 10f; // Tempo em segundos para incrementar a hora

    void Update()
        
    {
        print(hora);
        // Incrementa o temporizador
        timer += Time.deltaTime; // Adiciona o tempo desde o último frame

        
        if (timer >= incrementoTempo)
        {
            // Reinicia o temporizador
            timer = 0f;

          
            hora++;

           
            if (hora >= 24)
            {
                hora = 0; 
                dias++; 
                print("Dias passados: " + dias); 
            }
        }
    }
}


