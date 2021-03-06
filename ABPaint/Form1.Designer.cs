﻿namespace ABPaint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolbox = new System.Windows.Forms.FlowLayoutPanel();
            this.toolCursorN = new System.Windows.Forms.Panel();
            this.timgCursorN = new System.Windows.Forms.PictureBox();
            this.toolCursorS = new System.Windows.Forms.Panel();
            this.timgCursorS = new System.Windows.Forms.PictureBox();
            this.toolPencil = new System.Windows.Forms.Panel();
            this.timgPencil = new System.Windows.Forms.PictureBox();
            this.toolBrush = new System.Windows.Forms.Panel();
            this.timgBrush = new System.Windows.Forms.PictureBox();
            this.toolRect = new System.Windows.Forms.Panel();
            this.timgRect = new System.Windows.Forms.PictureBox();
            this.toolElli = new System.Windows.Forms.Panel();
            this.timgElli = new System.Windows.Forms.PictureBox();
            this.toolLine = new System.Windows.Forms.Panel();
            this.timgLine = new System.Windows.Forms.PictureBox();
            this.toolFill = new System.Windows.Forms.Panel();
            this.timgFill = new System.Windows.Forms.PictureBox();
            this.toolText = new System.Windows.Forms.Panel();
            this.timgText = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.zoomUp = new System.Windows.Forms.Button();
            this.zoomDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.redrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appcenter = new System.Windows.Forms.Panel();
            this.canvaspre = new ABPaint.CanvasBox();
            this.welcomeScreen = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.properties = new System.Windows.Forms.Panel();
            this.propertiesProps = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.clrFill = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clrBord = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clrNorm = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBThick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlFont = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItl = new System.Windows.Forms.Button();
            this.btnUline = new System.Windows.Forms.Button();
            this.propertiesLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cl8 = new ABPaint.RightMenu.ColorBox();
            this.cl4 = new ABPaint.RightMenu.ColorBox();
            this.cl7 = new ABPaint.RightMenu.ColorBox();
            this.cl3 = new ABPaint.RightMenu.ColorBox();
            this.cl6 = new ABPaint.RightMenu.ColorBox();
            this.cl5 = new ABPaint.RightMenu.ColorBox();
            this.cl2 = new ABPaint.RightMenu.ColorBox();
            this.cl1 = new ABPaint.RightMenu.ColorBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.movingRefresh = new System.Windows.Forms.Timer(this.components);
            this.openFileDialogOPEN = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSAVE = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogIMPORT = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogEXPORT = new System.Windows.Forms.SaveFileDialog();
            this.toolbox.SuspendLayout();
            this.toolCursorN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timgCursorN)).BeginInit();
            this.toolCursorS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timgCursorS)).BeginInit();
            this.toolPencil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timgPencil)).BeginInit();
            this.toolBrush.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timgBrush)).BeginInit();
            this.toolRect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timgRect)).BeginInit();
            this.toolElli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timgElli)).BeginInit();
            this.toolLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timgLine)).BeginInit();
            this.toolFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timgFill)).BeginInit();
            this.toolText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timgText)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.appcenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvaspre)).BeginInit();
            this.welcomeScreen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.properties.SuspendLayout();
            this.propertiesProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clrFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clrBord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clrNorm)).BeginInit();
            this.pnlFont.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbox
            // 
            this.toolbox.BackColor = System.Drawing.Color.Gray;
            this.toolbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolbox.Controls.Add(this.toolCursorN);
            this.toolbox.Controls.Add(this.toolCursorS);
            this.toolbox.Controls.Add(this.toolPencil);
            this.toolbox.Controls.Add(this.toolBrush);
            this.toolbox.Controls.Add(this.toolRect);
            this.toolbox.Controls.Add(this.toolElli);
            this.toolbox.Controls.Add(this.toolLine);
            this.toolbox.Controls.Add(this.toolFill);
            this.toolbox.Controls.Add(this.toolText);
            this.toolbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolbox.Location = new System.Drawing.Point(0, 41);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(60, 471);
            this.toolbox.TabIndex = 0;
            // 
            // toolCursorN
            // 
            this.toolCursorN.BackColor = System.Drawing.Color.White;
            this.toolCursorN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolCursorN.Controls.Add(this.timgCursorN);
            this.toolCursorN.Location = new System.Drawing.Point(3, 3);
            this.toolCursorN.Name = "toolCursorN";
            this.toolCursorN.Size = new System.Drawing.Size(47, 43);
            this.toolCursorN.TabIndex = 1;
            // 
            // timgCursorN
            // 
            this.timgCursorN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timgCursorN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timgCursorN.Image = ((System.Drawing.Image)(resources.GetObject("timgCursorN.Image")));
            this.timgCursorN.Location = new System.Drawing.Point(0, 0);
            this.timgCursorN.Name = "timgCursorN";
            this.timgCursorN.Size = new System.Drawing.Size(45, 41);
            this.timgCursorN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.timgCursorN.TabIndex = 1;
            this.timgCursorN.TabStop = false;
            this.timgCursorN.Click += new System.EventHandler(this.timgCursorN_Click);
            // 
            // toolCursorS
            // 
            this.toolCursorS.BackColor = System.Drawing.Color.White;
            this.toolCursorS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolCursorS.Controls.Add(this.timgCursorS);
            this.toolCursorS.Location = new System.Drawing.Point(3, 52);
            this.toolCursorS.Name = "toolCursorS";
            this.toolCursorS.Size = new System.Drawing.Size(47, 43);
            this.toolCursorS.TabIndex = 2;
            // 
            // timgCursorS
            // 
            this.timgCursorS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timgCursorS.Image = ((System.Drawing.Image)(resources.GetObject("timgCursorS.Image")));
            this.timgCursorS.Location = new System.Drawing.Point(0, 0);
            this.timgCursorS.Name = "timgCursorS";
            this.timgCursorS.Size = new System.Drawing.Size(45, 41);
            this.timgCursorS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.timgCursorS.TabIndex = 2;
            this.timgCursorS.TabStop = false;
            this.timgCursorS.Click += new System.EventHandler(this.timgCursorS_Click);
            // 
            // toolPencil
            // 
            this.toolPencil.BackColor = System.Drawing.Color.White;
            this.toolPencil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolPencil.Controls.Add(this.timgPencil);
            this.toolPencil.Location = new System.Drawing.Point(3, 101);
            this.toolPencil.Name = "toolPencil";
            this.toolPencil.Size = new System.Drawing.Size(47, 43);
            this.toolPencil.TabIndex = 3;
            // 
            // timgPencil
            // 
            this.timgPencil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timgPencil.Image = global::ABPaint.Properties.Resources.PencilTool;
            this.timgPencil.Location = new System.Drawing.Point(0, 0);
            this.timgPencil.Name = "timgPencil";
            this.timgPencil.Size = new System.Drawing.Size(45, 41);
            this.timgPencil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.timgPencil.TabIndex = 2;
            this.timgPencil.TabStop = false;
            this.timgPencil.Click += new System.EventHandler(this.timgPencil_Click);
            // 
            // toolBrush
            // 
            this.toolBrush.BackColor = System.Drawing.Color.White;
            this.toolBrush.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolBrush.Controls.Add(this.timgBrush);
            this.toolBrush.Location = new System.Drawing.Point(3, 150);
            this.toolBrush.Name = "toolBrush";
            this.toolBrush.Size = new System.Drawing.Size(47, 43);
            this.toolBrush.TabIndex = 4;
            // 
            // timgBrush
            // 
            this.timgBrush.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timgBrush.Image = global::ABPaint.Properties.Resources.PaintBrush;
            this.timgBrush.Location = new System.Drawing.Point(0, 0);
            this.timgBrush.Name = "timgBrush";
            this.timgBrush.Size = new System.Drawing.Size(45, 41);
            this.timgBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.timgBrush.TabIndex = 2;
            this.timgBrush.TabStop = false;
            this.timgBrush.Click += new System.EventHandler(this.timgBrush_Click);
            // 
            // toolRect
            // 
            this.toolRect.BackColor = System.Drawing.Color.White;
            this.toolRect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolRect.Controls.Add(this.timgRect);
            this.toolRect.Location = new System.Drawing.Point(3, 199);
            this.toolRect.Name = "toolRect";
            this.toolRect.Size = new System.Drawing.Size(47, 43);
            this.toolRect.TabIndex = 5;
            // 
            // timgRect
            // 
            this.timgRect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timgRect.Image = global::ABPaint.Properties.Resources.Rectangle;
            this.timgRect.Location = new System.Drawing.Point(0, 0);
            this.timgRect.Name = "timgRect";
            this.timgRect.Size = new System.Drawing.Size(45, 41);
            this.timgRect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.timgRect.TabIndex = 2;
            this.timgRect.TabStop = false;
            this.timgRect.Click += new System.EventHandler(this.timgRect_Click);
            // 
            // toolElli
            // 
            this.toolElli.BackColor = System.Drawing.Color.White;
            this.toolElli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolElli.Controls.Add(this.timgElli);
            this.toolElli.Location = new System.Drawing.Point(3, 248);
            this.toolElli.Name = "toolElli";
            this.toolElli.Size = new System.Drawing.Size(47, 43);
            this.toolElli.TabIndex = 6;
            // 
            // timgElli
            // 
            this.timgElli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timgElli.Image = global::ABPaint.Properties.Resources.EllipseIcon;
            this.timgElli.Location = new System.Drawing.Point(0, 0);
            this.timgElli.Name = "timgElli";
            this.timgElli.Size = new System.Drawing.Size(45, 41);
            this.timgElli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.timgElli.TabIndex = 2;
            this.timgElli.TabStop = false;
            this.timgElli.Click += new System.EventHandler(this.timgElli_Click);
            // 
            // toolLine
            // 
            this.toolLine.BackColor = System.Drawing.Color.White;
            this.toolLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolLine.Controls.Add(this.timgLine);
            this.toolLine.Location = new System.Drawing.Point(3, 297);
            this.toolLine.Name = "toolLine";
            this.toolLine.Size = new System.Drawing.Size(47, 43);
            this.toolLine.TabIndex = 7;
            // 
            // timgLine
            // 
            this.timgLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timgLine.Image = global::ABPaint.Properties.Resources.LineIcon;
            this.timgLine.Location = new System.Drawing.Point(0, 0);
            this.timgLine.Name = "timgLine";
            this.timgLine.Size = new System.Drawing.Size(45, 41);
            this.timgLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.timgLine.TabIndex = 2;
            this.timgLine.TabStop = false;
            this.timgLine.Click += new System.EventHandler(this.timgLine_Click);
            // 
            // toolFill
            // 
            this.toolFill.BackColor = System.Drawing.Color.White;
            this.toolFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolFill.Controls.Add(this.timgFill);
            this.toolFill.Location = new System.Drawing.Point(3, 346);
            this.toolFill.Name = "toolFill";
            this.toolFill.Size = new System.Drawing.Size(47, 43);
            this.toolFill.TabIndex = 8;
            // 
            // timgFill
            // 
            this.timgFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timgFill.Image = global::ABPaint.Properties.Resources.FillBucket;
            this.timgFill.Location = new System.Drawing.Point(0, 0);
            this.timgFill.Name = "timgFill";
            this.timgFill.Size = new System.Drawing.Size(45, 41);
            this.timgFill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.timgFill.TabIndex = 2;
            this.timgFill.TabStop = false;
            this.timgFill.Click += new System.EventHandler(this.timgFill_Click);
            // 
            // toolText
            // 
            this.toolText.BackColor = System.Drawing.Color.White;
            this.toolText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolText.Controls.Add(this.timgText);
            this.toolText.Location = new System.Drawing.Point(3, 395);
            this.toolText.Name = "toolText";
            this.toolText.Size = new System.Drawing.Size(47, 43);
            this.toolText.TabIndex = 9;
            // 
            // timgText
            // 
            this.timgText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timgText.Image = global::ABPaint.Properties.Resources.TextIcon;
            this.timgText.Location = new System.Drawing.Point(0, 0);
            this.timgText.Name = "timgText";
            this.timgText.Size = new System.Drawing.Size(45, 41);
            this.timgText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.timgText.TabIndex = 2;
            this.timgText.TabStop = false;
            this.timgText.Click += new System.EventHandler(this.timgText_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 41);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.zoomUp);
            this.panel4.Controls.Add(this.zoomDown);
            this.panel4.Location = new System.Drawing.Point(537, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 32);
            this.panel4.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(47, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "X1";
            // 
            // zoomUp
            // 
            this.zoomUp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zoomUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.zoomUp.Location = new System.Drawing.Point(110, 3);
            this.zoomUp.Name = "zoomUp";
            this.zoomUp.Size = new System.Drawing.Size(33, 26);
            this.zoomUp.TabIndex = 1;
            this.zoomUp.Text = "+";
            this.zoomUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.zoomUp.UseVisualStyleBackColor = true;
            this.zoomUp.Click += new System.EventHandler(this.zoomUp_Click);
            // 
            // zoomDown
            // 
            this.zoomDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zoomDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.zoomDown.Location = new System.Drawing.Point(3, 3);
            this.zoomDown.Name = "zoomDown";
            this.zoomDown.Size = new System.Drawing.Size(33, 26);
            this.zoomDown.TabIndex = 1;
            this.zoomDown.Text = "--";
            this.zoomDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.zoomDown.UseVisualStyleBackColor = true;
            this.zoomDown.Click += new System.EventHandler(this.zoomDown_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(689, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(223, 41);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator2,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 37);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::ABPaint.Properties.Resources.NewImage;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::ABPaint.Properties.Resources.Open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::ABPaint.Properties.Resources.SaveIcon;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::ABPaint.Properties.Resources.SaveAsIcon;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::ABPaint.Properties.Resources.Import;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.importToolStripMenuItem.Text = "Import...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::ABPaint.Properties.Resources.Export;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exportToolStripMenuItem.Text = "Export...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator5,
            this.redrawToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 37);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::ABPaint.Properties.Resources.CutIcon;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::ABPaint.Properties.Resources.Copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::ABPaint.Properties.Resources.Paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::ABPaint.Properties.Resources.TrashCan;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // redrawToolStripMenuItem
            // 
            this.redrawToolStripMenuItem.Image = global::ABPaint.Properties.Resources.RefreshIcon;
            this.redrawToolStripMenuItem.Name = "redrawToolStripMenuItem";
            this.redrawToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redrawToolStripMenuItem.Text = "Redraw";
            this.redrawToolStripMenuItem.Click += new System.EventHandler(this.redrawToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polygonTestToolStripMenuItem,
            this.cropToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 37);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // polygonTestToolStripMenuItem
            // 
            this.polygonTestToolStripMenuItem.Name = "polygonTestToolStripMenuItem";
            this.polygonTestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.polygonTestToolStripMenuItem.Text = "Polygon Test";
            this.polygonTestToolStripMenuItem.Click += new System.EventHandler(this.polygonTestToolStripMenuItem_Click);
            // 
            // cropToolStripMenuItem
            // 
            this.cropToolStripMenuItem.Image = global::ABPaint.Properties.Resources.Crop;
            this.cropToolStripMenuItem.Name = "cropToolStripMenuItem";
            this.cropToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cropToolStripMenuItem.Text = "Crop";
            this.cropToolStripMenuItem.Click += new System.EventHandler(this.cropToolStripMenuItem_Click);
            // 
            // appcenter
            // 
            this.appcenter.AutoScroll = true;
            this.appcenter.AutoSize = true;
            this.appcenter.Controls.Add(this.canvaspre);
            this.appcenter.Controls.Add(this.welcomeScreen);
            this.appcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appcenter.Location = new System.Drawing.Point(60, 41);
            this.appcenter.Name = "appcenter";
            this.appcenter.Size = new System.Drawing.Size(724, 471);
            this.appcenter.TabIndex = 3;
            this.appcenter.Click += new System.EventHandler(this.CanvasAnywhereClick);
            // 
            // canvaspre
            // 
            this.canvaspre.BackColor = System.Drawing.Color.Transparent;
            this.canvaspre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvaspre.Location = new System.Drawing.Point(150, 54);
            this.canvaspre.Name = "canvaspre";
            this.canvaspre.Size = new System.Drawing.Size(426, 303);
            this.canvaspre.TabIndex = 1;
            this.canvaspre.TabStop = false;
            this.canvaspre.Click += new System.EventHandler(this.CanvasAnywhereClick);
            this.canvaspre.Paint += new System.Windows.Forms.PaintEventHandler(this.canvaspre_Paint);
            this.canvaspre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvaspre_MouseDown);
            this.canvaspre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvaspre_MouseMove);
            this.canvaspre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvaspre_MouseUp);
            // 
            // welcomeScreen
            // 
            this.welcomeScreen.Controls.Add(this.label9);
            this.welcomeScreen.Controls.Add(this.label3);
            this.welcomeScreen.Location = new System.Drawing.Point(154, 55);
            this.welcomeScreen.Name = "welcomeScreen";
            this.welcomeScreen.Size = new System.Drawing.Size(404, 305);
            this.welcomeScreen.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Goudy Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(404, 264);
            this.label9.TabIndex = 0;
            this.label9.Text = resources.GetString("label9.Text");
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.CanvasAnywhereClick);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.CanvasAnywhereClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.properties);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 117);
            this.panel2.TabIndex = 2;
            // 
            // properties
            // 
            this.properties.Controls.Add(this.propertiesProps);
            this.properties.Controls.Add(this.propertiesLbl);
            this.properties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.properties.Location = new System.Drawing.Point(0, 0);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(645, 117);
            this.properties.TabIndex = 1;
            // 
            // propertiesProps
            // 
            this.propertiesProps.Controls.Add(this.label4);
            this.propertiesProps.Controls.Add(this.clrFill);
            this.propertiesProps.Controls.Add(this.label5);
            this.propertiesProps.Controls.Add(this.clrBord);
            this.propertiesProps.Controls.Add(this.label6);
            this.propertiesProps.Controls.Add(this.clrNorm);
            this.propertiesProps.Controls.Add(this.label7);
            this.propertiesProps.Controls.Add(this.txtBWidth);
            this.propertiesProps.Controls.Add(this.label8);
            this.propertiesProps.Controls.Add(this.txtBThick);
            this.propertiesProps.Controls.Add(this.label2);
            this.propertiesProps.Controls.Add(this.txtTText);
            this.propertiesProps.Controls.Add(this.label10);
            this.propertiesProps.Controls.Add(this.pnlFont);
            this.propertiesProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesProps.Location = new System.Drawing.Point(0, 23);
            this.propertiesProps.Name = "propertiesProps";
            this.propertiesProps.Size = new System.Drawing.Size(645, 94);
            this.propertiesProps.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fill Color:";
            // 
            // clrFill
            // 
            this.clrFill.BackColor = System.Drawing.Color.Black;
            this.clrFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clrFill.Location = new System.Drawing.Point(82, 3);
            this.clrFill.Name = "clrFill";
            this.clrFill.Size = new System.Drawing.Size(24, 22);
            this.clrFill.TabIndex = 1;
            this.clrFill.TabStop = false;
            this.clrFill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clrFill_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Border Color:";
            // 
            // clrBord
            // 
            this.clrBord.BackColor = System.Drawing.Color.Black;
            this.clrBord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clrBord.Location = new System.Drawing.Point(220, 3);
            this.clrBord.Name = "clrBord";
            this.clrBord.Size = new System.Drawing.Size(24, 22);
            this.clrBord.TabIndex = 1;
            this.clrBord.TabStop = false;
            this.clrBord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clrBord_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Color:";
            // 
            // clrNorm
            // 
            this.clrNorm.BackColor = System.Drawing.Color.Black;
            this.clrNorm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clrNorm.Location = new System.Drawing.Point(306, 3);
            this.clrNorm.Name = "clrNorm";
            this.clrNorm.Size = new System.Drawing.Size(24, 22);
            this.clrNorm.TabIndex = 1;
            this.clrNorm.TabStop = false;
            this.clrNorm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clrNorm_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Border Size:";
            // 
            // txtBWidth
            // 
            this.txtBWidth.Location = new System.Drawing.Point(438, 3);
            this.txtBWidth.Name = "txtBWidth";
            this.txtBWidth.Size = new System.Drawing.Size(51, 20);
            this.txtBWidth.TabIndex = 2;
            this.txtBWidth.Text = "10";
            this.txtBWidth.TextChanged += new System.EventHandler(this.txtBWidth_TextChanged);
            this.txtBWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnlyKeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(495, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thickness:";
            // 
            // txtBThick
            // 
            this.txtBThick.Location = new System.Drawing.Point(585, 3);
            this.txtBThick.Name = "txtBThick";
            this.txtBThick.Size = new System.Drawing.Size(51, 20);
            this.txtBThick.TabIndex = 2;
            this.txtBThick.Text = "20";
            this.txtBThick.TextChanged += new System.EventHandler(this.txtBThick_TextChanged);
            this.txtBThick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnlyKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Text:";
            // 
            // txtTText
            // 
            this.txtTText.Location = new System.Drawing.Point(52, 31);
            this.txtTText.Name = "txtTText";
            this.txtTText.Size = new System.Drawing.Size(100, 20);
            this.txtTText.TabIndex = 3;
            this.txtTText.TextChanged += new System.EventHandler(this.txtTText_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Font:";
            // 
            // pnlFont
            // 
            this.pnlFont.BackColor = System.Drawing.Color.Gray;
            this.pnlFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFont.Controls.Add(this.cmbFont);
            this.pnlFont.Controls.Add(this.cmbSize);
            this.pnlFont.Controls.Add(this.btnBold);
            this.pnlFont.Controls.Add(this.btnItl);
            this.pnlFont.Controls.Add(this.btnUline);
            this.pnlFont.ForeColor = System.Drawing.Color.Black;
            this.pnlFont.Location = new System.Drawing.Point(210, 31);
            this.pnlFont.Name = "pnlFont";
            this.pnlFont.Size = new System.Drawing.Size(200, 58);
            this.pnlFont.TabIndex = 4;
            // 
            // cmbFont
            // 
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(3, 3);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(121, 21);
            this.cmbFont.TabIndex = 0;
            this.cmbFont.Text = "Microsoft Sans Serif";
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "10.5",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cmbSize.Location = new System.Drawing.Point(130, 3);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(47, 21);
            this.cmbSize.TabIndex = 0;
            this.cmbSize.Text = "12";
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            this.cmbSize.TextUpdate += new System.EventHandler(this.cmbSize_TextUpdate);
            this.cmbSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnlyKeyPress);
            // 
            // btnBold
            // 
            this.btnBold.Image = global::ABPaint.Properties.Resources.bold;
            this.btnBold.Location = new System.Drawing.Point(3, 30);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(30, 23);
            this.btnBold.TabIndex = 1;
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItl
            // 
            this.btnItl.Image = global::ABPaint.Properties.Resources.italic;
            this.btnItl.Location = new System.Drawing.Point(39, 30);
            this.btnItl.Name = "btnItl";
            this.btnItl.Size = new System.Drawing.Size(30, 23);
            this.btnItl.TabIndex = 1;
            this.btnItl.UseVisualStyleBackColor = true;
            this.btnItl.Click += new System.EventHandler(this.btnItl_Click);
            // 
            // btnUline
            // 
            this.btnUline.Image = global::ABPaint.Properties.Resources.underline;
            this.btnUline.Location = new System.Drawing.Point(75, 30);
            this.btnUline.Name = "btnUline";
            this.btnUline.Size = new System.Drawing.Size(30, 23);
            this.btnUline.TabIndex = 1;
            this.btnUline.UseVisualStyleBackColor = true;
            this.btnUline.Click += new System.EventHandler(this.btnUline_Click);
            // 
            // propertiesLbl
            // 
            this.propertiesLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertiesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesLbl.Location = new System.Drawing.Point(0, 0);
            this.propertiesLbl.Name = "propertiesLbl";
            this.propertiesLbl.Size = new System.Drawing.Size(645, 23);
            this.propertiesLbl.TabIndex = 0;
            this.propertiesLbl.Text = "<ERROR>";
            this.propertiesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cl8);
            this.panel3.Controls.Add(this.cl4);
            this.panel3.Controls.Add(this.cl7);
            this.panel3.Controls.Add(this.cl3);
            this.panel3.Controls.Add(this.cl6);
            this.panel3.Controls.Add(this.cl5);
            this.panel3.Controls.Add(this.cl2);
            this.panel3.Controls.Add(this.cl1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(645, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 117);
            this.panel3.TabIndex = 0;
            // 
            // cl8
            // 
            this.cl8.BackColor = System.Drawing.Color.Blue;
            this.cl8.Location = new System.Drawing.Point(104, 51);
            this.cl8.Name = "cl8";
            this.cl8.Size = new System.Drawing.Size(24, 20);
            this.cl8.TabIndex = 2;
            this.cl8.ToSelect = 8;
            // 
            // cl4
            // 
            this.cl4.BackColor = System.Drawing.Color.Black;
            this.cl4.Location = new System.Drawing.Point(104, 26);
            this.cl4.Name = "cl4";
            this.cl4.Size = new System.Drawing.Size(24, 20);
            this.cl4.TabIndex = 2;
            this.cl4.ToSelect = 4;
            // 
            // cl7
            // 
            this.cl7.BackColor = System.Drawing.Color.Green;
            this.cl7.Location = new System.Drawing.Point(74, 51);
            this.cl7.Name = "cl7";
            this.cl7.Size = new System.Drawing.Size(24, 20);
            this.cl7.TabIndex = 2;
            this.cl7.ToSelect = 7;
            // 
            // cl3
            // 
            this.cl3.BackColor = System.Drawing.Color.Black;
            this.cl3.Location = new System.Drawing.Point(74, 26);
            this.cl3.Name = "cl3";
            this.cl3.Size = new System.Drawing.Size(24, 20);
            this.cl3.TabIndex = 2;
            this.cl3.ToSelect = 3;
            // 
            // cl6
            // 
            this.cl6.BackColor = System.Drawing.Color.Red;
            this.cl6.Location = new System.Drawing.Point(44, 51);
            this.cl6.Name = "cl6";
            this.cl6.Size = new System.Drawing.Size(24, 20);
            this.cl6.TabIndex = 2;
            this.cl6.ToSelect = 6;
            // 
            // cl5
            // 
            this.cl5.BackColor = System.Drawing.Color.DarkGray;
            this.cl5.Location = new System.Drawing.Point(14, 51);
            this.cl5.Name = "cl5";
            this.cl5.Size = new System.Drawing.Size(24, 20);
            this.cl5.TabIndex = 2;
            this.cl5.ToSelect = 5;
            // 
            // cl2
            // 
            this.cl2.BackColor = System.Drawing.Color.Black;
            this.cl2.Location = new System.Drawing.Point(44, 26);
            this.cl2.Name = "cl2";
            this.cl2.Size = new System.Drawing.Size(24, 20);
            this.cl2.TabIndex = 2;
            this.cl2.ToSelect = 2;
            // 
            // cl1
            // 
            this.cl1.BackColor = System.Drawing.Color.Black;
            this.cl1.Location = new System.Drawing.Point(14, 26);
            this.cl1.Name = "cl1";
            this.cl1.Size = new System.Drawing.Size(24, 20);
            this.cl1.TabIndex = 2;
            this.cl1.ToSelect = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color:";
            // 
            // movingRefresh
            // 
            this.movingRefresh.Interval = 10;
            this.movingRefresh.Tick += new System.EventHandler(this.movingRefresh_Tick);
            // 
            // openFileDialogOPEN
            // 
            this.openFileDialogOPEN.FileName = "*";
            this.openFileDialogOPEN.Filter = "ABPaint File (*.abpt)|*.abpt|All files|*.*";
            this.openFileDialogOPEN.Title = "Open...";
            // 
            // saveFileDialogSAVE
            // 
            this.saveFileDialogSAVE.FileName = "*";
            this.saveFileDialogSAVE.Filter = "ABPaint File (*.abpt)|*.abpt|All files|*.*";
            this.saveFileDialogSAVE.Title = "Save...";
            // 
            // openFileDialogIMPORT
            // 
            this.openFileDialogIMPORT.FileName = "*";
            this.openFileDialogIMPORT.Filter = resources.GetString("openFileDialogIMPORT.Filter");
            this.openFileDialogIMPORT.Title = "Import...";
            // 
            // saveFileDialogEXPORT
            // 
            this.saveFileDialogEXPORT.FileName = "*";
            this.saveFileDialogEXPORT.Filter = resources.GetString("saveFileDialogEXPORT.Filter");
            this.saveFileDialogEXPORT.Title = "Export...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 629);
            this.Controls.Add(this.appcenter);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ABPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolbox.ResumeLayout(false);
            this.toolCursorN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timgCursorN)).EndInit();
            this.toolCursorS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timgCursorS)).EndInit();
            this.toolPencil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timgPencil)).EndInit();
            this.toolBrush.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timgBrush)).EndInit();
            this.toolRect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timgRect)).EndInit();
            this.toolElli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timgElli)).EndInit();
            this.toolLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timgLine)).EndInit();
            this.toolFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timgFill)).EndInit();
            this.toolText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timgText)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.appcenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvaspre)).EndInit();
            this.welcomeScreen.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.properties.ResumeLayout(false);
            this.propertiesProps.ResumeLayout(false);
            this.propertiesProps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clrFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clrBord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clrNorm)).EndInit();
            this.pnlFont.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.ComboBox cmbSize;
        public ABPaint.CanvasBox canvaspre;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Panel appcenter;
        public System.Windows.Forms.Timer movingRefresh;
        public System.Windows.Forms.FlowLayoutPanel toolbox;
        public System.Windows.Forms.Panel toolCursorN;
        public System.Windows.Forms.Panel toolCursorS;
        public System.Windows.Forms.PictureBox timgCursorN;
        public System.Windows.Forms.PictureBox timgCursorS;
        public System.Windows.Forms.Panel toolPencil;
        public System.Windows.Forms.PictureBox timgPencil;
        public System.Windows.Forms.Panel toolBrush;
        public System.Windows.Forms.PictureBox timgBrush;
        public System.Windows.Forms.Panel toolRect;
        public System.Windows.Forms.PictureBox timgRect;
        public System.Windows.Forms.Panel toolElli;
        public System.Windows.Forms.PictureBox timgElli;
        public System.Windows.Forms.Panel toolLine;
        public System.Windows.Forms.PictureBox timgLine;
        public System.Windows.Forms.Panel toolFill;
        public System.Windows.Forms.PictureBox timgFill;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel toolText;
        public System.Windows.Forms.PictureBox timgText;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel properties;
        public System.Windows.Forms.Label propertiesLbl;
        public System.Windows.Forms.FlowLayoutPanel propertiesProps;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox clrFill;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox clrBord;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox clrNorm;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtBWidth;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtBThick;
        public System.Windows.Forms.Panel welcomeScreen;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTText;
        public System.Windows.Forms.FlowLayoutPanel pnlFont;
        public System.Windows.Forms.ComboBox cmbFont;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnBold;
        public System.Windows.Forms.Button btnItl;
        public System.Windows.Forms.Button btnUline;
        public RightMenu.ColorBox cl1;
        public RightMenu.ColorBox cl4;
        public RightMenu.ColorBox cl3;
        public RightMenu.ColorBox cl2;
        public RightMenu.ColorBox cl8;
        public RightMenu.ColorBox cl7;
        public RightMenu.ColorBox cl6;
        public RightMenu.ColorBox cl5;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button zoomDown;
        public System.Windows.Forms.Button zoomUp;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        public System.Windows.Forms.OpenFileDialog openFileDialogOPEN;
        public System.Windows.Forms.SaveFileDialog saveFileDialogSAVE;
        public System.Windows.Forms.OpenFileDialog openFileDialogIMPORT;
        public System.Windows.Forms.SaveFileDialog saveFileDialogEXPORT;
        public System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripMenuItem redrawToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem polygonTestToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cropToolStripMenuItem;
    }
}

