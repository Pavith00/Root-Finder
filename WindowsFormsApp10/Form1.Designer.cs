namespace WindowsFormsApp10
{
    partial class Form1
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
            this.solve = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rootsLbl = new System.Windows.Forms.Label();
            this.cLbl = new System.Windows.Forms.Label();
            this.atxt = new System.Windows.Forms.TextBox();
            this.btxt = new System.Windows.Forms.TextBox();
            this.ctxt = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.NewProb = new System.Windows.Forms.Button();
            this.bLbl = new System.Windows.Forms.Label();
            this.aLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // solve
            // 
            this.solve.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solve.Location = new System.Drawing.Point(234, 304);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 44);
            this.solve.TabIndex = 25;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "ax^2+bx+c=0";
            // 
            // rootsLbl
            // 
            this.rootsLbl.AutoSize = true;
            this.rootsLbl.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rootsLbl.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootsLbl.Location = new System.Drawing.Point(285, 254);
            this.rootsLbl.Name = "rootsLbl";
            this.rootsLbl.Size = new System.Drawing.Size(98, 14);
            this.rootsLbl.TabIndex = 23;
            this.rootsLbl.Text = "Number of roots:";
            // 
            // cLbl
            // 
            this.cLbl.AutoSize = true;
            this.cLbl.BackColor = System.Drawing.Color.LightGray;
            this.cLbl.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLbl.Location = new System.Drawing.Point(285, 220);
            this.cLbl.Name = "cLbl";
            this.cLbl.Size = new System.Drawing.Size(84, 14);
            this.cLbl.TabIndex = 22;
            this.cLbl.Text = "Coefficient c=";
            // 
            // atxt
            // 
            this.atxt.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atxt.Location = new System.Drawing.Point(386, 141);
            this.atxt.Name = "atxt";
            this.atxt.Size = new System.Drawing.Size(100, 22);
            this.atxt.TabIndex = 21;
            // 
            // btxt
            // 
            this.btxt.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxt.Location = new System.Drawing.Point(386, 181);
            this.btxt.Name = "btxt";
            this.btxt.Size = new System.Drawing.Size(100, 22);
            this.btxt.TabIndex = 20;
            // 
            // ctxt
            // 
            this.ctxt.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxt.Location = new System.Drawing.Point(386, 220);
            this.ctxt.Name = "ctxt";
            this.ctxt.Size = new System.Drawing.Size(100, 22);
            this.ctxt.TabIndex = 19;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(491, 304);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 44);
            this.exit.TabIndex = 18;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // NewProb
            // 
            this.NewProb.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProb.Location = new System.Drawing.Point(358, 304);
            this.NewProb.Name = "NewProb";
            this.NewProb.Size = new System.Drawing.Size(75, 44);
            this.NewProb.TabIndex = 17;
            this.NewProb.Text = "New Problem";
            this.NewProb.UseVisualStyleBackColor = true;
            this.NewProb.Click += new System.EventHandler(this.NewProb_Click);
            // 
            // bLbl
            // 
            this.bLbl.AutoSize = true;
            this.bLbl.BackColor = System.Drawing.Color.LightGray;
            this.bLbl.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLbl.Location = new System.Drawing.Point(285, 181);
            this.bLbl.Name = "bLbl";
            this.bLbl.Size = new System.Drawing.Size(85, 14);
            this.bLbl.TabIndex = 16;
            this.bLbl.Text = "Coefficient b=";
            // 
            // aLbl
            // 
            this.aLbl.AutoSize = true;
            this.aLbl.BackColor = System.Drawing.Color.LightGray;
            this.aLbl.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLbl.Location = new System.Drawing.Point(285, 144);
            this.aLbl.Name = "aLbl";
            this.aLbl.Size = new System.Drawing.Size(84, 14);
            this.aLbl.TabIndex = 15;
            this.aLbl.Text = "Coefficient a=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp10.Properties.Resources.aesthetic_wallpaper_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rootsLbl);
            this.Controls.Add(this.cLbl);
            this.Controls.Add(this.atxt);
            this.Controls.Add(this.btxt);
            this.Controls.Add(this.ctxt);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.NewProb);
            this.Controls.Add(this.bLbl);
            this.Controls.Add(this.aLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rootsLbl;
        private System.Windows.Forms.Label cLbl;
        private System.Windows.Forms.TextBox atxt;
        private System.Windows.Forms.TextBox btxt;
        private System.Windows.Forms.TextBox ctxt;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button NewProb;
        private System.Windows.Forms.Label bLbl;
        private System.Windows.Forms.Label aLbl;
    }
}

