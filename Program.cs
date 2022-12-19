namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Cronometro\n----------------------------------\nS = segundos => 10s = 10 segundos \nM = minutos => 1m = 1 minuto \nS = sair");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Quanto tempo deseja contar? ");
            string data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm'){
                multiplier = 60;
            }

            if(time == 0 || type == 's'){
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);

        }

        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("Já vai começar...");
            Thread.Sleep(1000);
            Console.WriteLine("Iniciou!");
           
           Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine("tempo atual: " + currentTime);
                Thread.Sleep(1000);     //atrasar execução

            }
            Console.Clear();
            Console.WriteLine("Cronometo finalizado, retornando ao Menu...");
            Thread.Sleep(2000);
        }

    }
}