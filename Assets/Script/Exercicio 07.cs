using UnityEngine;

public class Exercicio07 : MonoBehaviour
{
    public int numeroDeFaces; // Definido pelo usu�rio

    void Start()
    {
        Rolagem(); // Chama a fun��o de rolagem no in�cio do jogo
    }

    void Rolagem()
    {
        // Verifica se o n�mero de faces � v�lido
        if (numeroDeFaces < 1)
        {
            print("N�mero de faces deve ser maior que 0");
            return;
        }

        // Rolagem do dado
        int resultado = Random.Range(1, numeroDeFaces + 1); // +1 para incluir a face m�xima
        print("Resultado da rolagem: " + resultado);
    }
}
