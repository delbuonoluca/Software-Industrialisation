using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace EdgeDetectionApp
{
    public partial class Filters_EdgeDetection : Form
    {
        #region MACHADO_Atributes

        System.Drawing.Image Origin;
        System.Drawing.Image FilteredImage;

        #endregion

        public Filters_EdgeDetection()
        {
            InitializeComponent();
            Fill_listBoxes();
        }

        // Save the modified image
        #region MACHADO_FileManagement
        private void SaveImage()
        {
            rightPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            FolderBrowserDialog fl = new FolderBrowserDialog();
            if (fl.ShowDialog() != DialogResult.Cancel)
            {

                rightPictureBox.Image.Save(fl.SelectedPath + @"\" + tbx_imageName.Text + @".png", System.Drawing.Imaging.ImageFormat.Png);
            };
            rightPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Load the initial image
        private void LoadImage()
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dr = op.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string path = op.FileName;
                leftPictureBox.Load(path);
                Bitmap temp = new Bitmap(leftPictureBox.Image,
                   new Size(leftPictureBox.Width, leftPictureBox.Height));
                leftPictureBox.Image = temp;
                Origin = leftPictureBox.Image;
                tbx_imageName.Text = Path.GetFileNameWithoutExtension(op.FileName) + "_edgeDetected"; // CHAT GPT : 
                FilteredImage = leftPictureBox.Image;
            }
        }

        // Fill the listboxes
        private void Fill_listBoxes()
        {
            List<string> filterItems = new List<string>
            {
                "Laplacian3x3",
                "Laplacian5x5",
                "Sobel3x3Horizontal",
                "Sobel3x3Vertical",
                "Prewitt3x3Horizontal",
                "Prewitt3x3Vertical",
                "Kirsch3x3Horizontal",
                "Kirsch3x3Vertical"
            };
            this.xFilter_listBox.Items.AddRange(filterItems.ToArray());
            this.yFilter_listBox.Items.AddRange(filterItems.ToArray());

        }

        #endregion

        #region MACHADO_Events      

        public void Button_loadImage(object sender, EventArgs e)
        {
            LoadImage();            
        }  

        public void Button_saveImage(object sender, EventArgs e)
        {
            if(Origin != null)
            {
                SaveImage();
            }
        }

        #endregion

        #region MACHADO_ApplyFilters

        public void Button_reset_filter(object sender, EventArgs e)
        {
            leftPictureBox.Image = Origin;
            btn_rainbowFilter.Checked = false;
            btn_swapFilter.Checked = false;
            FilteredImage = Origin;
        }

        private void Btn_SelectedFilters(object sender, EventArgs e)
        {
            if (Origin != null)
            {
                FilteredImage = Origin;

                if (btn_swapFilter.Checked)
                {
                    FilteredImage = ImageFilters.SwapFilter(new Bitmap(FilteredImage));
                }
                if (btn_rainbowFilter.Checked)
                {
                    FilteredImage = ImageFilters.RainbowFilter(new Bitmap(FilteredImage));
                }
                
                leftPictureBox.Image = FilteredImage;
            }
        }

        #endregion

        private void Btn_apply_Filters(object sender, EventArgs e)
        {
            rightPictureBox.Image = leftPictureBox.Image;
            btn_saveImage.Enabled = true;
        }

        private void Btn_apply_edgeDetection_Click(object sender, EventArgs e)
        {
            if (xFilter_listBox.SelectedItem != null && yFilter_listBox.SelectedItem != null)
            {
                ImageEdgesDetection imageEdgesDetection = new ImageEdgesDetection();
                rightPictureBox.Image = imageEdgesDetection.DetectEdges(xFilter_listBox.SelectedItem.ToString(), yFilter_listBox.SelectedItem.ToString(), new Bitmap(rightPictureBox.Image));
            }
        }

        private void Button_reset_EdgeDetection(object sender, EventArgs e)
        {
            rightPictureBox.Image = FilteredImage;
        }
    }
}
