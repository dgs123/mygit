﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Manning.MyPhotoAlbum
{
    class CustomPhotoFormatter:IFormatProvider,ICustomFormatter
    {
        // IFormatProvider implementation
        public object GetFormat(Type formatType)
        {
            // Need to check for ICustomFormatter type,not current type
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        // ICustomFormatProvider Implementation
        public string Format(string format,object arg,IFormatProvider provider)
        {
            if (arg == null )
            {
                throw new ArgumentException("arg cannot be null");
            }

            // Format a Photograph object
            if (!string.IsNullOrEmpty(format) && arg is Photograph)
            {
                Photograph photo = (Photograph)arg;
                if (char.ToLower(format[0]) == 'p')
                {
                    if (format.Length == 1)
                    {
                        throw new FormatException("X,Y coordinate required.");
                    }

                    // Find coordinates for pixel by splitting on the comma
                    string[] points = format.Substring(1).Split(new char[] { ',' });

                    if (points.Length != 2)
                    {
                        throw new FormatException("Unable to determine X,Y coordinate");
                    }

                    // Presume X and Y are valid integers
                    int x = Int32.Parse(points[0]);
                    if (x < 0 || x > photo.Image.Width)
                    {
                        throw new FormatException("Width is out of range");
                    }

                    int y = Int32.Parse(points[1]);
                    if (y < 0 || y > photo.Image.Height)
                    {
                        throw new FormatException("Height is out range");
                    }

                    // Return pixel color as RGB string
                    Color c = photo.Image.GetPixel(x, y);
                    return string.Format($"R{c.R}G{c.G}B{c.B}");
                }
                else  // use default Photograph formatting
                {
                    return photo.ToString(format);
                } 
            }
            // Handle non-Photograph arguments appropriately
            if (arg is IFormattable)
            {
                return ((IFormattable)arg).ToString(format, provider);
            }
            else
            {
                return arg.ToString();
            }
        }
    }
}
