namespace ModeloParcial
{
    partial class frm_jardineria
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
            this.rtxt_jardin = new System.Windows.Forms.RichTextBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_jardin
            // 
            this.rtxt_jardin.Location = new System.Drawing.Point(12, 82);
            this.rtxt_jardin.Name = "rtxt_jardin";
            this.rtxt_jardin.ReadOnly = true;
            this.rtxt_jardin.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxt_jardin.Size = new System.Drawing.Size(688, 356);
            this.rtxt_jardin.TabIndex = 0;
            this.rtxt_jardin.Text = "";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(544, 12);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(156, 64);
            this.btn_mostrar.TabIndex = 1;
            this.btn_mostrar.Text = "Ver Datos";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // frm_jardineria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.rtxt_jardin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_jardineria";
            this.Text = "Jardines";
            this.Load += new System.EventHandler(this.frm_jardineria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_jardin;
        private System.Windows.Forms.Button btn_mostrar;
    }
}
