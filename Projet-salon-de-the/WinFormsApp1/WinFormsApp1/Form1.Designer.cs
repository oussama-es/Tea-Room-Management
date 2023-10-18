namespace WinFormsApp1
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            listerToolStripMenuItem = new ToolStripMenuItem();
            rechercherToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem2 = new ToolStripMenuItem();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem1 = new ToolStripMenuItem();
            modifierToolStripMenuItem1 = new ToolStripMenuItem();
            listerToolStripMenuItem1 = new ToolStripMenuItem();
            rechercherToolStripMenuItem1 = new ToolStripMenuItem();
            quitterToolStripMenuItem1 = new ToolStripMenuItem();
            quitterToolStripMenuItem3 = new ToolStripMenuItem();
            gestionDesToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            listerBilanToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, gestionToolStripMenuItem, gestionDesToolStripMenuItem, listerBilanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(537, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem, modifierToolStripMenuItem, listerToolStripMenuItem, rechercherToolStripMenuItem, quitterToolStripMenuItem, quitterToolStripMenuItem2 });
            menuToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(135, 19);
            menuToolStripMenuItem.Text = "Gestion des serveurs";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(180, 22);
            ajouterToolStripMenuItem.Text = "Ajouter";
            ajouterToolStripMenuItem.Click += ajouterToolStripMenuItem_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(180, 22);
            modifierToolStripMenuItem.Text = "Modifier";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // listerToolStripMenuItem
            // 
            listerToolStripMenuItem.Name = "listerToolStripMenuItem";
            listerToolStripMenuItem.Size = new Size(180, 22);
            listerToolStripMenuItem.Text = "Lister";
            listerToolStripMenuItem.Click += listerToolStripMenuItem_Click;
            // 
            // rechercherToolStripMenuItem
            // 
            rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            rechercherToolStripMenuItem.Size = new Size(180, 22);
            rechercherToolStripMenuItem.Text = "Rechercher";
            rechercherToolStripMenuItem.Click += rechercherToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(180, 22);
            quitterToolStripMenuItem.Text = "Supprimer";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem2
            // 
            quitterToolStripMenuItem2.Name = "quitterToolStripMenuItem2";
            quitterToolStripMenuItem2.Size = new Size(180, 22);
            quitterToolStripMenuItem2.Text = "Quitter";
            quitterToolStripMenuItem2.Click += quitterToolStripMenuItem2_Click;
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem1, modifierToolStripMenuItem1, listerToolStripMenuItem1, rechercherToolStripMenuItem1, quitterToolStripMenuItem1, quitterToolStripMenuItem3 });
            gestionToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(133, 19);
            gestionToolStripMenuItem.Text = "Gestion des boissons";
            gestionToolStripMenuItem.Click += gestionToolStripMenuItem_Click;
            // 
            // ajouterToolStripMenuItem1
            // 
            ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            ajouterToolStripMenuItem1.Size = new Size(180, 22);
            ajouterToolStripMenuItem1.Text = "Ajouter";
            ajouterToolStripMenuItem1.Click += ajouterToolStripMenuItem1_Click;
            // 
            // modifierToolStripMenuItem1
            // 
            modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            modifierToolStripMenuItem1.Size = new Size(180, 22);
            modifierToolStripMenuItem1.Text = "Modifier";
            modifierToolStripMenuItem1.Click += modifierToolStripMenuItem1_Click;
            // 
            // listerToolStripMenuItem1
            // 
            listerToolStripMenuItem1.Name = "listerToolStripMenuItem1";
            listerToolStripMenuItem1.Size = new Size(180, 22);
            listerToolStripMenuItem1.Text = "Lister";
            listerToolStripMenuItem1.Click += listerToolStripMenuItem1_Click;
            // 
            // rechercherToolStripMenuItem1
            // 
            rechercherToolStripMenuItem1.Name = "rechercherToolStripMenuItem1";
            rechercherToolStripMenuItem1.Size = new Size(180, 22);
            rechercherToolStripMenuItem1.Text = "Rechercher";
            rechercherToolStripMenuItem1.Click += rechercherToolStripMenuItem1_Click;
            // 
            // quitterToolStripMenuItem1
            // 
            quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            quitterToolStripMenuItem1.Size = new Size(180, 22);
            quitterToolStripMenuItem1.Text = "Supprimer";
            quitterToolStripMenuItem1.Click += quitterToolStripMenuItem1_Click;
            // 
            // quitterToolStripMenuItem3
            // 
            quitterToolStripMenuItem3.Name = "quitterToolStripMenuItem3";
            quitterToolStripMenuItem3.Size = new Size(180, 22);
            quitterToolStripMenuItem3.Text = "Quitter";
            quitterToolStripMenuItem3.Click += quitterToolStripMenuItem3_Click;
            // 
            // gestionDesToolStripMenuItem
            // 
            gestionDesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem2, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5 });
            gestionDesToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gestionDesToolStripMenuItem.Name = "gestionDesToolStripMenuItem";
            gestionDesToolStripMenuItem.Size = new Size(155, 19);
            gestionDesToolStripMenuItem.Text = "Gestion des Commandes";
            // 
            // ajouterToolStripMenuItem2
            // 
            ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            ajouterToolStripMenuItem2.Size = new Size(180, 22);
            ajouterToolStripMenuItem2.Text = "Ajouter";
            ajouterToolStripMenuItem2.Click += ajouterToolStripMenuItem2_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "Modifier";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "Lister";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "Rechercher";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(180, 22);
            toolStripMenuItem4.Text = "Supprimer";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(180, 22);
            toolStripMenuItem5.Text = "Quitter";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // listerBilanToolStripMenuItem
            // 
            listerBilanToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listerBilanToolStripMenuItem.Name = "listerBilanToolStripMenuItem";
            listerBilanToolStripMenuItem.Size = new Size(80, 19);
            listerBilanToolStripMenuItem.Text = "Lister Bilan";
            listerBilanToolStripMenuItem.Click += listerBilanToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 251);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Salon de thé";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem listerToolStripMenuItem;
        private ToolStripMenuItem rechercherToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem1;
        private ToolStripMenuItem modifierToolStripMenuItem1;
        private ToolStripMenuItem listerToolStripMenuItem1;
        private ToolStripMenuItem rechercherToolStripMenuItem1;
        private ToolStripMenuItem quitterToolStripMenuItem1;
        private ToolStripMenuItem gestionDesToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem2;
        private ToolStripMenuItem quitterToolStripMenuItem3;
        private ToolStripMenuItem ajouterToolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem listerBilanToolStripMenuItem;
    }
}