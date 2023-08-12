

using LinqYJson.Entities;
using Newtonsoft.Json;

namespace LinqYJson;

    public class Env
    {
        private static string fileName = "tiendaCampus.json";
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
        public static void SaveDataJson<T>(T datos)where T : class{
            string json = JsonConvert.SerializeObject(datos, Formatting.Indented);
            File.WriteAllText(Env.FileName, json);
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
            bool header = false;
            Console.WriteLine("{0,-30}",titulo);
            foreach (var elemento in lista)
            {
                Type tipoClase = elemento.GetType();
                var propiedades = tipoClase.GetProperties();

                if (header == false){
                    foreach (var propiedad in propiedades)
                    {
                        Console.Write("{0,-20}", propiedad.Name);
                    }
                    header = true;
                    Console.WriteLine();
                }

            /*   foreach (var propiedad in propiedades)
                {
                    Console.WriteLine($"{propiedad.Name}: {propiedad.GetValue(elemento)}");
                } */
                foreach (var propiedad in propiedades)
                {
                    Console.Write("{0,-20}", propiedad.GetValue(elemento));
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.ReadKey();
        }

    }

