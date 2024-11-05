using UnityEngine;

namespace MeuJogo
{
    public class ColetarItem : MonoBehaviour
    {
        private Inventario inventario;

        // Inicialização
        private void Start()
        {
            // Encontre o componente de Inventário no jogador
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
                    // Adiciona o item ao inventário e aplica seu efeito
                    inventario.AdicionarItem(item.tipoItem);
                    Destroy(other.gameObject); // Destrói o item após ser coletado
                }
            }
        }
    }
}