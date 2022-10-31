
namespace Base_de_datos_bs_subastas
{
    partial class categoriasFRM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoriasFRM));
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txtCategorias = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_todos = new System.Windows.Forms.Button();
            this.lbl_consulta = new System.Windows.Forms.Label();
            this.dtG_ver_categorias = new System.Windows.Forms.DataGridView();
            this.idP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_categorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtG_ver_categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_categoria.Location = new System.Drawing.Point(43, 17);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(322, 23);
            this.lbl_categoria.TabIndex = 0;
            this.lbl_categoria.Text = "Ingrese el nombre de la nueva categoría:";
            // 
            // txtCategorias
            // 
            this.txtCategorias.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategorias.Location = new System.Drawing.Point(43, 58);
            this.txtCategorias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategorias.Name = "txtCategorias";
            this.txtCategorias.Size = new System.Drawing.Size(716, 30);
            this.txtCategorias.TabIndex = 1;
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_salir.Location = new System.Drawing.Point(677, 106);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(80, 80);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_save.Location = new System.Drawing.Point(576, 106);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 80);
            this.btn_save.TabIndex = 3;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_eliminar.Location = new System.Drawing.Point(475, 106);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(80, 80);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_buscar.Location = new System.Drawing.Point(374, 106);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(80, 80);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_todos
            // 
            this.btn_todos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_todos.BackgroundImage")));
            this.btn_todos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_todos.Location = new System.Drawing.Point(273, 106);
            this.btn_todos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(80, 80);
            this.btn_todos.TabIndex = 6;
            this.btn_todos.UseVisualStyleBackColor = true;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // lbl_consulta
            // 
            this.lbl_consulta.AutoSize = true;
            this.lbl_consulta.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_consulta.Location = new System.Drawing.Point(43, 259);
            this.lbl_consulta.Name = "lbl_consulta";
            this.lbl_consulta.Size = new System.Drawing.Size(246, 23);
            this.lbl_consulta.TabIndex = 7;
            this.lbl_consulta.Text = "Consulta general de categorías";
            // 
            // dtG_ver_categorias
            // 
            this.dtG_ver_categorias.AllowUserToAddRows = false;
            this.dtG_ver_categorias.AllowUserToDeleteRows = false;
            this.dtG_ver_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG_ver_categorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idP,
            this.col_ID,
            this.col_categorias});
            this.dtG_ver_categorias.Location = new System.Drawing.Point(43, 299);
            this.dtG_ver_categorias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtG_ver_categorias.Name = "dtG_ver_categorias";
            this.dtG_ver_categorias.RowHeadersWidth = 51;
            this.dtG_ver_categorias.RowTemplate.Height = 25;
            this.dtG_ver_categorias.Size = new System.Drawing.Size(716, 230);
            this.dtG_ver_categorias.TabIndex = 8;
            // 
            // idP
            // 
            this.idP.HeaderText = "#";
            this.idP.MinimumWidth = 6;
            this.idP.Name = "idP";
            this.idP.Width = 30;
            // 
            // col_ID
            // 
            this.col_ID.DataPropertyName = "id_categoria";
            this.col_ID.HeaderText = "ID";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.Width = 40;
            // 
            // col_categorias
            // 
            this.col_categorias.DataPropertyName = "nombre_categoria";
            this.col_categorias.HeaderText = "Categorías";
            this.col_categorias.MinimumWidth = 6;
            this.col_categorias.Name = "col_categorias";
            this.col_categorias.Width = 480;
            // 
            // categoriasFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 600);
            this.Controls.Add(this.dtG_ver_categorias);
            this.Controls.Add(this.lbl_consulta);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txtCategorias);
            this.Controls.Add(this.lbl_categoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "categoriasFRM";
            this.Text = "Categorías";
            ((System.ComponentModel.ISupportInitialize)(this.dtG_ver_categorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.TextBox txtCategorias;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.Label lbl_consulta;
        private System.Windows.Forms.DataGridView dtG_ver_categorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_categorias;
    }
}

