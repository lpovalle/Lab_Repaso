namespace LaboratorioRepaso_1037214
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbx_searchsong = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Playlist = new System.Windows.Forms.Button();
            this.tbx_addName = new System.Windows.Forms.TextBox();
            this.btn_newPlaylist = new System.Windows.Forms.Button();
            this.btn_AscName = new System.Windows.Forms.Button();
            this.btn_AscTime = new System.Windows.Forms.Button();
            this.btn_DescName = new System.Windows.Forms.Button();
            this.btn_DescTime = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbx_addAutor = new System.Windows.Forms.TextBox();
            this.tbx_addLenght = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Enabled = false;
            this.btn_Add.Location = new System.Drawing.Point(264, 272);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(92, 40);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Agregar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbx_searchsong
            // 
            this.tbx_searchsong.Enabled = false;
            this.tbx_searchsong.Location = new System.Drawing.Point(49, 116);
            this.tbx_searchsong.Name = "tbx_searchsong";
            this.tbx_searchsong.Size = new System.Drawing.Size(166, 22);
            this.tbx_searchsong.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Enabled = false;
            this.btn_Search.Location = new System.Drawing.Point(231, 107);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(92, 40);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Buscar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Playlist
            // 
            this.btn_Playlist.Location = new System.Drawing.Point(101, 21);
            this.btn_Playlist.Name = "btn_Playlist";
            this.btn_Playlist.Size = new System.Drawing.Size(127, 40);
            this.btn_Playlist.TabIndex = 3;
            this.btn_Playlist.Text = "Ingresar Playlist";
            this.btn_Playlist.UseVisualStyleBackColor = true;
            this.btn_Playlist.Click += new System.EventHandler(this.btn_Playlist_Click);
            // 
            // tbx_addName
            // 
            this.tbx_addName.Enabled = false;
            this.tbx_addName.Location = new System.Drawing.Point(101, 262);
            this.tbx_addName.Name = "tbx_addName";
            this.tbx_addName.Size = new System.Drawing.Size(147, 22);
            this.tbx_addName.TabIndex = 4;
            // 
            // btn_newPlaylist
            // 
            this.btn_newPlaylist.Location = new System.Drawing.Point(101, 190);
            this.btn_newPlaylist.Name = "btn_newPlaylist";
            this.btn_newPlaylist.Size = new System.Drawing.Size(127, 40);
            this.btn_newPlaylist.TabIndex = 5;
            this.btn_newPlaylist.Text = "Nueva Playlist";
            this.btn_newPlaylist.UseVisualStyleBackColor = true;
            this.btn_newPlaylist.Click += new System.EventHandler(this.btn_newPlaylist_Click);
            // 
            // btn_AscName
            // 
            this.btn_AscName.Enabled = false;
            this.btn_AscName.Location = new System.Drawing.Point(52, 363);
            this.btn_AscName.Name = "btn_AscName";
            this.btn_AscName.Size = new System.Drawing.Size(106, 51);
            this.btn_AscName.TabIndex = 6;
            this.btn_AscName.Text = "Ascendente Nombre";
            this.btn_AscName.UseVisualStyleBackColor = true;
            this.btn_AscName.Click += new System.EventHandler(this.btn_AscName_Click);
            // 
            // btn_AscTime
            // 
            this.btn_AscTime.Enabled = false;
            this.btn_AscTime.Location = new System.Drawing.Point(185, 363);
            this.btn_AscTime.Name = "btn_AscTime";
            this.btn_AscTime.Size = new System.Drawing.Size(102, 51);
            this.btn_AscTime.TabIndex = 7;
            this.btn_AscTime.Text = "Ascendente Duración";
            this.btn_AscTime.UseVisualStyleBackColor = true;
            this.btn_AscTime.Click += new System.EventHandler(this.btn_AscTime_Click);
            // 
            // btn_DescName
            // 
            this.btn_DescName.Enabled = false;
            this.btn_DescName.Location = new System.Drawing.Point(52, 427);
            this.btn_DescName.Name = "btn_DescName";
            this.btn_DescName.Size = new System.Drawing.Size(106, 47);
            this.btn_DescName.TabIndex = 8;
            this.btn_DescName.Text = "Descendente Nombre";
            this.btn_DescName.UseVisualStyleBackColor = true;
            this.btn_DescName.Click += new System.EventHandler(this.btn_DescName_Click);
            // 
            // btn_DescTime
            // 
            this.btn_DescTime.Enabled = false;
            this.btn_DescTime.Location = new System.Drawing.Point(185, 427);
            this.btn_DescTime.Name = "btn_DescTime";
            this.btn_DescTime.Size = new System.Drawing.Size(102, 47);
            this.btn_DescTime.TabIndex = 9;
            this.btn_DescTime.Text = "Descendente Duración";
            this.btn_DescTime.UseVisualStyleBackColor = true;
            this.btn_DescTime.Click += new System.EventHandler(this.btn_DescTime_Click);
            // 
            // tbx_addAutor
            // 
            this.tbx_addAutor.Enabled = false;
            this.tbx_addAutor.Location = new System.Drawing.Point(101, 290);
            this.tbx_addAutor.Name = "tbx_addAutor";
            this.tbx_addAutor.Size = new System.Drawing.Size(147, 22);
            this.tbx_addAutor.TabIndex = 10;
            // 
            // tbx_addLenght
            // 
            this.tbx_addLenght.Enabled = false;
            this.tbx_addLenght.Location = new System.Drawing.Point(101, 318);
            this.tbx_addLenght.Name = "tbx_addLenght";
            this.tbx_addLenght.Size = new System.Drawing.Size(147, 22);
            this.tbx_addLenght.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "AUTOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "DURACIÓN:";
            // 
            // btn_Create
            // 
            this.btn_Create.Enabled = false;
            this.btn_Create.Location = new System.Drawing.Point(109, 480);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(106, 47);
            this.btn_Create.TabIndex = 15;
            this.btn_Create.Text = "Crear archivo de playlist";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 570);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_addLenght);
            this.Controls.Add(this.tbx_addAutor);
            this.Controls.Add(this.btn_DescTime);
            this.Controls.Add(this.btn_DescName);
            this.Controls.Add(this.btn_AscTime);
            this.Controls.Add(this.btn_AscName);
            this.Controls.Add(this.btn_newPlaylist);
            this.Controls.Add(this.tbx_addName);
            this.Controls.Add(this.btn_Playlist);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tbx_searchsong);
            this.Controls.Add(this.btn_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbx_searchsong;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Playlist;
        private System.Windows.Forms.TextBox tbx_addName;
        private System.Windows.Forms.Button btn_newPlaylist;
        private System.Windows.Forms.Button btn_AscName;
        private System.Windows.Forms.Button btn_AscTime;
        private System.Windows.Forms.Button btn_DescName;
        private System.Windows.Forms.Button btn_DescTime;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbx_addAutor;
        private System.Windows.Forms.TextBox tbx_addLenght;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Create;
    }
}

