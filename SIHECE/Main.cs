using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIHECE
{
    public partial class Main : myForm
    {
        public Main()
        {
            InitializeComponent();
            // Inicialización de propiedades personalizadas del formulario.
            this.Titulo = "SIHECE - Sistema de Información Hospitalaria y Expediente Clínico Electrónico";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
