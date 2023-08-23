namespace FCFE2KG
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip_kg = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenu_Openfile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Mapeditor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Pic_fe2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FEKGLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabCtl_fe = new System.Windows.Forms.TabControl();
            this.TPage_patch = new System.Windows.Forms.TabPage();
            this.TPage_hero = new System.Windows.Forms.TabPage();
            this.TPage_baowu = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_save2file = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusStrip_main = new System.Windows.Forms.StatusStrip();
            this.ToolStripLable_1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripLable_crc32 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripLable_romName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip_kg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_fe2)).BeginInit();
            this.FEKGLayoutPanel.SuspendLayout();
            this.tabCtl_fe.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.StatusStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_kg
            // 
            this.menuStrip_kg.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip_kg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_Openfile,
            this.ToolStripMenu_Mapeditor,
            this.ToolStripMenu_Exit});
            this.menuStrip_kg.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_kg.Name = "menuStrip_kg";
            this.menuStrip_kg.Size = new System.Drawing.Size(800, 25);
            this.menuStrip_kg.TabIndex = 0;
            this.menuStrip_kg.Text = "menuStripKG";
            // 
            // ToolStripMenu_Openfile
            // 
            this.ToolStripMenu_Openfile.Name = "ToolStripMenu_Openfile";
            this.ToolStripMenu_Openfile.Size = new System.Drawing.Size(92, 21);
            this.ToolStripMenu_Openfile.Text = "打开NES文件";
            // 
            // ToolStripMenu_Mapeditor
            // 
            this.ToolStripMenu_Mapeditor.Name = "ToolStripMenu_Mapeditor";
            this.ToolStripMenu_Mapeditor.Size = new System.Drawing.Size(80, 21);
            this.ToolStripMenu_Mapeditor.Text = "地图编辑器";
            this.ToolStripMenu_Mapeditor.Visible = false;
            this.ToolStripMenu_Mapeditor.Click += new System.EventHandler(this.ToolStripMenu_Mapeditor_Click);
            // 
            // ToolStripMenu_Exit
            // 
            this.ToolStripMenu_Exit.Name = "ToolStripMenu_Exit";
            this.ToolStripMenu_Exit.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenu_Exit.Text = "退出";
            this.ToolStripMenu_Exit.Click += new System.EventHandler(this.ToolStripMenu_Exit_Click);
            // 
            // Pic_fe2
            // 
            this.Pic_fe2.BackColor = System.Drawing.SystemColors.Window;
            this.Pic_fe2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic_fe2.Image = ((System.Drawing.Image)(resources.GetObject("Pic_fe2.Image")));
            this.Pic_fe2.Location = new System.Drawing.Point(673, 3);
            this.Pic_fe2.Name = "Pic_fe2";
            this.Pic_fe2.Size = new System.Drawing.Size(124, 360);
            this.Pic_fe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pic_fe2.TabIndex = 1;
            this.Pic_fe2.TabStop = false;
            this.toolTip1.SetToolTip(this.Pic_fe2, "关于（鼠标双击）");
            this.Pic_fe2.Click += new System.EventHandler(this.Pic_fe2_Click);
            this.Pic_fe2.DoubleClick += new System.EventHandler(this.Pic_fe2_about);
            // 
            // FEKGLayoutPanel
            // 
            this.FEKGLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.FEKGLayoutPanel.ColumnCount = 2;
            this.FEKGLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FEKGLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.FEKGLayoutPanel.Controls.Add(this.Pic_fe2, 1, 0);
            this.FEKGLayoutPanel.Controls.Add(this.tabCtl_fe, 0, 0);
            this.FEKGLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.FEKGLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FEKGLayoutPanel.Location = new System.Drawing.Point(0, 25);
            this.FEKGLayoutPanel.Name = "FEKGLayoutPanel";
            this.FEKGLayoutPanel.RowCount = 3;
            this.FEKGLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FEKGLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.FEKGLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FEKGLayoutPanel.Size = new System.Drawing.Size(800, 436);
            this.FEKGLayoutPanel.TabIndex = 2;
            // 
            // tabCtl_fe
            // 
            this.tabCtl_fe.Controls.Add(this.TPage_patch);
            this.tabCtl_fe.Controls.Add(this.TPage_hero);
            this.tabCtl_fe.Controls.Add(this.TPage_baowu);
            this.tabCtl_fe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtl_fe.Location = new System.Drawing.Point(3, 3);
            this.tabCtl_fe.Name = "tabCtl_fe";
            this.tabCtl_fe.SelectedIndex = 0;
            this.tabCtl_fe.Size = new System.Drawing.Size(664, 360);
            this.tabCtl_fe.TabIndex = 2;
            // 
            // TPage_patch
            // 
            this.TPage_patch.Location = new System.Drawing.Point(4, 22);
            this.TPage_patch.Name = "TPage_patch";
            this.TPage_patch.Padding = new System.Windows.Forms.Padding(3);
            this.TPage_patch.Size = new System.Drawing.Size(656, 334);
            this.TPage_patch.TabIndex = 0;
            this.TPage_patch.Text = "应用补丁";
            this.TPage_patch.UseVisualStyleBackColor = true;
            // 
            // TPage_hero
            // 
            this.TPage_hero.Location = new System.Drawing.Point(4, 22);
            this.TPage_hero.Name = "TPage_hero";
            this.TPage_hero.Padding = new System.Windows.Forms.Padding(3);
            this.TPage_hero.Size = new System.Drawing.Size(656, 334);
            this.TPage_hero.TabIndex = 1;
            this.TPage_hero.Text = "人物修改";
            this.TPage_hero.UseVisualStyleBackColor = true;
            // 
            // TPage_baowu
            // 
            this.TPage_baowu.Location = new System.Drawing.Point(4, 22);
            this.TPage_baowu.Name = "TPage_baowu";
            this.TPage_baowu.Padding = new System.Windows.Forms.Padding(3);
            this.TPage_baowu.Size = new System.Drawing.Size(656, 334);
            this.TPage_baowu.TabIndex = 2;
            this.TPage_baowu.Text = "宝箱";
            this.TPage_baowu.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_save2file, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 369);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 44);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Btn_save2file
            // 
            this.Btn_save2file.Location = new System.Drawing.Point(581, 3);
            this.Btn_save2file.Name = "Btn_save2file";
            this.Btn_save2file.Size = new System.Drawing.Size(75, 31);
            this.Btn_save2file.TabIndex = 0;
            this.Btn_save2file.Text = "保存到文件";
            this.Btn_save2file.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 38);
            this.panel1.TabIndex = 1;
            // 
            // StatusStrip_main
            // 
            this.StatusStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLable_1,
            this.ToolStripLable_crc32,
            this.ToolStripLable_romName});
            this.StatusStrip_main.Location = new System.Drawing.Point(0, 439);
            this.StatusStrip_main.Name = "StatusStrip_main";
            this.StatusStrip_main.Size = new System.Drawing.Size(800, 22);
            this.StatusStrip_main.TabIndex = 3;
            this.StatusStrip_main.Text = "statusStrip1";
            // 
            // ToolStripLable_1
            // 
            this.ToolStripLable_1.Name = "ToolStripLable_1";
            this.ToolStripLable_1.Size = new System.Drawing.Size(87, 17);
            this.ToolStripLable_1.Text = "ROM CRC32: ";
            // 
            // ToolStripLable_crc32
            // 
            this.ToolStripLable_crc32.Name = "ToolStripLable_crc32";
            this.ToolStripLable_crc32.Size = new System.Drawing.Size(54, 17);
            this.ToolStripLable_crc32.Text = "[CRC32]";
            // 
            // ToolStripLable_romName
            // 
            this.ToolStripLable_romName.Name = "ToolStripLable_romName";
            this.ToolStripLable_romName.Size = new System.Drawing.Size(82, 17);
            this.ToolStripLable_romName.Text = "[CN/JPN/US]";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.StatusStrip_main);
            this.Controls.Add(this.FEKGLayoutPanel);
            this.Controls.Add(this.menuStrip_kg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_kg;
            this.MinimumSize = new System.Drawing.Size(496, 496);
            this.Name = "MainForm";
            this.Text = "FC火纹外传简单粗暴修改器KGv1.0";
            this.menuStrip_kg.ResumeLayout(false);
            this.menuStrip_kg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_fe2)).EndInit();
            this.FEKGLayoutPanel.ResumeLayout(false);
            this.tabCtl_fe.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.StatusStrip_main.ResumeLayout(false);
            this.StatusStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_kg;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Openfile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Mapeditor;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Exit;
        private System.Windows.Forms.PictureBox Pic_fe2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel FEKGLayoutPanel;
        private System.Windows.Forms.TabControl tabCtl_fe;
        private System.Windows.Forms.TabPage TPage_patch;
        private System.Windows.Forms.TabPage TPage_hero;
        private System.Windows.Forms.TabPage TPage_baowu;
        private System.Windows.Forms.StatusStrip StatusStrip_main;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLable_1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLable_crc32;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLable_romName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_save2file;
        private System.Windows.Forms.Panel panel1;
    }
}

