using LinqYJson;
using LinqYJson.Entities;
using LinqYJson.View;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        if(Env.ValidarFile(Env.FileName) == false)
        {
            File.WriteAllText(Env.FileName, "");
        }else{
            Env.LoadDataProductos(Env.FileName);
        }
        Env.ImprimirData("dddddd",Env.TiendaCampus.Categorias);
        do
        {
            opcion = MenusView.MenuPrincipal();
            switch (opcion)
            {
                case 1:
                    Producto.AddProducto();
                    break;
                case 2:
                    Categoria.AddCategoria();
                    string json = JsonConvert.SerializeObject(Env.TiendaCampus, Formatting.Indented);
                    File.WriteAllText(Env.FileName, json);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                
                default:
                    Console.WriteLine("Opcion Invalida");
                    break;
            }
        } while (opcion != 4);
    }
}