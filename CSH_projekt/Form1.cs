using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSH_projekt
{
	public partial class Form1 : Form
	{
		double zoomFactor = 1.5;
		Image slika;
		Size novaVelicina;
		Point mouseLoc = new Point();
		bool Dragging = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void zoomInButton_Click(object sender, EventArgs e)
		{

			novaVelicina = new Size((int)(novaVelicina.Width * zoomFactor), (int)(novaVelicina.Height * zoomFactor));
			pictureBox1.Image = Zoom(slika, novaVelicina);

		}

		private void zoomOutButton_Click(object sender, EventArgs e)
		{
			novaVelicina = new Size((int)(novaVelicina.Width / zoomFactor), (int)(novaVelicina.Height / zoomFactor));
			pictureBox1.Image = Zoom(slika, novaVelicina);
		}

		private void uploadImageButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog()
			{
				Filter = "Files|*.jpg;*.jpeg;*.png;",
				Multiselect = false
			})
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					String path = openFileDialog.FileName;
					slika = Image.FromFile(path);
					pictureBox1.Image = slika;
					novaVelicina = new Size(slika.Width, slika.Height);
				}
			if (slika != null)
			{
				zoomInButton.Enabled = true;
				zoomOutButton.Enabled = true;
			}
		}

		private Image Zoom(Image image, Size size)
		{
			Bitmap bmp = new Bitmap(image, size.Width, size.Height);
			Graphics graphics = Graphics.FromImage(bmp);
			graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
			pictureBox1.Size = size;
			return bmp;
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e) { Dragging = false; }
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
				if (e.Button == MouseButtons.Left)
				{
					mouseLoc = e.Location;
					Dragging = true;
				}
		}
		
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if(Dragging == false || slika == null)
			{
				return;
			}

			Point currentMousePos = e.Location;

			int distanceX = currentMousePos.X - mouseLoc.X;
			int distanceY = currentMousePos.Y - mouseLoc.Y;

			int newX = pictureBox1.Location.X + distanceX;
			int newY = pictureBox1.Location.Y + distanceY;

			if(newX > panel1.Left && newX < panel1.Right)
			{
				pictureBox1.Location = new Point(newX, pictureBox1.Location.Y);
			}
			
			if(newY > panel1.Top && newY < panel1.Bottom)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X, newY);
			}
		}
	}
}

