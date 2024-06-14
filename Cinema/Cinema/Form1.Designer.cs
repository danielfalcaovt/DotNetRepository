namespace Cinema
{
    partial class frmReservador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservador));
            lblTitulo = new Label();
            btnFilme1 = new Button();
            btnFilme2 = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Berlin Sans FB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(139, 60);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(346, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Qual filme você deseja assistir?";
            // 
            // btnFilme1
            // 
            btnFilme1.BackgroundImage = Properties.Resources.arcanefilme1;
            btnFilme1.BackgroundImageLayout = ImageLayout.Zoom;
            btnFilme1.Cursor = Cursors.Hand;
            btnFilme1.FlatStyle = FlatStyle.Flat;
            btnFilme1.ForeColor = Color.Transparent;
            btnFilme1.Location = new Point(63, 150);
            btnFilme1.Name = "btnFilme1";
            btnFilme1.Size = new Size(164, 220);
            btnFilme1.TabIndex = 1;
            btnFilme1.TextAlign = ContentAlignment.MiddleRight;
            btnFilme1.UseVisualStyleBackColor = true;
            btnFilme1.Click += button1_Click;
            // 
            // btnFilme2
            // 
            btnFilme2.BackgroundImage = Properties.Resources.carrinhosfilme;
            btnFilme2.BackgroundImageLayout = ImageLayout.Stretch;
            btnFilme2.Cursor = Cursors.Hand;
            btnFilme2.FlatStyle = FlatStyle.Flat;
            btnFilme2.ForeColor = Color.Transparent;
            btnFilme2.Location = new Point(392, 150);
            btnFilme2.Name = "btnFilme2";
            btnFilme2.Size = new Size(164, 220);
            btnFilme2.TabIndex = 2;
            btnFilme2.TextAlign = ContentAlignment.MiddleRight;
            btnFilme2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFilme2.UseVisualStyleBackColor = true;
            btnFilme2.Click += btnFilme2_Click;
            // 
            // frmReservador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(623, 450);
            Controls.Add(btnFilme2);
            Controls.Add(btnFilme1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmReservador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Reserva de Assentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnFilme1;
        private Button btnFilme2;
    }
}
