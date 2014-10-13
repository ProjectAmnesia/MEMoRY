using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace MemoryCodeSamples
{
    public class Pictures
    {
        public List<Image> bilder = new List<Image>();
        
        public Image[] theme1 = {Properties.Resources.gurkor,Properties.Resources.Nectarine,Properties.Resources.chili,
                                Properties.Resources.apple,Properties.Resources.arter5,Properties.Resources.aubergine,Properties.Resources.avokado,
                                Properties.Resources.Banana,Properties.Resources.beans655,Properties.Resources.bjornbar,Properties.Resources.blueberries_03,
                                Properties.Resources.Broccoli,Properties.Resources.chilis,Properties.Resources.citron,Properties.Resources.crazy,
                                Properties.Resources.empeher3,Properties.Resources.galia,Properties.Resources.ginger,Properties.Resources.granat,
                                Properties.Resources.grönkål,Properties.Resources.guanabana,Properties.Resources.guavas,Properties.Resources.hallon,
                                Properties.Resources.Hjortron,Properties.Resources.honey,Properties.Resources.Kiwano,Properties.Resources.Kiwi,
                                Properties.Resources.kokos,Properties.Resources.korsbar,Properties.Resources.Kronartskocka,Properties.Resources.krusbar,
                                Properties.Resources.lime,Properties.Resources.Lingon_2,Properties.Resources.Litchi,Properties.Resources.mandarin,
                                Properties.Resources.mango,Properties.Resources.melon,Properties.Resources.morot,Properties.Resources.oliver,
                                Properties.Resources.orange,Properties.Resources.papaya,Properties.Resources.passion,Properties.Resources.pear,
                                Properties.Resources.pfi_549_3,Properties.Resources.Physalis_fruit,Properties.Resources.Pineapple,Properties.Resources.pitahaya,
                                Properties.Resources.pumpa,Properties.Resources.rodavindruvor,Properties.Resources.rosagrapefrukt,Properties.Resources.sparris,
                                Properties.Resources.squash,Properties.Resources.Strawberry,Properties.Resources.tamarillo_7,Properties.Resources.tamarind,
                                Properties.Resources.tomat,Properties.Resources.tomatillo,Properties.Resources.tranbar,Properties.Resources.watermelon,
                                Properties.Resources.äpple};
        public Image[] theme2;
        public Image[] theme3;
        //public List<Image> bilder = new List<Image>();

        public Pictures() { }

        public void ResizeImage(int width, int height)
        {
            foreach (Image bild in theme1)
            {
                var image = bild;
                var newimage = ScaleImage(image, width, height);
                bilder.Add(newimage);
            }
            
        }
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }
    }
}
