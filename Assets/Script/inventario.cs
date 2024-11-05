using System.Collections.Generic;
using UnityEngine;

namespace MeuJogo
{
    public class Inventario : MonoBehaviour
    {
        public int pontuacao = 0; // Pontua��o do jogador
        public int vida = 100;    // Vida do jogador

        private Dictionary<TipoItem, int> inventario = new Dictionary<TipoItem, int>();

        // M�todo para adicionar itens ao invent�rio
        public void AdicionarItem(TipoItem tipo)
        {
            if (inventario.ContainsKey(tipo))
            {
                inventario[tipo]++;
            }
            else
            {
                inventario[tipo] = 1;
            }

            AplicarEfeito(tipo);
        }

        // M�todo para aplicar os efeitos de um item
        private void AplicarEfeito(TipoItem tipoItem)
        {
            switch (tipoItem)
            {
                case TipoItem.Moeda:
                    // Aumenta a pontua��o
                    pontuacao += 10;
                    Debug.Log("Voc� coletou uma moeda! Pontua��o: " + pontuacao);
                    break;

                case TipoItem.Pocao:
                    // Aumenta a vida (m�ximo de 100)
                    vida = Mathf.Min(vida + 20, 100);
                    Debug.Log("Voc� coletou uma po��o! Vida: " + vida);
                    break;

                case TipoItem.PowerUp:
                    // Ativa um power-up
                    AtivarPowerUp();
                    break;

                default:
                    Debug.Log("Item desconhecido!");
                    break;
            }
        }

        // M�todo para ativar o power-up
        private void AtivarPowerUp()
        {
            Debug.Log("Power-up ativado!");
            // Adicione a l�gica de power-up aqui, como invencibilidade ou aumento de velocidade
        }
    }
}