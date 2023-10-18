using StrategyAct;

class Program
{
    static void Main(string[] args)
    {
        ClienteCafeteria cliente = new ClienteCafeteria();

        IPreparacionCafe preparacionCafeNegro = new PreparacionCafeNegro();
        IPreparacionCafe preparacionCafeConLeche = new PreparacionCafeConLeche();

        cliente.SetPreparacionCafe(preparacionCafeNegro);
        cliente.PrepararCafe();

        cliente.SetPreparacionCafe(preparacionCafeConLeche);
        cliente.PrepararCafe();

        Console.ReadKey();
    }
}
