namespace LinqYJson.Entities;

    public class TiendaCampus
    {
        private List<Producto> productos = new ();
        private List<Categoria> categorias = new ();

        public List<Categoria> Categorias
        {
            get { return categorias; }
            set { categorias = value; }
        }
        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }
        public TiendaCampus(){}
    }
