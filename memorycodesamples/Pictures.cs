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
        public Image[] theme2 = {Properties.Resources.apa, Properties.Resources.apan,Properties.Resources.ara,Properties.Resources.baby,Properties.Resources.bird,
                                Properties.Resources.birds,Properties.Resources.bjorn,Properties.Resources.bush,Properties.Resources.bushdog,Properties.Resources.calf,
                                Properties.Resources.cat,Properties.Resources.catinbox,Properties.Resources.catscrat,Properties.Resources.cute,Properties.Resources.cute2,
                                Properties.Resources.cutest,Properties.Resources.rabbit,Properties.Resources.dog,Properties.Resources.dogs,Properties.Resources.ekorrar,
                                Properties.Resources.ekorre,Properties.Resources.ekorre2,Properties.Resources.elefant,Properties.Resources.fox,Properties.Resources.frog,
                                Properties.Resources.giraff,Properties.Resources.giraff2,Properties.Resources.giraff3,Properties.Resources.gorilla,Properties.Resources.hund,
                                Properties.Resources.kanin,Properties.Resources.kaninis,Properties.Resources.katt,Properties.Resources.kisse,Properties.Resources.kitten,
                                Properties.Resources.ladybird,Properties.Resources.lion,Properties.Resources.lion2,Properties.Resources.lo,Properties.Resources.monkey,
                                Properties.Resources.mus,Properties.Resources.noshorn,Properties.Resources.orm,Properties.Resources.owl,Properties.Resources.panda,
                                Properties.Resources.pandared,Properties.Resources.pingvin7,Properties.Resources.racoons,Properties.Resources.red,Properties.Resources.redPanda,
                                Properties.Resources.räv,Properties.Resources.sel,Properties.Resources.squirrel,Properties.Resources.surikat,Properties.Resources.surikatter,
                                Properties.Resources.säl,Properties.Resources.söt,Properties.Resources.söööt,Properties.Resources.söööta,Properties.Resources.tiger};
        public Image[] theme3;
        //public List<Image> bilder = new List<Image>();

        public Pictures() { }

        public void ResizeImage(int width, int height, int theme)
        {
            bilder.Clear();
            Image[]temabilder;            
            if (theme == 1)
            {
                temabilder = theme1;
            }
            else { temabilder = theme2; }
            foreach (Image bild in temabilder)
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
