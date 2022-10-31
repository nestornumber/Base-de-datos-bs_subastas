using db_sis22A;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_de_datos_bs_subastas
{

    public partial class categoriasFRM : Form
    {
        //Agregar la instancia de la clase cls_transacciones a nivel del formulario.
        cls_transacciones objT = new cls_transacciones();

        public categoriasFRM()
        {
            InitializeComponent();
        }

        //Formulario[categoriasFRM]
        //agregar el método consulta[para consultar todas las categorías]
        //agregar el método consulta con filtro en los parámetros[para hacer las búsquedas] 
        //agregar el metodo showBuscar[metodo para filtrar la consulta]
        public void consulta()
        {
            string sql = "Select * from categorias";
            dtG_ver_categorias.DataSource = objT.consulta(sql);
            dtG_ver_categorias.Refresh();
        }

        public void consulta(string filtro)
        {
            string sql = "Select * from categorias where nombre_categoria like '" + filtro + "'";
            dtG_ver_categorias.DataSource = objT.consulta(sql);
        }

        //Método para consultar categorías.
        private static DialogResult ShowBuscar(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(500, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Ingrese el nombre de la categoria a buscar";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "gBuscar";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);
            inputBox.MaximizeBox = false;

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancelar";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string input = "";
            DialogResult cd = ShowBuscar(ref input);
            consulta(input);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            string mensaje = "Confirme la eliminacion de las categorias";
            MessageBoxIcon icono = MessageBoxIcon.Question;
            respuesta = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, icono);
            if (respuesta == DialogResult.Yes)
            { 
                foreach (DataGridViewRow fila in this.dtG_ver_categorias.Rows)
                {
                    DataGridViewCheckBoxCell ck = (DataGridViewCheckBoxCell)fila.Cells["idP"];
                    if (Convert.ToBoolean(ck.Value)) 
                    {
                        string id = fila.Cells[1].Value.ToString();
                        string sql = "delete from categorias where id_categoria='" + id + "'";
                        objT.ejecutarComando(sql);
                        consulta();
                    }
                }
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            //analiza si el textbox txtCategoria esta vacio, y si lo esta añade el nuevo campo
            if (txtCategorias.Text.Trim() == string.Empty)
            {
                string cat = txtCategorias.Text;
                string sql = "insert into categorias (nombre_categoria) values('" + cat + "')";
                objT.ejecutarComando(sql);
                consulta();
                this.txtCategorias.Text = "";
            }

            //aca si tiene texto igual lo añade
            else
            {
                string cat = txtCategorias.Text;
                string sql = "insert into categorias (nombre_categoria) values('" + cat + "')";
                objT.ejecutarComando(sql);
                consulta();
                this.txtCategorias.Text = "";
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

