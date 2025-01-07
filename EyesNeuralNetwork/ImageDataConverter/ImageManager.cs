using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesNeuralNetwork.ImageDataConverter
{
    public class ImageManager
    {
        //This is an image which you want to convert
        public Image ImageSource { get; set; }
        //This is an image in binary code
        public byte[,] pixelColorData { get; set; }

        public Image ConvertDataToImage(byte[,] colorData)
        {
            Bitmap result_bitmap = new Bitmap(colorData.GetLength(0), colorData.GetLength(1));
            using (Graphics graphics = Graphics.FromImage(result_bitmap))
            {
                for (int x = 0; x < result_bitmap.Width; x++)
                {
                    for (int y = 0; y < result_bitmap.Height; y++)
                    {
                        if (colorData[x, y] != 0)
                        {
                            result_bitmap.SetPixel(x, y, Color.Black);
                        }
                    }
                }
            }
            Image result_image = result_bitmap;
            return result_image;
        }

        public byte[,] ConvertImageToData(Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            pixelColorData = new byte[image.Width, image.Height];
            short brightness = 150;
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    if (bitmap.GetPixel(x, y).A != 0)
                    {
                        if (bitmap.GetPixel(x, y).R >= brightness || bitmap.GetPixel(x, y).G >= brightness || bitmap.GetPixel(x, y).B >= brightness)
                        {
                            pixelColorData[x, y] = 1;
                        }
                        else
                        {
                            pixelColorData[x, y] = 0;
                        }
                    }
                }
            }
            return pixelColorData;
        }
    }
}
