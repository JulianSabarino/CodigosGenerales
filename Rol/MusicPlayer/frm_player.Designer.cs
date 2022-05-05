namespace MusicPlayer
{
    partial class frm_player
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
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_addList = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(311, 304);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Reproducir";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_addList
            // 
            this.btn_addList.Location = new System.Drawing.Point(77, 304);
            this.btn_addList.Name = "btn_addList";
            this.btn_addList.Size = new System.Drawing.Size(75, 23);
            this.btn_addList.TabIndex = 1;
            this.btn_addList.Text = "Cargar Lista";
            this.btn_addList.UseVisualStyleBackColor = true;
            this.btn_addList.Click += new System.EventHandler(this.btn_addList_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(528, 304);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Parar";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // frm_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_addList);
            this.Controls.Add(this.btn_play);
            this.Name = "frm_player";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_addList;
        private System.Windows.Forms.Button btn_stop;
    }
}
