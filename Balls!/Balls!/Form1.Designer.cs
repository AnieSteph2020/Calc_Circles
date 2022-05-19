namespace Balls_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.butCalc = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtBoxCircum = new System.Windows.Forms.TextBox();
            this.txtBoxSurf = new System.Windows.Forms.TextBox();
            this.txtBoxVol = new System.Windows.Forms.TextBox();
            this.chkBoxCircum = new System.Windows.Forms.CheckBox();
            this.chkBoxSurf = new System.Windows.Forms.CheckBox();
            this.chkBoxVol = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "radius";
            // 
            // butCalc
            // 
            this.butCalc.BackColor = System.Drawing.SystemColors.Window;
            this.butCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butCalc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butCalc.Location = new System.Drawing.Point(171, 444);
            this.butCalc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCalc.Name = "butCalc";
            this.butCalc.Size = new System.Drawing.Size(100, 28);
            this.butCalc.TabIndex = 8;
            this.butCalc.Text = "calculate";
            this.butCalc.UseVisualStyleBackColor = false;
            this.butCalc.Click += new System.EventHandler(this.btnClick);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(67, 54);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(132, 22);
            this.txtRadius.TabIndex = 1;
            // 
            // txtBoxCircum
            // 
            this.txtBoxCircum.Location = new System.Drawing.Point(233, 240);
            this.txtBoxCircum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCircum.Name = "txtBoxCircum";
            this.txtBoxCircum.ReadOnly = true;
            this.txtBoxCircum.Size = new System.Drawing.Size(132, 22);
            this.txtBoxCircum.TabIndex = 3;
            this.txtBoxCircum.Visible = false;
            // 
            // txtBoxSurf
            // 
            this.txtBoxSurf.Location = new System.Drawing.Point(233, 290);
            this.txtBoxSurf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxSurf.Name = "txtBoxSurf";
            this.txtBoxSurf.ReadOnly = true;
            this.txtBoxSurf.Size = new System.Drawing.Size(132, 22);
            this.txtBoxSurf.TabIndex = 5;
            this.txtBoxSurf.Visible = false;
            // 
            // txtBoxVol
            // 
            this.txtBoxVol.Location = new System.Drawing.Point(233, 348);
            this.txtBoxVol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxVol.Name = "txtBoxVol";
            this.txtBoxVol.ReadOnly = true;
            this.txtBoxVol.Size = new System.Drawing.Size(132, 22);
            this.txtBoxVol.TabIndex = 7;
            this.txtBoxVol.Visible = false;
            // 
            // chkBoxCircum
            // 
            this.chkBoxCircum.AutoSize = true;
            this.chkBoxCircum.Location = new System.Drawing.Point(33, 244);
            this.chkBoxCircum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxCircum.Name = "chkBoxCircum";
            this.chkBoxCircum.Size = new System.Drawing.Size(130, 20);
            this.chkBoxCircum.TabIndex = 2;
            this.chkBoxCircum.Text = "circumference";
            this.chkBoxCircum.UseVisualStyleBackColor = true;
            this.chkBoxCircum.CheckedChanged += new System.EventHandler(this.checkBCircumChecked);
            // 
            // chkBoxSurf
            // 
            this.chkBoxSurf.AutoSize = true;
            this.chkBoxSurf.Location = new System.Drawing.Point(33, 290);
            this.chkBoxSurf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxSurf.Name = "chkBoxSurf";
            this.chkBoxSurf.Size = new System.Drawing.Size(82, 20);
            this.chkBoxSurf.TabIndex = 4;
            this.chkBoxSurf.Text = "surface";
            this.chkBoxSurf.UseVisualStyleBackColor = true;
            this.chkBoxSurf.CheckedChanged += new System.EventHandler(this.checkBSurfChecked);
            // 
            // chkBoxVol
            // 
            this.chkBoxVol.AutoSize = true;
            this.chkBoxVol.Location = new System.Drawing.Point(33, 348);
            this.chkBoxVol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxVol.Name = "chkBoxVol";
            this.chkBoxVol.Size = new System.Drawing.Size(74, 20);
            this.chkBoxVol.TabIndex = 6;
            this.chkBoxVol.Text = "volume";
            this.chkBoxVol.UseVisualStyleBackColor = true;
            this.chkBoxVol.CheckedChanged += new System.EventHandler(this.checkBVolChecked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Balls_.Properties.Resources.assorted_mix_27mm_bouncy_balls__66646_1607809516;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 554);
            this.Controls.Add(this.chkBoxVol);
            this.Controls.Add(this.chkBoxSurf);
            this.Controls.Add(this.chkBoxCircum);
            this.Controls.Add(this.txtBoxVol);
            this.Controls.Add(this.txtBoxSurf);
            this.Controls.Add(this.txtBoxCircum);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.butCalc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Balls!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butCalc;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtBoxCircum;
        private System.Windows.Forms.TextBox txtBoxSurf;
        private System.Windows.Forms.TextBox txtBoxVol;
        private System.Windows.Forms.CheckBox chkBoxCircum;
        private System.Windows.Forms.CheckBox chkBoxSurf;
        private System.Windows.Forms.CheckBox chkBoxVol;
    }
}

