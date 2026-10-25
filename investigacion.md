# Validacion de entradas

## 1. Que es
La validacion de entradas consiste en revisar que los datos que escribe el usuario cumplan con el formato y rango esperado antes de usarlos en el programa. Evita errores y comportamientos inesperados.

## 2. Que pasa si no se valida
Si no se valida, el programa puede caerse (excepciones), calcular mal o mostrar informacion sensible. Ejemplo: en el codigo original, escribir letras en las notas provoca un FormatException y el programa se detiene.

## 3. Que recomienda OWASP
OWASP recomienda validar todas las entradas del usuario en el servidor, preferir listas blancas (solo aceptar lo permitido), rechazar datos invalidos de forma clara y nunca confiar en lo que viene del cliente. Tambien sugiere sanitizar los datos antes de usarlos para evitar inyecciones y otros ataques.

Fuente: OWASP Input Validation Cheat Sheet - https://cheatsheetseries.owasp.org/cheatsheets/Input_Validation_Cheat_Sheet.html

## 4. Como se valida en C#
En C# se puede validar de varias formas: int.TryParse para numeros, string.IsNullOrWhiteSpace para textos vacios, y comprobaciones de rango (minimo y maximo). Lo ideal es crear metodos reutilizables como Validador.LeerEntero y Validador.LeerTexto para no repetir codigo y manejar los errores de forma amigable con el usuario.

Fuente: Documentacion oficial de Microsoft - https://learn.microsoft.com/es-es/dotnet/api/system.int32.tryparse