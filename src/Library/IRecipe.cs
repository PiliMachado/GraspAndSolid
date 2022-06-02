namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// IRecipe es la interfaz que va a utilizar Recipe y de la cual va a depender C
    /// ConoslePrinter para que ConsolePrinter deje de depender de Recipe sino que de la 
    /// abstracción de ella, como se indica en el principio DIP.
    /// </summary>
    public interface IRecipe
    {
        string GetTextToPrint();
    }
}