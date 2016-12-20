
# Algoritmica
This is a repository to create basic algoritmics problems.

##Recursividad:
En programación, un método usual de simplificación de un problema complejo es la división de este en subproblemas del mismo tipo. Esta técnica de programación se conoce como divide y vencerás y es el núcleo en el diseño de numerosos algoritmos de gran importancia, así como también es parte fundamental de la programación dinámica.
Fuente: https://es.wikipedia.org/wiki/Recursi%C3%B3n#Recursi.C3.B3n_en_inform.C3.A1tica

Un ejemplo típico de recursión o recursividad es el de las torres de hanoi: http://www.uterra.com/juegos/torre_hanoi.php

Este juego consiste en mover los discos del palo de la izquierda al palo de la derecha teniendo el palo del medio como auxiliar, la estrategia abordada en la solución de este problema ha sido:

* Cuando solo hay un disco solo hay que moverlo del origen al destino 
* Supongamos que podemos mover de origen a centro n-1 discos 
* movemos de origen a destino el disco que se ha quedado solo
* movemos de centro a derecha los n-1 


##Programación dinámica:
En informática, la programación dinámica es un método para reducir el tiempo de ejecución de un algoritmo mediante la utilización de subproblemas superpuestos y subestructuras óptimas.
Una subestructura óptima significa que se pueden usar soluciones óptimas de subproblemas para encontrar la solución óptima del problema en su conjunto.
En general, se pueden resolver problemas con subestructuras óptimas siguiendo estos tres pasos:

* Dividir el problema en subproblemas más pequeños.
* Resolver estos problemas de manera óptima usando este proceso de tres pasos recursivamente.
* Usar estas soluciones óptimas para construir una solución óptima al problema original.

Los subproblemas se resuelven a su vez dividiéndolos en subproblemas más pequeños hasta que se alcance el caso fácil, donde la solución al problema es trivial.

Si necesitamos resolver el mismo problema más tarde, podemos obtener la solución de la lista de soluciones calculadas y reutilizarla. Este acercamiento al problema se llama memoización.

La programación toma normalmente uno de los dos siguientes enfoques:
* Top-down: El problema se divide en subproblemas, y estos se resuelven recordando las soluciones por si fueran necesarias nuevamente. Es una combinación de memoización y recursión.
* Bottom-up: Todos los problemas que puedan ser necesarios se resuelven de antemano y después se usan para resolver las soluciones a problemas mayores. Este enfoque es ligeramente mejor en consumo de espacio y llamadas a funciones, pero a veces resulta poco intuitivo encontrar todos los subproblemas necesarios para resolver un problema dado.

Fuente: https://es.wikipedia.org/wiki/Programaci%C3%B3n_din%C3%A1mica 


###Problems:
* Find the contiguous subarray within an array (containing at least one number) which has the largest sum. 
For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
the contiguous subarray [4,-1,2,1] has the largest sum = 6.
The idea is: "We should ignore the sum of the previous n-1 elements if the number of the element is greater than the sum."

