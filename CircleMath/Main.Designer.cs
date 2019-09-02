namespace CircleMath
{
    partial class Main
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
            this.canvas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimesTableDecrease = new System.Windows.Forms.Button();
            this.btnTimesTableIncrease = new System.Windows.Forms.Button();
            this.btnDivisionDecrease = new System.Windows.Forms.Button();
            this.btnDivisionIncrease = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimesTable = new System.Windows.Forms.TextBox();
            this.txtCircleDivisions = new System.Windows.Forms.TextBox();
            this.doMath = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(594, 473);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnTimesTableDecrease);
            this.panel2.Controls.Add(this.btnTimesTableIncrease);
            this.panel2.Controls.Add(this.btnDivisionDecrease);
            this.panel2.Controls.Add(this.btnDivisionIncrease);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTimesTable);
            this.panel2.Controls.Add(this.txtCircleDivisions);
            this.panel2.Controls.Add(this.doMath);
            this.panel2.Location = new System.Drawing.Point(0, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 92);
            this.panel2.TabIndex = 1;
            // 
            // btnTimesTableDecrease
            // 
            this.btnTimesTableDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimesTableDecrease.Location = new System.Drawing.Point(360, 40);
            this.btnTimesTableDecrease.Name = "btnTimesTableDecrease";
            this.btnTimesTableDecrease.Size = new System.Drawing.Size(30, 23);
            this.btnTimesTableDecrease.TabIndex = 9;
            this.btnTimesTableDecrease.Text = "-";
            this.btnTimesTableDecrease.UseVisualStyleBackColor = true;
            this.btnTimesTableDecrease.Click += new System.EventHandler(this.BtnTimesTableDecrease_Click);
            // 
            // btnTimesTableIncrease
            // 
            this.btnTimesTableIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimesTableIncrease.Location = new System.Drawing.Point(360, 10);
            this.btnTimesTableIncrease.Name = "btnTimesTableIncrease";
            this.btnTimesTableIncrease.Size = new System.Drawing.Size(30, 23);
            this.btnTimesTableIncrease.TabIndex = 8;
            this.btnTimesTableIncrease.Text = "+";
            this.btnTimesTableIncrease.UseVisualStyleBackColor = true;
            this.btnTimesTableIncrease.Click += new System.EventHandler(this.BtnTimesTableIncrease_Click);
            // 
            // btnDivisionDecrease
            // 
            this.btnDivisionDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisionDecrease.Location = new System.Drawing.Point(113, 40);
            this.btnDivisionDecrease.Name = "btnDivisionDecrease";
            this.btnDivisionDecrease.Size = new System.Drawing.Size(30, 23);
            this.btnDivisionDecrease.TabIndex = 7;
            this.btnDivisionDecrease.Text = "-";
            this.btnDivisionDecrease.UseVisualStyleBackColor = true;
            this.btnDivisionDecrease.Click += new System.EventHandler(this.BtnDivisionDecrease_Click);
            // 
            // btnDivisionIncrease
            // 
            this.btnDivisionIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisionIncrease.Location = new System.Drawing.Point(113, 10);
            this.btnDivisionIncrease.Name = "btnDivisionIncrease";
            this.btnDivisionIncrease.Size = new System.Drawing.Size(30, 23);
            this.btnDivisionIncrease.TabIndex = 6;
            this.btnDivisionIncrease.Text = "+";
            this.btnDivisionIncrease.UseVisualStyleBackColor = true;
            this.btnDivisionIncrease.Click += new System.EventHandler(this.BtnDivisionIncrease_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Times table";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of divisions";
            // 
            // txtTimesTable
            // 
            this.txtTimesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTimesTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimesTable.Location = new System.Drawing.Point(260, 10);
            this.txtTimesTable.Name = "txtTimesTable";
            this.txtTimesTable.Size = new System.Drawing.Size(94, 53);
            this.txtTimesTable.TabIndex = 3;
            this.txtTimesTable.Text = "10";
            // 
            // txtCircleDivisions
            // 
            this.txtCircleDivisions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCircleDivisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCircleDivisions.Location = new System.Drawing.Point(12, 10);
            this.txtCircleDivisions.Name = "txtCircleDivisions";
            this.txtCircleDivisions.Size = new System.Drawing.Size(94, 53);
            this.txtCircleDivisions.TabIndex = 1;
            this.txtCircleDivisions.Text = "10";
            // 
            // doMath
            // 
            this.doMath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doMath.Location = new System.Drawing.Point(497, 10);
            this.doMath.Name = "doMath";
            this.doMath.Size = new System.Drawing.Size(94, 53);
            this.doMath.TabIndex = 0;
            this.doMath.Text = "Go";
            this.doMath.UseVisualStyleBackColor = true;
            this.doMath.Click += new System.EventHandler(this.DoMath_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 561);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(610, 600);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button doMath;
        private System.Windows.Forms.TextBox txtTimesTable;
        private System.Windows.Forms.TextBox txtCircleDivisions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimesTableDecrease;
        private System.Windows.Forms.Button btnTimesTableIncrease;
        private System.Windows.Forms.Button btnDivisionDecrease;
        private System.Windows.Forms.Button btnDivisionIncrease;
    }
}

