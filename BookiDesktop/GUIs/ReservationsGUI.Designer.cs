﻿namespace BookiDesktop.GUIs {
    partial class ReservationsGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.reservationsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationsGridView
            // 
            this.reservationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationsGridView.Location = new System.Drawing.Point(12, 12);
            this.reservationsGridView.Name = "reservationsGridView";
            this.reservationsGridView.RowHeadersWidth = 51;
            this.reservationsGridView.RowTemplate.Height = 24;
            this.reservationsGridView.Size = new System.Drawing.Size(1176, 476);
            this.reservationsGridView.TabIndex = 0;
            this.reservationsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationsGridView_CellClick);
            // 
            // ReservationsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.reservationsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationsGUI";
            this.Text = "ReservationsGUI";
            ((System.ComponentModel.ISupportInitialize)(this.reservationsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reservationsGridView;
    }
}