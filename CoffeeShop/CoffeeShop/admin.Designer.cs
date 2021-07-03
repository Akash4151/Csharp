namespace CoffeeShop
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.updad = new System.Windows.Forms.Button();
            this.delad = new System.Windows.Forms.Button();
            this.viewad = new System.Windows.Forms.Button();
            this.lgad = new System.Windows.Forms.Button();
            this.coadg = new System.Windows.Forms.Label();
            this.pradg = new System.Windows.Forms.Label();
            this.txtcad = new System.Windows.Forms.TextBox();
            this.txtpad = new System.Windows.Forms.TextBox();
            this.dgbadmin = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // updad
            // 
            this.updad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updad.Location = new System.Drawing.Point(45, 509);
            this.updad.Name = "updad";
            this.updad.Size = new System.Drawing.Size(138, 47);
            this.updad.TabIndex = 1;
            this.updad.Text = "Update";
            this.updad.UseVisualStyleBackColor = true;
            this.updad.Click += new System.EventHandler(this.updad_Click);
            // 
            // delad
            // 
            this.delad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delad.Location = new System.Drawing.Point(227, 510);
            this.delad.Name = "delad";
            this.delad.Size = new System.Drawing.Size(138, 47);
            this.delad.TabIndex = 2;
            this.delad.Text = "Delete";
            this.delad.UseVisualStyleBackColor = true;
            this.delad.Click += new System.EventHandler(this.delad_Click);
            // 
            // viewad
            // 
            this.viewad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewad.Location = new System.Drawing.Point(606, 513);
            this.viewad.Name = "viewad";
            this.viewad.Size = new System.Drawing.Size(138, 47);
            this.viewad.TabIndex = 4;
            this.viewad.Text = "View All";
            this.viewad.UseVisualStyleBackColor = true;
            this.viewad.Click += new System.EventHandler(this.viewad_Click);
            // 
            // lgad
            // 
            this.lgad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgad.Location = new System.Drawing.Point(793, 513);
            this.lgad.Name = "lgad";
            this.lgad.Size = new System.Drawing.Size(138, 47);
            this.lgad.TabIndex = 5;
            this.lgad.Text = "LogOut";
            this.lgad.UseVisualStyleBackColor = true;
            this.lgad.Click += new System.EventHandler(this.lgad_Click);
            // 
            // coadg
            // 
            this.coadg.AutoSize = true;
            this.coadg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coadg.Location = new System.Drawing.Point(77, 151);
            this.coadg.Name = "coadg";
            this.coadg.Size = new System.Drawing.Size(90, 29);
            this.coadg.TabIndex = 7;
            this.coadg.Text = "Coffee";
            // 
            // pradg
            // 
            this.pradg.AutoSize = true;
            this.pradg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pradg.Location = new System.Drawing.Point(77, 195);
            this.pradg.Name = "pradg";
            this.pradg.Size = new System.Drawing.Size(74, 29);
            this.pradg.TabIndex = 8;
            this.pradg.Text = "Price";
            // 
            // txtcad
            // 
            this.txtcad.Location = new System.Drawing.Point(180, 151);
            this.txtcad.Name = "txtcad";
            this.txtcad.Size = new System.Drawing.Size(135, 26);
            this.txtcad.TabIndex = 9;
            // 
            // txtpad
            // 
            this.txtpad.Location = new System.Drawing.Point(180, 195);
            this.txtpad.Name = "txtpad";
            this.txtpad.Size = new System.Drawing.Size(135, 26);
            this.txtpad.TabIndex = 10;
            // 
            // dgbadmin
            // 
            this.dgbadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbadmin.Location = new System.Drawing.Point(366, 26);
            this.dgbadmin.Name = "dgbadmin";
            this.dgbadmin.RowTemplate.Height = 28;
            this.dgbadmin.Size = new System.Drawing.Size(586, 394);
            this.dgbadmin.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(412, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Location = new System.Drawing.Point(45, 455);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(138, 48);
            this.insert.TabIndex = 13;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1040, 670);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgbadmin);
            this.Controls.Add(this.txtpad);
            this.Controls.Add(this.txtcad);
            this.Controls.Add(this.pradg);
            this.Controls.Add(this.coadg);
            this.Controls.Add(this.lgad);
            this.Controls.Add(this.viewad);
            this.Controls.Add(this.delad);
            this.Controls.Add(this.updad);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbadmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updad;
        private System.Windows.Forms.Button delad;
        private System.Windows.Forms.Button viewad;
        private System.Windows.Forms.Button lgad;
        private System.Windows.Forms.Label coadg;
        private System.Windows.Forms.Label pradg;
        private System.Windows.Forms.TextBox txtcad;
        private System.Windows.Forms.TextBox txtpad;
        private System.Windows.Forms.DataGridView dgbadmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button insert;
    }
}