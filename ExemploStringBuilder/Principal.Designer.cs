namespace ExemploStringBuilder
{
    partial class Principal
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
            this.btExemplo01 = new System.Windows.Forms.Button();
            this.btExemplo02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btExemplo01
            // 
            this.btExemplo01.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemplo01.Location = new System.Drawing.Point(12, 12);
            this.btExemplo01.Name = "btExemplo01";
            this.btExemplo01.Size = new System.Drawing.Size(180, 54);
            this.btExemplo01.TabIndex = 0;
            this.btExemplo01.Text = "Exemplo01";
            this.btExemplo01.UseVisualStyleBackColor = true;
            this.btExemplo01.Click += new System.EventHandler(this.btExemplo01_Click);
            // 
            // btExemplo02
            // 
            this.btExemplo02.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemplo02.Location = new System.Drawing.Point(198, 12);
            this.btExemplo02.Name = "btExemplo02";
            this.btExemplo02.Size = new System.Drawing.Size(180, 54);
            this.btExemplo02.TabIndex = 1;
            this.btExemplo02.Text = "Exemplo02";
            this.btExemplo02.UseVisualStyleBackColor = true;
            this.btExemplo02.Click += new System.EventHandler(this.btExemplo02_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 457);
            this.Controls.Add(this.btExemplo02);
            this.Controls.Add(this.btExemplo01);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExemplo01;
        private System.Windows.Forms.Button btExemplo02;
    }
}

