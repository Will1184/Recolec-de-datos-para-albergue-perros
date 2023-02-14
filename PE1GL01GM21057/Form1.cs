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
    /* En un albergue para perros se recolecta la siguiente informaci�n por cada uno: Nombre, Sexo, color, raza y a�o de nacimiento del perro
     * Considere que la raza puede ser: labrador, husky, chiguagua, pastor alem�n, pitbull, Golden retriever, cruzado
     * Los colores pueden ser: negro, blanco, caf�, parchado.
     * listado de todos los registrados en la instituci�n, Calcule y muestre la edad del perro en a�os humanos, sabiendo que la edad se calcula de la siguiente forma
     � El primer a�o de vida en perros se traduce en 15 a�os humanos.
     � Una vez que el perro cumple 2 a�os, se deben sumar 9 a�os adicionales.
     � A partir de los 3, se a�aden alrededor de 5 a�os por cada a�o canino.
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
            int a�oNacimineto = int.Parse(textA�o.Text);


            //PROCESO DE DATOS
            int a�os = 2022 - a�oNacimineto;
            int a�osHumanos = 0;
           
            if (a�os == 1)
            {
                a�osHumanos = 15;
            }
            else if (a�os == 2)
            {
                a�osHumanos = 24;
            }
            else if (a�os == 3)
            {
                a�osHumanos = 29;
            } else if (a�os == 4)
            {
                a�osHumanos = 34;
            }
            else if (a�os >= 5) {
                a�osHumanos = a�os+34+5;
            }

            //SALIDA DE DATOS
            int n = gridDatos.Rows.Add();
            gridDatos.Rows[n].Cells[0].Value =nombre;
            gridDatos.Rows[n].Cells[1].Value = color;
            gridDatos.Rows[n].Cells[2].Value = raza;
            gridDatos.Rows[n].Cells[3].Value = a�os.ToString();
            gridDatos.Rows[n].Cells[4].Value = a�osHumanos.ToString();
            //Dejar vacios los espacios de texto en caso de ingresar nuevos datos
            textA�o.Clear();
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