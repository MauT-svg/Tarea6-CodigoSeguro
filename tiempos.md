# Tiempos List vs LinkedList

|Persona|List inicio|LinkedList inicio|List final|LinkedList final|
|-|-|-|-|-|
|Mauricio|503|25|1|9|
|Johana|145|3|0|29|

## Conclusion

En ambas computadoras, insertar al inicio fue mucho mas lento en List que en LinkedList.
Esto ocurre porque List tiene que mover todos los elementos cada vez que se inserta en la posicion 0.
LinkedList solo crea un nuevo nodo y lo enlaza, por eso es casi instantanea.
Al insertar al final ambas son rapidas, pero List suele ser un poco mas eficiente porque usa un arreglo interno.



Nota: Los tiempos fueron medidos en las computadoras de Mauricio y Johana el dia de la entrega. Los resultados confirman que LinkedList es mucho mas eficiente al insertar al inicio.



\## Observacion final



En ambas computadoras se repitio el mismo patron:

\- Insertar al inicio en List es significativamente mas lento.

\- LinkedList mantiene tiempos bajos tanto al inicio como al final.

\- Esto demuestra la diferencia de complejidad entre las dos estructuras.





