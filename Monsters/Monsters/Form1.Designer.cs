﻿namespace Monsters
{
    partial class MonstersTable
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItem = new System.Windows.Forms.Button();
            this.chooseZombie = new System.Windows.Forms.Button();
            this.strongBeasts = new System.Windows.Forms.Button();
            this.countListItems = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(12, 377);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(164, 38);
            this.AddItem.TabIndex = 1;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // chooseZombie
            // 
            this.chooseZombie.Location = new System.Drawing.Point(218, 377);
            this.chooseZombie.Name = "chooseZombie";
            this.chooseZombie.Size = new System.Drawing.Size(169, 37);
            this.chooseZombie.TabIndex = 2;
            this.chooseZombie.Text = "Choose Zombie";
            this.chooseZombie.UseVisualStyleBackColor = true;
            this.chooseZombie.Click += new System.EventHandler(this.chooseZombie_Click);
            // 
            // strongBeasts
            // 
            this.strongBeasts.Location = new System.Drawing.Point(428, 377);
            this.strongBeasts.Name = "strongBeasts";
            this.strongBeasts.Size = new System.Drawing.Size(237, 38);
            this.strongBeasts.TabIndex = 3;
            this.strongBeasts.Text = "Take 2 strong  Beasts (random)";
            this.strongBeasts.UseVisualStyleBackColor = true;
            this.strongBeasts.Click += new System.EventHandler(this.strongBeasts_Click);
            // 
            // countListItems
            // 
            this.countListItems.Location = new System.Drawing.Point(719, 389);
            this.countListItems.Name = "countListItems";
            this.countListItems.Size = new System.Drawing.Size(90, 25);
            this.countListItems.TabIndex = 4;
            this.countListItems.Text = "Count items";
            // 
            // MonstersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.countListItems);
            this.Controls.Add(this.strongBeasts);
            this.Controls.Add(this.chooseZombie);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MonstersTable";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button chooseZombie;
        private System.Windows.Forms.Button strongBeasts;
        private System.Windows.Forms.Label countListItems;
    }
}

