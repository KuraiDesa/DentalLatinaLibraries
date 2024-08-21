namespace DentalLatina
{
    public class Sistema
    {
        public static Sistema instancia = new Sistema();
  
        public string[] categorias = { "CLÍNICA", "LABORATORIO", "IMPLANTOLOGÍA" };
        public List<string> subcategorias= new List<string>();
        public List<Producto> productos = new List<Producto>();
        

        public void agregarProducto(Producto producto)
        {
            productos.Add(producto);
        }
        public List<Producto> getProductos() {  return productos; }
        public void agregarSubCat(string subCat)
        {
            subcategorias.Add(subCat);
        }
        public List<string> getSubcategorias() { return subcategorias; }

        public string[] getCategoria()
        {
            return categorias;
        }
    }
}
