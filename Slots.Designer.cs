namespace Kazik
{
    partial class Slots
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slots));
            this.pictureBoxMiddleSlot = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightSlot = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftSlot = new System.Windows.Forms.PictureBox();
            this.imageListLeftSlot = new System.Windows.Forms.ImageList(this.components);
            this.imageListMiddleSlot = new System.Windows.Forms.ImageList(this.components);
            this.imageListRightSlot = new System.Windows.Forms.ImageList(this.components);
            this.timerLeftSlot = new System.Windows.Forms.Timer(this.components);
            this.timerMiddleSlot = new System.Windows.Forms.Timer(this.components);
            this.timerRightSlot = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddleSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMiddleSlot
            // 
            this.pictureBoxMiddleSlot.Location = new System.Drawing.Point(574, 365);
            this.pictureBoxMiddleSlot.Name = "pictureBoxMiddleSlot";
            this.pictureBoxMiddleSlot.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxMiddleSlot.TabIndex = 0;
            this.pictureBoxMiddleSlot.TabStop = false;
            // 
            // pictureBoxRightSlot
            // 
            this.pictureBoxRightSlot.Location = new System.Drawing.Point(755, 365);
            this.pictureBoxRightSlot.Name = "pictureBoxRightSlot";
            this.pictureBoxRightSlot.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxRightSlot.TabIndex = 1;
            this.pictureBoxRightSlot.TabStop = false;
            // 
            // pictureBoxLeftSlot
            // 
            this.pictureBoxLeftSlot.Location = new System.Drawing.Point(392, 365);
            this.pictureBoxLeftSlot.Name = "pictureBoxLeftSlot";
            this.pictureBoxLeftSlot.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxLeftSlot.TabIndex = 2;
            this.pictureBoxLeftSlot.TabStop = false;
            // 
            // imageListLeftSlot
            // 
            this.imageListLeftSlot.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLeftSlot.ImageStream")));
            this.imageListLeftSlot.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLeftSlot.Images.SetKeyName(0, "Cherry.jpg");
            this.imageListLeftSlot.Images.SetKeyName(1, "Pear.jpg");
            this.imageListLeftSlot.Images.SetKeyName(2, "Seven.jpg");
            this.imageListLeftSlot.Images.SetKeyName(3, "Star.jpg");
            this.imageListLeftSlot.Images.SetKeyName(4, "Strawberry.jpg");
            // 
            // imageListMiddleSlot
            // 
            this.imageListMiddleSlot.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMiddleSlot.ImageStream")));
            this.imageListMiddleSlot.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMiddleSlot.Images.SetKeyName(0, "Cherry.jpg");
            this.imageListMiddleSlot.Images.SetKeyName(1, "Pear.jpg");
            this.imageListMiddleSlot.Images.SetKeyName(2, "Seven.jpg");
            this.imageListMiddleSlot.Images.SetKeyName(3, "Star.jpg");
            this.imageListMiddleSlot.Images.SetKeyName(4, "Strawberry.jpg");
            // 
            // imageListRightSlot
            // 
            this.imageListRightSlot.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRightSlot.ImageStream")));
            this.imageListRightSlot.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRightSlot.Images.SetKeyName(0, "Cherry.jpg");
            this.imageListRightSlot.Images.SetKeyName(1, "Pear.jpg");
            this.imageListRightSlot.Images.SetKeyName(2, "Seven.jpg");
            this.imageListRightSlot.Images.SetKeyName(3, "Star.jpg");
            this.imageListRightSlot.Images.SetKeyName(4, "Strawberry.jpg");
            // 
            // timerLeftSlot
            // 
            this.timerLeftSlot.Enabled = true;
            this.timerLeftSlot.Tick += new System.EventHandler(this.timerLeftSlot_Tick);
            // 
            // timerMiddleSlot
            // 
            this.timerMiddleSlot.Enabled = true;
            this.timerMiddleSlot.Tick += new System.EventHandler(this.timerMiddleSlot_Tick);
            // 
            // timerRightSlot
            // 
            this.timerRightSlot.Enabled = true;
            this.timerRightSlot.Tick += new System.EventHandler(this.timerRightSlot_Tick);
            // 
            // Slots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kazik.Properties.Resources.Slots2;
            this.ClientSize = new System.Drawing.Size(1274, 778);
            this.Controls.Add(this.pictureBoxLeftSlot);
            this.Controls.Add(this.pictureBoxRightSlot);
            this.Controls.Add(this.pictureBoxMiddleSlot);
            this.Name = "Slots";
            this.Text = "Slots";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddleSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftSlot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMiddleSlot;
        private System.Windows.Forms.PictureBox pictureBoxRightSlot;
        private System.Windows.Forms.PictureBox pictureBoxLeftSlot;
        private System.Windows.Forms.ImageList imageListLeftSlot;
        private System.Windows.Forms.ImageList imageListMiddleSlot;
        private System.Windows.Forms.ImageList imageListRightSlot;
        private System.Windows.Forms.Timer timerLeftSlot;
        private System.Windows.Forms.Timer timerMiddleSlot;
        private System.Windows.Forms.Timer timerRightSlot;
    }
}