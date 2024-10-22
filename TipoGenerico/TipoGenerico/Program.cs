

using TipoGenerico;

class Program
{
    public static void Main(string[] args)
    {
        Pilha<int> nome = new();

        //Adicionando Valores Dentro da lista
        int[] numeros = new int[] {11 , 22 , 33 , 44 , 55 , 66 };
        nome.valores.AddRange(numeros);
        nome.PercorreLista();
        nome.Push(31);
        nome.Buscar(nome.valores, 31);
        nome.Push(32);
        nome.IsEmpyt();
        nome.Pop();
        nome.Peek();
        nome.PercorreLista();
    }
}
