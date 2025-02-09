using EyesNeuralNetwork.ImageDataConverter;
using System;
using System.Drawing;

namespace EyesNeuralNetwork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            ImageManager imageManager = new ImageManager();
            Image newImage = imageManager.ConvertDataToImage(imageManager.ConvertImageToData(Image.FromFile("z.jpg")));
            newImage.Save("svo.png");
            Console.WriteLine("Ended");
        }
    }
}