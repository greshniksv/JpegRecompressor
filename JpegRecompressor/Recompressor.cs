using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JpegRecompressor
{
    public delegate void ProgressEventHandler(string info, int progress);

    public class Recompressor
    {
        public event ProgressEventHandler progressEvent;

        protected void OnProgress(string info, int progress)
        {
            progressEvent?.Invoke(info, progress);
        }

        public void Start(RecompressorParameter parameter)
        {
            OnProgress("Starting", 1);
            var files = Directory.EnumerateFiles(parameter.Source, "*", SearchOption.AllDirectories).ToList();
            var list = new ConcurrentStack<string>();
            var length = files.Count;

            Task.Factory.StartNew(() =>
            {
                QParallel.ForEach(files, parameter.ThreadCount, (file) =>
                {
                    list.Push(file);

                    OnProgress(file, list.Count * 100 / length);

                    var bitmap = JpegToBitmap(file);

                    if (parameter.Width.HasValue && parameter.Height.HasValue)
                    {
                        bitmap = Resize(bitmap, parameter.Width.Value, parameter.Height.Value);
                    }

                    var nFile = file.Replace(parameter.Source, "");
                    nFile = string.Concat(parameter.Destination, nFile);

                    using (var ms1 = MakeJpeg(bitmap, parameter.Quality))
                    using (var fileStream = new FileStream(nFile, FileMode.Create))
                    {
                        ms1.CopyTo(fileStream);
                    }
                });

                OnProgress("Finish", 100);
            });
        }
        
        private Bitmap Resize(Bitmap bitmap, float width, float height)
        {
            var brush = new SolidBrush(System.Drawing.Color.Black);
            float scale = Math.Min(width / bitmap.Width, height / bitmap.Height);

            var bmp = new Bitmap((int)width, (int)height);
            var graph = Graphics.FromImage(bmp);

            // uncomment for higher quality output
            //graph.InterpolationMode = InterpolationMode.High;
            //graph.CompositingQuality = CompositingQuality.HighQuality;
            //graph.SmoothingMode = SmoothingMode.AntiAlias;

            var scaleWidth = (int)(bitmap.Width * scale);
            var scaleHeight = (int)(bitmap.Height * scale);

            graph.FillRectangle(brush, new RectangleF(0, 0, width, height));
            graph.DrawImage(bitmap, new Rectangle(((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight));
            return bmp;
        }

        private MemoryStream MakeJpeg(Bitmap bitmap, long quality)
        {
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            // Create an Encoder object based on the GUID  
            // for the Quality parameter category.  
            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object.  
            // An EncoderParameters object has an array of EncoderParameter  
            // objects. In this case, there is only one  
            // EncoderParameter object in the array.  
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            var myEncoderParameter = new EncoderParameter(myEncoder, quality);
            myEncoderParameters.Param[0] = myEncoderParameter;
            var ms = new MemoryStream();
            bitmap.Save(ms, jpgEncoder, myEncoderParameters);
            ms.Position = 0;
            return ms;
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private Bitmap JpegToBitmap(string fileName)
        {
            Bitmap bitmap;
            using (Stream bmpStream = File.Open(fileName, FileMode.Open))
            {
                var image = System.Drawing.Image.FromStream(bmpStream);
                bitmap = new Bitmap(image);
            }
            return bitmap;
        }
    }
}
