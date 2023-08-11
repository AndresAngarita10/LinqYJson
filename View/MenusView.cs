namespace LinqYJson.View;

    public static class MenusView
    {
        public static int MenuPrincipal(){
            Console.Clear();
            Console.WriteLine("1. Registro de productos");
            Console.WriteLine("2. Registro de categorias");
            Console.WriteLine("3. Mostrar Productos");
            Console.WriteLine("4. Salir");
            return int.Parse(Console.ReadLine());
        }
    }
