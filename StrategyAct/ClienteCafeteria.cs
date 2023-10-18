namespace StrategyAct
{
    public class ClienteCafeteria
    {
        private IPreparacionCafe preparacionCafe;

        public void SetPreparacionCafe(IPreparacionCafe preparacionCafe)
        {
            this.preparacionCafe = preparacionCafe;
        }

        public void PrepararCafe()
        {
            if (preparacionCafe != null)
            {
                preparacionCafe.PrepararCafe();
            }
            else
            {
                Console.WriteLine("Por favor, seleccione una estrategia de preparación de café.");
            }
        }
    }
}
