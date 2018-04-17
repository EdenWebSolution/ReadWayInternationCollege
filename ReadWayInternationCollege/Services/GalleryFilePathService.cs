using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadWayInternationCollege.Services
{
    public class GalleryFilePathService
    {
        public string[] Imagepath { get; set; }

        public string[] GetImagePath()
        {
            //var ImagePaths = System.IO.File.ReadAllLines(@"~/ReadWayInternationCollege/Files/ImagePaths.txt");
            var Path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), @"Files\ImagePaths.txt");
            var ImagePaths = System.IO.File.ReadAllLines(Path);

            return ImagePaths;
        }
    }
}