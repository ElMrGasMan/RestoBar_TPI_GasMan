﻿namespace Resto.Net
{
    partial class Preview
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
            panelDiseñoLayout = new Panel();
            PanelDeHerramientas = new Panel();
            Salir = new Button();
            Vision = new Label();
            label1 = new Label();
            PanelDeHerramientas.SuspendLayout();
            SuspendLayout();
            // 
            // panelDiseñoLayout
            // 
            panelDiseñoLayout.AllowDrop = true;
            panelDiseñoLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDiseñoLayout.BackColor = SystemColors.InactiveCaption;
            panelDiseñoLayout.Location = new Point(0, 0);
            panelDiseñoLayout.Name = "panelDiseñoLayout";
            panelDiseñoLayout.Size = new Size(611, 455);
            panelDiseñoLayout.TabIndex = 4;
            // 
            // PanelDeHerramientas
            // 
            PanelDeHerramientas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            PanelDeHerramientas.BackColor = Color.FromArgb(54, 61, 74);
            PanelDeHerramientas.Controls.Add(Vision);
            PanelDeHerramientas.Controls.Add(label1);
            PanelDeHerramientas.Controls.Add(Salir);
            PanelDeHerramientas.Location = new Point(611, 0);
            PanelDeHerramientas.Name = "PanelDeHerramientas";
            PanelDeHerramientas.Size = new Size(245, 455);
            PanelDeHerramientas.TabIndex = 3;
            // 
            // Salir
            // 
            Salir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Salir.BackColor = Color.FromArgb(37, 43, 52);
            Salir.FlatAppearance.BorderColor = Color.FromArgb(37, 43, 52);
            Salir.FlatStyle = FlatStyle.Flat;
            Salir.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Salir.ForeColor = SystemColors.Control;
            Salir.Location = new Point(0, 398);
            Salir.Margin = new Padding(3, 4, 3, 4);
            Salir.Name = "Salir";
            Salir.Size = new Size(242, 30);
            Salir.TabIndex = 0;
            Salir.Text = "Volver";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // Vision
            // 
            Vision.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Vision.AutoSize = true;
            Vision.BackColor = Color.Transparent;
            Vision.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            Vision.ForeColor = Color.FromArgb(113, 188, 252);
            Vision.Location = new Point(121, 9);
            Vision.Margin = new Padding(0);
            Vision.Name = "Vision";
            Vision.Size = new Size(89, 29);
            Vision.TabIndex = 7;
            Vision.Text = "Vision";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(54, 61, 74);
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(45, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 29);
            label1.TabIndex = 6;
            label1.Text = "Restó";
            // 
            // Preview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 462);
            Controls.Add(PanelDeHerramientas);
            Controls.Add(panelDiseñoLayout);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(877, 509);
            Name = "Preview";
            Text = "Previuw";
            FormClosing += Preview_FormClosing;
            PanelDeHerramientas.ResumeLayout(false);
            PanelDeHerramientas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDiseñoLayout;
        private Panel PanelDeHerramientas;
        private Button Salir;
        private Label Vision;
        private Label label1;
    }
}