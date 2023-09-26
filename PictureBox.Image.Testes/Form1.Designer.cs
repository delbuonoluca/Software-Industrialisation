using System;
using System.Collections.Generic;

namespace PictureBox.Image.Testes
{
    partial class Filters_EdgeDetection
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_loadImage;
        private System.Windows.Forms.Button btn_saveImage;
        private System.Windows.Forms.Button btn_resetFilter;
        private System.Windows.Forms.TextBox tbx_imageName;
        private System.Windows.Forms.CheckBox btn_swapFilter;
        private System.Windows.Forms.CheckBox btn_rainbowFilter;
        //private List<String> xyFilters;
        private System.Windows.Forms.ListBox listBoxYFilter;
        private System.Windows.Forms.ListBox listBoxXFilter;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_loadImage = new System.Windows.Forms.Button();
            this.btn_resetFilter = new System.Windows.Forms.Button();
            this.btn_saveImage = new System.Windows.Forms.Button();
            this.tbx_imageName = new System.Windows.Forms.TextBox();
            this.btn_swapFilter = new System.Windows.Forms.CheckBox();
            this.btn_rainbowFilter = new System.Windows.Forms.CheckBox();
            this.listBoxYFilter = new System.Windows.Forms.ListBox();
            this.listBoxXFilter = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xFilter_listBox = new System.Windows.Forms.ListBox();
            this.yFilter_listBox = new System.Windows.Forms.ListBox();
            this.btn_apply_edgeDetection = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 428);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_loadImage
            // 
            this.btn_loadImage.Location = new System.Drawing.Point(11, 483);
            this.btn_loadImage.Name = "btn_loadImage";
            this.btn_loadImage.Size = new System.Drawing.Size(75, 25);
            this.btn_loadImage.TabIndex = 8;
            this.btn_loadImage.Text = "Load Image";
            this.btn_loadImage.UseVisualStyleBackColor = true;
            this.btn_loadImage.Click += new System.EventHandler(this.Button_loadImage);
            // 
            // btn_resetFilter
            // 
            this.btn_resetFilter.Location = new System.Drawing.Point(11, 563);
            this.btn_resetFilter.Name = "btn_resetFilter";
            this.btn_resetFilter.Size = new System.Drawing.Size(75, 23);
            this.btn_resetFilter.TabIndex = 34;
            this.btn_resetFilter.Text = "Reset Filter\r\n";
            this.btn_resetFilter.UseVisualStyleBackColor = true;
            this.btn_resetFilter.Click += new System.EventHandler(this.Button_reset_filter);
            // 
            // btn_saveImage
            // 
            this.btn_saveImage.Location = new System.Drawing.Point(1232, 249);
            this.btn_saveImage.Name = "btn_saveImage";
            this.btn_saveImage.Size = new System.Drawing.Size(100, 30);
            this.btn_saveImage.TabIndex = 36;
            this.btn_saveImage.Text = "Save Image";
            this.btn_saveImage.UseVisualStyleBackColor = true;
            this.btn_saveImage.Click += new System.EventHandler(this.Button_saveImage);
            // 
            // tbx_imageName
            // 
            this.tbx_imageName.Location = new System.Drawing.Point(1232, 285);
            this.tbx_imageName.Name = "tbx_imageName";
            this.tbx_imageName.Size = new System.Drawing.Size(100, 20);
            this.tbx_imageName.TabIndex = 37;
            // 
            // btn_swapFilter
            // 
            this.btn_swapFilter.Location = new System.Drawing.Point(11, 527);
            this.btn_swapFilter.Name = "btn_swapFilter";
            this.btn_swapFilter.Size = new System.Drawing.Size(98, 30);
            this.btn_swapFilter.TabIndex = 40;
            this.btn_swapFilter.Text = "Swap Filter";
            this.btn_swapFilter.UseVisualStyleBackColor = true;
            this.btn_swapFilter.Click += new System.EventHandler(this.Button_apply_swapFilter);
            // 
            // btn_rainbowFilter
            // 
            this.btn_rainbowFilter.Location = new System.Drawing.Point(115, 527);
            this.btn_rainbowFilter.Name = "btn_rainbowFilter";
            this.btn_rainbowFilter.Size = new System.Drawing.Size(98, 30);
            this.btn_rainbowFilter.TabIndex = 47;
            this.btn_rainbowFilter.Text = "Rainbow Filter";
            this.btn_rainbowFilter.UseVisualStyleBackColor = true;
            this.btn_rainbowFilter.Click += new System.EventHandler(this.Button_apply_rainbowFilter);
            // 
            // listBoxYFilter
            // 
            this.listBoxYFilter.Location = new System.Drawing.Point(0, 0);
            this.listBoxYFilter.Name = "listBoxYFilter";
            this.listBoxYFilter.Size = new System.Drawing.Size(120, 96);
            this.listBoxYFilter.TabIndex = 0;
            // 
            // listBoxXFilter
            // 
            this.listBoxXFilter.Location = new System.Drawing.Point(0, 0);
            this.listBoxXFilter.Name = "listBoxXFilter";
            this.listBoxXFilter.Size = new System.Drawing.Size(120, 96);
            this.listBoxXFilter.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 48;
            this.button1.Text = "Apply filters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_applyFilters);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(674, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(552, 428);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(963, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Y Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(820, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "X Filter";
            // 
            // xFilter_listBox
            // 
            this.xFilter_listBox.FormattingEnabled = true;
            this.xFilter_listBox.Items.AddRange(new object[] {
            "",
            "Laplacian3x3",
            "Laplacian5x5",
            "Sobel3x3Horizontal",
            "Sobel3x3Vertical",
            "Prewitt3x3Horizontal",
            "Prewitt3x3Vertical",
            "Kirsch3x3Horizontal",
            "Kirsch3x3Vertical"});
            this.xFilter_listBox.Location = new System.Drawing.Point(820, 505);
            this.xFilter_listBox.Name = "xFilter_listBox";
            this.xFilter_listBox.Size = new System.Drawing.Size(120, 95);
            this.xFilter_listBox.TabIndex = 51;
            // 
            // yFilter_listBox
            // 
            this.yFilter_listBox.FormattingEnabled = true;
            this.yFilter_listBox.Items.AddRange(new object[] {
            "",
            "Laplacian3x3",
            "Laplacian5x5",
            "Sobel3x3Horizontal",
            "Sobel3x3Vertical",
            "Prewitt3x3Horizontal",
            "Prewitt3x3Vertical",
            "Kirsch3x3Horizontal",
            "Kirsch3x3Vertical"});
            this.yFilter_listBox.Location = new System.Drawing.Point(966, 505);
            this.yFilter_listBox.Name = "yFilter_listBox";
            this.yFilter_listBox.Size = new System.Drawing.Size(120, 95);
            this.yFilter_listBox.TabIndex = 50;
            // 
            // btn_apply_edgeDetection
            // 
            this.btn_apply_edgeDetection.Location = new System.Drawing.Point(1087, 530);
            this.btn_apply_edgeDetection.Name = "btn_apply_edgeDetection";
            this.btn_apply_edgeDetection.Size = new System.Drawing.Size(139, 30);
            this.btn_apply_edgeDetection.TabIndex = 54;
            this.btn_apply_edgeDetection.Text = "Apply Edge Detection";
            this.btn_apply_edgeDetection.UseVisualStyleBackColor = true;
            this.btn_apply_edgeDetection.Click += new System.EventHandler(this.btn_apply_edgeDetection_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(726, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 55;
            this.button2.Text = "Reset Edge Detection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_reset_EdgeDetection);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Pixel Manipulation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Edges Detection";
            // 
            // Filters_EdgeDetection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1351, 633);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_apply_edgeDetection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xFilter_listBox);
            this.Controls.Add(this.yFilter_listBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_rainbowFilter);
            this.Controls.Add(this.btn_swapFilter);
            this.Controls.Add(this.tbx_imageName);
            this.Controls.Add(this.btn_saveImage);
            this.Controls.Add(this.btn_resetFilter);
            this.Controls.Add(this.btn_loadImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Filters_EdgeDetection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox xFilter_listBox;
        private System.Windows.Forms.ListBox yFilter_listBox;
        private System.Windows.Forms.Button btn_apply_edgeDetection;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

