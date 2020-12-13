namespace AbstractFactoryPattern
{
    public class PerenneGarden : Garden
    {
        public PerenneGarden(){
            shade = new Plant("Ajo");
            border = new Plant("Fresa");
            center = new Plant("Romero");
        }
    }
}