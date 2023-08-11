
namespace LinqYJson.Entities;

    public class Categoria
    {
        private int id;
        private string descripcion;
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {
            get { return descripcion;}
            set { descripcion = value;}
        }
        public static void AddCategoria(){
            Categoria cat = new ();
            Console.WriteLine("Ingrese el Id de ña categoria");
            cat.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre de la categorai");
            cat.Descripcion = Console.ReadLine();
            Env.TiendaCampus.Categorias.Add(cat);
        }

        public /* static */ IEnumerable<Categoria> ListaCategorias(){
            return from cat in Env.TiendaCampus.Categorias
                    select cat;
        }
    }
