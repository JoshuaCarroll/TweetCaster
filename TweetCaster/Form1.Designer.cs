namespace TweetCaster
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
            this.pnlTweet = new System.Windows.Forms.Panel();
            this.txtTweet = new System.Windows.Forms.Label();
            this.lblScreenName = new System.Windows.Forms.Label();
            this.pnlCurtain = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.txtAutoRotateCount = new System.Windows.Forms.TextBox();
            this.chkAutoRotate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPromotionTweet = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTweetQueue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTweetQueueCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTweetQueue = new System.Windows.Forms.TextBox();
            this.imgTweet = new System.Windows.Forms.PictureBox();
            this.timerShowTweetBox = new System.Windows.Forms.Timer(this.components);
            this.timerHideTweetBox = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTweet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTweet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTweet
            // 
            this.pnlTweet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTweet.BackColor = System.Drawing.Color.Lime;
            this.pnlTweet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTweet.BackgroundImage")));
            this.pnlTweet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTweet.Controls.Add(this.pnlCurtain);
            this.pnlTweet.Controls.Add(this.imgTweet);
            this.pnlTweet.Controls.Add(this.txtTweet);
            this.pnlTweet.Controls.Add(this.lblScreenName);
            this.pnlTweet.Controls.Add(this.lblName);
            this.pnlTweet.Controls.Add(this.imgAvatar);
            this.pnlTweet.Location = new System.Drawing.Point(12, 12);
            this.pnlTweet.Name = "pnlTweet";
            this.pnlTweet.Size = new System.Drawing.Size(1206, 165);
            this.pnlTweet.TabIndex = 0;
            // 
            // txtTweet
            // 
            this.txtTweet.AutoEllipsis = true;
            this.txtTweet.BackColor = System.Drawing.Color.Transparent;
            this.txtTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTweet.ForeColor = System.Drawing.Color.White;
            this.txtTweet.Location = new System.Drawing.Point(225, 20);
            this.txtTweet.Name = "txtTweet";
            this.txtTweet.Size = new System.Drawing.Size(802, 72);
            this.txtTweet.TabIndex = 11;
            this.txtTweet.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean nibh justo, iacul" +
    "is in elementum et, lobortis pulvinar mi. Duis rhoncus sed.";
            this.txtTweet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScreenName
            // 
            this.lblScreenName.AutoSize = true;
            this.lblScreenName.BackColor = System.Drawing.Color.Transparent;
            this.lblScreenName.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenName.ForeColor = System.Drawing.Color.LightGray;
            this.lblScreenName.Location = new System.Drawing.Point(800, 125);
            this.lblScreenName.Name = "lblScreenName";
            this.lblScreenName.Size = new System.Drawing.Size(130, 19);
            this.lblScreenName.TabIndex = 10;
            this.lblScreenName.Text = "@PersonName";
            // 
            // pnlCurtain
            // 
            this.pnlCurtain.Location = new System.Drawing.Point(3, 3);
            this.pnlCurtain.Name = "pnlCurtain";
            this.pnlCurtain.Size = new System.Drawing.Size(1, 159);
            this.pnlCurtain.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(773, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 22);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Person Name";
            // 
            // imgAvatar
            // 
            this.imgAvatar.BackColor = System.Drawing.Color.Transparent;
            this.imgAvatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgAvatar.ErrorImage")));
            this.imgAvatar.Location = new System.Drawing.Point(84, 23);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(67, 67);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAvatar.TabIndex = 8;
            this.imgAvatar.TabStop = false;
            // 
            // txtAutoRotateCount
            // 
            this.txtAutoRotateCount.Location = new System.Drawing.Point(377, 185);
            this.txtAutoRotateCount.Name = "txtAutoRotateCount";
            this.txtAutoRotateCount.Size = new System.Drawing.Size(21, 20);
            this.txtAutoRotateCount.TabIndex = 15;
            this.txtAutoRotateCount.Text = "5";
            // 
            // chkAutoRotate
            // 
            this.chkAutoRotate.AutoSize = true;
            this.chkAutoRotate.Location = new System.Drawing.Point(198, 187);
            this.chkAutoRotate.Name = "chkAutoRotate";
            this.chkAutoRotate.Size = new System.Drawing.Size(181, 17);
            this.chkAutoRotate.TabIndex = 14;
            this.chkAutoRotate.Text = "Auto rotate when queue reaches";
            this.chkAutoRotate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Promotion tweet: ";
            // 
            // txtPromotionTweet
            // 
            this.txtPromotionTweet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPromotionTweet.Location = new System.Drawing.Point(709, 185);
            this.txtPromotionTweet.Name = "txtPromotionTweet";
            this.txtPromotionTweet.Size = new System.Drawing.Size(509, 20);
            this.txtPromotionTweet.TabIndex = 12;
            this.txtPromotionTweet.Text = "Live fan feedback powered by #TweetCaster";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start rotation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTweetQueue,
            this.toolStripStatusLabelTweetQueueCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1230, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTweetQueue
            // 
            this.toolStripStatusLabelTweetQueue.Name = "toolStripStatusLabelTweetQueue";
            this.toolStripStatusLabelTweetQueue.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabelTweetQueue.Text = "Tweet queue: ";
            // 
            // toolStripStatusLabelTweetQueueCount
            // 
            this.toolStripStatusLabelTweetQueueCount.Name = "toolStripStatusLabelTweetQueueCount";
            this.toolStripStatusLabelTweetQueueCount.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelTweetQueueCount.Text = "0";
            // 
            // txtTweetQueue
            // 
            this.txtTweetQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTweetQueue.Location = new System.Drawing.Point(12, 212);
            this.txtTweetQueue.Multiline = true;
            this.txtTweetQueue.Name = "txtTweetQueue";
            this.txtTweetQueue.Size = new System.Drawing.Size(1206, 178);
            this.txtTweetQueue.TabIndex = 17;
            // 
            // imgTweet
            // 
            this.imgTweet.BackColor = System.Drawing.Color.Transparent;
            this.imgTweet.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgTweet.ErrorImage")));
            this.imgTweet.Location = new System.Drawing.Point(1033, 22);
            this.imgTweet.Name = "imgTweet";
            this.imgTweet.Size = new System.Drawing.Size(126, 67);
            this.imgTweet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTweet.TabIndex = 12;
            this.imgTweet.TabStop = false;
            // 
            // timerShowTweetBox
            // 
            this.timerShowTweetBox.Interval = 1;
            this.timerShowTweetBox.Tick += new System.EventHandler(this.timerShowTweetBox_Tick);
            // 
            // timerHideTweetBox
            // 
            this.timerHideTweetBox.Interval = 1;
            this.timerHideTweetBox.Tick += new System.EventHandler(this.timerHideTweetBox_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 415);
            this.Controls.Add(this.txtTweetQueue);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtAutoRotateCount);
            this.Controls.Add(this.chkAutoRotate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPromotionTweet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlTweet);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TweetCaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTweet.ResumeLayout(false);
            this.pnlTweet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTweet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTweet;
        private System.Windows.Forms.Panel pnlCurtain;
        private System.Windows.Forms.Label txtTweet;
        private System.Windows.Forms.Label lblScreenName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.TextBox txtAutoRotateCount;
        private System.Windows.Forms.CheckBox chkAutoRotate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPromotionTweet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTweetQueue;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTweetQueueCount;
        private System.Windows.Forms.TextBox txtTweetQueue;
        private System.Windows.Forms.PictureBox imgTweet;
        private System.Windows.Forms.Timer timerShowTweetBox;
        private System.Windows.Forms.Timer timerHideTweetBox;
        private System.Windows.Forms.Timer timer1;
    }
}

