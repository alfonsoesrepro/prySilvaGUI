namespace prySilvaGUI
{
    partial class frmBotonera
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
            cmdAtras = new Button();
            cmdSiguiente = new Button();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // cmdAtras
            // 
            cmdAtras.Location = new Point(108, 281);
            cmdAtras.Name = "cmdAtras";
            cmdAtras.Size = new Size(75, 23);
            cmdAtras.TabIndex = 0;
            cmdAtras.Text = "<--";
            cmdAtras.UseVisualStyleBackColor = true;
            cmdAtras.Click += cmdAtras_Click;
            // 
            // cmdSiguiente
            // 
            cmdSiguiente.Location = new Point(291, 281);
            cmdSiguiente.Name = "cmdSiguiente";
            cmdSiguiente.Size = new Size(75, 23);
            cmdSiguiente.TabIndex = 1;
            cmdSiguiente.Text = "-->";
            cmdSiguiente.UseVisualStyleBackColor = true;
            cmdSiguiente.Click += cmdSiguiente_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.Control;
            lblNombre.Location = new Point(205, 201);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 15);
            lblNombre.TabIndex = 3;
            // 
            // frmBotonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(484, 461);
            Controls.Add(lblNombre);
            Controls.Add(cmdSiguiente);
            Controls.Add(cmdAtras);
            Name = "frmBotonera";
            Text = "Botonera";
            Load += frmBotonera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAtras;
        private Button cmdSiguiente;
        private Label lblNombre;
    }
}