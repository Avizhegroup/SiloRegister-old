using System.Drawing;
using System.Drawing.Imaging;

namespace RfidConnectRegister.BussinessLogic
{
    public class ZPLHelperBase
    {

        unsafe private static byte[][] GetImageData(Rectangle dim, int stride, Bitmap bmpCompressed)
        {
            byte[][] imageData;
            var data = bmpCompressed.LockBits(dim, ImageLockMode.ReadOnly, PixelFormat.Format1bppIndexed);
            try
            {
                byte* pixelData = (byte*)data.Scan0.ToPointer();
                byte rightMask = (byte)(0xff << (data.Stride * 8 - dim.Width));
                imageData = new byte[dim.Height][];

                for (int row = 0; row < dim.Height; row++)
                {
                    byte* rowStart = pixelData + row * data.Stride;
                    imageData[row] = new byte[stride];

                    for (int col = 0; col < stride; col++)
                    {
                        byte f = (byte)(0xff ^ rowStart[col]);
                        f = (col == stride - 1) ? (byte)(f & rightMask) : f;
                        imageData[row][col] = f;
                    }
                }
            }
            finally
            {
                bmpCompressed.UnlockBits(data);
            }
            return imageData;
        }
    }
}