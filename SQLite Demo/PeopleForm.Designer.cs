namespace SQLite_Demo
{
    partial class PeopleForm
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
            btn_add = new Button();
            btn_refresh = new Button();
            tbx_apellido = new TextBox();
            tbx_nombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lb_listPerson = new ListBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Location = new Point(12, 178);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(158, 59);
            btn_add.TabIndex = 0;
            btn_add.Text = "AÑADIR PERSONA";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(12, 243);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(158, 59);
            btn_refresh.TabIndex = 0;
            btn_refresh.Text = "REFRESCAR LISTA";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_add.Click += btn_refresh_Click;
            // 
            // tbx_apellido
            // 
            tbx_apellido.Location = new Point(15, 144);
            tbx_apellido.Name = "tbx_apellido";
            tbx_apellido.Size = new Size(155, 23);
            tbx_apellido.TabIndex = 1;
            // 
            // tbx_nombre
            // 
            tbx_nombre.Location = new Point(15, 90);
            tbx_nombre.Name = "tbx_nombre";
            tbx_nombre.Size = new Size(155, 23);
            tbx_nombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 72);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 126);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // lb_listPerson
            // 
            lb_listPerson.FormattingEnabled = true;
            lb_listPerson.ItemHeight = 15;
            lb_listPerson.Location = new Point(226, 88);
            lb_listPerson.Name = "lb_listPerson";
            lb_listPerson.Size = new Size(218, 214);
            lb_listPerson.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(96, 36);
            label3.TabIndex = 4;
            label3.Text = "Añadir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(226, 9);
            label4.Name = "label4";
            label4.Size = new Size(80, 36);
            label4.TabIndex = 4;
            label4.Text = "Listar";
            // 
            // PeopleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 316);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lb_listPerson);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbx_nombre);
            Controls.Add(tbx_apellido);
            Controls.Add(btn_refresh);
            Controls.Add(btn_add);
            Name = "PeopleForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add;
        private Button btn_refresh;
        private TextBox tbx_apellido;
        private TextBox tbx_nombre;
        private Label label1;
        private Label label2;
        private ListBox lb_listPerson;
        private Label label3;
        private Label label4;
    }
}