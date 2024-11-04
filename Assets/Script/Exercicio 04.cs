using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    //(Verificar item de inventário) Um jogador possui itens limitados
    //no inventário.Verifique se o jogador possui uma "Poção de Vida".
    //Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    //indisponível".

    public class Item 
    {
        public string Nome { get; private set; }

        public Item(string nome)
        {
            Nome = nome;
        }
    }

    public class Inventario
    {
        private List<Item> itens;

        public Inventario()
        {
            itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            itens.Add(item); 
        }

        public bool PossuiItem(string nomeItem)
        {
            foreach (var item in itens)
            {
                if (item.Nome == nomeItem)
                {
                    return true;
                }
            }
            return false;
        }
    }

    private Inventario inventario;


    void Start()
    {
        inventario = new Inventario();
        // Adicionando a Poção de Vida ao inventário para teste
        inventario.AdicionarItem(new Item("Poção de Vida"));

        // Verifica automaticamente se possui a Poção de Vida ao iniciar o jogo
        VerificarPoçãoVida();
    }

    void VerificarPoçãoVida()
    {
        if (inventario.PossuiItem("Poção de Vida"))
        {
            print("Usando Poção de Vida");
        }
        else
        {
            print("Poção indisponível");
        }
    }
}

    
