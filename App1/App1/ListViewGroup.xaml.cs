using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        private ObservableCollection<AlumnosGroup> ListOfStudents { get; set; }

        public ListViewGroup()
        {
            InitializeComponent();

            ListOfStudents = new ObservableCollection<AlumnosGroup>();
            SetupStudents();

            // Asigna los datos a la vista
            listView.ItemsSource = ListOfStudents;

            // Establece si se permite la agrupación en el ListView
            listView.IsGroupingEnabled = true;
        }

        private void SetupStudents()
        {
            var aList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "Deysi R", Apellido = "Lloja Lucero" },
                new Alumnos() { Nombre = "Rosa M", Apellido = "Pinedo Hoyos" },
                new Alumnos() { Nombre = "Maria S", Apellido = "Ramos Diaz" },
                new Alumnos() { Nombre = "Sara H", Apellido = "Rosales Cruz" },
                new Alumnos() { Nombre = "Maria J", Apellido = "Lucero Diaz" },
                new Alumnos() { Nombre = "Jimina K", Apellido = "Rosas Rojas" },
                new Alumnos() { Nombre = "Rosa M", Apellido = "Gonsales Cruz" }
            };
            aList.Heading = "A";

            var bList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "Diego F", Apellido = "Colqui Diaz" },
                new Alumnos() { Nombre = "Lucia T", Apellido = "Torres Cruz" },
                new Alumnos() { Nombre = "Marcos M", Apellido = "Gomes Rojas" }
            };
            bList.Heading = "B";

            var cList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "D Rubi", Apellido = "Lloja Lucero" },
                new Alumnos() { Nombre = "Jose M", Apellido = "Colqui Torres" },
                new Alumnos() { Nombre = "Erick T", Apellido = "Rosas Cruz" }
            };
            cList.Heading = "C";

            var dList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "Maria J", Apellido = "Lucero Diaz" },
                new Alumnos() { Nombre = "Jimina K", Apellido = "Rosas Rojas" },
                new Alumnos() { Nombre = "Rosa M", Apellido = "Gonsales Cruz" }
            };
      
            ListOfStudents.Add(aList);
            ListOfStudents.Add(bList);
            ListOfStudents.Add(cList);
            ListOfStudents.Add(dList);
            
        }
    }
}
