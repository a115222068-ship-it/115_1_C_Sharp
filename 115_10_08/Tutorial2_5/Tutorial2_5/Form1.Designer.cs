namespace Tutorial2_5
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
            this.cadeBackpictureBox = new System.Windows.Forms.PictureBox();
            this.cadeFacepictureBox = new System.Windows.Forms.PictureBox();
            this.showBackButton = new System.Windows.Forms.Button();
            this.showFaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cadeBackpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadeFacepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cadeBackpictureBox
            // 
            this.cadeBackpictureBox.Image = global::Tutorial2_5.Properties.Resources.Backface_Blue;
            this.cadeBackpictureBox.Location = new System.Drawing.Point(311, 42);
            this.cadeBackpictureBox.Name = "cadeBackpictureBox";
            this.cadeBackpictureBox.Size = new System.Drawing.Size(195, 308);
            this.cadeBackpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cadeBackpictureBox.TabIndex = 3;
            this.cadeBackpictureBox.TabStop = false;
            this.cadeBackpictureBox.Click += new System.EventHandler(this.cadeBackpictureBox_Click);
            // 
            // cadeFacepictureBox
            // 
            this.cadeFacepictureBox.Image = global::Tutorial2_5.Properties.Resources.King_Hearts;
            this.cadeFacepictureBox.Location = new System.Drawing.Point(311, 42);
            this.cadeFacepictureBox.Name = "cadeFacepictureBox";
            this.cadeFacepictureBox.Size = new System.Drawing.Size(195, 308);
            this.cadeFacepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cadeFacepictureBox.TabIndex = 2;
            this.cadeFacepictureBox.TabStop = false;
            this.cadeFacepictureBox.Visible = false;
            this.cadeFacepictureBox.Click += new System.EventHandler(this.cadeFacepictureBox_Click);
            // 
            // showBackButton
            // 
            this.showBackButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showBackButton.Location = new System.Drawing.Point(214, 356);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(172, 82);
            this.showBackButton.TabIndex = 4;
            this.showBackButton.Text = "顯示背面";
            this.showBackButton.UseVisualStyleBackColor = true;
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            // 
            // showFaceButton
            // 
            this.showFaceButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showFaceButton.Location = new System.Drawing.Point(407, 356);
            this.showFaceButton.Name = "showFaceButton";
            this.showFaceButton.Size = new System.Drawing.Size(172, 82);
            this.showFaceButton.TabIndex = 5;
            this.showFaceButton.Text = "顯示正面";
            this.showFaceButton.UseVisualStyleBackColor = true;
            this.showFaceButton.Click += new System.EventHandler(this.cadeFacepictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showFaceButton);
            this.Controls.Add(this.showBackButton);
            this.Controls.Add(this.cadeBackpictureBox);
            this.Controls.Add(this.cadeFacepictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cadeBackpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadeFacepictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cadeFacepictureBox;
        private System.Windows.Forms.PictureBox cadeBackpictureBox;
        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button showFaceButton;
    }
}

