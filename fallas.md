# Tabla de fallas

| # | Linea o instruccion | Que falla | Que puede pasar | Como se corrige |
|---|---------------------|-----------|-----------------|-----------------|
| 1 | for (int i = 0; i <= 3; i++) | El ciclo se pasa del limite del arreglo (indices 0 a 2) | Se produce IndexOutOfRangeException y el programa se cae | Cambiar la condicion a i < 3 |
| 2 | int.Parse(Console.ReadLine()) | No valida si el usuario escribe letras, simbolos o deja vacio | FormatException y el programa se detiene | Usar Validador.LeerEntero o int.TryParse |
| 3 | suma / notas.Length | Division entre enteros, se pierden los decimales | El promedio sale incorrecto (ej: 81 en lugar de 81.67) | Convertir a double: (double)suma / notas.Length |
| 4 | Console.WriteLine("Tu PIN " + pin + " fue guardado") | Muestra el PIN en texto plano | Se expone informacion sensible en pantalla | Mostrar asteriscos: new string('*', pin.Length) |
| 5 | pendientes.Pop() | Se intenta sacar un elemento de una pila vacia | InvalidOperationException y el programa se cae | Verificar antes: if (pendientes.Count > 0) |