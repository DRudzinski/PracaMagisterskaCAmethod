namespace MultiscaleModeling
{
    partial class mainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exectime = new System.Windows.Forms.Label();
            this.tpl_checkbox = new System.Windows.Forms.CheckBox();
            this.import_cond_button = new System.Windows.Forms.Button();
            this.Animation_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.p_check = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.more_check = new System.Windows.Forms.RadioButton();
            this.matrixpanel = new System.Windows.Forms.Panel();
            this.pic_box3 = new System.Windows.Forms.PictureBox();
            this.pic_box2 = new System.Windows.Forms.PictureBox();
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.heigh_label = new System.Windows.Forms.Label();
            this.width_label = new System.Windows.Forms.Label();
            this.heigh_txt = new System.Windows.Forms.TextBox();
            this.bcond_label = new System.Windows.Forms.Label();
            this.neigh_label = new System.Windows.Forms.Label();
            this.nexts_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.seed_num = new System.Windows.Forms.NumericUpDown();
            this.seed_button = new System.Windows.Forms.Button();
            this.seed_label = new System.Windows.Forms.Label();
            this.size_button = new System.Windows.Forms.Button();
            this.size_label = new System.Windows.Forms.Label();
            this.width_txt = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.matrixpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_num)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.exectime);
            this.mainPanel.Controls.Add(this.tpl_checkbox);
            this.mainPanel.Controls.Add(this.import_cond_button);
            this.mainPanel.Controls.Add(this.Animation_button);
            this.mainPanel.Controls.Add(this.groupBox2);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.matrixpanel);
            this.mainPanel.Controls.Add(this.heigh_label);
            this.mainPanel.Controls.Add(this.width_label);
            this.mainPanel.Controls.Add(this.heigh_txt);
            this.mainPanel.Controls.Add(this.bcond_label);
            this.mainPanel.Controls.Add(this.neigh_label);
            this.mainPanel.Controls.Add(this.nexts_button);
            this.mainPanel.Controls.Add(this.reset_button);
            this.mainPanel.Controls.Add(this.pause_button);
            this.mainPanel.Controls.Add(this.start_button);
            this.mainPanel.Controls.Add(this.seed_num);
            this.mainPanel.Controls.Add(this.seed_button);
            this.mainPanel.Controls.Add(this.seed_label);
            this.mainPanel.Controls.Add(this.size_button);
            this.mainPanel.Controls.Add(this.size_label);
            this.mainPanel.Controls.Add(this.width_txt);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1566, 800);
            this.mainPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(948, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Execution time";
            // 
            // exectime
            // 
            this.exectime.AutoSize = true;
            this.exectime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exectime.Location = new System.Drawing.Point(1053, 159);
            this.exectime.Name = "exectime";
            this.exectime.Size = new System.Drawing.Size(26, 29);
            this.exectime.TabIndex = 29;
            this.exectime.Text = "0";
            // 
            // tpl_checkbox
            // 
            this.tpl_checkbox.AutoSize = true;
            this.tpl_checkbox.Location = new System.Drawing.Point(12, 19);
            this.tpl_checkbox.Name = "tpl_checkbox";
            this.tpl_checkbox.Size = new System.Drawing.Size(98, 21);
            this.tpl_checkbox.TabIndex = 28;
            this.tpl_checkbox.Text = "Active TPL";
            this.tpl_checkbox.UseVisualStyleBackColor = true;
            // 
            // import_cond_button
            // 
            this.import_cond_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.import_cond_button.Location = new System.Drawing.Point(9, 250);
            this.import_cond_button.Margin = new System.Windows.Forms.Padding(4);
            this.import_cond_button.Name = "import_cond_button";
            this.import_cond_button.Size = new System.Drawing.Size(180, 37);
            this.import_cond_button.TabIndex = 27;
            this.import_cond_button.Text = "Set conditions";
            this.import_cond_button.UseVisualStyleBackColor = true;
            // 
            // Animation_button
            // 
            this.Animation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Animation_button.Location = new System.Drawing.Point(456, 209);
            this.Animation_button.Margin = new System.Windows.Forms.Padding(4);
            this.Animation_button.Name = "Animation_button";
            this.Animation_button.Size = new System.Drawing.Size(180, 78);
            this.Animation_button.TabIndex = 23;
            this.Animation_button.Text = "Start";
            this.Animation_button.UseVisualStyleBackColor = true;
            this.Animation_button.Click += new System.EventHandler(this.Animation_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.p_check);
            this.groupBox2.Location = new System.Drawing.Point(888, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(304, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // p_check
            // 
            this.p_check.AutoSize = true;
            this.p_check.Checked = true;
            this.p_check.Location = new System.Drawing.Point(27, 23);
            this.p_check.Margin = new System.Windows.Forms.Padding(4);
            this.p_check.Name = "p_check";
            this.p_check.Size = new System.Drawing.Size(80, 21);
            this.p_check.TabIndex = 2;
            this.p_check.TabStop = true;
            this.p_check.Text = "Periodic";
            this.p_check.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.more_check);
            this.groupBox1.Location = new System.Drawing.Point(529, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(293, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // more_check
            // 
            this.more_check.AutoSize = true;
            this.more_check.Checked = true;
            this.more_check.Location = new System.Drawing.Point(0, 11);
            this.more_check.Margin = new System.Windows.Forms.Padding(4);
            this.more_check.Name = "more_check";
            this.more_check.Size = new System.Drawing.Size(72, 21);
            this.more_check.TabIndex = 0;
            this.more_check.TabStop = true;
            this.more_check.Text = "Moor\'a";
            this.more_check.UseVisualStyleBackColor = true;
            // 
            // matrixpanel
            // 
            this.matrixpanel.AutoScroll = true;
            this.matrixpanel.Controls.Add(this.pic_box3);
            this.matrixpanel.Controls.Add(this.pic_box2);
            this.matrixpanel.Controls.Add(this.pic_box);
            this.matrixpanel.Location = new System.Drawing.Point(3, 295);
            this.matrixpanel.Margin = new System.Windows.Forms.Padding(4);
            this.matrixpanel.Name = "matrixpanel";
            this.matrixpanel.Size = new System.Drawing.Size(1267, 501);
            this.matrixpanel.TabIndex = 21;
            // 
            // pic_box3
            // 
            this.pic_box3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_box3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pic_box3.Location = new System.Drawing.Point(1018, 24);
            this.pic_box3.Margin = new System.Windows.Forms.Padding(4);
            this.pic_box3.Name = "pic_box3";
            this.pic_box3.Size = new System.Drawing.Size(217, 167);
            this.pic_box3.TabIndex = 2;
            this.pic_box3.TabStop = false;
            // 
            // pic_box2
            // 
            this.pic_box2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_box2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pic_box2.Location = new System.Drawing.Point(526, 24);
            this.pic_box2.Margin = new System.Windows.Forms.Padding(4);
            this.pic_box2.Name = "pic_box2";
            this.pic_box2.Size = new System.Drawing.Size(217, 167);
            this.pic_box2.TabIndex = 1;
            this.pic_box2.TabStop = false;
            // 
            // pic_box
            // 
            this.pic_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pic_box.Location = new System.Drawing.Point(36, 24);
            this.pic_box.Margin = new System.Windows.Forms.Padding(4);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(217, 167);
            this.pic_box.TabIndex = 0;
            this.pic_box.TabStop = false;
            // 
            // heigh_label
            // 
            this.heigh_label.AutoSize = true;
            this.heigh_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heigh_label.Location = new System.Drawing.Point(308, 39);
            this.heigh_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heigh_label.Name = "heigh_label";
            this.heigh_label.Size = new System.Drawing.Size(54, 20);
            this.heigh_label.TabIndex = 20;
            this.heigh_label.Text = "height";
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.width_label.Location = new System.Drawing.Point(208, 39);
            this.width_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(48, 20);
            this.width_label.TabIndex = 19;
            this.width_label.Text = "width";
            // 
            // heigh_txt
            // 
            this.heigh_txt.Location = new System.Drawing.Point(288, 63);
            this.heigh_txt.Margin = new System.Windows.Forms.Padding(4);
            this.heigh_txt.Name = "heigh_txt";
            this.heigh_txt.Size = new System.Drawing.Size(95, 22);
            this.heigh_txt.TabIndex = 18;
            // 
            // bcond_label
            // 
            this.bcond_label.AutoSize = true;
            this.bcond_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bcond_label.Location = new System.Drawing.Point(883, 11);
            this.bcond_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bcond_label.Name = "bcond_label";
            this.bcond_label.Size = new System.Drawing.Size(374, 29);
            this.bcond_label.TabIndex = 14;
            this.bcond_label.Text = "Select type of boundary condition:";
            // 
            // neigh_label
            // 
            this.neigh_label.AutoSize = true;
            this.neigh_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.neigh_label.Location = new System.Drawing.Point(524, 11);
            this.neigh_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.neigh_label.Name = "neigh_label";
            this.neigh_label.Size = new System.Drawing.Size(334, 29);
            this.neigh_label.TabIndex = 13;
            this.neigh_label.Text = "Select type of neighbourhood:";
            // 
            // nexts_button
            // 
            this.nexts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nexts_button.Location = new System.Drawing.Point(880, 209);
            this.nexts_button.Margin = new System.Windows.Forms.Padding(4);
            this.nexts_button.Name = "nexts_button";
            this.nexts_button.Size = new System.Drawing.Size(180, 78);
            this.nexts_button.TabIndex = 10;
            this.nexts_button.Text = "Next Step";
            this.nexts_button.UseVisualStyleBackColor = true;
            this.nexts_button.Click += new System.EventHandler(this.nexts_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reset_button.Location = new System.Drawing.Point(1089, 210);
            this.reset_button.Margin = new System.Windows.Forms.Padding(4);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(180, 78);
            this.reset_button.TabIndex = 9;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // pause_button
            // 
            this.pause_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pause_button.Location = new System.Drawing.Point(672, 209);
            this.pause_button.Margin = new System.Windows.Forms.Padding(4);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(180, 78);
            this.pause_button.TabIndex = 8;
            this.pause_button.Text = "Pause";
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_button.Location = new System.Drawing.Point(197, 250);
            this.start_button.Margin = new System.Windows.Forms.Padding(4);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(180, 37);
            this.start_button.TabIndex = 7;
            this.start_button.Text = "Generate";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // seed_num
            // 
            this.seed_num.Location = new System.Drawing.Point(237, 112);
            this.seed_num.Margin = new System.Windows.Forms.Padding(4);
            this.seed_num.Name = "seed_num";
            this.seed_num.Size = new System.Drawing.Size(96, 22);
            this.seed_num.TabIndex = 6;
            // 
            // seed_button
            // 
            this.seed_button.Location = new System.Drawing.Point(392, 113);
            this.seed_button.Margin = new System.Windows.Forms.Padding(4);
            this.seed_button.Name = "seed_button";
            this.seed_button.Size = new System.Drawing.Size(100, 28);
            this.seed_button.TabIndex = 5;
            this.seed_button.Text = "OK";
            this.seed_button.UseVisualStyleBackColor = true;
            this.seed_button.Click += new System.EventHandler(this.seed_button_Click);
            // 
            // seed_label
            // 
            this.seed_label.AutoSize = true;
            this.seed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seed_label.Location = new System.Drawing.Point(4, 108);
            this.seed_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seed_label.Name = "seed_label";
            this.seed_label.Size = new System.Drawing.Size(215, 29);
            this.seed_label.TabIndex = 3;
            this.seed_label.Text = "Set seeds number:";
            // 
            // size_button
            // 
            this.size_button.Location = new System.Drawing.Point(392, 63);
            this.size_button.Margin = new System.Windows.Forms.Padding(4);
            this.size_button.Name = "size_button";
            this.size_button.Size = new System.Drawing.Size(100, 28);
            this.size_button.TabIndex = 2;
            this.size_button.Text = "OK";
            this.size_button.UseVisualStyleBackColor = true;
            this.size_button.Click += new System.EventHandler(this.size_button_Click);
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.size_label.Location = new System.Drawing.Point(4, 59);
            this.size_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(164, 29);
            this.size_label.TabIndex = 1;
            this.size_label.Text = "Set CA space:";
            // 
            // width_txt
            // 
            this.width_txt.Location = new System.Drawing.Point(184, 63);
            this.width_txt.Margin = new System.Windows.Forms.Padding(4);
            this.width_txt.Name = "width_txt";
            this.width_txt.Size = new System.Drawing.Size(95, 22);
            this.width_txt.TabIndex = 0;
            this.width_txt.TextChanged += new System.EventHandler(this.Width_txt_TextChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "MultiscaleModeling Damian Rudziński";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.matrixpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_num)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox width_txt;
        private System.Windows.Forms.NumericUpDown seed_num;
        private System.Windows.Forms.Button seed_button;
        private System.Windows.Forms.Label seed_label;
        private System.Windows.Forms.Button size_button;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Button nexts_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label bcond_label;
        private System.Windows.Forms.Label neigh_label;
        private System.Windows.Forms.Label heigh_label;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.TextBox heigh_txt;
        private System.Windows.Forms.Panel matrixpanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton p_check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton more_check;
        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.Button Animation_button;
        private System.Windows.Forms.Button import_cond_button;
        public System.Windows.Forms.CheckBox tpl_checkbox;
        private System.Windows.Forms.Label exectime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_box3;
        private System.Windows.Forms.PictureBox pic_box2;
    }
}

