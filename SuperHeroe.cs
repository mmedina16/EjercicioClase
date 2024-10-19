
namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool PuedeVolar { get; set; }

        public SuperPoder SuperPoder;


        //Constructor
        public SuperHeroe()
        {
            SuperPoder = new SuperPoder();
        }


        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede volar: {PuedeVolar}");
            Console.WriteLine($"Super poder: {SuperPoder.Nombre}");
            Console.WriteLine($"Descripcion: {SuperPoder.Descripcion}");
            Console.WriteLine($"Nivel: {SuperPoder.Nivel}");
            Console.WriteLine();
        }
    }
}
