
namespace LinqYJson.Entities;
using Newtonsoft.Json;

    public class Producto
    {
        private string idProducto;
        private string nombreProducto;
        private int stock;
        private int stockMin;
        private int stockMax;
        private double valorVenta;
        private double valorCompra;
        private int idCategoria;

        public Producto()
        {
            if(!File.Exists(Env.FileName))
            {
                File.WriteAllText(Env.FileName, "");
            }
        }

        public string IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        public string NombreProducto
        {
            get { return nombreProducto;}
            set { nombreProducto = value;}
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public int StockMin
        {
            get { return stockMin; }
            set { stockMin = value; }
        }
        public int StockMax
        {
            get { return stockMax; }
            set { stockMax = value; }
        }
        public double ValorCompra 
        {
            get { return valorCompra;}
            set { valorCompra = value;}
        }
        public double ValorVenta 
        {
            get { return valorVenta;}
            set { valorVenta = value;}
        }
        public int IdCategoria 
        {
            get { return idCategoria;}
            set { idCategoria = value;}
        }
        public static void AddProducto(){
            Producto p = new();
            Console.WriteLine("Ingrese el Id Producto");
            p.IdProducto = Console.ReadLine();
            Console.WriteLine("Ingrese nombre del prodcuto");
            p.NombreProducto = Console.ReadLine();
            Console.WriteLine("Ingrese el stock actual ");
            p.Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el stock minimo");
            p.StockMin = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el stock maximo");
            p.StockMax = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor compra: ");
            p.ValorCompra = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor de venta");
            p.ValorVenta = double.Parse(Console.ReadLine());
            Env.TiendaCampus.Productos.Add(p);
        }
    }
