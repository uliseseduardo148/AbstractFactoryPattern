namespace AbstractFactoryPattern
{
    public class AnnualGarden : Garden
    {
        public AnnualGarden()
        {
            shade = new Plant("Girasol");
            border = new Plant("Amaranto");
            center = new Plant("Alhelí");
        }
    }
}