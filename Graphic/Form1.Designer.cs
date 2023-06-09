namespace Graphic
{
    partial class Form1
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
            this.pnlBlackboard = new System.Windows.Forms.Panel();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.rdoGray = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoCyan = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoMagenta = new System.Windows.Forms.RadioButton();
            this.rdoYellow = new System.Windows.Forms.RadioButton();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.grpColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBlackboard
            // 
            this.pnlBlackboard.BackColor = System.Drawing.Color.Black;
            this.pnlBlackboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBlackboard.Location = new System.Drawing.Point(12, 12);
            this.pnlBlackboard.Name = "pnlBlackboard";
            this.pnlBlackboard.Size = new System.Drawing.Size(574, 401);
            this.pnlBlackboard.TabIndex = 0;
            this.pnlBlackboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBlackboard_Paint);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(615, 300);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(159, 32);
            this.btnErase.TabIndex = 9;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(615, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 32);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpColor
            // 
            this.grpColor.BackColor = System.Drawing.Color.Black;
            this.grpColor.Controls.Add(this.rdoWhite);
            this.grpColor.Controls.Add(this.rdoYellow);
            this.grpColor.Controls.Add(this.rdoMagenta);
            this.grpColor.Controls.Add(this.rdoRed);
            this.grpColor.Controls.Add(this.rdoCyan);
            this.grpColor.Controls.Add(this.rdoGreen);
            this.grpColor.Controls.Add(this.rdoBlue);
            this.grpColor.Controls.Add(this.rdoGray);
            this.grpColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpColor.ForeColor = System.Drawing.Color.White;
            this.grpColor.Location = new System.Drawing.Point(592, 12);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(200, 267);
            this.grpColor.TabIndex = 11;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // rdoGray
            // 
            this.rdoGray.AutoSize = true;
            this.rdoGray.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoGray.Location = new System.Drawing.Point(33, 34);
            this.rdoGray.Name = "rdoGray";
            this.rdoGray.Size = new System.Drawing.Size(86, 21);
            this.rdoGray.TabIndex = 0;
            this.rdoGray.Text = "               ";
            this.rdoGray.UseVisualStyleBackColor = true;
            this.rdoGray.CheckedChanged += new System.EventHandler(this.rdoGray_CheckedChanged);
            this.rdoGray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rdoGray_MouseMove);
            this.rdoGray.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rdoGray_MouseUp);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoBlue.Location = new System.Drawing.Point(33, 61);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(86, 21);
            this.rdoBlue.TabIndex = 1;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "               ";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoGreen.Location = new System.Drawing.Point(33, 88);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(86, 21);
            this.rdoGreen.TabIndex = 2;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "               ";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // rdoCyan
            // 
            this.rdoCyan.AutoSize = true;
            this.rdoCyan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoCyan.Location = new System.Drawing.Point(33, 115);
            this.rdoCyan.Name = "rdoCyan";
            this.rdoCyan.Size = new System.Drawing.Size(86, 21);
            this.rdoCyan.TabIndex = 3;
            this.rdoCyan.TabStop = true;
            this.rdoCyan.Text = "               ";
            this.rdoCyan.UseVisualStyleBackColor = true;
            this.rdoCyan.CheckedChanged += new System.EventHandler(this.rdoCyan_CheckedChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoRed.Location = new System.Drawing.Point(33, 142);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(86, 21);
            this.rdoRed.TabIndex = 4;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "               ";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // rdoMagenta
            // 
            this.rdoMagenta.AutoSize = true;
            this.rdoMagenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoMagenta.Location = new System.Drawing.Point(33, 169);
            this.rdoMagenta.Name = "rdoMagenta";
            this.rdoMagenta.Size = new System.Drawing.Size(86, 21);
            this.rdoMagenta.TabIndex = 5;
            this.rdoMagenta.TabStop = true;
            this.rdoMagenta.Text = "               ";
            this.rdoMagenta.UseVisualStyleBackColor = true;
            this.rdoMagenta.CheckedChanged += new System.EventHandler(this.rdoMagenta_CheckedChanged);
            // 
            // rdoYellow
            // 
            this.rdoYellow.AutoSize = true;
            this.rdoYellow.Location = new System.Drawing.Point(33, 196);
            this.rdoYellow.Name = "rdoYellow";
            this.rdoYellow.Size = new System.Drawing.Size(86, 21);
            this.rdoYellow.TabIndex = 6;
            this.rdoYellow.TabStop = true;
            this.rdoYellow.Text = "               ";
            this.rdoYellow.UseVisualStyleBackColor = true;
            this.rdoYellow.CheckedChanged += new System.EventHandler(this.rdoYellow_CheckedChanged);
            // 
            // rdoWhite
            // 
            this.rdoWhite.AutoSize = true;
            this.rdoWhite.Location = new System.Drawing.Point(33, 223);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(86, 21);
            this.rdoWhite.TabIndex = 7;
            this.rdoWhite.TabStop = true;
            this.rdoWhite.Text = "               ";
            this.rdoWhite.UseVisualStyleBackColor = true;
            this.rdoWhite.CheckedChanged += new System.EventHandler(this.rdoWhite_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.pnlBlackboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackboard Fun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBlackboard;
        private Button btnErase;
        private Button btnExit;
        private GroupBox grpColor;
        private RadioButton rdoWhite;
        private RadioButton rdoYellow;
        private RadioButton rdoMagenta;
        private RadioButton rdoRed;
        private RadioButton rdoCyan;
        private RadioButton rdoGreen;
        private RadioButton rdoBlue;
        private RadioButton rdoGray;
    }
}