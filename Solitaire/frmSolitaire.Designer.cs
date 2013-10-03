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
            this.pbStack0 = new System.Windows.Forms.PictureBox();
            this.pbStack1 = new System.Windows.Forms.PictureBox();
            this.pbStack2 = new System.Windows.Forms.PictureBox();
            this.pbStack3 = new System.Windows.Forms.PictureBox();
            this.pbDiscardStack = new System.Windows.Forms.PictureBox();
            this.imgListOrderedDeck = new System.Windows.Forms.ImageList(this.components);
            this.btnNewGame = new System.Windows.Forms.Button();
            this.imgListCardBack = new System.Windows.Forms.ImageList(this.components);
            this.testBox0 = new System.Windows.Forms.TextBox();
            this.testBox1 = new System.Windows.Forms.TextBox();
            this.testBox2 = new System.Windows.Forms.TextBox();
            this.testBox3 = new System.Windows.Forms.TextBox();
            this.texsBox4 = new System.Windows.Forms.TextBox();
            this.testBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscardStack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDeck
            // 
            this.pbDeck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDeck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeck.Location = new System.Drawing.Point(12, 12);
            this.pbDeck.Name = "pbDeck";
            this.pbDeck.Size = new System.Drawing.Size(90, 140);
            this.pbDeck.TabIndex = 0;
            this.pbDeck.TabStop = false;
            this.pbDeck.Click += new System.EventHandler(this.pbDeck_Click);
            // 
            // pbStack0
            // 
            this.pbStack0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStack0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStack0.Location = new System.Drawing.Point(149, 82);
            this.pbStack0.Name = "pbStack0";
            this.pbStack0.Size = new System.Drawing.Size(90, 140);
            this.pbStack0.TabIndex = 1;
            this.pbStack0.TabStop = false;
            this.pbStack0.Click += new System.EventHandler(this.pbStack_Click);
            this.pbStack0.DoubleClick += new System.EventHandler(this.pbStack_DoubleClick);
            // 
            // pbStack1
            // 
            this.pbStack1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStack1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStack1.Location = new System.Drawing.Point(245, 82);
            this.pbStack1.Name = "pbStack1";
            this.pbStack1.Size = new System.Drawing.Size(90, 140);
            this.pbStack1.TabIndex = 2;
            this.pbStack1.TabStop = false;
            this.pbStack1.Click += new System.EventHandler(this.pbStack_Click);
            this.pbStack1.DoubleClick += new System.EventHandler(this.pbStack_DoubleClick);
            // 
            // pbStack2
            // 
            this.pbStack2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStack2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStack2.Location = new System.Drawing.Point(341, 82);
            this.pbStack2.Name = "pbStack2";
            this.pbStack2.Size = new System.Drawing.Size(90, 140);
            this.pbStack2.TabIndex = 3;
            this.pbStack2.TabStop = false;
            this.pbStack2.Click += new System.EventHandler(this.pbStack_Click);
            this.pbStack2.DoubleClick += new System.EventHandler(this.pbStack_DoubleClick);
            // 
            // pbStack3
            // 
            this.pbStack3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStack3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStack3.Location = new System.Drawing.Point(437, 82);
            this.pbStack3.Name = "pbStack3";
            this.pbStack3.Size = new System.Drawing.Size(90, 140);
            this.pbStack3.TabIndex = 4;
            this.pbStack3.TabStop = false;
            this.pbStack3.Click += new System.EventHandler(this.pbStack_Click);
            this.pbStack3.DoubleClick += new System.EventHandler(this.pbStack_DoubleClick);
            // 
            // pbDiscardStack
            // 
            this.pbDiscardStack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDiscardStack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDiscardStack.Location = new System.Drawing.Point(574, 233);
            this.pbDiscardStack.Name = "pbDiscardStack";
            this.pbDiscardStack.Size = new System.Drawing.Size(90, 140);
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
            // btnNewGame
            // 
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.Location = new System.Drawing.Point(12, 340);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(90, 33);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "&New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // imgListCardBack
            // 
            this.imgListCardBack.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListCardBack.ImageStream")));
            this.imgListCardBack.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListCardBack.Images.SetKeyName(0, "cardbackBlue.png");
            this.imgListCardBack.Images.SetKeyName(1, "cardbackRed.png");
            // 
            // testBox0
            // 
            this.testBox0.Location = new System.Drawing.Point(149, 56);
            this.testBox0.Name = "testBox0";
            this.testBox0.Size = new System.Drawing.Size(90, 20);
            this.testBox0.TabIndex = 7;
            // 
            // testBox1
            // 
            this.testBox1.Location = new System.Drawing.Point(245, 56);
            this.testBox1.Name = "testBox1";
            this.testBox1.Size = new System.Drawing.Size(90, 20);
            this.testBox1.TabIndex = 8;
            // 
            // testBox2
            // 
            this.testBox2.Location = new System.Drawing.Point(341, 56);
            this.testBox2.Name = "testBox2";
            this.testBox2.Size = new System.Drawing.Size(90, 20);
            this.testBox2.TabIndex = 9;
            // 
            // testBox3
            // 
            this.testBox3.Location = new System.Drawing.Point(437, 56);
            this.testBox3.Name = "testBox3";
            this.testBox3.Size = new System.Drawing.Size(90, 20);
            this.testBox3.TabIndex = 10;
            // 
            // texsBox4
            // 
            this.texsBox4.Location = new System.Drawing.Point(245, 12);
            this.texsBox4.Name = "texsBox4";
            this.texsBox4.Size = new System.Drawing.Size(186, 20);
            this.texsBox4.TabIndex = 11;
            // 
            // testBox5
            // 
            this.testBox5.Location = new System.Drawing.Point(574, 202);
            this.testBox5.Name = "testBox5";
            this.testBox5.Size = new System.Drawing.Size(90, 20);
            this.testBox5.TabIndex = 12;
            // 
            // AllAcesSolitaire
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 385);
            this.Controls.Add(this.testBox5);
            this.Controls.Add(this.texsBox4);
            this.Controls.Add(this.testBox3);
            this.Controls.Add(this.testBox2);
            this.Controls.Add(this.testBox1);
            this.Controls.Add(this.testBox0);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pbDiscardStack);
            this.Controls.Add(this.pbStack3);
            this.Controls.Add(this.pbStack2);
            this.Controls.Add(this.pbStack1);
            this.Controls.Add(this.pbStack0);
            this.Controls.Add(this.pbDeck);
            this.Name = "AllAcesSolitaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Aces Solitaire";
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscardStack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDeck;
        private System.Windows.Forms.PictureBox pbStack0;
        private System.Windows.Forms.PictureBox pbStack1;
        private System.Windows.Forms.PictureBox pbStack2;
        private System.Windows.Forms.PictureBox pbStack3;
        private System.Windows.Forms.PictureBox pbDiscardStack;
        private System.Windows.Forms.ImageList imgListOrderedDeck;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ImageList imgListCardBack;
        private System.Windows.Forms.TextBox testBox0;
        private System.Windows.Forms.TextBox testBox1;
        private System.Windows.Forms.TextBox testBox2;
        private System.Windows.Forms.TextBox testBox3;
        private System.Windows.Forms.TextBox texsBox4;
        private System.Windows.Forms.TextBox testBox5;
    }
}