// See https://aka.ms/new-console-template for more information
const double porc_descuento = 0.1;
static void LeerDatos(ref double preciox, ref int cantidadx)
{
  System.Console.WriteLine("Ingrese precio:");
  preciox = double.Parse(Console.ReadLine());
  System.Console.WriteLine("Ingrese cantidad");
  cantidadx = int.Parse(Console.ReadLine());
}

static double CalcularSubtotal(double precio, int cantidad)
{
  double sub_total = precio * cantidad;
  return sub_total;
}

static double CalcularDescuento(double Subtotal)
{
  return Subtotal * porc_descuento;
}

static double CalcularTotal(double Subtotal, double descuento)
{
  return Subtotal - descuento;
}
System.Console.WriteLine("Bienvenido a la calculadora de compras");
double precio = 0;
int cantidad = 0;
LeerDatos(ref precio, ref cantidad);

double sub_total = CalcularSubtotal(precio,cantidad);
System.Console.WriteLine($"Subtotal:{sub_total}");

CalcularDescuento(sub_total);
