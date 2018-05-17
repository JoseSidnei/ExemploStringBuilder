namespace ExemploStringBuilder
{
    partial class Exemplo01
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
            this.lbNome01 = new System.Windows.Forms.Label();
            this.txtNome01 = new System.Windows.Forms.TextBox();
            this.lbNome02 = new System.Windows.Forms.Label();
            this.lbNome03 = new System.Windows.Forms.Label();
            this.txtNome02 = new System.Windows.Forms.TextBox();
            this.txtNome03 = new System.Windows.Forms.TextBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.txtApresentar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNome01
            // 
            this.lbNome01.AutoSize = true;
            this.lbNome01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNome01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome01.Location = new System.Drawing.Point(13, 33);
            this.lbNome01.Name = "lbNome01";
            this.lbNome01.Size = new System.Drawing.Size(57, 22);
            this.lbNome01.TabIndex = 0;
            this.lbNome01.Text = "Nome";
            // 
            // txtNome01
            // 
            this.txtNome01.Location = new System.Drawing.Point(13, 58);
            this.txtNome01.Name = "txtNome01";
            this.txtNome01.Size = new System.Drawing.Size(401, 20);
            this.txtNome01.TabIndex = 1;
            // 
            // lbNome02
            // 
            this.lbNome02.AutoSize = true;
            this.lbNome02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNome02.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbNome02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome02.Location = new System.Drawing.Point(13, 106);
            this.lbNome02.Name = "lbNome02";
            this.lbNome02.Size = new System.Drawing.Size(57, 22);
            this.lbNome02.TabIndex = 2;
            this.lbNome02.Text = "Nome";
            // 
            // lbNome03
            // 
            this.lbNome03.AutoSize = true;
            this.lbNome03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNome03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome03.Location = new System.Drawing.Point(13, 174);
            this.lbNome03.Name = "lbNome03";
            this.lbNome03.Size = new System.Drawing.Size(57, 22);
            this.lbNome03.TabIndex = 3;
            this.lbNome03.Text = "Nome";
            // 
            // txtNome02
            // 
            this.txtNome02.Location = new System.Drawing.Point(13, 131);
            this.txtNome02.Name = "txtNome02";
            this.txtNome02.Size = new System.Drawing.Size(401, 20);
            this.txtNome02.TabIndex = 2;
            // 
            // txtNome03
            // 
            this.txtNome03.Location = new System.Drawing.Point(13, 199);
            this.txtNome03.Name = "txtNome03";
            this.txtNome03.Size = new System.Drawing.Size(401, 20);
            this.txtNome03.TabIndex = 3;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.Location = new System.Drawing.Point(226, 225);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(188, 51);
            this.btnProcessar.TabIndex = 4;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // txtApresentar
            // 
            this.txtApresentar.Location = new System.Drawing.Point(13, 342);
            this.txtApresentar.Multiline = true;
            this.txtApresentar.Name = "txtApresentar";
            this.txtApresentar.Size = new System.Drawing.Size(401, 190);
            this.txtApresentar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado";
            // 
            // Exemplo01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApresentar);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.txtNome03);
            this.Controls.Add(this.txtNome02);
            this.Controls.Add(this.lbNome03);
            this.Controls.Add(this.lbNome02);
            this.Controls.Add(this.txtNome01);
            this.Controls.Add(this.lbNome01);
            this.Name = "Exemplo01";
            this.Text = "Exemplo01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome01;
        private System.Windows.Forms.TextBox txtNome01;
        private System.Windows.Forms.Label lbNome02;
        private System.Windows.Forms.Label lbNome03;
        private System.Windows.Forms.TextBox txtNome02;
        private System.Windows.Forms.TextBox txtNome03;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.TextBox txtApresentar;
        private System.Windows.Forms.Label label1;
    }
}