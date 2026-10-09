// Ejercicio 2: Cálculo de fuerza en un cilindro neumático
Console.WriteLine("SISTEMA DE FUERZA EN CILINDRO NEUMATICO");                         // Título de la aplicación
Console.WriteLine();                                                                  // Salto de línea

// Crear un objeto de la clase CilindroNeumatico
CilindroNeumatico cilindro1 = new CilindroNeumatico();                                 // Objeto: cilindro1 de la clase CilindroNeumatico

// Capturar la información del objeto 
Console.Write("Ingrese la presión en kPa: ");                                         // Solicitud de datos
cilindro1.PresionKpa = Convert.ToDouble(Console.ReadLine());                          // Propiedad: PresionKpa

Console.Write("Ingrese el área efectiva del pistón en cm²: ");                        // Solicitud de datos
cilindro1.AreaCm2 = Convert.ToDouble(Console.ReadLine());                             // Propiedad: AreaCm2

Console.Write("Ingrese el requerimiento mínimo de fuerza en N: ");                    // Solicitud de datos
cilindro1.FuerzaMinima = Convert.ToDouble(Console.ReadLine());                        // Propiedad: FuerzaMinima

// Solicitar al objeto que realice los cálculos y evaluaciones
double presionPa = cilindro1.CalcularPresionPa();     // Conversión a Pascales          // Invocación del método CalcularPresionPa
double areaM2 = cilindro1.CalcularAreaM2();             // Conversión a metros cuadrados  // Invocación del método CalcularAreaM2
double fuerza = cilindro1.CalcularFuerza();             // Cálculo de la fuerza en N      // Invocación del método CalcularFuerza

// Mostrar resultados con unidades correspondientes
Console.WriteLine();                                                                  // Salto de línea
Console.WriteLine($"Presión convertida: {presionPa:F2} Pa");                          // Salida con unidades (Pa)
Console.WriteLine($"Área convertida: {areaM2:F4} m²");                                  // Salida con unidades (m²)
Console.WriteLine($"Fuerza calculada: {fuerza:F2} N");                                  // Salida con unidades (N)
Console.WriteLine($"Evaluación: {cilindro1.EvaluarRequerimiento()}");                   // Invocación del método EvaluarRequerimiento


// Definición de la clase
class CilindroNeumatico                                                               // Clase: CilindroNeumatico
{
    // Propiedades
    public double PresionKpa { get; set; }   // Presión ingresada en kPa       // Propiedad: PresionKpa
    public double AreaCm2 { get; set; }        // Área ingresada en cm²         // Propiedad: AreaCm2
    public double FuerzaMinima { get; set; }  // Fuerza mínima requerida en N // Propiedad: FuerzaMinima

    // Método para convertir la presión a Pascales (Pa)
    public double CalcularPresionPa()                                                 // Método: CalcularPresionPa
    {
        return PresionKpa * 1000.0;                                                     // Operación y retorno
    }

    // Método para convertir el área a metros cuadrados (m²)
    public double CalcularAreaM2()                                                    // Método: CalcularAreaM2
    {
        return AreaCm2 / 10000.0;                                                       // Operación y retorno
    }

    // Método para calcular la fuerza eléctrica/mecánica (F = P * A)
    public double CalcularFuerza()                                                    // Método: CalcularFuerza
    {
        double presionPa = CalcularPresionPa();                                         // Variable local con conversión
        double areaM2 = CalcularAreaM2();                                               // Variable local con conversión

        return presionPa * areaM2;                                                      // Operación y retorno
    }

    // Método para determinar si cumple con el requerimiento mínimo
    public string EvaluarRequerimiento()                                              // Método: EvaluarRequerimiento
    {
        double fuerzaActual = CalcularFuerza();                                         // Variable local con cálculo actual

        if (fuerzaActual >= FuerzaMinima)                                               // Validación del requerimiento
        {
            return "CUMPLE CON EL REQUERIMIENTO";                                       // Retorno si es verdadero
        }
        else
        {
            return "NO CUMPLE CON EL REQUERIMIENTO";                                    // Retorno si es falso
        }
    }
}