namespace ControleDeAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           int tlCachorro = 0, tlGato=0,tlPeixe = 0;
           int contador = 1;
           Animal[] animais = new Animal[5]; 
           Console.WriteLine("Controle de Animais");

            while (contador <= 5) 
            {
               
                
                Animal animal = new Animal();
                
                
                Console.Write("Infome o nome do " + contador + "º animal: ");
                animal.Nome = Console.ReadLine();

                Console.Write("Infome o tipo do " + contador + "º animal (Cachorro, Gato ou Peixe): ");
                animal.Tipo = Console.ReadLine();

                if (animal.Tipo == "Cachorro") tlCachorro++;
                if (animal.Tipo == "Gato") tlGato++;
                if (animal.Tipo == "Peixe") tlPeixe++;

                animais[contador - 1] = animal;
                contador++;
            }
           

            
            Console.WriteLine("Total de animais");
            Console.WriteLine("Cachorros: " + tlCachorro + " \n Gatos: " +tlGato + " \n Peixes: " + tlPeixe);
            Console.ReadKey();
        }
    }
}