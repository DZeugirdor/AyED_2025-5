namespace _1_Rodriguez_TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contraseñaGuardada = "Messi";

            Console.Write("Ingresá la contraseña: ");
            string contraseñaUsuario = Console.ReadLine();

            if (contraseñaUsuario == contraseñaGuardada)
            {
                Console.WriteLine("La contraseña es correcta.");
            }
            else
            {
                Console.WriteLine("La contraseña es incorrecta.");
            }
        }
    }
}
