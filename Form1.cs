using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.CompilerServices;

namespace CajeroBBVA
{
    public partial class CajeroBBVA : Form
    {
        Queue<string> documentos = new Queue<string>(); // creamos la cola
        Queue<string> colaTurnos = new Queue<string>();
        public int xClick = 0, yClick = 0;


        int contador = 1;// creamos un contador de los turnos
        public CajeroBBVA()
        {
            InitializeComponent();

            data_g.AllowUserToAddRows = false;
            dataGridView1.AllowUserToAddRows = false;
            text_dni.Text = "Numero de documento";
            data_g.AutoGenerateColumns = false;
            text_dni.MaxLength = 8;
            cajero1btn.Enabled = false;
            cajero2btn.Enabled = false;
        }

        private void turnobtn_Click(object sender, EventArgs e)
        {
            string dni;
            bool valido = true;
            cajero1btn.Enabled = true;
            cajero2btn.Enabled = true;
            if (text_dni.Text == "Numero de documento")
            {
                valido = false;
                MessageBox.Show("Ingrese su numero de Documento");
            }
            if (documentos.Contains(text_dni.Text))
            {
                valido = false;
                MessageBox.Show("Ya pidio un turno!");
            }
            else if(valido)
            {
                data_g.Rows.Clear();
                dataGridView1.Rows.Clear();
                if (text_dni.Text != "")
                {
                    dni = text_dni.Text;
                    colaTurnos.Enqueue(Convert.ToString(contador));
                    documentos.Enqueue(dni);
                    recorrerCola(colaTurnos, documentos);
                }
                else
                {
                    MessageBox.Show("Debe ingresar un documento valido");
                    data_g.Refresh();
                }
                data_g.Refresh();
                dataGridView1.Refresh();
                contador++;
            }
            text_dni.Text = "Numero de documento";
            mostrarTurnotxt.Clear();
        }

        private void cajero1btn_Click(object sender, EventArgs e)
        {

            if (colaTurnos.Count == 1)
            {

                data_g.Rows.Clear();
                dataGridView1.Rows.Clear();
                colaTurnos.Dequeue();
                string documento = documentos.Dequeue() + " Caja 1";
                mostrarTurnotxt.Text = "No hay mas turnos"; // Mostramos el turno en nuestro box 
                anteriortxt.AppendText(documento + "\r\n");
                recorrerCola(colaTurnos, documentos);
            }
            else if (colaTurnos.Count > 1)
            {
                data_g.Rows.Clear();
                dataGridView1.Rows.Clear();
                colaTurnos.Dequeue(); // Sacamos el primer turno de nuestra cola
                string documento = documentos.Dequeue() + " Caja 1";
                mostrarTurnotxt.Text = documento.ToString(); // Mostramos el turno en nuestro box 
                anteriortxt.AppendText(documento + "\r\n");

                recorrerCola(colaTurnos, documentos);
            }
            botonActivar();
        }

        private void cajero2btn_Click(object sender, EventArgs e)
        {
            if (colaTurnos.Count == 1)
            {

                data_g.Rows.Clear();
                dataGridView1.Rows.Clear();

                colaTurnos.Dequeue(); // Sacamos el primer turno de nuestra cola
                string documento = documentos.Dequeue() + " Caja 2";

                mostrarTurnotxt.Text = "No hay mas turnos"; // Mostramos el turno en nuestro box 
                anteriortxt.AppendText(documento + "\r\n");

                recorrerCola(colaTurnos, documentos);
            }
            else
            {
                data_g.Rows.Clear();
                dataGridView1.Rows.Clear();
                colaTurnos.Dequeue(); // Sacamos el primer turno de nuestra cola
                string documento = documentos.Dequeue() + " Caja 2";
                mostrarTurnotxt.Text = documento; // Mostramos el turno en nuestro box 
                anteriortxt.AppendText(documento + "\r\n");

                recorrerCola(colaTurnos, documentos);
            }
            botonActivar();
        }

        public void recorrerCola(Queue<string> colaTurnos, Queue<string> documentos)
        {
            foreach (String docu in documentos)
            {
                data_g.Rows.Add(docu);

            }
            foreach (string turno in colaTurnos)
            {
                dataGridView1.Rows.Add(turno);
            }
            data_g.Refresh();
            dataGridView1.Refresh();

        }

        private void data_g_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text_dni_MouseClick(object sender, MouseEventArgs e)
        {

            if (text_dni.Text == "Numero de documento")
            {
                text_dni.Clear();
            }


        }

        private void text_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

        public void botonActivar()
        {
            if (documentos.Count > 0)
            {
                cajero1btn.Enabled = true;
                cajero2btn.Enabled = true;
            }
            else
            {
                cajero1btn.Enabled = false;
                cajero2btn.Enabled = false;
            }
        }

        public void limpiarTextBox(TextBox text)
        {
            text.Clear();
        }

        private void cajero1btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                turnobtn_Click(turnobtn, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_dni_Leave(object sender, EventArgs e)
        {

        }

        private void CajeroBBVA_Load(object sender, EventArgs e)
        {
           
        }

        private void text_dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_dni_MouseLeave(object sender, EventArgs e)
        {
            if(text_dni.Text == "")
            {
                text_dni.Text = "Numero de documento";
            }
            
        }

        private void text_dni_MouseHover(object sender, EventArgs e)
        {
            if (text_dni.Text == "Numero de documento")
            {
                text_dni.Clear();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
            {
                xClick = e.X;
                yClick = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - xClick);
                this.Top = this.Top +(e.Y - yClick);
            }
        }
    }
}
