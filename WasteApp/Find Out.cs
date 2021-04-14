using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Find_Out : Form
    {
        public Find_Out()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Plastic is a widely-used material to manufacture and package products. Recycling has become a global initiative to reduce the waste as the most of the material is non-biodegradable" +
                "Biodegradable plastics are increasingly being used. There are tips to follow when recycling, which are: Recycle on the move, check whilst sorting plastics according to the resin code, crush containers" +
                "and make the cap is on the plastic bottles. Across the country there are numerous locations recycling plastic products. The plastics recycling processes include:" +
                "-PET(Polyethylene terephlate): The containers can be sorted into different colour fractions and baled for sale. The RPET has been used for polyester fibres, clothing manufacturing and food/non-food containers. " +
                "The results of popular products such as the clothing fabrics, has built a major public awareness of environmental issues." +
                "-HDPE(High Density Polyethylene): The highly crystalline structure is strong and stiff plastic. These are highly demanded and usually downcycled further to tables, plastic lumber, stationery, roadside curbs, benches and other durable plastic products." +
                "-PS(Polystyrene): These are not so often recycled as manufacturers invest less on compactors and logistical systems. These are added to insulation sheets, construction materials, clothes hangers, toys, flower pots, picture frames and rulers." +
                "-Plastic Recycle Rates: There is growing opportunity to recycle plastic as 80% of the disposed plastics are discarded to landfills.";
            string title = "Plastic Info";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
               
            }
            else
            {
              this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Glass remains the same after usage which makes it ideal for recycling. The glass waste is sorted into different colours, seperated by chemical composition and reprocessed for usable products. Glass products are common in households and industrial waste" +
                             "The recycling of glass not only reduces the carbon dioxide emission during the manufacturing of new glass with sand, lime and soda but reduces energy consumtion by approximately 60% and saves raw materials. The various glass products recycleable are bottles, light bulbs, broken glassware and other items." +
                             "The recycled glass can be used as aggregate in concrete, ceraramic sanitary ware, astroturf, water filtration media, fiberglass insulation if not reused in their original form.";
            string title = "Glass Info";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                
            }
            else
            {
              this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Metal is referred to as scrap which recyclable materials disposed from product manufacturing and consumption such as vehicle parts, construction supplies and surplus materials. In some scrapyeard, the items are resold prior to the melting process and use weight without funtional conditions considered" +
                             " A scrap metal shredder commonly used to recycle items with other combined material such as stoves, refrigerator";
            string title = "Metal Info";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
             
            }
            else
            {
                this.Close();  
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string message = "Paper is non-biodegradable. Paper is ";
            string title = "Paper Info";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
               
            }
            else
            {
              this.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string message = "Hazardous Products is non-biodegradable. Hazardous Products is ";
            string title = "Hazardous Products Info";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                
            }
            else
            {
              this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Electronics ";
            string title = "Electronics Info";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {

            }
            else
            {
              this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Construction Material";
            string title = "Construction Material Info";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
               
            }
            else
            {
             this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = "Wet waste is biodegradable waste which is organic. Wet Waste is commonly anything which decomposes in the long run and is usually disposed by restaurants and food outlets in large amounts as left over food or ingredients. Wet waste offers an opportunity to be used as compost in the agricultural sector." +
                             "The moisture contents can be easily reproduced. There are numerous types of wet waste which include: Food, Paint, Flowers, Vehicle oils, wet factory waste, hazardous materials, oils & fats for cooking. Proper segregation of wet waste ensures the environment and economic values are met preventing  build ups in landfills," +
                             " water pollution, localised explosions and greenhouse emissions such as methane.";
            string title = "Wet Waste Info";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
               
            }
            else
            {
               this.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string message = "Dry Waste is non-biodegradable with minimum food products. This type of waste does not decay or decompose in the long run and has relatively low or no moisture. There are vrious dry waste items, which one would assume are the majority of waste." +
                             " These items include: Paper, Fabrics/Textiles, Aluminium, Metal, Glass, Furniture, Wood/Wooden products and cardboards. As with wet waste, the dry waste when mixed together as the combination releases harmful gases such as methane.";
            string title = "Dry Waste Info";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {

            }
            else
            {
               this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form3 dl = new Form3();
            dl.ShowDialog();
        }
    }
}