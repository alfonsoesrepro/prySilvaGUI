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
            cmdAgregar = new Button();
            txtAgregado = new TextBox();
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
            // 
            // cmdSiguiente
            // 
            cmdSiguiente.Location = new Point(291, 281);
            cmdSiguiente.Name = "cmdSiguiente";
            cmdSiguiente.Size = new Size(75, 23);
            cmdSiguiente.TabIndex = 1;
            cmdSiguiente.Text = "-->";
            cmdSiguiente.UseVisualStyleBackColor = true;
            // 
            // cmdAgregar
            // 
            cmdAgregar.Location = new Point(200, 181);
            cmdAgregar.Name = "cmdAgregar";
            cmdAgregar.Size = new Size(75, 23);
            cmdAgregar.TabIndex = 2;
            cmdAgregar.Text = "Agregar";
            cmdAgregar.UseVisualStyleBackColor = true;
            // 
            // txtAgregado
            // 
            txtAgregado.Location = new Point(186, 124);
            txtAgregado.Name = "txtAgregado";
            txtAgregado.Size = new Size(100, 23);
            txtAgregado.TabIndex = 4;
            // 
            // frmBotonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(484, 461);
            Controls.Add(txtAgregado);
            Controls.Add(cmdAgregar);
            Controls.Add(cmdSiguiente);
            Controls.Add(cmdAtras);
            Name = "frmBotonera";
            Text = "Botonera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAtras;
        private Button cmdSiguiente;
        private Button cmdAgregar;
        private TextBox txtAgregado;
    }
}