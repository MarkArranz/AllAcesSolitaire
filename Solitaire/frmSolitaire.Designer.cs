namespace Solitaire
{
    partial class AllAcesSolitaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllAcesSolitaire));
            this.pbDeck = new System.Windows.Forms.PictureBox();
            this.pbDiscardStack = new System.Windows.Forms.PictureBox();
            this.imgListOrderedDeck = new System.Windows.Forms.ImageList(this.components);
            this.imgListCardBack = new System.Windows.Forms.ImageList(this.components);
            this.testBox0 = new System.Windows.Forms.TextBox();
            this.testBox1 = new System.Windows.Forms.TextBox();
            this.testBox2 = new System.Windows.Forms.TextBox();
            this.testBox3 = new System.Windows.Forms.TextBox();
            this.testBox4 = new System.Windows.Forms.TextBox();
            this.testBox5 = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleStackBase3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleStackBase2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleStackBase1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleStackBase0 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valueBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscardStack)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDeck
            // 
            this.pbDeck.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbDeck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbDeck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDeck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeck.Location = new System.Drawing.Point(12, 48);
            this.pbDeck.Name = "pbDeck";
            this.pbDeck.Size = new System.Drawing.Size(90, 140);
            this.pbDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDeck.TabIndex = 0;
            this.pbDeck.TabStop = false;
            this.pbDeck.Click += new System.EventHandler(this.pbDeck_Click);
            // 
            // pbDiscardStack
            // 
            this.pbDiscardStack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDiscardStack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbDiscardStack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbDiscardStack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDiscardStack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDiscardStack.Location = new System.Drawing.Point(566, 48);
            this.pbDiscardStack.Name = "pbDiscardStack";
            this.pbDiscardStack.Size = new System.Drawing.Size(90, 140);
            this.pbDiscardStack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDiscardStack.TabIndex = 5;
            this.pbDiscardStack.TabStop = false;
            this.pbDiscardStack.Click += new System.EventHandler(this.pbDiscardPile_Click);
            // 
            // imgListOrderedDeck
            // 
            this.imgListOrderedDeck.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListOrderedDeck.ImageStream")));
            this.imgListOrderedDeck.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListOrderedDeck.Images.SetKeyName(0, "club2.png");
            this.imgListOrderedDeck.Images.SetKeyName(1, "club3.png");
            this.imgListOrderedDeck.Images.SetKeyName(2, "club4.png");
            this.imgListOrderedDeck.Images.SetKeyName(3, "club5.png");
            this.imgListOrderedDeck.Images.SetKeyName(4, "club6.png");
            this.imgListOrderedDeck.Images.SetKeyName(5, "club7.png");
            this.imgListOrderedDeck.Images.SetKeyName(6, "club8.png");
            this.imgListOrderedDeck.Images.SetKeyName(7, "club9.png");
            this.imgListOrderedDeck.Images.SetKeyName(8, "club10.png");
            this.imgListOrderedDeck.Images.SetKeyName(9, "clubJ.png");
            this.imgListOrderedDeck.Images.SetKeyName(10, "clubQ.png");
            this.imgListOrderedDeck.Images.SetKeyName(11, "clubK.png");
            this.imgListOrderedDeck.Images.SetKeyName(12, "clubA.png");
            this.imgListOrderedDeck.Images.SetKeyName(13, "dia2.png");
            this.imgListOrderedDeck.Images.SetKeyName(14, "dia3.png");
            this.imgListOrderedDeck.Images.SetKeyName(15, "dia4.png");
            this.imgListOrderedDeck.Images.SetKeyName(16, "dia5.png");
            this.imgListOrderedDeck.Images.SetKeyName(17, "dia6.png");
            this.imgListOrderedDeck.Images.SetKeyName(18, "dia7.png");
            this.imgListOrderedDeck.Images.SetKeyName(19, "dia8.png");
            this.imgListOrderedDeck.Images.SetKeyName(20, "dia9.png");
            this.imgListOrderedDeck.Images.SetKeyName(21, "dia10.png");
            this.imgListOrderedDeck.Images.SetKeyName(22, "diaJ.png");
            this.imgListOrderedDeck.Images.SetKeyName(23, "diaQ.png");
            this.imgListOrderedDeck.Images.SetKeyName(24, "diaK.png");
            this.imgListOrderedDeck.Images.SetKeyName(25, "diaA.png");
            this.imgListOrderedDeck.Images.SetKeyName(26, "heart2.png");
            this.imgListOrderedDeck.Images.SetKeyName(27, "heart3.png");
            this.imgListOrderedDeck.Images.SetKeyName(28, "heart4.png");
            this.imgListOrderedDeck.Images.SetKeyName(29, "heart5.png");
            this.imgListOrderedDeck.Images.SetKeyName(30, "heart6.png");
            this.imgListOrderedDeck.Images.SetKeyName(31, "heart7.png");
            this.imgListOrderedDeck.Images.SetKeyName(32, "heart8.png");
            this.imgListOrderedDeck.Images.SetKeyName(33, "heart9.png");
            this.imgListOrderedDeck.Images.SetKeyName(34, "heart10.png");
            this.imgListOrderedDeck.Images.SetKeyName(35, "heartJ.png");
            this.imgListOrderedDeck.Images.SetKeyName(36, "heartQ.png");
            this.imgListOrderedDeck.Images.SetKeyName(37, "heartK.png");
            this.imgListOrderedDeck.Images.SetKeyName(38, "heartA.png");
            this.imgListOrderedDeck.Images.SetKeyName(39, "spade2.png");
            this.imgListOrderedDeck.Images.SetKeyName(40, "spade3.png");
            this.imgListOrderedDeck.Images.SetKeyName(41, "spade4.png");
            this.imgListOrderedDeck.Images.SetKeyName(42, "spade5.png");
            this.imgListOrderedDeck.Images.SetKeyName(43, "spade6.png");
            this.imgListOrderedDeck.Images.SetKeyName(44, "spade7.png");
            this.imgListOrderedDeck.Images.SetKeyName(45, "spade8.png");
            this.imgListOrderedDeck.Images.SetKeyName(46, "spade9.png");
            this.imgListOrderedDeck.Images.SetKeyName(47, "spade10.png");
            this.imgListOrderedDeck.Images.SetKeyName(48, "spadeJ.png");
            this.imgListOrderedDeck.Images.SetKeyName(49, "spadeQ.png");
            this.imgListOrderedDeck.Images.SetKeyName(50, "spadeK.png");
            this.imgListOrderedDeck.Images.SetKeyName(51, "spadeA.png");
            // 
            // imgListCardBack
            // 
            this.imgListCardBack.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListCardBack.ImageStream")));
            this.imgListCardBack.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListCardBack.Images.SetKeyName(0, "cardbackRed.png");
            this.imgListCardBack.Images.SetKeyName(1, "cardbackBlue.png");
            // 
            // testBox0
            // 
            this.testBox0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.testBox0.Location = new System.Drawing.Point(131, 120);
            this.testBox0.Name = "testBox0";
            this.testBox0.Size = new System.Drawing.Size(91, 20);
            this.testBox0.TabIndex = 7;
            this.testBox0.Visible = false;
            // 
            // testBox1
            // 
            this.testBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.testBox1.Location = new System.Drawing.Point(236, 120);
            this.testBox1.Name = "testBox1";
            this.testBox1.Size = new System.Drawing.Size(91, 20);
            this.testBox1.TabIndex = 8;
            this.testBox1.Visible = false;
            // 
            // testBox2
            // 
            this.testBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.testBox2.Location = new System.Drawing.Point(341, 120);
            this.testBox2.Name = "testBox2";
            this.testBox2.Size = new System.Drawing.Size(91, 20);
            this.testBox2.TabIndex = 9;
            this.testBox2.Visible = false;
            // 
            // testBox3
            // 
            this.testBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.testBox3.Location = new System.Drawing.Point(446, 120);
            this.testBox3.Name = "testBox3";
            this.testBox3.Size = new System.Drawing.Size(91, 20);
            this.testBox3.TabIndex = 10;
            this.testBox3.Visible = false;
            // 
            // testBox4
            // 
            this.testBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.testBox4.Location = new System.Drawing.Point(236, 78);
            this.testBox4.Name = "testBox4";
            this.testBox4.Size = new System.Drawing.Size(196, 20);
            this.testBox4.TabIndex = 11;
            this.testBox4.Visible = false;
            // 
            // testBox5
            // 
            this.testBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testBox5.Location = new System.Drawing.Point(566, 194);
            this.testBox5.Name = "testBox5";
            this.testBox5.Size = new System.Drawing.Size(90, 20);
            this.testBox5.TabIndex = 12;
            this.testBox5.Visible = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleStackBase3,
            this.rectangleStackBase2,
            this.rectangleStackBase1,
            this.rectangleStackBase0});
            this.shapeContainer1.Size = new System.Drawing.Size(668, 403);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleStackBase3
            // 
            this.rectangleStackBase3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rectangleStackBase3.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.rectangleStackBase3.BorderWidth = 5;
            this.rectangleStackBase3.CornerRadius = 3;
            this.rectangleStackBase3.Location = new System.Drawing.Point(446, 150);
            this.rectangleStackBase3.Name = "rectangleStackBase3";
            this.rectangleStackBase3.Size = new System.Drawing.Size(90, 140);
            this.rectangleStackBase3.Click += new System.EventHandler(this.pbCardImage_Click);
            this.rectangleStackBase3.DoubleClick += new System.EventHandler(this.pbCardImage_DoubleClick);
            // 
            // rectangleStackBase2
            // 
            this.rectangleStackBase2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rectangleStackBase2.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.rectangleStackBase2.BorderWidth = 5;
            this.rectangleStackBase2.CornerRadius = 3;
            this.rectangleStackBase2.Location = new System.Drawing.Point(341, 150);
            this.rectangleStackBase2.Name = "rectangleStackBase2";
            this.rectangleStackBase2.Size = new System.Drawing.Size(90, 140);
            this.rectangleStackBase2.Click += new System.EventHandler(this.pbCardImage_Click);
            this.rectangleStackBase2.DoubleClick += new System.EventHandler(this.pbCardImage_DoubleClick);
            // 
            // rectangleStackBase1
            // 
            this.rectangleStackBase1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rectangleStackBase1.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.rectangleStackBase1.BorderWidth = 5;
            this.rectangleStackBase1.CornerRadius = 3;
            this.rectangleStackBase1.Location = new System.Drawing.Point(236, 150);
            this.rectangleStackBase1.Name = "rectangleStackBase1";
            this.rectangleStackBase1.Size = new System.Drawing.Size(90, 140);
            this.rectangleStackBase1.Click += new System.EventHandler(this.pbCardImage_Click);
            this.rectangleStackBase1.DoubleClick += new System.EventHandler(this.pbCardImage_DoubleClick);
            // 
            // rectangleStackBase0
            // 
            this.rectangleStackBase0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rectangleStackBase0.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.rectangleStackBase0.BorderWidth = 5;
            this.rectangleStackBase0.CornerRadius = 3;
            this.rectangleStackBase0.Location = new System.Drawing.Point(131, 150);
            this.rectangleStackBase0.Name = "rectangleStackBase0";
            this.rectangleStackBase0.Size = new System.Drawing.Size(90, 140);
            this.rectangleStackBase0.Click += new System.EventHandler(this.pbCardImage_Click);
            this.rectangleStackBase0.DoubleClick += new System.EventHandler(this.pbCardImage_DoubleClick);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(668, 24);
            this.MenuStrip.TabIndex = 17;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valueBoxesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // valueBoxesToolStripMenuItem
            // 
            this.valueBoxesToolStripMenuItem.CheckOnClick = true;
            this.valueBoxesToolStripMenuItem.Name = "valueBoxesToolStripMenuItem";
            this.valueBoxesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.valueBoxesToolStripMenuItem.Text = "Debug Boxes";
            this.valueBoxesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.valueBoxesToolStripMenuItem_CheckedChanged);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardBackToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // cardBackToolStripMenuItem
            // 
            this.cardBackToolStripMenuItem.Enabled = false;
            this.cardBackToolStripMenuItem.Name = "cardBackToolStripMenuItem";
            this.cardBackToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.cardBackToolStripMenuItem.Text = "Change Card Back Design";
            this.cardBackToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // testBox6
            // 
            this.testBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testBox6.Location = new System.Drawing.Point(12, 194);
            this.testBox6.Name = "testBox6";
            this.testBox6.Size = new System.Drawing.Size(90, 20);
            this.testBox6.TabIndex = 18;
            this.testBox6.Visible = false;
            // 
            // AllAcesSolitaire
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Solitaire.Properties.Resources.suited_poker_table_felt_400x300;
            this.ClientSize = new System.Drawing.Size(668, 403);
            this.Controls.Add(this.testBox6);
            this.Controls.Add(this.testBox5);
            this.Controls.Add(this.testBox4);
            this.Controls.Add(this.testBox3);
            this.Controls.Add(this.testBox2);
            this.Controls.Add(this.testBox1);
            this.Controls.Add(this.testBox0);
            this.Controls.Add(this.pbDiscardStack);
            this.Controls.Add(this.pbDeck);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.shapeContainer1);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "AllAcesSolitaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Aces Solitaire";
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscardStack)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDeck;
        private System.Windows.Forms.PictureBox pbDiscardStack;
        private System.Windows.Forms.ImageList imgListOrderedDeck;
        private System.Windows.Forms.ImageList imgListCardBack;
        private System.Windows.Forms.TextBox testBox0;
        private System.Windows.Forms.TextBox testBox1;
        private System.Windows.Forms.TextBox testBox2;
        private System.Windows.Forms.TextBox testBox3;
        private System.Windows.Forms.TextBox testBox4;
        private System.Windows.Forms.TextBox testBox5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleStackBase3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleStackBase2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleStackBase1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleStackBase0;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valueBoxesToolStripMenuItem;
        private System.Windows.Forms.TextBox testBox6;
    }
}