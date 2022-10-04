# CumbanchaVolante
Hernan Sasdelli 
TP1_LaboratorioYProgramacionII_2022
Programa no terminado, sin minimos requisitos para aprovacion, compila, sin errores hasta que lo intente arreglar y crashea en mostrar los datos de la factura

Sinceramente, me gusto mucho el programa y tenia en la cabeza que iba a quedar muy bueno, no era muy dificil, pero por falta de tiempo personal ( no el que me dieron los profesores) no me alcanzo. Cosas que pasan, lo bueno, es que que este cuatrimestre siento que aprendo mucho mejor y mucho mas que en el anterior que recurse.
En cuanto a la programacion, me doy cuenta que tengo que enfocarme en un punto, resolverlo, y pasar al siguiente, ya me paso en C, el primer cuatrimestre, pienso en todo junto, las validacion, los puntos pedidos, el final del programa, y tengo que ir mas desde el punto mas chico al mas grande, paso por paso, porque al momento de resolver el punto, me anulo pensando en todo lo que sigue y me termino trabando en cosas simples.

El programa, la idea era 3 datagrid en la pantalla principal,
Cuando se toca Vuelos, el principal muestra los vuelos, el secundario los pasajeros, y el tercero el espacio de equipaje en bodega
Cuando se toca aviones, el principal lista los aviones, el secundario los vuelos por realizar, y el tercero los vuelos realizados
Cuando se toca pasajeros(era la idea cambiar a clientes), los vuelos realizados y el terceario a definir(idea de destinos mas visitados)

Ademas, los forms de carga de vuelo, cliente, y venta de pasaje
La carga de nuevo vuelo verificada, el avion no puede salir dos veces el mismo dia
La carga de clientes tiene los datos verificados y utilizacion de Regex (Regular Expression)

Cosas que faltan:
Falta estadisticas
Falta Botones de ayuda
Codigo sin documentar
Falta terminar de subir un pasajero al avion ( principal )
Falta verificar si el vuelo se realizo, esta en vuelo, o se realizara
Verificar si el pasajero ya esta en el vuelo
No se controla equipaje, clase vacia
Visual no terminada

y muchas otras cosas mas 

Puntos de los temas de la clase aplicados
solo breves ejemplos

Clases y metodos estaticos
*public static class Venta** maneja las listas que se van usando a lo largo del proyecto

Sobrecarga de Constructores
** public frm_emitirEticket(){}
** public frm_emitirEticket(Pasajero pasajeroASubir, Vuelo vueloSelect):this(){}
Hecho para inicializar un nuevo formulario con informacion de un formulario anterior

Colecciones
Utilizacion de Listas, 
la idea era utilizar un diccionario para documentar los vuelos hechos por el cliente

Herencia y Polimorfismo
Clase Pasajero Hereda de Cliente

Uso del Try Catch

si llegaron hasta aca, muchas gracias por su tiempo







