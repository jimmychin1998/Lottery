namespace Lv1威力彩
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn對獎 = new System.Windows.Forms.Button();
            this.btnPrizeNumber = new System.Windows.Forms.Button();
            this.lblPrizeNumber = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lblNo7 = new System.Windows.Forms.Label();
            this.lblNo6 = new System.Windows.Forms.Label();
            this.lblNo5 = new System.Windows.Forms.Label();
            this.lblNo4 = new System.Windows.Forms.Label();
            this.lblNo3 = new System.Windows.Forms.Label();
            this.lblNo2 = new System.Windows.Forms.Label();
            this.lblNo1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblPrizeTotal = new System.Windows.Forms.Label();
            this.listBoxRandom = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn對獎
            // 
            this.btn對獎.BackColor = System.Drawing.Color.OrangeRed;
            this.btn對獎.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn對獎.Location = new System.Drawing.Point(999, 101);
            this.btn對獎.Margin = new System.Windows.Forms.Padding(4);
            this.btn對獎.Name = "btn對獎";
            this.btn對獎.Size = new System.Drawing.Size(184, 74);
            this.btn對獎.TabIndex = 31;
            this.btn對獎.Text = "單一對獎";
            this.btn對獎.UseVisualStyleBackColor = false;
            this.btn對獎.Click += new System.EventHandler(this.btn對獎_Click);
            // 
            // btnPrizeNumber
            // 
            this.btnPrizeNumber.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPrizeNumber.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrizeNumber.Location = new System.Drawing.Point(1200, 101);
            this.btnPrizeNumber.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrizeNumber.Name = "btnPrizeNumber";
            this.btnPrizeNumber.Size = new System.Drawing.Size(184, 74);
            this.btnPrizeNumber.TabIndex = 30;
            this.btnPrizeNumber.Text = "開獎號碼";
            this.btnPrizeNumber.UseVisualStyleBackColor = false;
            this.btnPrizeNumber.Click += new System.EventHandler(this.btnPrizeNumber_Click);
            // 
            // lblPrizeNumber
            // 
            this.lblPrizeNumber.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblPrizeNumber.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrizeNumber.Location = new System.Drawing.Point(866, 201);
            this.lblPrizeNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrizeNumber.Name = "lblPrizeNumber";
            this.lblPrizeNumber.Size = new System.Drawing.Size(528, 114);
            this.lblPrizeNumber.TabIndex = 29;
            this.lblPrizeNumber.Text = "0";
            this.lblPrizeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.LightGray;
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.ForeColor = System.Drawing.Color.Blue;
            this.btnShow.Location = new System.Drawing.Point(36, 667);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(184, 74);
            this.btnShow.TabIndex = 28;
            this.btnShow.Text = "顯示簽單";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(36, 561);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(242, 74);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "刪除所有號碼";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.BackColor = System.Drawing.Color.LightGray;
            this.btnRemoveAt.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveAt.ForeColor = System.Drawing.Color.Chocolate;
            this.btnRemoveAt.Location = new System.Drawing.Point(36, 455);
            this.btnRemoveAt.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(242, 74);
            this.btnRemoveAt.TabIndex = 26;
            this.btnRemoveAt.Text = "刪除所選號碼";
            this.btnRemoveAt.UseVisualStyleBackColor = false;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.LightGray;
            this.btnInput.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInput.Location = new System.Drawing.Point(36, 347);
            this.btnInput.Margin = new System.Windows.Forms.Padding(4);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(184, 74);
            this.btnInput.TabIndex = 25;
            this.btnInput.Text = "加入選號";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.LightGray;
            this.btnRandom.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom.Location = new System.Drawing.Point(36, 241);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(184, 74);
            this.btnRandom.TabIndex = 24;
            this.btnRandom.Text = "產生亂數";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 37;
            this.listBox.Location = new System.Drawing.Point(342, 241);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox.Size = new System.Drawing.Size(452, 522);
            this.listBox.TabIndex = 23;
            // 
            // lblNo7
            // 
            this.lblNo7.BackColor = System.Drawing.Color.Red;
            this.lblNo7.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNo7.Location = new System.Drawing.Point(864, 61);
            this.lblNo7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNo7.Name = "lblNo7";
            this.lblNo7.Size = new System.Drawing.Size(98, 114);
            this.lblNo7.TabIndex = 22;
            this.lblNo7.Text = "0";
            this.lblNo7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNo6
            // 
            this.lblNo6.BackColor = System.Drawing.Color.Cyan;
            this.lblNo6.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNo6.Location = new System.Drawing.Point(756, 61);
            this.lblNo6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNo6.Name = "lblNo6";
            this.lblNo6.Size = new System.Drawing.Size(98, 114);
            this.lblNo6.TabIndex = 21;
            this.lblNo6.Text = "0";
            this.lblNo6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNo5
            // 
            this.lblNo5.BackColor = System.Drawing.Color.Cyan;
            this.lblNo5.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNo5.Location = new System.Drawing.Point(649, 61);
            this.lblNo5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNo5.Name = "lblNo5";
            this.lblNo5.Size = new System.Drawing.Size(98, 114);
            this.lblNo5.TabIndex = 20;
            this.lblNo5.Text = "0";
            this.lblNo5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNo4
            // 
            this.lblNo4.BackColor = System.Drawing.Color.Cyan;
            this.lblNo4.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNo4.Location = new System.Drawing.Point(542, 61);
            this.lblNo4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNo4.Name = "lblNo4";
            this.lblNo4.Size = new System.Drawing.Size(98, 114);
            this.lblNo4.TabIndex = 19;
            this.lblNo4.Text = "0";
            this.lblNo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNo3
            // 
            this.lblNo3.BackColor = System.Drawing.Color.Cyan;
            this.lblNo3.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNo3.Location = new System.Drawing.Point(436, 61);
            this.lblNo3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNo3.Name = "lblNo3";
            this.lblNo3.Size = new System.Drawing.Size(98, 114);
            this.lblNo3.TabIndex = 18;
            this.lblNo3.Text = "0";
            this.lblNo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNo2
            // 
            this.lblNo2.BackColor = System.Drawing.Color.Cyan;
            this.lblNo2.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNo2.Location = new System.Drawing.Point(330, 61);
            this.lblNo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNo2.Name = "lblNo2";
            this.lblNo2.Size = new System.Drawing.Size(98, 114);
            this.lblNo2.TabIndex = 17;
            this.lblNo2.Text = "0";
            this.lblNo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNo1
            // 
            this.lblNo1.BackColor = System.Drawing.Color.Cyan;
            this.lblNo1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNo1.Location = new System.Drawing.Point(220, 61);
            this.lblNo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNo1.Name = "lblNo1";
            this.lblNo1.Size = new System.Drawing.Size(99, 114);
            this.lblNo1.TabIndex = 16;
            this.lblNo1.Text = "0";
            this.lblNo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTest.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTest.Location = new System.Drawing.Point(864, 345);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(335, 74);
            this.btnTest.TabIndex = 32;
            this.btnTest.Text = "左欄獎號同時對獎";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblPrizeTotal
            // 
            this.lblPrizeTotal.BackColor = System.Drawing.Color.Pink;
            this.lblPrizeTotal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrizeTotal.Location = new System.Drawing.Point(225, 809);
            this.lblPrizeTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrizeTotal.Name = "lblPrizeTotal";
            this.lblPrizeTotal.Size = new System.Drawing.Size(958, 42);
            this.lblPrizeTotal.TabIndex = 33;
            this.lblPrizeTotal.Text = "總累積獎金為0";
            this.lblPrizeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxRandom
            // 
            this.listBoxRandom.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxRandom.FormattingEnabled = true;
            this.listBoxRandom.ItemHeight = 37;
            this.listBoxRandom.Location = new System.Drawing.Point(876, 500);
            this.listBoxRandom.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxRandom.Name = "listBoxRandom";
            this.listBoxRandom.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxRandom.Size = new System.Drawing.Size(442, 263);
            this.listBoxRandom.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(908, 454);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 42);
            this.label1.TabIndex = 35;
            this.label1.Text = "亂數產生紀錄如下";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(225, 869);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(958, 42);
            this.label2.TabIndex = 37;
            this.label2.Text = "兌獎紀錄如下";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 37;
            this.listBoxHistory.Location = new System.Drawing.Point(193, 915);
            this.listBoxHistory.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxHistory.Size = new System.Drawing.Size(1015, 263);
            this.listBoxHistory.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1387, 1192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRandom);
            this.Controls.Add(this.lblPrizeTotal);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btn對獎);
            this.Controls.Add(this.btnPrizeNumber);
            this.Controls.Add(this.lblPrizeNumber);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lblNo7);
            this.Controls.Add(this.lblNo6);
            this.Controls.Add(this.lblNo5);
            this.Controls.Add(this.lblNo4);
            this.Controls.Add(this.lblNo3);
            this.Controls.Add(this.lblNo2);
            this.Controls.Add(this.lblNo1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn對獎;
        private System.Windows.Forms.Button btnPrizeNumber;
        private System.Windows.Forms.Label lblPrizeNumber;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lblNo7;
        private System.Windows.Forms.Label lblNo6;
        private System.Windows.Forms.Label lblNo5;
        private System.Windows.Forms.Label lblNo4;
        private System.Windows.Forms.Label lblNo3;
        private System.Windows.Forms.Label lblNo2;
        private System.Windows.Forms.Label lblNo1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblPrizeTotal;
        private System.Windows.Forms.ListBox listBoxRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxHistory;
    }
}

