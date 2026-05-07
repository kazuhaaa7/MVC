using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using MVC.View;

namespace MVC.View
{
    partial class Form2
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
            TableUser = new DataGridView();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            ((System.ComponentModel.ISupportInitialize)TableUser).BeginInit();
            SuspendLayout();


            // TableUser
            TableUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableUser.Location = new Point(12, 60);
            TableUser.Name = "TableUser";
            TableUser.RowHeadersVisible = false;
            TableUser.Size = new Size(776, 350);
            TableUser.TabIndex = 0;
            TableUser.ReadOnly = true;
            TableUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TableUser.MultiSelect = false;


            // btnTambah
            btnTambah.Location = new Point(12, 12);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 35);
            btnTambah.Text = "Tambah";
            btnTambah.BackColor = Color.SeaGreen;
            btnTambah.ForeColor = Color.White;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Click += btnTambah_Click;


            // btnEdit
            btnEdit.Location = new Point(145, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 35);
            btnEdit.Text = "Edit";
            btnEdit.BackColor = Color.SteelBlue;
            btnEdit.ForeColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Click += btnEdit_Click;


            // btnHapus
            btnHapus.Location = new Point(278, 12);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(120, 35);
            btnHapus.Text = "Hapus";
            btnHapus.BackColor = Color.Crimson;
            btnHapus.ForeColor = Color.White;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Click += btnHapus_Click;


            // Form2
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TableUser);
            Controls.Add(btnTambah);
            Controls.Add(btnEdit);
            Controls.Add(btnHapus);
            Name = "Form2";
            Text = "Dashboard User";
            ((System.ComponentModel.ISupportInitialize)TableUser).EndInit();
            ResumeLayout(false);
        }


        #endregion


        private DataGridView TableUser;
        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
    }
}