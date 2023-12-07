using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM
{
    public partial class FrmEmpleados : Form
    {
        Empleado empleadoFormulario;
        public FrmEmpleados()
        {
            InitializeComponent();
        }
        public Empleado EmpleadoFormulario 
        {
            get
            {
                return empleadoFormulario;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int legajo = int.Parse(this.txtLegajo.Text);
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string sector = this.txtSector.Text;
            double sueldo = double.Parse(this.txtSueldo.Text);


        }
    }
}
