internal class Program
{
    private static void Main(string[] args)
    {
        int numero, escolha, resultado;
        escolha = 0;

        Console.WriteLine(" Informe o numero para a tabuada: ");
        escolha = int.Parse(Console.ReadLine());
        Console.Clear();
        
            if( ( escolha >= 1) && ( escolha <= 9 ) )
            {
                for (numero = 0; numero < 11; numero++)
                {
                    resultado = numero * escolha;
                    Console.WriteLine(escolha + " X " + numero + "= " +(escolha * numero));
                }
            }
            else
            {
            Console.WriteLine("Erro! Informe um numero entre 1 e 9!");
            }
       
    }
}