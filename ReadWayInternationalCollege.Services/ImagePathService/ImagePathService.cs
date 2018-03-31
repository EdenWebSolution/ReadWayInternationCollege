using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWayInternationalCollege.Services.ImagePathService
{
    public class ImagePathService
    {
        public string[] GetImagePath()
        {
            return  System.IO.File.ReadAllLines(@"D:\Projects\ReadWayInternationCollege\ReadWayInternationalCollege.Services\ImagePathFile\MainSlider.txt");
        }
    }
}
