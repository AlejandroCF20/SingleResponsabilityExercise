namespace SingleResponsabilityExercise;

public class Pedido
{
    public int IdPedido { get; set; }
    public List<Producto> Productos { get; set; }
    public int TotalPagar { get; set; }
    
    // Vemos que esta clase no está cumpliendo la única responsabilidad de servir para ser instanciada como un objeto, sino que además tiene 
    // funciones dentro de la misma.
    public Pedido CrearPedido(List<Producto> productos)
    {
        Pedido pedido = new Pedido()
        {
            IdPedido = new Random().Next(1, 1000),
            Productos = productos,
            TotalPagar = productos.Sum(x => x.PrecioProducto)
        };
        
        // Aquí iría una conexión con la base de datos, creando el pedido
        return pedido;
    }

    // Vemos una función de consultar precio producto en la clase Pedido...
    public int ConsultarPrecioProducto(string nombreProducto)
    {
        // Aquí iría una conexión con la base de datos, obteniendo los datos del producto
        return new Random().Next(1, 10000000);
    }
}