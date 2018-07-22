namespace CursoCSharp
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            System.Console.WriteLine(saudacao);

            System.Console.WriteLine("Teste".Length);

            string valorImportante = null;
            System.Console.WriteLine(valorImportante?.Length);
        }
    }
}