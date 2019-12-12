namespace algoritimo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Label();
            this.n4 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Label();
            this.el2 = new System.Windows.Forms.Label();
            this.el1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sorteio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // n5
            // 
            this.n5.AutoSize = true;
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(569, 108);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(142, 31);
            this.n5.TabIndex = 1;
            this.n5.Text = "Quadrado";
            // 
            // n4
            // 
            this.n4.AutoSize = true;
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(477, 108);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(142, 31);
            this.n4.TabIndex = 2;
            this.n4.Text = "Quadrado";
            // 
            // n3
            // 
            this.n3.AutoSize = true;
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(385, 108);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(142, 31);
            this.n3.TabIndex = 3;
            this.n3.Text = "Quadrado";
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(293, 108);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(142, 31);
            this.n2.TabIndex = 4;
            this.n2.Text = "Quadrado";
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(201, 108);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(142, 31);
            this.n1.TabIndex = 5;
            this.n1.Text = "Quadrado";
            // 
            // el2
            // 
            this.el2.AutoSize = true;
            this.el2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.el2.Location = new System.Drawing.Point(320, 139);
            this.el2.Name = "el2";
            this.el2.Size = new System.Drawing.Size(121, 31);
            this.el2.TabIndex = 6;
            this.el2.Text = "Estrelas";
            // 
            // el1
            // 
            this.el1.AutoSize = true;
            this.el1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.el1.Location = new System.Drawing.Point(201, 139);
            this.el1.Name = "el1";
            this.el1.Size = new System.Drawing.Size(121, 31);
            this.el1.TabIndex = 7;
            this.el1.Text = "Estrelas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.el1);
            this.Controls.Add(this.el2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label n5;
        private System.Windows.Forms.Label n4;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label el2;
        private System.Windows.Forms.Label el1;
    }
}

