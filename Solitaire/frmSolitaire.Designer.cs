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
            this.pbPosition1 = new System.Windows.Forms.PictureBox();
            this.pbPosition2 = new System.Windows.Forms.PictureBox();
            this.pbPosition3 = new System.Windows.Forms.PictureBox();
            this.pbPosition4 = new System.Windows.Forms.PictureBox();
            this.pbDiscardPile = new System.Windows.Forms.PictureBox();
            this.imgListOrderedDeck = new System.Windows.Forms.ImageList(this.components);
            this.btnNewGame = new System.Windows.Forms.Button();
            this.imgListCardBack = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscardPile)).BeginInit();
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
            // pbPosition1
            // 
            this.pbPosition1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPosition1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPosition1.Location = new System.Drawing.Point(149, 82);
            this.pbPosition1.Name = "pbPosition1";
            this.pbPosition1.Size = new System.Drawing.Size(90, 140);
            this.pbPosition1.TabIndex = 1;
            this.pbPosition1.TabStop = false;
            // 
            // pbPosition2
            // 
            this.pbPosition2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPosition2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPosition2.Location = new System.Drawing.Point(245, 82);
            this.pbPosition2.Name = "pbPosition2";
            this.pbPosition2.Size = new System.Drawing.Size(90, 140);
            this.pbPosition2.TabIndex = 2;
            this.pbPosition2.TabStop = false;
            // 
            // pbPosition3
            // 
            this.pbPosition3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPosition3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPosition3.Location = new System.Drawing.Point(341, 82);
            this.pbPosition3.Name = "pbPosition3";
            this.pbPosition3.Size = new System.Drawing.Size(90, 140);
            this.pbPosition3.TabIndex = 3;
            this.pbPosition3.TabStop = false;
            // 
            // pbPosition4
            // 
            this.pbPosition4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPosition4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPosition4.Location = new System.Drawing.Point(437, 82);
            this.pbPosition4.Name = "pbPosition4";
            this.pbPosition4.Size = new System.Drawing.Size(90, 140);
            this.pbPosition4.TabIndex = 4;
            this.pbPosition4.TabStop = false;
            // 
            // pbDiscardPile
            // 
            this.pbDiscardPile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDiscardPile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDiscardPile.Location = new System.Drawing.Point(574, 233);
            this.pbDiscardPile.Name = "pbDiscardPile";
            this.pbDiscardPile.Size = new System.Drawing.Size(90, 140);
            this.pbDiscardPile.TabIndex = 5;
            this.pbDiscardPile.TabStop = false;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(341, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(437, 233);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 20);
            this.textBox4.TabIndex = 10;
            // 
            // AllAcesSolitaire
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 385);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pbDiscardPile);
            this.Controls.Add(this.pbPosition4);
            this.Controls.Add(this.pbPosition3);
            this.Controls.Add(this.pbPosition2);
            this.Controls.Add(this.pbPosition1);
            this.Controls.Add(this.pbDeck);
            this.Name = "AllAcesSolitaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Aces Solitaire";
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscardPile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDeck;
        private System.Windows.Forms.PictureBox pbPosition1;
        private System.Windows.Forms.PictureBox pbPosition2;
        private System.Windows.Forms.PictureBox pbPosition3;
        private System.Windows.Forms.PictureBox pbPosition4;
        private System.Windows.Forms.PictureBox pbDiscardPile;
        private System.Windows.Forms.ImageList imgListOrderedDeck;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ImageList imgListCardBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

