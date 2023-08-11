

using LinqYJson.Entities;

namespace LinqYJson;

    public class Env
    {
        private static string fileName = "tiendaCampus.jsom";
        private static TiendaCampus tiendaCampus = new ();
        /* 
        private static List<Producto> productos = new();
        private static List<Categoria> categorias = new();
 */
        public static string FileName { get => fileName; set => fileName = value; }

        public static TiendaCampus TiendaCampus { get => tiendaCampus; set => tiendaCampus = value;}

        public static void LoadDataProductos(string nombreArchivo)
        {
            using (StreamReader reader = new (nombreArchivo))
            {
                string json = reader.ReadToEnd();
                Env.TiendaCampus = System.Text.Json.JsonSerializer.Deserialize<TiendaCampus>(json, new System.Text.Json.JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true 
                })?? new TiendaCampus();
            }
        }

        public static bool ValidarFile(string fileName)
        {
            if(!File.Exists(fileName))
            {
                return false;
            }
            return true;
        }

        public static void ImprimirData<T>(string titulo, IEnumerable<T> lista)
        {
            Console.WriteLine("{0,-30}",titulo);
            foreach (var elemento in lista)
            {
                Type tipoClase = elemento.GetType();
                var propiedades = tipoClase.GetProperties();
                foreach (var propiedad in propiedades)
                {
                    Console.WriteLine($"{propiedad.Name}: {propiedad.GetValue(elemento)}");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.ReadKey();
        }

    }

