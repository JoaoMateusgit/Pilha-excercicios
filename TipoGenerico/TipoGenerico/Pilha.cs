using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoGenerico
{

    public class Pilha<T>
    {

        public List<T> valores = new();

        //Adiciona um valor para dentro da lista Valores
        public void Push(T item)
        {
            valores.Add(item);
            Console.WriteLine($"valor adicionado a lista: {item}");
        }

        //Remove o primeiro item da pilha e devolve o valor atualizado
        public void Pop()
        {
            if (valores.Count == 0)
                throw new ArgumentNullException("O campo está Vazio!");
            Console.Write("Valor Removido do topo!, ");
            valores.RemoveRange(valores.Count - 1, 1);
            Console.WriteLine($"Valor no topo da Pilha Atualizado: {valores.Last()}");

        }

        //Retornba o primeiro item da lista
        public void Peek()
        {
            if (valores.Count == 0)
                throw new ArgumentNullException("O campo está Vazio!");
            Console.WriteLine($"Primeiro item da Pilha: {valores.First()}");
        }

        //Verifica se a lista está vazia
        public void IsEmpyt()
        {
            if (valores.Count == 0)
                throw new ArgumentNullException("O campo está Vazio!");
        }

        //Mostra na tela a lista com valores atualizados
        public void PercorreLista()
        {
            foreach (var numero in valores)
            {
                Console.WriteLine(numero);
            }
        }

        public void Buscar<T>(IEnumerable<T> lista, T item)
        {
            Console.WriteLine("digite");
            foreach (T elemento in lista) // 'elemento' é uma nova variável local
            {
                // Aqui você pode comparar 'elemento' com 'item' ou fazer outras operações
                if (elemento.Equals(item))
                {
                    Console.WriteLine($"Item encontrado! {item}");
                    return;
                }
            }
            Console.WriteLine("Item não encontrado.");
        }
    }
}
