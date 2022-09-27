using SingleResponsabilityExercise;
Pedido pedido = new Pedido();

Console.WriteLine("Bienvenido a la consola para creación de pedidos");
Console.WriteLine("Escriba qué productos quiere agregar, separados por una coma");
string productos = Console.ReadLine() ?? "";

if (!string.IsNullOrEmpty(productos))
{
    var productosArray = productos.Split(",");
    List<Producto> listaProductos = new List<Producto>();
    foreach (var producto in productosArray)
    {
        var precioProducto = pedido.ConsultarPrecioProducto(producto);
        Producto productoObj = new Producto()
        {
            NombreProducto = producto,
            PrecioProducto = precioProducto
        };
        listaProductos.Add(productoObj);
    }

    var pedidoResultante = pedido.CrearPedido(listaProductos);
    if (pedidoResultante != null)
    {
        Console.WriteLine("El siguiente pedido fue creado:");
        Console.WriteLine($"Id: {pedidoResultante.IdPedido}");
        pedidoResultante.Productos.ForEach(x => Console.WriteLine($"Producto: {x.NombreProducto} --- Precio: {x.PrecioProducto}"));
        Console.WriteLine($"Total a pagar: {pedidoResultante.TotalPagar}");
    }
    
}
else
{
    Console.WriteLine("No agregaste ningun producto!");
}