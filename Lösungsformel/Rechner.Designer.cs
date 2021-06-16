namespace Lösungsformel
{
    partial class Rechner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rechneMS = new System.Windows.Forms.ToolStripMenuItem();
            this.löscheMS = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMS = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbxa = new System.Windows.Forms.TextBox();
            this.txtbxc = new System.Windows.Forms.TextBox();
            this.txtbxb = new System.Windows.Forms.TextBox();
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lblx1 = new System.Windows.Forms.Label();
            this.lblx2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblns = new System.Windows.Forms.Label();
            this.lblgl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechneMS,
            this.löscheMS,
            this.stopMS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(17, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(488, 47);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rechneMS
            // 
            this.rechneMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechneMS.Name = "rechneMS";
            this.rechneMS.Size = new System.Drawing.Size(127, 37);
            this.rechneMS.Text = "Rechne";
            this.rechneMS.Click += new System.EventHandler(this.rechneMS_Click);
            // 
            // löscheMS
            // 
            this.löscheMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.löscheMS.Name = "löscheMS";
            this.löscheMS.Size = new System.Drawing.Size(121, 37);
            this.löscheMS.Text = "Lösche";
            this.löscheMS.Click += new System.EventHandler(this.löscheMS_Click);
            // 
            // stopMS
            // 
            this.stopMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopMS.Name = "stopMS";
            this.stopMS.Size = new System.Drawing.Size(86, 37);
            this.stopMS.Text = "Stop";
            this.stopMS.Click += new System.EventHandler(this.stopMS_Click);
            // 
            // txtbxa
            // 
            this.txtbxa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxa.Location = new System.Drawing.Point(49, 60);
            this.txtbxa.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtbxa.Name = "txtbxa";
            this.txtbxa.Size = new System.Drawing.Size(86, 32);
            this.txtbxa.TabIndex = 1;
            // 
            // txtbxc
            // 
            this.txtbxc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxc.Location = new System.Drawing.Point(49, 130);
            this.txtbxc.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtbxc.Name = "txtbxc";
            this.txtbxc.Size = new System.Drawing.Size(86, 32);
            this.txtbxc.TabIndex = 3;
            // 
            // txtbxb
            // 
            this.txtbxb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxb.Location = new System.Drawing.Point(49, 96);
            this.txtbxb.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtbxb.Name = "txtbxb";
            this.txtbxb.Size = new System.Drawing.Size(86, 32);
            this.txtbxb.TabIndex = 2;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(18, 63);
            this.lbla.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(28, 24);
            this.lbla.TabIndex = 4;
            this.lbla.Text = "a:";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(18, 99);
            this.lblb.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(27, 24);
            this.lblb.TabIndex = 5;
            this.lblb.Text = "b:";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc.Location = new System.Drawing.Point(18, 133);
            this.lblc.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(27, 24);
            this.lblc.TabIndex = 6;
            this.lblc.Text = "c:";
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.lblx1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx1.Location = new System.Drawing.Point(18, 212);
            this.lblx1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(50, 24);
            this.lblx1.TabIndex = 10;
            this.lblx1.Text = "x1 =";
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx2.Location = new System.Drawing.Point(18, 236);
            this.lblx2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(50, 24);
            this.lblx2.TabIndex = 11;
            this.lblx2.Text = "x2 =";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblns
            // 
            this.lblns.AutoSize = true;
            this.lblns.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblns.Location = new System.Drawing.Point(19, 170);
            this.lblns.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblns.Name = "lblns";
            this.lblns.Size = new System.Drawing.Size(211, 24);
            this.lblns.TabIndex = 12;
            this.lblns.Text = "Anzahl der Nullstellen:";
            // 
            // lblgl
            // 
            this.lblgl.AutoSize = true;
            this.lblgl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgl.Location = new System.Drawing.Point(164, 63);
            this.lblgl.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblgl.Name = "lblgl";
            this.lblgl.Size = new System.Drawing.Size(102, 24);
            this.lblgl.TabIndex = 13;
            this.lblgl.Text = "Gleichung";
            // 
            // Rechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 312);
            this.Controls.Add(this.lblgl);
            this.Controls.Add(this.lblns);
            this.Controls.Add(this.lblx2);
            this.Controls.Add(this.lblx1);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.txtbxb);
            this.Controls.Add(this.txtbxc);
            this.Controls.Add(this.txtbxa);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Rechner";
            this.Text = "Lösungsformel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stopMS;
        private System.Windows.Forms.ToolStripMenuItem rechneMS;
        private System.Windows.Forms.TextBox txtbxa;
        private System.Windows.Forms.TextBox txtbxc;
        private System.Windows.Forms.TextBox txtbxb;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem löscheMS;
        private System.Windows.Forms.Label lblns;
        private System.Windows.Forms.Label lblgl;
    }
}

