using UnityEngine;


namespace MeuJogo
{
    // Definindo os tipos de itens que o jogador pode coletar
    public enum TipoItem
    {
        Moeda,
        Pocao,
        PowerUp
    }

    // Script que representa um item que o jogador pode coletar
    public class Item : MonoBehaviour
    {
        // Defina o tipo de item que este objeto será
        public TipoItem tipoItem;
    }
}

