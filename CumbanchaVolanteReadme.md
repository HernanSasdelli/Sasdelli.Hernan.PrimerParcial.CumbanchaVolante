# CumbanchaVolante
Hernan Sasdelli 
TP1_LaboratorioYProgramacionII_2022

Sinceramente, me gusto mucho el programa y tenia en la cabeza que iba a quedar muy bueno, no era muy dificil, pero por falta de tiempo personal ( no el que me dieron los profesores) no me alcanzo. Cosas que pasan, lo bueno, es que que este cuatrimestre siento que aprendo mucho mejor y mucho mas que en el anterior que recurse.
En cuanto a la programacion, me doy cuenta que tengo que enfocarme en un punto, resolverlo, y pasar al siguiente, ya me paso en C, el primer cuatrimestre, pienso en todo junto, las validacion, los puntos pedidos, el final del programa, y tengo que ir mas desde el punto mas chico al mas grande, paso por paso, porque al momento de resolver el punto, me anulo pensando en todo lo que sigue y me termino trabando en cosas simples.


Sobre el programa

**Compila sin errores, 
**dvertencias
  Advertencia	CS8600, aparece al hacer esta agignacion de una fila del datagrid principal de MenuPrincipal, a un string:  
  
/////dtg_secundario.CurrentRow.Cells[10].Value.ToString();

**Se sobreescribe el metodo ToString(), desde la clase Vuelo:
 
 ////public override string ToString()
 
 se utiliza para concatenar en un string las propiedades principales del vuelo:
 
////string fecha
////string origen
////string destino

que luego se guardara en un diccionario que tiene detallado los viajes hechos por cada cliente

**Se implementa sobre carga de constructores en las Clases
///Vuelo
  static Vuelo()  carga las listas de destinos apenas inicia el programa sin parametros
   public Vuelo(detalla todos los paremetros necesarios para crear un Vuelo)
   
///Pasajero
1er constructor
public Pasajero(detalla todos los parametros necesarios para crear un pasajero desde cliente, sin cargar valijas, y clases en que viaja)            

2do constructor  
 public Pasajero(detalla todos los parametros necesarios para crear un pasajero completamente, listo para subir a un vuelo)
 
 **Se implementan las clases 
 
 //Venta  (clase estatica) todo lo que relacionado a las listas de vuelos, clientes, aeronaves, pasajeros, utilizadas para la logica de negocio
 
 //Usuario
 
 //VistaUsuario separa la lista de vuelos, entre realizados y proximos, para que no se visualicen como disponibles, los vuelos que ya no pueden subir pasajeros, ejemplo "EnCurso" o "Realizado"
 
 //Vuelo contiene dos enumarados, para contener el tipo de destino(internacional, nacional) y el tipo de servicio(clase turista, clase premium)
 
 //Aeronave
 -identificador alfanumerico
 -detalle de baños, espacio en bodega, asientos, y recerva del 20% de los asientos para clase premium. Se visualiza facilmente todos los fatos al tocar el boton aeronaves del menu principal.
 
 //Persona (clase Abstracta) Base
 //Cliente derivada 
 ////public virtual string MostrarInfoCliente() se sobreescribe en clase hija
 //Pasajero derivada
 ////public override string MostrarInfoCliente()
 
 //Equipaje (clase estatica)
 
 //Facturacion
 //Factura
 
 //Harcodeo (clase estatica)
 //Validacion
 
 Las 3 clases estaticas solo manejan datos no tienen caracteristicas propias
 
 
 **Colecciones genericas
 //List<> se utiliza en todo el largo de la aplicacion, para manejo de facturacion, clientes, vuelos, destinos, harcodeo, pasajero, aviones.
 
 //Dictionary<> para guardar los vuelos(key idVuelo) y detallar fecha, origen y destino del mismo en un string (value detalles)
 
 
 **Toda la logica esta realizada en las clases, en los formularios se dejo la logica indispensable, para compartir informacion entre los botones y bloquear los mismos depende las elecciones del cliente.
 
