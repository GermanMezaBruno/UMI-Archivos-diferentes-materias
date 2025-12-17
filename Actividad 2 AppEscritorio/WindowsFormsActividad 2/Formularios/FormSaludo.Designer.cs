namespace WindowsFormsActividad_2.Formularios
{
    partial class FormSaludo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaludo));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonSaludar = new System.Windows.Forms.Button();
            this.buttonbacksaludo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Nombre: ";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(115, 129);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(128, 20);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSaludar
            // 
            this.buttonSaludar.Location = new System.Drawing.Point(134, 183);
            this.buttonSaludar.Name = "buttonSaludar";
            this.buttonSaludar.Size = new System.Drawing.Size(98, 33);
            this.buttonSaludar.TabIndex = 2;
            this.buttonSaludar.Text = "Saludar";
            this.buttonSaludar.UseVisualStyleBackColor = true;
            this.buttonSaludar.Click += new System.EventHandler(this.buttonSaludar_Click);
            // 
            // buttonbacksaludo
            // 
            this.buttonbacksaludo.Location = new System.Drawing.Point(143, 303);
            this.buttonbacksaludo.Name = "buttonbacksaludo";
            this.buttonbacksaludo.Size = new System.Drawing.Size(75, 23);
            this.buttonbacksaludo.TabIndex = 3;
            this.buttonbacksaludo.Text = "Regresar";
            this.buttonbacksaludo.UseVisualStyleBackColor = true;
            this.buttonbacksaludo.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSaludo
            // 
            this.AcceptButton = this.buttonSaludar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 329);
            this.Controls.Add(this.buttonbacksaludo);
            this.Controls.Add(this.buttonSaludar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSaludo";
            this.Text = "Saludo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSaludo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonSaludar;
        private System.Windows.Forms.Button buttonbacksaludo;
    }
}