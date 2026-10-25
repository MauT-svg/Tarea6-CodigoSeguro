# Tabla de fallas

| # | Linea o instruccion | Que falla | Que puede pasar | Como se corrige |
|---|---------------------|-----------|-----------------|-----------------|
| 1 | for (int i = 0; i <= 3; i++) | El for se pasa del límite del arreglo | IndexOutOfRangeException | Cambiar a i < 3 |
| 2 | int.Parse(Console.ReadLine()) | No valida letras ni vacío | FormatException | Usar Validador.LeerEntero |
| 3 | suma / notas.Length | División de enteros | Pierde decimales | (double)suma / notas.Length |
| 4 | Console.WriteLine("Tu PIN " + pin...) | Muestra el PIN real | Información sensible visible | new string('*', pin.Length) |
| 5 | pendientes.Pop() | Pila vacía | InvalidOperationException | if (pendientes.Count > 0) |

Nota: Estas fallas fueron identificadas a partir del codigo inseguro proporcionado en clase.