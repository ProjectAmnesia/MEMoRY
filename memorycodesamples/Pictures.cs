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
        public Image[] theme3 = {Properties.Resources.belle,Properties.Resources.brave,Properties.Resources.bu,Properties.Resources.c,Properties.Resources.cru,
                                Properties.Resources.daphne,Properties.Resources.dgr,Properties.Resources.dio,Properties.Resources.grisalisa,Properties.Resources.dre,
                                Properties.Resources.dt,Properties.Resources.Frozen,Properties.Resources.fry,Properties.Resources.ft,Properties.Resources.ftkjrd,Properties.Resources.ftko,
                                Properties.Resources.g,Properties.Resources.gjy,Properties.Resources.glitch,Properties.Resources.gtui,Properties.Resources.ut,Properties.Resources.gu,
                                Properties.Resources.guk,Properties.Resources.gy,Properties.Resources.hacke,Properties.Resources.hello,Properties.Resources.hg,Properties.Resources.ho,
                                Properties.Resources.images,Properties.Resources.j,Properties.Resources.jdtr,Properties.Resources.jerry,Properties.Resources.jg,Properties.Resources.jy,
                                Properties.Resources.jyp,Properties.Resources.kty,Properties.Resources.lisa,Properties.Resources.minnie,Properties.Resources.musse,Properties.Resources.nj,
                                Properties.Resources.pluto1,Properties.Resources.princesssjazmine,Properties.Resources.rht,Properties.Resources.smurfelina,Properties.Resources.snow,
                                Properties.Resources.Tangled,Properties.Resources.timon,Properties.Resources.ting,Properties.Resources.top,Properties.Resources.trhe,Properties.Resources.Velma,
                                Properties.Resources.vg,Properties.Resources.vgy,Properties.Resources.vh,Properties.Resources.vhj,Properties.Resources.vj,Properties.Resources.vjt,
                                Properties.Resources.wonder,Properties.Resources.yt,Properties.Resources.ytYeft8};        
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
            else if(theme == 2)
            { temabilder = theme2; }
            else
            {temabilder = theme3;}
            foreach (Image bild in temabilder)
            {
                Random rand = new Random();
                var image = bild;
                var newimage = ScaleImage(image, width, height);
                bilder.Insert(rand.Next(0, bilder.Count), newimage);
                //bilder.Add(newimage);
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
