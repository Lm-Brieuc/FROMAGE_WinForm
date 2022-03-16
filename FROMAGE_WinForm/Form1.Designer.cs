namespace FROMAGE_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Fromages = new System.Windows.Forms.ListBox();
            this.Label_list_Fromage = new System.Windows.Forms.Label();
            this.textBox_Lait = new System.Windows.Forms.TextBox();
            this.textBox_Departement = new System.Windows.Forms.TextBox();
            this.textBox_Wiki = new System.Windows.Forms.TextBox();
            this.label_Lait = new System.Windows.Forms.Label();
            this.label_Departement = new System.Windows.Forms.Label();
            this.label_Wiki = new System.Windows.Forms.Label();
            this.groupBox_Detail = new System.Windows.Forms.GroupBox();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_Filter = new System.Windows.Forms.ListBox();
            this.label_Filtre_Departement = new System.Windows.Forms.Label();
            this.groupBox_Detail.SuspendLayout();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Fromages
            // 
            this.listBox_Fromages.FormattingEnabled = true;
            this.listBox_Fromages.ItemHeight = 20;
            this.listBox_Fromages.Location = new System.Drawing.Point(25, 61);
            this.listBox_Fromages.Name = "listBox_Fromages";
            this.listBox_Fromages.Size = new System.Drawing.Size(221, 364);
            this.listBox_Fromages.TabIndex = 0;
            this.listBox_Fromages.SelectedIndexChanged += new System.EventHandler(this.listBox_Fromages_SelectedIndexChanged_1);
            // 
            // Label_list_Fromage
            // 
            this.Label_list_Fromage.AutoSize = true;
            this.Label_list_Fromage.Location = new System.Drawing.Point(25, 38);
            this.Label_list_Fromage.Name = "Label_list_Fromage";
            this.Label_list_Fromage.Size = new System.Drawing.Size(104, 20);
            this.Label_list_Fromage.TabIndex = 1;
            this.Label_list_Fromage.Text = "Les fromages :";
            this.Label_list_Fromage.Click += new System.EventHandler(this.Label_list_Fromage_Click);
            // 
            // textBox_Lait
            // 
            this.textBox_Lait.Location = new System.Drawing.Point(151, 58);
            this.textBox_Lait.Name = "textBox_Lait";
            this.textBox_Lait.Size = new System.Drawing.Size(125, 27);
            this.textBox_Lait.TabIndex = 2;
            // 
            // textBox_Departement
            // 
            this.textBox_Departement.Location = new System.Drawing.Point(151, 102);
            this.textBox_Departement.Name = "textBox_Departement";
            this.textBox_Departement.Size = new System.Drawing.Size(125, 27);
            this.textBox_Departement.TabIndex = 3;
            // 
            // textBox_Wiki
            // 
            this.textBox_Wiki.Location = new System.Drawing.Point(151, 142);
            this.textBox_Wiki.Name = "textBox_Wiki";
            this.textBox_Wiki.Size = new System.Drawing.Size(125, 27);
            this.textBox_Wiki.TabIndex = 4;
            // 
            // label_Lait
            // 
            this.label_Lait.AutoSize = true;
            this.label_Lait.Location = new System.Drawing.Point(26, 65);
            this.label_Lait.Name = "label_Lait";
            this.label_Lait.Size = new System.Drawing.Size(40, 20);
            this.label_Lait.TabIndex = 5;
            this.label_Lait.Text = "Lait :";
            // 
            // label_Departement
            // 
            this.label_Departement.AutoSize = true;
            this.label_Departement.Location = new System.Drawing.Point(26, 109);
            this.label_Departement.Name = "label_Departement";
            this.label_Departement.Size = new System.Drawing.Size(104, 20);
            this.label_Departement.TabIndex = 6;
            this.label_Departement.Text = "Departement :";
            this.label_Departement.Click += new System.EventHandler(this.label_Departement_Click);
            // 
            // label_Wiki
            // 
            this.label_Wiki.AutoSize = true;
            this.label_Wiki.Location = new System.Drawing.Point(26, 149);
            this.label_Wiki.Name = "label_Wiki";
            this.label_Wiki.Size = new System.Drawing.Size(114, 20);
            this.label_Wiki.TabIndex = 7;
            this.label_Wiki.Text = "Lien Wikipedia :";
            // 
            // groupBox_Detail
            // 
            this.groupBox_Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox_Detail.Controls.Add(this.label_Departement);
            this.groupBox_Detail.Controls.Add(this.label_Wiki);
            this.groupBox_Detail.Controls.Add(this.textBox_Lait);
            this.groupBox_Detail.Controls.Add(this.textBox_Departement);
            this.groupBox_Detail.Controls.Add(this.label_Lait);
            this.groupBox_Detail.Controls.Add(this.textBox_Wiki);
            this.groupBox_Detail.Location = new System.Drawing.Point(299, 61);
            this.groupBox_Detail.Name = "groupBox_Detail";
            this.groupBox_Detail.Size = new System.Drawing.Size(290, 191);
            this.groupBox_Detail.TabIndex = 8;
            this.groupBox_Detail.TabStop = false;
            this.groupBox_Detail.Text = "Détail ";
            // 
            // main_menu
            // 
            this.main_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(800, 28);
            this.main_menu.TabIndex = 9;
            this.main_menu.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.couleurToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.optionToolStripMenuItem.Text = "&Option";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // couleurToolStripMenuItem
            // 
            this.couleurToolStripMenuItem.Name = "couleurToolStripMenuItem";
            this.couleurToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.couleurToolStripMenuItem.Text = "&Couleur";
            this.couleurToolStripMenuItem.Click += new System.EventHandler(this.couleurToolStripMenuItem_Click);
            // 
            // listBox_Filter
            // 
            this.listBox_Filter.FormattingEnabled = true;
            this.listBox_Filter.ItemHeight = 20;
            this.listBox_Filter.Location = new System.Drawing.Point(303, 281);
            this.listBox_Filter.Name = "listBox_Filter";
            this.listBox_Filter.Size = new System.Drawing.Size(286, 144);
            this.listBox_Filter.TabIndex = 10;
            this.listBox_Filter.SelectedIndexChanged += new System.EventHandler(this.listBox_Filter_SelectedIndexChanged);
            // 
            // label_Filtre_Departement
            // 
            this.label_Filtre_Departement.AutoSize = true;
            this.label_Filtre_Departement.Location = new System.Drawing.Point(297, 260);
            this.label_Filtre_Departement.Name = "label_Filtre_Departement";
            this.label_Filtre_Departement.Size = new System.Drawing.Size(158, 20);
            this.label_Filtre_Departement.TabIndex = 11;
            this.label_Filtre_Departement.Text = "Filtre par département";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Filtre_Departement);
            this.Controls.Add(this.listBox_Filter);
            this.Controls.Add(this.groupBox_Detail);
            this.Controls.Add(this.Label_list_Fromage);
            this.Controls.Add(this.listBox_Fromages);
            this.Controls.Add(this.main_menu);
            this.MainMenuStrip = this.main_menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_Detail.ResumeLayout(false);
            this.groupBox_Detail.PerformLayout();
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox_Fromages;
        private Label Label_list_Fromage;
        private TextBox textBox_Lait;
        private TextBox textBox_Departement;
        private TextBox textBox_Wiki;
        private Label label_Lait;
        private Label label_Departement;
        private Label label_Wiki;
        private GroupBox groupBox_Detail;
        private MenuStrip main_menu;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem couleurToolStripMenuItem;
        private ListBox listBox_Filter;
        private Label label_Filtre_Departement;
    }
}