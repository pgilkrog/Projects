using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

/// <summary>
/// Summary description for ImageTools
/// </summary>
public class ImageTools
{
    public static void GenerateThumbnail(string filePath, string OriginalFile, int width, int height, bool retainAspect, string quality)
    {
        //Generate Thumbnail tager imod et billede (filePath), giver det et nyt navn(savePathName), giver det en ny størrelse(width, height),
        //definere om den skal holde sit aspect eller ej(retainAspect), og til sidst vælger man i hvilken kvalitet billede gemmes i(quality)
        //der er lavet tre valgmuligheder for kvalitet(low, medium og high).

        Bitmap bitmapNew;
        float fx, fy, f;
        int widthTh, heightTh;
        float widthOrig, heightOrig;
        bitmapNew = new Bitmap(filePath);

        //Beregn billedstørrelse
        if(retainAspect)
        {
            //Bevar aspekt
            widthOrig = bitmapNew.Width;
            heightOrig = bitmapNew.Height;
            fx = widthOrig / width;
            fy = heightOrig / height;

            //må ikke være større end thumbnail størrelse
            f = Math.Max(fx, fy);
            if (f<1)
            {
                f= 1;
            }
                widthTh = (int)(widthOrig / f);
                heightTh = (int)(heightOrig / f);
        }
            else
            {
                widthTh = width;
                heightTh = height;
            }


            Size newSize = new Size(widthTh, heightTh);

            //Oprettelse af det nye billede med den nye størrelse
            using (Bitmap thumb = new Bitmap((System.Drawing.Image)bitmapNew, newSize))
            {
                Graphics g = Graphics.FromImage(thumb);

                //Denne int64 bruges til at bestemme hvilken kvalitet billedet skal gemmes i.
                Int64 qualityLevel = 25L;

                if(quality == "high")
                {
                    //kvalitetopsætning
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                    g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    qualityLevel = 95L;
                }

                if(quality == "medium" || quality == "low")
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                    g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                    if(quality == "medium")
                        qualityLevel = 65L;
                }

                //Valg af codec encoder.[1] er jpg
                System.Drawing.Imaging.ImageCodecInfo codec = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()[1];

                //Valg af Codec encoder parameter
                System.Drawing.Imaging.EncoderParameters eParams = new System.Drawing.Imaging.EncoderParameters(1);
                eParams.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qualityLevel);

                //her genereres den nye thumbnail
                thumb.Save(OriginalFile, codec, eParams);
                thumb.Dispose();
            }
        }
    }
