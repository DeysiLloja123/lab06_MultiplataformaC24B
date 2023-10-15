# DOCUMENTACIÒN DELLAB 06

Nuestras aplicaciòn tiene de nombre app01, y dentro de este se ha implementado 4 botos, los 3 primeros botones, son de las activiades que se realizaron en clase, y el 4to boton nosmuestra una lista agrupada de alumnos en base a sus respectivas secciones.
Sin embargo Para realizar esta actividad se crearon  archivos, los cuales a continuaciòn los explicaremos: 

# El  Archivo Clase Alumnos

Dentro de esta clase llamada Alumnos, se establecieron los atributos con las que contaran los alumnos, tales como:

* Nombre: Nos permitira segmentar el nombre del estudiante.
  
* Apellido: Este es para el apellido del estudiante.
  
 * FullName: Este atributo combina el nombre y el apellido del estudiante.

# El Archivo Clase AlumnosGroup

En esta clase denomida AlumnosGroup, se esta extiendiendo una lista de los estudiantes, para luego  agregar la propiedad Heading, que representa la primera letra del apellido de los estudiantes en ese grupo. Por otro lado la propiedad Students almacena la lista de estudiantes pertenecientes a este grupo.

# El Archivo ListViewGroup.xaml

Dentro de este archivo de tipo XAML se ha definido la interfaz de usuario y dentro de est un ListView llamado listView que se encargara de muestror la lista de estudiantes.

# El Archivo ListViewGroup.xaml.cs

Dentro de este archivo, la página se inicia y se genera una agrupación de estudiantes con su respectiva secciòn perteneciente. Luego, se ejecutan las siguientes acciones:

* 1. Los estudiantes se asignan al "listView".
* 2. Se habilita la función de agrupación en el "listView".
* 3. Se especifican las plantillas para los encabezados de grupo y los elementos de la lista.
* 4. Se muestra la lista de estudiantes organizados en grupos en la página.

## A continuaciòn se muestras capturas de los resultados:

Ejecuciòn de la aplicaciòn en nuestro telefono Android:

![image](https://github.com/DeysiLloja123/lab06_MultiplataformaC24B/assets/129902954/a1dfb2e4-11ef-4864-b368-db44b45f9b1e)

Parte del menuopantalla principal de la aplicaciòn:

![image](https://github.com/DeysiLloja123/lab06_MultiplataformaC24B/assets/129902954/6c99e2aa-78d6-489d-bafa-351822cf4930)

Listado de alumnos co su respectiva secciòn:

![image](https://github.com/DeysiLloja123/lab06_MultiplataformaC24B/assets/129902954/d9223838-5d8a-49c3-8481-f36f734703f6)

![image](https://github.com/DeysiLloja123/lab06_MultiplataformaC24B/assets/129902954/eb7ef148-3e89-42a8-ad4a-39f841776d80)

![image](https://github.com/DeysiLloja123/lab06_MultiplataformaC24B/assets/129902954/b579c302-ba02-4906-a0e9-b926868e2467)


