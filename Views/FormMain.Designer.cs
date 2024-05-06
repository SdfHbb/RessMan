using System.ComponentModel;

namespace RessMan.Views
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBestellungen = new System.Windows.Forms.Button();
            this.btnKunden = new System.Windows.Forms.Button();
            this.btnBestellungsdetails = new System.Windows.Forms.Button();
            this.btnArtikelkategorien = new System.Windows.Forms.Button();
            this.btnArtikel = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 97);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1315, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "{RessMan}";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.btnBestellungen);
            this.panel2.Controls.Add(this.btnKunden);
            this.panel2.Controls.Add(this.btnBestellungsdetails);
            this.panel2.Controls.Add(this.btnArtikelkategorien);
            this.panel2.Controls.Add(this.btnArtikel);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 613);
            this.panel2.TabIndex = 2;
            // 
            // btnBestellungen
            // 
            this.btnBestellungen.Location = new System.Drawing.Point(36, 440);
            this.btnBestellungen.Name = "btnBestellungen";
            this.btnBestellungen.Size = new System.Drawing.Size(162, 63);
            this.btnBestellungen.TabIndex = 5;
            this.btnBestellungen.Text = "Bestellungen";
            this.btnBestellungen.UseVisualStyleBackColor = true;
            // 
            // btnKunden
            // 
            this.btnKunden.Location = new System.Drawing.Point(36, 240);
            this.btnKunden.Name = "btnKunden";
            this.btnKunden.Size = new System.Drawing.Size(162, 63);
            this.btnKunden.TabIndex = 3;
            this.btnKunden.Text = "Kunden";
            this.btnKunden.UseVisualStyleBackColor = true;
            // 
            // btnBestellungsdetails
            // 
            this.btnBestellungsdetails.Location = new System.Drawing.Point(36, 529);
            this.btnBestellungsdetails.Name = "btnBestellungsdetails";
            this.btnBestellungsdetails.Size = new System.Drawing.Size(162, 63);
            this.btnBestellungsdetails.TabIndex = 6;
            this.btnBestellungsdetails.Text = "Bestellungsdetails";
            this.btnBestellungsdetails.UseVisualStyleBackColor = true;
            // 
            // btnArtikelkategorien
            // 
            this.btnArtikelkategorien.Location = new System.Drawing.Point(36, 341);
            this.btnArtikelkategorien.Name = "btnArtikelkategorien";
            this.btnArtikelkategorien.Size = new System.Drawing.Size(162, 63);
            this.btnArtikelkategorien.TabIndex = 4;
            this.btnArtikelkategorien.Text = "Artikelkategorien";
            this.btnArtikelkategorien.UseVisualStyleBackColor = true;
            // 
            // btnArtikel
            // 
            this.btnArtikel.Location = new System.Drawing.Point(36, 139);
            this.btnArtikel.Name = "btnArtikel";
            this.btnArtikel.Size = new System.Drawing.Size(162, 63);
            this.btnArtikel.TabIndex = 2;
            this.btnArtikel.Text = "Artikel";
            this.btnArtikel.UseVisualStyleBackColor = true;
            this.btnArtikel.Click += new System.EventHandler(this.btnArtikel_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(36, 34);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(162, 63);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Thistle;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(235, 97);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1080, 613);
            this.panelMain.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 710);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnKunden;
        private System.Windows.Forms.Button btnArtikelkategorien;
        private System.Windows.Forms.Button btnBestellungsdetails;

        private System.Windows.Forms.Button btnBestellungen;

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnArtikel;

        private System.Windows.Forms.Panel panelMain;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}