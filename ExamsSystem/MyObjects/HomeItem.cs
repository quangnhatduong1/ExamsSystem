using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects
{
    class HomeItem
    {
        //các giá trị của một home item
        public string Title { get; set; }//tiêu đề
        public string Tag { get; set; }//tag
        public Image Img { get; set; }// hình
        public int PointX { get; set; }//vị trí x
        public int PointY { get; set; }// vị trí y
        public HomeItem(string title, string tag, Image img, int pointX, int pointY)
        {
            Title = title;
            Tag = tag;
            Img = img;
            PointX = pointX;
            PointY = pointY;
        }
        
    }
}
