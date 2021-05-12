# Threads, Sockets y Ficheros

Crear una aplicación de Consola C# llamada Mensajero. Dicha aplicación debe permitir las siguientes
operaciones:

#Enviar Mensaje:

Al enviar el mensaje, debe recibir el nombre del remitente, el mensaje y el tipo de comunicación:

- Nombre del Remitente: String
- Mensaje: Texto de largo máximo 20 que indica el texto a enviar
- Tipo de Comuncación: Puede ser “Aplicación” o “TCP” dependiendo de si la interfaz utilizada para enviar el mensaje fue desde la aplicación de consola o desde Socket.

Al efectuar el ingreso de los datos, debe ingresar una nueva fila en un fichero llamado mensajes.txt dentro del directorio del servidor

# Ver Mensajes Enviados:

Debe mostrar los mensajes existentes por pantalla.
La aplicación debe poseer dos interfaces de comunicación:

- Aplicación de Consola, el cual es efectuado por la Hebra Principal. Debe permitir interactuar con la aplicación de manera indefinida y efectuar ingreso de mensajes. En este caso, el mensaje debe ser ingresado con el Tipo de Comunicación “Aplicación”.

- Servidor Socket, el cual debe ser administrado por una Hebra Secundaria. Debe permitir interactuar mediante un Socket TCP con la aplicación. En este caso, el mensaje debe ser ingresado con el Tipo de Comunicación “TCP”. El Servidor debe permitir el recibir peticiones de simultaneos Clientes
