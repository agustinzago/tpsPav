﻿namespace TPS_PAV.GUI
{
    partial class ABMCCursosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaCurso = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionCurso = new System.Windows.Forms.RichTextBox();
            this.btAceptarAltaCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(85, 10);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(256, 22);
            this.txtNombreCurso.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // txtFechaCurso
            // 
            this.txtFechaCurso.Location = new System.Drawing.Point(85, 106);
            this.txtFechaCurso.Mask = "00/00/0000";
            this.txtFechaCurso.Name = "txtFechaCurso";
            this.txtFechaCurso.Size = new System.Drawing.Size(79, 22);
            this.txtFechaCurso.TabIndex = 3;
            this.txtFechaCurso.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoría: ";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(85, 60);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(256, 24);
            this.cbCategoria.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripcion:";
            // 
            // txtDescripcionCurso
            // 
            this.txtDescripcionCurso.Location = new System.Drawing.Point(19, 181);
            this.txtDescripcionCurso.Name = "txtDescripcionCurso";
            this.txtDescripcionCurso.Size = new System.Drawing.Size(322, 107);
            this.txtDescripcionCurso.TabIndex = 7;
            this.txtDescripcionCurso.Text = "";
            // 
            // btAceptarAltaCurso
            // 
            this.btAceptarAltaCurso.Location = new System.Drawing.Point(266, 310);
            this.btAceptarAltaCurso.Name = "btAceptarAltaCurso";
            this.btAceptarAltaCurso.Size = new System.Drawing.Size(75, 23);
            this.btAceptarAltaCurso.TabIndex = 8;
            this.btAceptarAltaCurso.Text = "Aceptar";
            this.btAceptarAltaCurso.UseVisualStyleBackColor = true;
            this.btAceptarAltaCurso.Click += new System.EventHandler(this.btAceptarAltaCurso_Click);
            // 
            // ABMCCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 346);
            this.Controls.Add(this.btAceptarAltaCurso);
            this.Controls.Add(this.txtDescripcionCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechaCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.label1);
            this.Name = "ABMCCursosForm";
            this.Text = "Nuevo Curso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ABMCCursosForm_FormClosing);
            this.Load += new System.EventHandler(this.ABMCCursosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFechaCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtDescripcionCurso;
        private System.Windows.Forms.Button btAceptarAltaCurso;
    }
}