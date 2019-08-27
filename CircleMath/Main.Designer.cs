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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimesTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTimesTable);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCircleDivisions);
            this.panel2.Controls.Add(this.doMath);
            this.panel2.Location = new System.Drawing.Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 89);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Times table";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of divisions";
            // 
            // txtTimesTable
            // 
            this.txtTimesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTimesTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimesTable.Location = new System.Drawing.Point(260, 7);
            this.txtTimesTable.Name = "txtTimesTable";
            this.txtTimesTable.Size = new System.Drawing.Size(94, 53);
            this.txtTimesTable.TabIndex = 3;
            this.txtTimesTable.Text = "10";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // txtCircleDivisions
            // 
            this.txtCircleDivisions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCircleDivisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCircleDivisions.Location = new System.Drawing.Point(12, 7);
            this.txtCircleDivisions.Name = "txtCircleDivisions";
            this.txtCircleDivisions.Size = new System.Drawing.Size(94, 53);
            this.txtCircleDivisions.TabIndex = 1;
            this.txtCircleDivisions.Text = "10";
            // 
            // doMath
            // 
            this.doMath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doMath.Location = new System.Drawing.Point(488, 7);
            this.doMath.Name = "doMath";
            this.doMath.Size = new System.Drawing.Size(94, 70);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCircleDivisions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

