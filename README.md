## Sistema de Préstamo de Libros - Consola en C#

Este proyecto es una aplicación de consola desarrollada en C# que permite gestionar un sistema básico de préstamos de libros en una biblioteca. El sistema facilita el registro de libros y usuarios, así como la gestión de préstamos y devoluciones.

##  Características principales

- Registrar usuarios con un número de identificación único y su nombre completo.
- Registrar libros con código (ISBN), título y autor.
- Prestar libros a usuarios registrados (un libro solo puede estar prestado a un usuario a la vez).
- Devolver libros prestados.
- Listar:
  - Libros disponibles.
  - Libros prestados y sus respectivos usuarios.
  - Libros prestados a un usuario específico.

##  Estructura del proyecto

El proyecto sigue un enfoque de **programación orientada a objetos (POO)**, utilizando múltiples clases para organizar la lógica del sistema:

- **`Libro`**: Representa un libro con propiedades como código, título, autor y estado de préstamo.
- **`Usuario`**: Representa un usuario de la biblioteca con número de identificación y nombre.
- **`GestionarPrestamos`**: Lógica central de los préstamos y devoluciones.
- **`ManejadorInterfaz`**: Clase puente entre el usuario y la lógica del sistema. Contiene métodos como `RegistrarUsuario()`, `PrestarLibro()`, `MostrarLibrosDisponibles()`, etc.
- **`PresentarMenu`**: Muestra un menú interactivo en consola y permite navegar por las opciones del sistema.
- **`Program`**: Clase principal que ejecuta el sistema desde el método `Main`.

##  Interfaz de usuario

La interacción se realiza a través de consola mediante un menú:

