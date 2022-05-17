Este programa simula un sistema de gestión de un Bar. Toda la parte visual está hecha con el framework de Windows Forms.

Al iniciarse, muestra una pantalla de log in, la cual ya tiene 2 usuarios de prueba para ingresar, un "Administrador" y un "Usuario Común". Para agilizar el test de la validación de usuario y contraseña, existen 2 botones que ingresan automáticamente los datos del primer tipo de usuario que se haya elegido.

Dependiendo del tipo de usuario que haya ingresado, el formulario principal tendrá más o menos botones, y el color general de los marcos externos será distinto para diferenciarlos.

Las principales funciones del programa se encuentran en la barra derecha del formulario principal. Ordenándolas desde arriba hacia abajo, sus características son las siguientes:

- Botón 1/Con plato y cubiertos: 
Es el único botón compartido por ambos tipos de usuario. Al clickear en él, se muestra un listado con toda la información de los espacios de consumo existentes y su estado. Si la columna derecha(Ocupado) se encuentra pintada de amarillo, la mesa está disponible para ser ocupada, y si es gris, no. Al hacer doble click en alguna de las celdas de las filas de la tabla, se abrirá un sub menú con los detalles del espacio de consumo que corresponda a esa fila.

Dentro de este sub menú se encontrarán todos los pedidos hechos hasta el momento por el espacio en un recuadro blanco. Aquí, al hacer doble click en alguno de los pedidos ya realizados, se abrirá una ventana preguntando por la cantidad a retirar, junto con un casillero para tildar(checkbox) si esa cantidad puede volver a formar parte del stock o ya fue consumida/desperdiciada. En la parte inferior del sub menú del espacio, habrá un listado con las consumiciones disponibles en stock. Este listado de stock muestra las comidas o bebidas, eligiendo cuál de las 2 mostrar en un combo box(botón desplegable con opciones) dentro del formulario. Al hacer doble click en alguna celda de la fila en el listado de stock, el programa pedirá ingresar la cantidad de esa consumición que querramos agregar al espacio de consumo, mostrándose en el recuadro blanco mencionado anteriormente.
Una vez que el espacio cuente con todas las consumiciones pedidas reflejadas en la aplicación, se debe hacer click en el botón "Guardar cambios" para que esos cambios dejen de ser temporales y sean permanentes, afectando al stock y al espacio correspondiente en el proceso.

- Botón 2/Usuario:
Esta sección y las que siguen son exclusivas de un usuario Administrador. Aquí está disponible la información (excluyendo el usuario de login y su contraseña) de los usuarios de esta aplicación/empleados del bar. También existen 2 botones para agregar y eliminar un usuario.
Para eliminar un usuario, se selecciona en la tabla de información alguna celda del usuario a borrar y se hace click en el botón para eliminar. Luego de un chequeo preguntando si está seguro de la acción, se borra al usuario seleccionado. Es importante recalcar que el Administrador usando la aplicación en ese momento no puede borrarse a sí mismo ya que la aplicación no puede carecer de usuarios con rol de Administrador
Al hacer click en agregar se abrirá un sub formulario donde se deberán ingresar los datos del usuario a crear con la posibilidad de darle privilegios de administrador o no, según corresponda. También es importante recalcar que esta instancia será la única donde un usuario puede definir su usuario y contraseña para luego ingresar a la aplicación. 

- Botón 3/Cajas:
En esta sección se ve el listado del tipo de stock que se quiera ver, pudiendo ser de tipo comida o bebida. 
Teniendo 6 botones en total, los botones de "Nueva Comida/Bebida" abren un sub formulario con los datos a ingresar de una nueva consumición. El botón "Cambiar precio unitario" abrirá el mismo formulario con todos los datos de la consumición seleccionada en la lista, dejando que el usuario modifique solamente el precio unitario de la consumición. Los botones "Agregar/Restar stock" suman o restan stock según corresponda, de la consumición seleccionada en la lista. Por último, "Eliminar Consumición" borra el registro de la consumición seleccionada en la lista. Esta acción sólo puede ser realizada con todos los espacios de consumo cerrados.

- Botón 4/Monedas:
En esta sección se ven los registros de las ventas realizadas a los espacios de consumo. El usuario tiene a modo informativo el registro de las mismas, la cantidad y el total recaudado hasta el momento. También puede modificar el precio del estacionamiento, el cual es un extra calculado al momento del cierre de mesa, si corresponde.

- Botón 5/Log out:
Este botón cierra el formulario principal y vuelve a mostrar el formulario de log in.