*****La solucion implementa 8 formularios en total
///Logueo, ingreso de usuario de la aplicacion, solo se ejecuta una vez al principio.

///Menu principal, base de partida de todos los demas Forms,
desde el mismo se ejecutan:

//Nuevo Cliente, ademas de las validaciones y verificar que ya no este cargado con anterioridad,solo dejara cargar un cliente que sea mayor de edad

//Nuevo Vuelo, solo permite generar vuelos a partir de un dia posterior al dia de la fecha, hasta 365.25 dias adelante(aproximando las fechas que manejan normalmente las aerolineas) y siempre que la aeronave, no este en uso en otro vuelo ese mismo dia. El usuario puede seleccionar entre las opciones, si el vuelo contara con WIfi, servicio de refresco, y/o comida.

//Estadisticas, ejecuta las estadisticas solicitadas por la consigna del programa, 
y muestra a traves de un datagrid los destinos ordenados por mayor solicitud, y por mayor facturacion

//Subir Pasajero, se habilita en el momento que se selecciona un vuelo desde el datagrid principal del Menu Principal. Comparte informacion del vuelo y de los clientes, para detallar las caracteristcas del vuelo a comprar y verificar, primero si el pasajero ya es cliente, segundo si existe la disponibilidad para la cantidad de pasajeros solicitada, y tercero si el pasajero ya no ha dido cargado en ese vuelo o precarga.

//Emitir Eticket, carga los datos del vuelo, con las caractistcas solicitadas por el pasajero, y los datos de los pasajeros a subir, para luego emitir la factura con importes de tazas, netos y totales. El importe Neto varia segun el tipo de destino(nacional,Internacion), el tipo de clase de servicio(premium, turista), y la cantidad de pasajeros a subir.
Al emitir correctamente el eticket vuelve la aplicacion al Menu Principal.

**Todos los formularios aparecen desde el centro de la pantalla, sin poder redimencionarse, y se puede salir de los formularios y desde la aplicacion solo desde los botones cancelar, y salir.

**********Uso del Menu Principal**********
Consta de dos datagrid, para expandir mas la visualizacion de informacion detallada de varias listas a la vez, sin tener que emitir nuevos formularios o mensajes de texto incomodos.

El boton de vuelos, muestra en el datagrid primario(izquierda de la pantalla) el listado de vuelos proximos; al hacer doble clic en una de las filas, habilita el boton de subir al avion, y detalla en el datagrid secundario(derecha de la pantalla) los pasajeros ya subidos al vuelo y todos sus detalles. Al hacer doble clic en una fila del datagrid secundario, se emite un mensaje con los datos y el equipaje del pasajero seleccionado.

El boton aviones, muestra en el datagrid principal(1), el detalle completo de todos los aviones de la flota. Al hacer doble click sobre uno, detalla en el dtg(2) secundario los vuelos realizados y a realizar del mismo avion.

El boton cliente, muestra la lista completa de clientes, en el dtg 1, al hacer doble click sobre uno, ejecuta una caja de mensaje con el detalle del cliente(funcion virtual), y el el dtg 2 el listado de vuelos comprados por ese cliente, realizados, y a realizar.

Boton estadisticas, muestra las estadisticas solicitadas por la consigna.

Boton Facturas, muestras todas las facturas de vuelos realizados.

Boton Vuelos historicos, muestra todos los Vuelos

****Funcionalidad Adicional****
Formulario 8
Debido a la inestabilidad economica del pais, la propuesta de funcionalidad de valor agregado, es modificar, los precios de costo de los vuelos, y modificar, las tazas e impuestos segun "reglamentacion vigente".

Listas externas utilizadas:
Regex utilizada para la validadcion de datos ingresados por el usuario, por ejemplo el mail

Linq utilizada para ordenar listas de objetos segun una variable especifica del mismo.
