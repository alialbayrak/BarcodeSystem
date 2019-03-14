namespace AliSoft
{
    partial class musterisec
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAD_SOYAD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.texte_posta = new System.Windows.Forms.TextBox();
            this.texttelefon = new System.Windows.Forms.TextBox();
            this.textad_soyad = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.textBoxArama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnAD_SOYAD,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(535, 411);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 44;
            // 
            // columnAD_SOYAD
            // 
            this.columnAD_SOYAD.Text = "AD SOYAD";
            this.columnAD_SOYAD.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TELEFON";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-POSTA";
            this.columnHeader4.Width = 130;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Kaydet / Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-Posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telefon Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad Soyad";
            // 
            // texte_posta
            // 
            this.texte_posta.Location = new System.Drawing.Point(643, 233);
            this.texte_posta.Name = "texte_posta";
            this.texte_posta.Size = new System.Drawing.Size(197, 20);
            this.texte_posta.TabIndex = 9;
            // 
            // texttelefon
            // 
            this.texttelefon.Location = new System.Drawing.Point(643, 178);
            this.texttelefon.Name = "texttelefon";
            this.texttelefon.Size = new System.Drawing.Size(197, 20);
            this.texttelefon.TabIndex = 8;
            // 
            // textad_soyad
            // 
            this.textad_soyad.Location = new System.Drawing.Point(643, 124);
            this.textad_soyad.Name = "textad_soyad";
            this.textad_soyad.Size = new System.Drawing.Size(197, 20);
            this.textad_soyad.TabIndex = 7;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(472, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 14;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // textBoxArama
            // 
            this.textBoxArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxArama.Location = new System.Drawing.Point(12, 13);
            this.textBoxArama.Name = "textBoxArama";
            this.textBoxArama.Size = new System.Drawing.Size(454, 22);
            this.textBoxArama.TabIndex = 15;
            // 
            // musterisec
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 466);
            this.Controls.Add(this.textBoxArama);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texte_posta);
            this.Controls.Add(this.texttelefon);
            this.Controls.Add(this.textad_soyad);
            this.Controls.Add(this.listView1);
            this.Name = "musterisec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "musterisec";
            this.Load += new System.EventHandler(this.musterisec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnAD_SOYAD;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texte_posta;
        private System.Windows.Forms.TextBox texttelefon;
        private System.Windows.Forms.TextBox textad_soyad;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox textBoxArama;



    }
}