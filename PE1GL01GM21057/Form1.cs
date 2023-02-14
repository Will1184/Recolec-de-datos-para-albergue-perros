using System.Windows.Forms.VisualStyles;
// Eva: #1
// Fecha: 06/9/2022
// Autor: Brandon William Gomez Monge
// Carnet: GM21057
// GD: #01
// Instructora: ING. Nelly Lissette Henriquez Sanchez
namespace PE1GL01GM21057
{
    //Decripcion del programa
    /* En un albergue para perros se recolecta la siguiente información por cada uno: Nombre, Sexo, color, raza y año de nacimiento del perro
     * Considere que la raza puede ser: labrador, husky, chiguagua, pastor alemán, pitbull, Golden retriever, cruzado
     * Los colores pueden ser: negro, blanco, café, parchado.
     * listado de todos los registrados en la institución, Calcule y muestre la edad del perro en años humanos, sabiendo que la edad se calcula de la siguiente forma
     • El primer año de vida en perros se traduce en 15 años humanos.
     • Una vez que el perro cumple 2 años, se deben sumar 9 años adicionales.
     • A partir de los 3, se añaden alrededor de 5 años por cada año canino.
*/
    public partial class Form1 : Form
    {
        private int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES Y ENTRADA DE DATOS
            String nombre = textNombre.Text;
            String color = textColor.Text;
            String raza = textRazas.Text;
            int añoNacimineto = int.Parse(textAño.Text);


            //PROCESO DE DATOS
            int años = 2022 - añoNacimineto;
            int añosHumanos = 0;
           
            if (años == 1)
            {
                añosHumanos = 15;
            }
            else if (años == 2)
            {
                añosHumanos = 24;
            }
            else if (años == 3)
            {
                añosHumanos = 29;
            } else if (años == 4)
            {
                añosHumanos = 34;
            }
            else if (años >= 5) {
                añosHumanos = años+34+5;
            }

            //SALIDA DE DATOS
            int n = gridDatos.Rows.Add();
            gridDatos.Rows[n].Cells[0].Value =nombre;
            gridDatos.Rows[n].Cells[1].Value = color;
            gridDatos.Rows[n].Cells[2].Value = raza;
            gridDatos.Rows[n].Cells[3].Value = años.ToString();
            gridDatos.Rows[n].Cells[4].Value = añosHumanos.ToString();
            //Dejar vacios los espacios de texto en caso de ingresar nuevos datos
            textAño.Clear();
            textNombre.Clear();
        }

        //Boton que se sale del programa si lo presionan
        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton que borra informacion de la tabla
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (c!=-1)
            {
                gridDatos.Rows.RemoveAt(c);
            }
        }

      
    }
}