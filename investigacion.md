# Validacion de entradas

## 1. Que es
La validación de entradas consiste en revisar que los datos que escribe el usuario cumplan con el formato y rango esperado antes de usarlos en el programa. Evita errores y comportamientos inesperados.

## 2. Que pasa si no se valida
Si no se valida, el programa puede caerse (excepciones), calcular mal o mostrar información sensible. Ejemplo: en el código original, escribir letras en las notas provoca un FormatException y el programa se detiene.

## 3. Que recomienda OWASP
OWASP recomienda validar todas las entradas del usuario (whitelist cuando sea posible), rechazar datos inválidos, no confiar nunca en lo que viene del cliente y sanitizar antes de usar los datos.

## 4. Como se valida en C#
En C# se puede usar int.TryParse para números, string.IsNullOrWhiteSpace para textos vacíos, y rangos (min/max). También se pueden crear métodos reutilizables como Validador.LeerEntero y Validador.LeerTexto.