namespace WindowsFormsApp2
{
    partial class CalcM
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
            this.labRA = new System.Windows.Forms.Label();
            this.labNome = new System.Windows.Forms.Label();
            this.labP1 = new System.Windows.Forms.Label();
            this.labP2 = new System.Windows.Forms.Label();
            this.labMedia = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.butCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labRA
            // 
            this.labRA.AutoSize = true;
            this.labRA.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F);
            this.labRA.Location = new System.Drawing.Point(74, 87);
            this.labRA.Name = "labRA";
            this.labRA.Size = new System.Drawing.Size(39, 24);
            this.labRA.TabIndex = 0;
            this.labRA.Text = "RA:";
            this.labRA.Click += new System.EventHandler(this.label1_Click);
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F);
            this.labNome.Location = new System.Drawing.Point(59, 133);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(63, 24);
            this.labNome.TabIndex = 1;
            this.labNome.Text = "Nome:";
            this.labNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // labP1
            // 
            this.labP1.AutoSize = true;
            this.labP1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labP1.Location = new System.Drawing.Point(215, 205);
            this.labP1.Name = "labP1";
            this.labP1.Size = new System.Drawing.Size(27, 17);
            this.labP1.TabIndex = 2;
            this.labP1.Text = "P1:";
            // 
            // labP2
            // 
            this.labP2.AutoSize = true;
            this.labP2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F);
            this.labP2.Location = new System.Drawing.Point(215, 258);
            this.labP2.Name = "labP2";
            this.labP2.Size = new System.Drawing.Size(27, 17);
            this.labP2.TabIndex = 3;
            this.labP2.Text = "P2:";
            // 
            // labMedia
            // 
            this.labMedia.AutoSize = true;
            this.labMedia.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMedia.Location = new System.Drawing.Point(162, 325);
            this.labMedia.Name = "labMedia";
            this.labMedia.Size = new System.Drawing.Size(66, 24);
            this.labMedia.TabIndex = 4;
            this.labMedia.Text = "Média:";
            this.labMedia.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(141, 91);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(342, 20);
            this.txtRA.TabIndex = 5;
            this.txtRA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(141, 137);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(342, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(262, 204);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(100, 20);
            this.txtP1.TabIndex = 7;
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(262, 255);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(100, 20);
            this.txtP2.TabIndex = 8;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(234, 329);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(186, 20);
            this.txtMedia.TabIndex = 9;
            // 
            // butCalc
            // 
            this.butCalc.Location = new System.Drawing.Point(262, 391);
            this.butCalc.Name = "butCalc";
            this.butCalc.Size = new System.Drawing.Size(75, 23);
            this.butCalc.TabIndex = 10;
            this.butCalc.Text = "Calcular";
            this.butCalc.UseVisualStyleBackColor = true;
            this.butCalc.Click += new System.EventHandler(this.butCalc_Click);
            // 
            // CalcM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 480);
            this.Controls.Add(this.butCalc);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.labMedia);
            this.Controls.Add(this.labP2);
            this.Controls.Add(this.labP1);
            this.Controls.Add(this.labNome);
            this.Controls.Add(this.labRA);
            this.Name = "CalcM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CalcM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRA;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.Label labP1;
        private System.Windows.Forms.Label labP2;
        private System.Windows.Forms.Label labMedia;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button butCalc;
    }
}

