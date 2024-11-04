using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    //(Verificar item de invent�rio) Um jogador possui itens limitados
    //no invent�rio.Verifique se o jogador possui uma "Po��o de Vida".
    //Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
    //indispon�vel".

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
        // Adicionando a Po��o de Vida ao invent�rio para teste
        inventario.AdicionarItem(new Item("Po��o de Vida"));

        // Verifica automaticamente se possui a Po��o de Vida ao iniciar o jogo
        VerificarPo��oVida();
    }

    void VerificarPo��oVida()
    {
        if (inventario.PossuiItem("Po��o de Vida"))
        {
            print("Usando Po��o de Vida");
        }
        else
        {
            print("Po��o indispon�vel");
        }
    }
}

    
