# Lab06 - Reynoso Davila

# ListViewGroup

Ejercicio que muestra una lista agrupada de alumnos y sus secciones.

## Clase `Alumnos`

La clase `Alumnos` representa a un estudiante y tiene las siguientes propiedades:

- `Nombre`: El nombre del estudiante.
- `Apellido`: El apellido del estudiante.

Además, la clase `Alumnos` tiene una propiedad `FullName` que combina el nombre y el apellido del estudiante.

## Clase `AlumnosGroup`

La clase `AlumnosGroup` extiende una lista de estudiantes y agrega una propiedad `Heading`, que representa la primera letra del apellido de los estudiantes en ese grupo. La propiedad `Students` contiene la lista de estudiantes en el grupo.

## Archivo `ListViewGroup.xaml`

Este archivo XAML define la interfaz de usuario y contiene:

- Un `ListView` llamado `listView` que muestra la lista de estudiantes.

## Archivo `ListViewGroup.xaml.cs`

Se inicializa la página y se crea una lista de estudiantes agrupados. Luego, se realiza lo siguiente:

- Asigna la lista de estudiantes al `listView`.
- Habilita la agrupación en el `listView`.
- Define las plantillas para los encabezados de grupo y los elementos de la lista.
- Muestra la lista de estudiantes agrupados en la página.
