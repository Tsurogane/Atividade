using UnityEngine;

namespace MeuJogo
{
    public class ColetarItem : MonoBehaviour
    {
        private Inventario inventario;

        // Inicializa��o
        private void Start()
        {
            // Encontre o componente de Invent�rio no jogador
            inventario = GetComponent<Inventario>();
        }

        // Detecta quando o jogador colide com um item
        private void OnTriggerEnter(Collider other)
        {
            // Verifica se o objeto que colidiu tem a tag "Item"
            if (other.CompareTag("Item"))
            {
                Item item = other.GetComponent<Item>(); // Pega o componente Item do objeto

                if (item != null)
                {
                    // Adiciona o item ao invent�rio e aplica seu efeito
                    inventario.AdicionarItem(item.tipoItem);
                    Destroy(other.gameObject); // Destr�i o item ap�s ser coletado
                }
            }
        }
    }
}