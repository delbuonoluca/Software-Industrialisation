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

        #region MACHADO_FileManagement

        private void SaveImage()
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            FolderBrowserDialog fl = new FolderBrowserDialog();
            if (fl.ShowDialog() != DialogResult.Cancel)
            {

                pictureBox2.Image.Save(fl.SelectedPath + @"\" + tbx_imageName.Text + @".png", System.Drawing.Imaging.ImageFormat.Png);
            };
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadImage()
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dr = op.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string path = op.FileName;
                pictureBox1.Load(path);
                Bitmap temp = new Bitmap(pictureBox1.Image,
                   new Size(pictureBox1.Width, pictureBox1.Height));
                pictureBox1.Image = temp;
                map = new Bitmap(pictureBox1.Image);
                Origin = pictureBox1.Image;
                tbx_imageName.Text = Path.GetFileName(op.FileName) + "_edgeDetected";
                FilteredImage = pictureBox1.Image;
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

            pictureBox1.Image = Origin;
            btn_rainbowFilter.Checked = false;
            btn_swapFilter.Checked = false;
            FilteredImage = Origin;
        }

        public void Button_apply_swapFilter(object sender, EventArgs e)
        {
            if(Origin != null)
            {
                pictureBox1.Image = FilteredImage;
                if (btn_swapFilter.Checked)
                {
                    pictureBox1.Image = ImageFilters.FilterSwap(new Bitmap(FilteredImage));

                }
                else
                {
                    pictureBox1.Image = ImageFilters.FilterSwap(new Bitmap(FilteredImage));
                }
                
                
                FilteredImage = pictureBox1.Image;
            }
        }

        public void Button_apply_rainbowFilter(object sender, EventArgs e)
        {
            if (Origin != null)
            {
                pictureBox1.Image = FilteredImage;
                pictureBox1.Image = ImageFilters.RainbowFilter(new Bitmap(FilteredImage));
                FilteredImage = pictureBox1.Image;
            }
        }

        #endregion

        private void Button_applyFilters(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void btn_apply_edgeDetection_Click(object sender, EventArgs e)
        {
            if(listBoxXFilter.SelectedItems != null && listBoxYFilter.SelectedItems != null) 
            { 
                ImageEdgesDetection imageEdgesDetection = new ImageEdgesDetection();
                pictureBox2.Image = imageEdgesDetection.DetectEdges(listBoxXFilter.SelectedItems.ToString(), listBoxYFilter.SelectedItems.ToString(), new Bitmap(pictureBox2.Image));
                //imageEdgesDetection.ConvertToXYCoord(new Bitmap(pictureBox2.Image));
            }
        }

        private void Button_reset_EdgeDetection(object sender, EventArgs e)
        {
            pictureBox2.Image = FilteredImage;
        }
    }
}
