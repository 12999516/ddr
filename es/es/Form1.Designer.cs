namespace es
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbl_field = new System.Windows.Forms.TableLayoutPanel();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_center = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_point = new System.Windows.Forms.Label();
            this.tbl_field.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_field
            // 
            this.tbl_field.ColumnCount = 3;
            this.tbl_field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tbl_field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tbl_field.Controls.Add(this.btn_down, 1, 2);
            this.tbl_field.Controls.Add(this.btn_right, 2, 1);
            this.tbl_field.Controls.Add(this.btn_center, 1, 1);
            this.tbl_field.Controls.Add(this.btn_left, 0, 1);
            this.tbl_field.Controls.Add(this.btn_up, 1, 0);
            this.tbl_field.Controls.Add(this.label1, 0, 0);
            this.tbl_field.Location = new System.Drawing.Point(216, 12);
            this.tbl_field.Name = "tbl_field";
            this.tbl_field.RowCount = 3;
            this.tbl_field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_field.Size = new System.Drawing.Size(400, 400);
            this.tbl_field.TabIndex = 0;
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.White;
            this.btn_down.BackgroundImage = global::es.Properties.Resources.down_removebg_preview;
            this.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_down.Location = new System.Drawing.Point(136, 269);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(127, 128);
            this.btn_down.TabIndex = 7;
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_right
            // 
            this.btn_right.BackColor = System.Drawing.Color.White;
            this.btn_right.BackgroundImage = global::es.Properties.Resources.right_removebg_preview;
            this.btn_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_right.Location = new System.Drawing.Point(269, 136);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(127, 127);
            this.btn_right.TabIndex = 6;
            this.btn_right.UseVisualStyleBackColor = false;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_center
            // 
            this.btn_center.BackColor = System.Drawing.Color.White;
            this.btn_center.BackgroundImage = global::es.Properties.Resources.center_removebg_preview;
            this.btn_center.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_center.Location = new System.Drawing.Point(136, 136);
            this.btn_center.Name = "btn_center";
            this.btn_center.Size = new System.Drawing.Size(127, 127);
            this.btn_center.TabIndex = 5;
            this.btn_center.UseVisualStyleBackColor = false;
            this.btn_center.Click += new System.EventHandler(this.btn_center_Click);
            // 
            // btn_left
            // 
            this.btn_left.BackColor = System.Drawing.Color.White;
            this.btn_left.BackgroundImage = global::es.Properties.Resources.left_removebg_preview;
            this.btn_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_left.Location = new System.Drawing.Point(3, 136);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(127, 127);
            this.btn_left.TabIndex = 4;
            this.btn_left.UseVisualStyleBackColor = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.White;
            this.btn_up.BackgroundImage = global::es.Properties.Resources.up_removebg_preview;
            this.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_up.Location = new System.Drawing.Point(136, 3);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(127, 127);
            this.btn_up.TabIndex = 2;
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::es.Properties.Resources.cover;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 166);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // lbl_point
            // 
            this.lbl_point.Location = new System.Drawing.Point(9, 205);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(100, 23);
            this.lbl_point.TabIndex = 2;
            this.lbl_point.Click += new System.EventHandler(this.lbl_point_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_point);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbl_field);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbl_field.ResumeLayout(false);
            this.tbl_field.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_field;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_center;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_point;
    }
}

