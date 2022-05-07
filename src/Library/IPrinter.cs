namespace Full_GRASP_And_SOLID.Library
{
    //Se utiliza el patrón Polimorfismo, se implementan dos objetos de distintos tipos.
    //Creamos una interfaz (interface) y dos clases donde esta se implementa en ambas,
    //separamos la clase  AllInOnePrinter al hacer las dos clases anteriormente mencionadas, y así aplicarles
    //las operaciones polimórficas.
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe, Destination destination);
    }
}