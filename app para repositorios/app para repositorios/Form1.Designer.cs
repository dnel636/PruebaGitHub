﻿namespace app_para_repositorios
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
            this.bMensaje = new System.Windows.Forms.Button();
            this.bLocura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bMensaje
            // 
            this.bMensaje.Location = new System.Drawing.Point(12, 12);
            this.bMensaje.Name = "bMensaje";
            this.bMensaje.Size = new System.Drawing.Size(75, 23);
            this.bMensaje.TabIndex = 0;
            this.bMensaje.Text = "mensaje";
            this.bMensaje.UseVisualStyleBackColor = true;
            this.bMensaje.Click += new System.EventHandler(this.bMensaje_Click);
            // 
            // bLocura
            // 
            this.bLocura.BackColor = System.Drawing.Color.Red;
            this.bLocura.Location = new System.Drawing.Point(93, 12);
            this.bLocura.Name = "bLocura";
            this.bLocura.Size = new System.Drawing.Size(75, 103);
            this.bLocura.TabIndex = 1;
            this.bLocura.Text = "locura";
            this.bLocura.UseVisualStyleBackColor = false;
            this.bLocura.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bLocura);
            this.Controls.Add(this.bMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMensaje;
        private System.Windows.Forms.Button bLocura;
    }
}

