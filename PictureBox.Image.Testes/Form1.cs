using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace PictureBox.Image.Testes
{
    public partial class Filters_EdgeDetection : Form
    {
        #region MACHADO_Atributes

        Bitmap map;
        System.Drawing.Image Origin;
        System.Drawing.Image FilteredImage;

        #endregion

        public Filters_EdgeDetection()
        {
            InitializeComponent();
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
                map = new Bitmap(leftPictureBox.Image);
                Origin = leftPictureBox.Image;
                tbx_imageName.Text = Path.GetFileNameWithoutExtension(op.FileName) + "_edgeDetected"; // CHAT GPT : 
                FilteredImage = leftPictureBox.Image;
            }
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

        public void Button_apply_swapFilter(object sender, EventArgs e)
        {
            if (Origin != null)
            {
                leftPictureBox.Image = FilteredImage;
                if (btn_swapFilter.Checked)
                {
                    leftPictureBox.Image = ImageFilters.RevertSwapFilter(new Bitmap(FilteredImage));

                }
                else
                {
                    leftPictureBox.Image = ImageFilters.SwapFilter(new Bitmap(FilteredImage));
                }
                FilteredImage = leftPictureBox.Image;
            }
        }

        public void Button_apply_rainbowFilter(object sender, EventArgs e)
        {
            if (Origin != null)
            {
                leftPictureBox.Image = FilteredImage;
                if (btn_rainbowFilter.Checked)
                {
                    leftPictureBox.Image = ImageFilters.RainbowFilter(new Bitmap(FilteredImage));
                }
                else
                {
                    leftPictureBox.Image = ImageFilters.RevertRainbowFilter(new Bitmap(FilteredImage));
                }
                FilteredImage = leftPictureBox.Image;
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
