using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Eficiencia
{
	public partial class Eficiencia : Form
	{
		public Eficiencia()
		{
			InitializeComponent();
		}



		//ARRANCANDO EL PROGRAMA
		private void Eficiencia_Load(object sender, EventArgs e)
		{
			//ABRIR DAYLY

		}



		//BLOQUEAR VENTANA EN MAXIMIZADA
		private void tmrMax_Tick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
