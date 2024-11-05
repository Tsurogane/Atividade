using System.Collections.Generic;
using UnityEngine;

namespace MeuJogo
{
    public class Inventario : MonoBehaviour
    {
        public int pontuacao = 0; // Pontuação do jogador
        public int vida = 100;    // Vida do jogador

        private Dictionary<TipoItem, int> inventario = new Dictionary<TipoItem, int>();

        // Método para adicionar itens ao inventário
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

        // Método para aplicar os efeitos de um item
        private void AplicarEfeito(TipoItem tipoItem)
        {
            switch (tipoItem)
            {
                case TipoItem.Moeda:
                    // Aumenta a pontuação
                    pontuacao += 10;
                    Debug.Log("Você coletou uma moeda! Pontuação: " + pontuacao);
                    break;

                case TipoItem.Pocao:
                    // Aumenta a vida (máximo de 100)
                    vida = Mathf.Min(vida + 20, 100);
                    Debug.Log("Você coletou uma poção! Vida: " + vida);
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

        // Método para ativar o power-up
        private void AtivarPowerUp()
        {
            Debug.Log("Power-up ativado!");
            // Adicione a lógica de power-up aqui, como invencibilidade ou aumento de velocidade
        }
    }
}