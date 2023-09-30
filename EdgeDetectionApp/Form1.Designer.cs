using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EdgeDetectionApp
{
    partial class Filters_EdgeDetection
    {
        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.Button btn_loadImage;
        private System.Windows.Forms.Button btn_saveImage;
        private System.Windows.Forms.Button btn_resetFilter;
        private System.Windows.Forms.TextBox tbx_imageName;
        private System.Windows.Forms.CheckBox btn_swapFilter;
        private System.Windows.Forms.CheckBox btn_rainbowFilter;
        private System.Windows.Forms.Button btn_apply_filters;
        private System.Windows.Forms.PictureBox rightPictureBox;
        private System.Windows.Forms.Label label_yFilter;
        private System.Windows.Forms.Label label_xFilter;
        private System.Windows.Forms.ListBox xFilter_listBox;
        private System.Windows.Forms.ListBox yFilter_listBox;
        private System.Windows.Forms.Button btn_apply_edgeDetection;
        private System.Windows.Forms.Button btn_reset_edgeDetection;
        private System.Windows.Forms.Label label_PixelManipulation;
        private System.Windows.Forms.Label label_EdgeDetection;

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
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.btn_loadImage = new System.Windows.Forms.Button();
            this.btn_resetFilter = new System.Windows.Forms.Button();
            this.btn_saveImage = new System.Windows.Forms.Button();
            this.tbx_imageName = new System.Windows.Forms.TextBox();
            this.btn_swapFilter = new System.Windows.Forms.CheckBox();
            this.btn_rainbowFilter = new System.Windows.Forms.CheckBox();
            this.btn_apply_filters = new System.Windows.Forms.Button();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.label_yFilter = new System.Windows.Forms.Label();
            this.label_xFilter = new System.Windows.Forms.Label();
            this.xFilter_listBox = new System.Windows.Forms.ListBox();
            this.yFilter_listBox = new System.Windows.Forms.ListBox();
            this.btn_apply_edgeDetection = new System.Windows.Forms.Button();
            this.btn_reset_edgeDetection = new System.Windows.Forms.Button();
            this.label_PixelManipulation = new System.Windows.Forms.Label();
            this.label_EdgeDetection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPictureBox.InitialImage = null;
            this.leftPictureBox.Location = new System.Drawing.Point(12, 49);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(552, 428);
            this.leftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftPictureBox.TabIndex = 0;
            this.leftPictureBox.TabStop = false;
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
            this.btn_saveImage.Enabled = false;
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
            this.tbx_imageName.Size = new System.Drawing.Size(100, 38);
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
            this.btn_swapFilter.CheckedChanged += new System.EventHandler(this.Btn_SelectedFilters);
            // 
            // btn_rainbowFilter
            // 
            this.btn_rainbowFilter.Location = new System.Drawing.Point(115, 527);
            this.btn_rainbowFilter.Name = "btn_rainbowFilter";
            this.btn_rainbowFilter.Size = new System.Drawing.Size(98, 30);
            this.btn_rainbowFilter.TabIndex = 47;
            this.btn_rainbowFilter.Text = "Rainbow Filter";
            this.btn_rainbowFilter.UseVisualStyleBackColor = true;
            this.btn_rainbowFilter.CheckedChanged += new System.EventHandler(this.Btn_SelectedFilters);
            // 
            // btn_apply_filters
            // 
            this.btn_apply_filters.Location = new System.Drawing.Point(570, 246);
            this.btn_apply_filters.Name = "btn_apply_filters";
            this.btn_apply_filters.Size = new System.Drawing.Size(98, 30);
            this.btn_apply_filters.TabIndex = 48;
            this.btn_apply_filters.Text = "Apply filters";
            this.btn_apply_filters.UseVisualStyleBackColor = true;
            this.btn_apply_filters.Click += new System.EventHandler(this.Btn_apply_Filters);
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPictureBox.InitialImage = null;
            this.rightPictureBox.Location = new System.Drawing.Point(674, 49);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(552, 428);
            this.rightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightPictureBox.TabIndex = 49;
            this.rightPictureBox.TabStop = false;
            // 
            // label_yFilter
            // 
            this.label_yFilter.AutoSize = true;
            this.label_yFilter.Location = new System.Drawing.Point(963, 486);
            this.label_yFilter.Name = "label_yFilter";
            this.label_yFilter.Size = new System.Drawing.Size(104, 32);
            this.label_yFilter.TabIndex = 52;
            this.label_yFilter.Text = "Y Filter";
            // 
            // label_xFilter
            // 
            this.label_xFilter.AutoSize = true;
            this.label_xFilter.Location = new System.Drawing.Point(820, 486);
            this.label_xFilter.Name = "label_xFilter";
            this.label_xFilter.Size = new System.Drawing.Size(104, 32);
            this.label_xFilter.TabIndex = 53;
            this.label_xFilter.Text = "X Filter";
            // 
            // xFilter_listBox
            // 
            this.xFilter_listBox.FormattingEnabled = true;
            this.xFilter_listBox.ItemHeight = 31;
            this.xFilter_listBox.Location = new System.Drawing.Point(820, 505);
            this.xFilter_listBox.Name = "xFilter_listBox";
            this.xFilter_listBox.Size = new System.Drawing.Size(120, 66);
            this.xFilter_listBox.TabIndex = 51;
            // 
            // yFilter_listBox
            // 
            this.yFilter_listBox.FormattingEnabled = true;
            this.yFilter_listBox.ItemHeight = 31;
            this.yFilter_listBox.Location = new System.Drawing.Point(966, 505);
            this.yFilter_listBox.Name = "yFilter_listBox";
            this.yFilter_listBox.Size = new System.Drawing.Size(120, 66);
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
            this.btn_apply_edgeDetection.Click += new System.EventHandler(this.Btn_apply_edgeDetection_Click);
            // 
            // btn_reset_edgeDetection
            // 
            this.btn_reset_edgeDetection.Location = new System.Drawing.Point(726, 541);
            this.btn_reset_edgeDetection.Name = "btn_reset_edgeDetection";
            this.btn_reset_edgeDetection.Size = new System.Drawing.Size(75, 23);
            this.btn_reset_edgeDetection.TabIndex = 55;
            this.btn_reset_edgeDetection.Text = "Reset Edge Detection";
            this.btn_reset_edgeDetection.UseVisualStyleBackColor = true;
            this.btn_reset_edgeDetection.Click += new System.EventHandler(this.Button_reset_EdgeDetection);
            // 
            // label_PixelManipulation
            // 
            this.label_PixelManipulation.AutoSize = true;
            this.label_PixelManipulation.Location = new System.Drawing.Point(12, 33);
            this.label_PixelManipulation.Name = "label_PixelManipulation";
            this.label_PixelManipulation.Size = new System.Drawing.Size(248, 32);
            this.label_PixelManipulation.TabIndex = 56;
            this.label_PixelManipulation.Text = "Pixel Manipulation";
            // 
            // label_EdgeDetection
            // 
            this.label_EdgeDetection.AutoSize = true;
            this.label_EdgeDetection.Location = new System.Drawing.Point(671, 33);
            this.label_EdgeDetection.Name = "label_EdgeDetection";
            this.label_EdgeDetection.Size = new System.Drawing.Size(223, 32);
            this.label_EdgeDetection.TabIndex = 57;
            this.label_EdgeDetection.Text = "Edges Detection";
            // 
            // Filters_EdgeDetection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1369, 633);
            this.Controls.Add(this.label_EdgeDetection);
            this.Controls.Add(this.label_PixelManipulation);
            this.Controls.Add(this.btn_reset_edgeDetection);
            this.Controls.Add(this.btn_apply_edgeDetection);
            this.Controls.Add(this.label_yFilter);
            this.Controls.Add(this.label_xFilter);
            this.Controls.Add(this.xFilter_listBox);
            this.Controls.Add(this.yFilter_listBox);
            this.Controls.Add(this.rightPictureBox);
            this.Controls.Add(this.btn_apply_filters);
            this.Controls.Add(this.btn_rainbowFilter);
            this.Controls.Add(this.btn_swapFilter);
            this.Controls.Add(this.tbx_imageName);
            this.Controls.Add(this.btn_saveImage);
            this.Controls.Add(this.btn_resetFilter);
            this.Controls.Add(this.btn_loadImage);
            this.Controls.Add(this.leftPictureBox);
            this.Name = "Filters_EdgeDetection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

