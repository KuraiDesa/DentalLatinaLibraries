using System.Reflection.Metadata.Ecma335;

namespace DentalLatina
{
    public class Sistema
    {

        public static Sistema inst;
        public string[] categorias = { "CLINICA", "LABORATORIO", "IMPLANTOLOGIA" };
        public string[] ubicacionEnvio = { "INTERIOR", "MONTEVIDEO" };
        public List<string> subcategorias= new List<string>();
        public List<Producto> productos = new List<Producto>();
        public List<Evento> eventos = new List<Evento>();
        public List<UsuariosInfo> usuarios = new List<UsuariosInfo>();
        public List<Promocion> promociones = new List<Promocion>(); 
        public List<Oportunidad> oportunidades = new List<Oportunidad>(); 
        public List<Envio> envios = new List<Envio>();
        public List<Sucursal> sucursales = new List<Sucursal>();
        public List<Libro> libros = new List<Libro>();


        //GETS
        public string[] getCategoria() { return categorias; }
        public string[] getUbicacionEnvio() { return ubicacionEnvio; }
        public List<Producto> getProductos() {  return productos; }
        public List <Evento> getEventos() {  return eventos; }
        public List<string> getSubcategorias() { return subcategorias; }
        public List<UsuariosInfo> getUsuarios() { return usuarios; }
        public List<Promocion> getPromociones() { return promociones; }
        public List<Envio> getEnvios() { return envios; }
        public List<Sucursal > getSucursales() { return sucursales; }
        public List<Libro> getLibros() { return libros; }
   
        

        //SETS
        public void setProductos(List<Producto> lista) {  productos = lista; }
        public void setEventos(List<Evento> lista) {  eventos = lista; }
        public void setSubCat(List<string> lista) { subcategorias = lista; }
        public void setCategorias(string[] array) {  categorias = array; }
        public void setUsuarios(List<UsuariosInfo> lista) {  usuarios = lista; }
        public void setPromociones(List<Promocion> lsita) {  promociones = lsita; }
        public void setEnvios(List<Envio> lista) {  envios = lista; }
        public void setSucursales(List<Sucursal> lista) { sucursales = lista; }
        public void setLibros(List<Libro> lista) {  libros = lista; }


        //AGREGAR
        public void addProducto(Producto producto){productos.Add(producto);}
        public void addSubCat(string subCat){subcategorias.Add(subCat);}
        public void addEvento(Evento evento) { eventos.Add(evento); }
        public void addUsuario(UsuariosInfo user) {usuarios.Add(user);}
        public void addPromocion(Promocion promocion) { promociones.Add(promocion); }
        public void addEnvio(Envio envio) { envios.Add(envio); }
        public void addSucursal(Sucursal sucursal) {  sucursales.Add(sucursal); }
        public void addLibro(Libro libro) {  libros.Add(libro);}


        //FUNCIONALIDADES
        public static Sistema instancia()
        {
            if (inst == null)
            {
                inst = new Sistema();
            }
            return inst;
        }

    }
}
