using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

//Notizen nach einem Update:
//Um adressen wieder zu finden einfach Links Kostüme suchen
//ID's für die ersten 4:
//00,01,02,03
//DLC: 08,09,0A,0B,0C,0D
//Abstand von anderen Charakteren: F4

namespace Hyrule
{

    public partial class Form1 : Form
    {
        public uint diff;
        public TCPGecko Gecko;

        public Form1()
        {
            InitializeComponent();
        }

        private void connectBox_Click(object sender, EventArgs e)
        {
            Gecko = new TCPGecko(ipBox.Text, 7331);
            {
                StreamWriter File = new StreamWriter("toolip.txt");
                File.Write(ipBox.Text);
                File.Close();
            }
            try
            {
                Gecko.Connect();
                connectBox.Enabled = false;
                label17.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64B385");
                label17.Text = "Connected!";
                load();
            }
            catch (ETCPGeckoException)
            {
                MessageBox.Show("Connection failed.");
            }

            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("You entered a wrong IP format.");
            }

        }


        public void release()
        {
            ipBox.Enabled = false;
            button13.Enabled = false;
        }
        public void hold()
        {
            ipBox.Enabled = false;
            button13.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button11.Enabled = true;
            button14.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            button38.Enabled = true;
            button39.Enabled = true;
            button40.Enabled = true;
            button41.Enabled = true;
            button42.Enabled = true;
            button43.Enabled = true;
            button44.Enabled = true;
            button46.Enabled = true;
            button47.Enabled = true;
            button48.Enabled = true;
            button49.Enabled = true;
            button50.Enabled = true;
            button51.Enabled = true;
            button52.Enabled = true;
            button54.Enabled = true;
            button55.Enabled = true;
            button56.Enabled = true;
            button57.Enabled = true;
            button58.Enabled = true;
            button59.Enabled = true;
            button60.Enabled = true;
            button62.Enabled = true;
            button63.Enabled = true;
            button64.Enabled = true;
            button65.Enabled = true;
            button66.Enabled = true;
            button67.Enabled = true;
            button68.Enabled = true;
            button70.Enabled = true;
            button71.Enabled = true;
            button72.Enabled = true;
            button73.Enabled = true;
            button74.Enabled = true;
            button75.Enabled = true;
            button76.Enabled = true;
            button78.Enabled = true;
            button79.Enabled = true;
            button80.Enabled = true;
            button81.Enabled = true;
            button82.Enabled = true;
            button83.Enabled = true;
            button84.Enabled = true;
            button86.Enabled = true;
            button87.Enabled = true;
            button88.Enabled = true;
            button89.Enabled = true;
            button90.Enabled = true;
            button91.Enabled = true;
            button92.Enabled = true;
            button94.Enabled = true;
            button95.Enabled = true;
            button96.Enabled = true;
            button97.Enabled = true;
            button98.Enabled = true;
            button99.Enabled = true;
            button100.Enabled = true;
            button102.Enabled = true;
            button103.Enabled = true;
            button104.Enabled = true;
            button105.Enabled = true;
            button106.Enabled = true;
            button107.Enabled = true;
            button108.Enabled = true;
            button110.Enabled = true;
            button111.Enabled = true;
            button112.Enabled = true;
            button113.Enabled = true;
            button114.Enabled = true;
            button115.Enabled = true;
            button116.Enabled = true;
            button118.Enabled = true;
            button119.Enabled = true;
            button120.Enabled = true;
            button121.Enabled = true;
            button122.Enabled = true;
            button123.Enabled = true;
            button124.Enabled = true;
            button126.Enabled = true;
            button127.Enabled = true;
            button128.Enabled = true;
            button129.Enabled = true;
            button130.Enabled = true;
            button131.Enabled = true;
            button132.Enabled = true;
            button134.Enabled = true;
            button135.Enabled = true;
            button136.Enabled = true;
            button137.Enabled = true;
            button138.Enabled = true;
            button139.Enabled = true;
            button140.Enabled = true;
            button142.Enabled = true;
            button143.Enabled = true;
            button144.Enabled = true;
            button145.Enabled = true;
            button147.Enabled = true;
            button150.Enabled = true;
            button151.Enabled = true;
            button152.Enabled = true;
            button153.Enabled = true;
            button155.Enabled = true;
            button158.Enabled = true;
            button159.Enabled = true;
            button160.Enabled = true;
            button161.Enabled = true;
            button163.Enabled = true;
            button166.Enabled = true;
            button167.Enabled = true;
            button168.Enabled = true;
            button169.Enabled = true;
            button171.Enabled = true;
            button174.Enabled = true;
            button175.Enabled = true;
            button176.Enabled = true;
            button177.Enabled = true;
            button179.Enabled = true;
            button182.Enabled = true;
            button183.Enabled = true;
            button184.Enabled = true;
            button185.Enabled = true;
            button187.Enabled = true;
            button190.Enabled = true;
            button191.Enabled = true;
            button192.Enabled = true;
            button193.Enabled = true;
            button195.Enabled = true;
            button198.Enabled = true;
            button199.Enabled = true;
            button200.Enabled = true;
            button201.Enabled = true;
            button203.Enabled = true;
            button206.Enabled = true;
            button207.Enabled = true;
            button208.Enabled = true;
            button209.Enabled = true;
            button211.Enabled = true;
            button214.Enabled = true;
            button215.Enabled = true;
            button216.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
        }
        public void load()
        {

            hold();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x35614E84, Convert.ToUInt32(numericUpDown1.Value)); //rupees

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x1071211C, 0x00000000); //damage taken

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)

            {
                timer1.Start();
                button2.Enabled = false;
            }

            else

            {
                timer1.Stop();
                button2.Enabled = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            Gecko.poke32(0x1071211C, 0x00000000); //damage taken
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x107121AC, 0x01010000); //full magic

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)

            {
                timer2.Start();
                button3.Enabled = false;
            }

            else

            {
                timer2.Stop();
                button3.Enabled = true;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 500;
            Gecko.poke32(0x107121AC, 0x01010000); //full magic
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x1071219C, 0x03030000); //full special

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)

            {
                timer3.Start();
                button4.Enabled = false;
            }

            else

            {
                timer3.Stop();
                button4.Enabled = true;

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 500;
            Gecko.poke32(0x1071219C, 0x03030000); //full special
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x10712120, 0x00003419); //K.O's (13.337)

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)

            {
                timer4.Start();
                button5.Enabled = false;
            }

            else

            {
                timer4.Stop();
                button5.Enabled = true;

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Interval = 500;
            Gecko.poke32(0x10712120, 0x00003419); //K.O's (13.337)
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x35628A64, 0x03E703E7); //Materials
            Gecko.poke32(0x35628A68, 0x03E703E7);
            Gecko.poke32(0x35628A6C, 0x03E703E7);
            Gecko.poke32(0x35628A70, 0x03E703E7);
            Gecko.poke32(0x35628A74, 0x03E703E7);
            Gecko.poke32(0x35628A78, 0x03E703E7);
            Gecko.poke32(0x35628A7C, 0x03E703E7);
            Gecko.poke32(0x35628A80, 0x03E703E7);
            Gecko.poke32(0x35628A84, 0x03E703E7);
            Gecko.poke32(0x35628A88, 0x03E703E7);
            Gecko.poke32(0x35628A8C, 0x03E703E7);
            Gecko.poke32(0x35628A90, 0x03E703E7);
            Gecko.poke32(0x35628A94, 0x03E703E7);
            Gecko.poke32(0x35628A98, 0x03E703E7);
            Gecko.poke32(0x35628A9C, 0x03E703E7);
            Gecko.poke32(0x35628AA0, 0x03E703E7);
            Gecko.poke32(0x35628AA4, 0x03E703E7);
            Gecko.poke32(0x35628AA8, 0x03E703E7);
            Gecko.poke32(0x35628AAC, 0x03E703E7);
            Gecko.poke32(0x35628AD0, 0x03E703E7);
            Gecko.poke32(0x35628AD4, 0x03E703E7);
            Gecko.poke32(0x35628AD8, 0x03E703E7);
            Gecko.poke32(0x35628ADC, 0x03E703E7);
            Gecko.poke32(0x35628AE0, 0x03E703E7);
            Gecko.poke32(0x35628AE4, 0x03E703E7);
            Gecko.poke32(0x35628AE8, 0x03E703E7);
            Gecko.poke32(0x35628AEC, 0x03E703E7);
            Gecko.poke32(0x35628AF0, 0x03E703E7);
            Gecko.poke32(0x35628AF4, 0x03E703E7);
            Gecko.poke32(0x35628AF8, 0x03E703E7);
            Gecko.poke32(0x35628AFC, 0x03E703E7);
            Gecko.poke32(0x35628AB0, 0x03E703E7);
            Gecko.poke32(0x35628AB4, 0x03E703E7);
            Gecko.poke32(0x35628AB8, 0x03E703E7);
            Gecko.poke32(0x35628ABC, 0x03E703E7);
            Gecko.poke32(0x35628AC0, 0x03E703E7);
            Gecko.poke32(0x35628AC4, 0x03E703E7);
            Gecko.poke32(0x35628AC8, 0x03E703E7);
            Gecko.poke32(0x35628ACC, 0x03E703E7);

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x35628F24, 0x06060606); //All Adventure Items
            Gecko.poke32(0x35628F28, 0x06060606);
            Gecko.poke32(0x35628F2C, 0x06060606);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x3562DF7C, 0x06060606); //All Master Quest Items
            Gecko.poke32(0x3562DF80, 0x06060606);
            Gecko.poke32(0x3562DF84, 0x06060606);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x3562E638, 0x06060000); //All Twilight Items
            Gecko.poke32(0x3562E63C, 0x00060600);
            Gecko.poke32(0x3562E644, 0x06060606);
            Gecko.poke32(0x3562E648, 0x06060606);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x35630E64, 0x06060000); //All Termina Items
            Gecko.poke32(0x35630E68, 0x00000006);
            Gecko.poke32(0x35630E78, 0x06060606);
            Gecko.poke32(0x35630E7C, 0x06060606);
            Gecko.poke32(0x35630E80, 0x06000000);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x3876B72F, Convert.ToUInt32(numericUpDown2.Value)); //character level

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visit the Trainingroom via the Adventure Map, to make the Level Hack work!");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ipBox.Text = File.ReadAllText("toolip.txt");
        }

        private void button14_Click(object sender, EventArgs e)
        {

            adventure(0x35615407, comboBox1.Text);

        }

        public void adventure(uint address1, string mode)
        {
            switch (mode)
            {
                case "Link":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Zelda":
                    Gecko.poke08(address1, 0x01);
                    break;

                case "Sheik":
                    Gecko.poke08(address1, 0x02);
                    break;

                case "Impa":
                    Gecko.poke08(address1, 0x03);
                    break;

                case "Ganondorf":
                    Gecko.poke08(address1, 0x04);
                    break;

                case "Darunia":
                    Gecko.poke08(address1, 0x05);
                    break;

                case "Ruto":
                    Gecko.poke08(address1, 0x06);
                    break;

                case "Agitha":
                    Gecko.poke08(address1, 0x07);
                    break;

                case "Midna":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Fi":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Ghirahim":
                    Gecko.poke08(address1, 0x0A);
                    break;

                case "Zant":
                    Gecko.poke08(address1, 0x0B);
                    break;

                case "Lana":
                    Gecko.poke08(address1, 0x0D);
                    break;

                case "Cia":
                    Gecko.poke08(address1, 0x2C);
                    break;

                case "Volga":
                    Gecko.poke08(address1, 0x2D);
                    break;

                case "Wizzro":
                    Gecko.poke08(address1, 0x2E);
                    break;

                case "Twili Midna":
                    Gecko.poke08(address1, 0x2F);
                    break;

                case "Young Link":
                    Gecko.poke08(address1, 0x30);
                    break;

                case "Tingle":
                    Gecko.poke08(address1, 0x31);
                    break;

                case "Ganon (Ganon-Mode)":
                    Gecko.poke08(address1, 0x32);
                    break;

                case "Cucco":
                    Gecko.poke08(address1, 0x33);
                    break;

                case "Linkle":
                    Gecko.poke08(address1, 0x34);
                    break;

                case "Skull Kid":
                    Gecko.poke08(address1, 0x35);
                    break;

                case "Toon-Link":
                    Gecko.poke08(address1, 0x36);
                    break;

                case "Tetra":
                    Gecko.poke08(address1, 0x37);
                    break;

                case "King Daphnes":
                    Gecko.poke08(address1, 0x38);
                    break;

                case "Medli":
                    Gecko.poke08(address1, 0x39);
                    break;

                case "Toon-Zelda":
                    Gecko.poke08(address1, 0x3A);
                    break;
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gbatemp.net/members/missing-number.16713/");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go to character Select, set the new Character and just press A until the Mission starts!");
        }

        private void button17_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D318C, 0x00000000); //lock link

        }

        private void button18_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D318C, 0x00000001); //unlock link

        }

        private void button19_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3190, 0xFFFFFFFF); //link costumes

        }

        private void button20_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3194, 0xFFFFFFFF); //link upgrades
            Gecko.poke32(0x356D3198, 0xFFFFFFFF); //link upgrades
            Gecko.poke32(0x356D319C, 0xFFFFFFFF); //link upgrades
            Gecko.poke32(0x356D31A0, 0xFFFFFFFF); //link upgrades

        }

        private void button21_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D31A4, Convert.ToUInt16(numericUpDown3.Value)); //link damage
            Gecko.poke16(0x356D31A6, Convert.ToUInt16(numericUpDown3.Value)); //link damage

        }

        private void button22_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D31A8, Convert.ToUInt16(numericUpDown4.Value)); //link hearts

        }

        private void button24_Click(object sender, EventArgs e)
        {

            linkcostume(0x356D31AA, comboBox3.Text);

        }

        public void linkcostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Hero's Clothes":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Trainee Tunic":
                    Gecko.poke08(address1, 0x01);
                    break;

                case "Zora Tunic":
                    Gecko.poke08(address1, 0x02);
                    break;

                case "Goron Tunic":
                    Gecko.poke08(address1, 0x03);
                    break;

                case "Kokiri Tunic":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Era of Twilight Tunic":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Knight of Skyloft Tunic":
                    Gecko.poke08(address1, 0x0A);
                    break;

                case "Hero's Clothes (Master Quest)":
                    Gecko.poke08(address1, 0x0B);
                    break;

                case "Dark Link":
                    Gecko.poke08(address1, 0x0C);
                    break;

                case "Postman Uniform":
                    Gecko.poke08(address1, 0x0D);
                    break;

                case "Hero's Clothes (Twilight)":
                    Gecko.poke08(address1, 0x0E);
                    break;

                case "Fierce Delty Link":
                    Gecko.poke08(address1, 0x0F);
                    break;

                case "Hero's Clothes (Boss)":
                    Gecko.poke08(address1, 0x10);
                    break;

                case "Classic Tunic":
                    Gecko.poke08(address1, 0x11);
                    break;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3468, 0x00000000); //lock impa

        }

        private void button27_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3468, 0x00000001); //unlock impa

        }

        private void button28_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D346C, 0xFFFFFFFF); //impa costumes

        }

        private void button30_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3470, 0xFFFFFFFF); //impa upgrades
            Gecko.poke32(0x356D3474, 0xFFFFFFFF); //impa upgrades
            Gecko.poke32(0x356D3478, 0xFFFFFFFF); //impa upgrades
            Gecko.poke32(0x356D347C, 0xFFFFFFFF); //impa upgrades

        }

        private void button32_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3480, Convert.ToUInt16(numericUpDown7.Value)); //impa damage
            Gecko.poke16(0x356D3482, Convert.ToUInt16(numericUpDown7.Value)); //impa damage

        }

        private void button31_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3484, Convert.ToUInt16(numericUpDown8.Value)); //impa hearts

        }

        private void button26_Click(object sender, EventArgs e)
        {

            impacostume(0x356D3486, comboBox4.Text);

        }

        public void impacostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Outfit":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Standard Outfit (Master-Quest)":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Standard Outfit (Twilight)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Era of the Hero of Time Outfit":
                    Gecko.poke08(address1, 0x0A);
                    break;

                case "Mask of Truth":
                    Gecko.poke08(address1, 0x0B);
                    break;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3374, 0x000000000); //lock sheik

        }

        private void button35_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3374, 0x00000001); //unlock sheik

        }

        private void button36_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3378, 0xFFFFFFFF); //costumes sheik

        }

        private void button38_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D337C, 0xFFFFFFFF); //skills sheik
            Gecko.poke32(0x356D3380, 0xFFFFFFFF); //skills sheik
            Gecko.poke32(0x356D3384, 0xFFFFFFFF); //skills sheik
            Gecko.poke32(0x356D3388, 0xFFFFFFFF); //skills sheik

        }

        private void button40_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D338C, Convert.ToUInt16(numericUpDown10.Value)); //sheik damage
            Gecko.poke16(0x356D338E, Convert.ToUInt16(numericUpDown10.Value)); //sheik damage

        }

        private void button39_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3390, Convert.ToUInt16(numericUpDown11.Value)); //sheik hearts

        }

        private void button34_Click(object sender, EventArgs e)
        {
            {

                sheikcostume(0x356D3392, comboBox5.Text);

            }

        }

        public void sheikcostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Outfit":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Standard Outfit (Master-Quest)":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Standard Outfit (Twilight)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Era of the Hero of Time Outfit":
                    Gecko.poke08(address1, 0x0A);
                    break;

                case "Kafei's Mask":
                    Gecko.poke08(address1, 0x0B);
                    break;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3DF0, 0x00000000); //lock lana

        }

        private void button43_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3DF0, 0x00000001); //unlock lana

        }

        private void button44_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3DF4, 0xFFFFFFFF); //costumes lana

        }

        private void button46_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3DF8, 0xFFFFFFFF); //skill lana
            Gecko.poke32(0x356D3DFC, 0xFFFFFFFF); //skill lana
            Gecko.poke32(0x356D3E00, 0xFFFFFFFF); //skill lana
            Gecko.poke32(0x356D3E04, 0xFFFFFFFF); //skill lana

        }

        private void button48_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3E08, Convert.ToUInt16(numericUpDown13.Value)); //lana damage
            Gecko.poke16(0x356D3E0A, Convert.ToUInt16(numericUpDown13.Value)); //lana damage

        }

        private void button47_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3E0C, Convert.ToUInt16(numericUpDown14.Value)); //lana hearts

        }

        private void button42_Click(object sender, EventArgs e)
        {

            lanacostume(0x356D3E0E, comboBox6.Text); //lana costume

        }

        public void lanacostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Outfit":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Guardian of Time":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Standard Outfit (Master-Quest)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Standard Outfit (Twilight)":
                    Gecko.poke08(address1, 0x0A);
                    break;

                case "Skull Kid's Clothes":
                    Gecko.poke08(address1, 0x0B);
                    break;

                case "Deku Mask":
                    Gecko.poke08(address1, 0x0B);
                    break;

                case "Stamdard Outfit (Boss)":
                    Gecko.poke08(address1, 0x0B);
                    break;
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5B7C, 0x00000000); //lock cia

        }

        private void button51_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5B7C, 0x00000003); //unlock cia

        }

        private void button52_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5B80, 0xFFFFFFFF); //Cia costumes

        }

        private void button54_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5B84, 0xFFFFFFFF); //Cia skill
            Gecko.poke32(0x356D5B88, 0xFFFFFFFF); //Cia skill
            Gecko.poke32(0x356D5B8C, 0xFFFFFFFF); //Cia skill
            Gecko.poke32(0x356D5B90, 0xFFFFFFFF); //Cia skill

        }

        private void button56_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5B94, Convert.ToUInt16(numericUpDown16.Value)); //cia damage
            Gecko.poke16(0x356D5B96, Convert.ToUInt16(numericUpDown16.Value)); //cia damage

        }

        private void button55_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5B98, Convert.ToUInt16(numericUpDown17.Value)); //cia hearts

        }

        private void button50_Click(object sender, EventArgs e)
        {

            ciacostume(0x356D5B9A, comboBox7.Text); //cia level

        }

        public void ciacostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Masked":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Unmasked":
                    Gecko.poke08(address1, 0x01);
                    break;

                case "Hatless":
                    Gecko.poke08(address1, 0x02);
                    break;

                case "Masked (Master-Quest)":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Unmasked (Master-Quest)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Hatless (Master-Quest)":
                    Gecko.poke08(address1, 0x0A);
                    break;

                case "Guardian of Time":
                    Gecko.poke08(address1, 0x0B);
                    break;

                case "Masked (Twilight)":
                    Gecko.poke08(address1, 0x0C);
                    break;

                case "Unmasked (Twilight)":
                    Gecko.poke08(address1, 0x0D);
                    break;

                case "Hatless (Twilight)":
                    Gecko.poke08(address1, 0x0E);
                    break;

                case "Majora's Mask":
                    Gecko.poke08(address1, 0x0F);
                    break;

                case "Masked (Boss)":
                    Gecko.poke08(address1, 0x10);
                    break;

                case "Unmasked (Boss)":
                    Gecko.poke08(address1, 0x11);
                    break;

                case "Hatless (Boss)":
                    Gecko.poke08(address1, 0x12);
                    break;
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3280, 0x00000000); //lock zelda

        }

        private void button59_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3280, 0x00000001); //unlock zelda

        }

        private void button60_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3284, 0xFFFFFFFF); //zelda costume

        }

        private void button62_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3288, 0xFFFFFFFF); //zelda skill
            Gecko.poke32(0x356D328C, 0xFFFFFFFF); //zelda skill
            Gecko.poke32(0x356D3290, 0xFFFFFFFF); //zelda skill
            Gecko.poke32(0x356D3294, 0xFFFFFFFF); //zelda skill

        }

        private void button64_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3298, Convert.ToUInt16(numericUpDown19.Value)); //zelda damage
            Gecko.poke16(0x356D329A, Convert.ToUInt16(numericUpDown19.Value)); //zelda damage

        }

        private void button63_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D329C, Convert.ToUInt16(numericUpDown20.Value)); //zelda hearts

        }

        private void button58_Click(object sender, EventArgs e)
        {

            zeldacostume(0x356D329E, comboBox8.Text); //zelda costume

        }

        public void zeldacostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Robes":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Era of the Hero of Time Robes":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Era of Twilight Robes":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Skyloft Robes":
                    Gecko.poke08(address1, 0x0A);
                    break;

                case "Standard Robes (Master-Quest)":
                    Gecko.poke08(address1, 0x0B);
                    break;

                case "Illia's Clothes":
                    Gecko.poke08(address1, 0x0C);
                    break;

                case "Standard Robes (Twilight)":
                    Gecko.poke08(address1, 0x0D);
                    break;

                case "Bunny Hood":
                    Gecko.poke08(address1, 0x0E);
                    break;

                case "Standard Robes (Boss)":
                    Gecko.poke08(address1, 0x0F);
                    break;
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D355C, 0x00000000); //lock ganondorf

        }

        private void button67_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D355C, 0x00000001); //unlock ganondorf

        }

        private void button68_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3560, 0xFFFFFFFF); //ganondorf costumes

        }

        private void button70_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3564, 0xFFFFFFFF); //ganondorf skills
            Gecko.poke32(0x356D3568, 0xFFFFFFFF); //ganondorf skills
            Gecko.poke32(0x356D356C, 0xFFFFFFFF); //ganondorf skills
            Gecko.poke32(0x356D3570, 0xFFFFFFFF); //ganondorf skills

        }

        private void button72_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3574, Convert.ToUInt16(numericUpDown22.Value)); //ganondorf damage
            Gecko.poke16(0x356D3576, Convert.ToUInt16(numericUpDown22.Value)); //ganondorf damage

        }

        private void button71_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3578, Convert.ToUInt16(numericUpDown23.Value)); //ganondorf hearts

        }

        private void button66_Click(object sender, EventArgs e)
        {

            ganondorfcostume(0x356D357E, comboBox8.Text); //ganondorf costume

        }

        public void ganondorfcostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Armor":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Era of the Hero of Time Armor":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Era of Twilight Armor":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Standard Armor (Master-Quest)":
                    Gecko.poke08(address1, 0x0A);
                    break;

                case "Standard Armor (Twilight)":
                    Gecko.poke08(address1, 0x0B);
                    break;

                case "Odolwa's Remains":
                    Gecko.poke08(address1, 0x0C);
                    break;

                case "Standard Armor (Boss)":
                    Gecko.poke08(address1, 0x0D);
                    break;
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3650, 0x00000000); //lock darunia

        }

        private void button75_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3650, 0x00000001); //unlock darunia

        }

        private void button76_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3654, 0xFFFFFFFF); //darunia costumes

        }

        private void button78_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3658, 0xFFFFFFFF); //darunia skill
            Gecko.poke32(0x356D365C, 0xFFFFFFFF); //darunia skill
            Gecko.poke32(0x356D3660, 0xFFFFFFFF); //darunia skill
            Gecko.poke32(0x356D3664, 0xFFFFFFFF); //darunia skill

        }

        private void button80_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3668, Convert.ToUInt16(numericUpDown25.Value)); //darunia damage
            Gecko.poke16(0x356D366A, Convert.ToUInt16(numericUpDown25.Value)); //darunia damage

        }

        private void button79_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D366C, Convert.ToUInt16(numericUpDown26.Value)); //darunia hearts

        }


        private void button74_Click(object sender, EventArgs e)
        {

            daruniacostume(0x356D366E, comboBox10.Text); //darunia costumes

        }

        public void daruniacostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Outfit":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Standard Outfit (Master-Quest)":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Standard Outfit (Twilight)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Goron Mask":
                    Gecko.poke08(address1, 0x0A);
                    break;
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3744, 0x00000000); //lock ruto

        }

        private void button83_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3744, 0x00000001); //unlock ruto

        }

        private void button84_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3748, 0xFFFFFFFF); //ruto costumes

        }

        private void button86_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D374C, 0xFFFFFFFF); //ruto skill
            Gecko.poke32(0x356D3750, 0xFFFFFFFF); //ruto skill
            Gecko.poke32(0x356D3754, 0xFFFFFFFF); //ruto skill
            Gecko.poke32(0x356D3758, 0xFFFFFFFF); //ruto skill

        }

        private void button88_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D375C, Convert.ToUInt16(numericUpDown28.Value)); //ruto damage
            Gecko.poke16(0x356D375F, Convert.ToUInt16(numericUpDown28.Value)); //ruto damage

        }

        private void button87_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3760, Convert.ToUInt16(numericUpDown29.Value)); //ruto hearts

        }

        private void button82_Click(object sender, EventArgs e)
        {

            rutocostume(0x356D3762, comboBox11.Text); //ruto costumes

        }

        public void rutocostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Outfit":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Standard Outfit (Master-Quest)":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Standard Outfit (Twilight)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Zora Mask":
                    Gecko.poke08(address1, 0x0A);
                    break;
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3838, 0x00000000); //lock Agnitha

        }

        private void button91_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3838, 0x00000001); //unlock Agnitha

        }

        private void button92_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D383C, 0xFFFFFFFF); //Agnitha Costumes

        }

        private void button94_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3840, 0xFFFFFFFF); //Agnitha Skills
            Gecko.poke32(0x356D3844, 0xFFFFFFFF);
            Gecko.poke32(0x356D3848, 0xFFFFFFFF);
            Gecko.poke32(0x356D384C, 0xFFFFFFFF);

        }

        private void button96_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3850, Convert.ToUInt16(numericUpDown31.Value)); //agni damage
            Gecko.poke16(0x356D3852, Convert.ToUInt16(numericUpDown31.Value)); //agni damage

        }

        private void button95_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3854, Convert.ToUInt16(numericUpDown32.Value)); //agni hearts

        }

        private void button90_Click(object sender, EventArgs e)
        {

            agnicostume(0x356D3856, comboBox12.Text); //agni costumes

        }

        public void agnicostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Outfit":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Standard Outfit (Master-Quest)":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Standard Outfit (Twilight)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Don Gero's Mask":
                    Gecko.poke08(address1, 0x0A);
                    break;
            }
        }

        private void button97_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D392C, 0x00000000); //lock Midna

        }

        private void button99_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D392C, 0x00000001); //unlock Midna

        }

        private void button100_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3930, 0xFFFFFFFF); //Midna Costumes

        }

        private void button102_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3934, 0xFFFFFFFF); //Minda Skills
            Gecko.poke32(0x356D3938, 0xFFFFFFFF);
            Gecko.poke32(0x356D393C, 0xFFFFFFFF);
            Gecko.poke32(0x356D3940, 0xFFFFFFFF);

        }

        private void button104_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3944, Convert.ToUInt16(numericUpDown31.Value)); //Midna damage
            Gecko.poke16(0x356D3946, Convert.ToUInt16(numericUpDown31.Value)); //Midna damage

        }

        private void button103_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3948, Convert.ToUInt16(numericUpDown32.Value)); //Midna Hearts

        }


        private void button98_Click(object sender, EventArgs e)
        {

            midnacostume(0x356D394A, comboBox13.Text); //Midna Costumes

        }

        public void midnacostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Outfit":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Standard Outfit (Master-Quest)":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Standard Outfit (Twilight)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Ordon Shield":
                    Gecko.poke08(address1, 0x0A);
                    break;
            }
        }

        private void button105_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3C08, 0x00000000); //lock Zant

        }

        private void button107_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3C08, 0x00000001); //unlock Zant

        }

        private void button108_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3C0C, 0xFFFFFFFF); //Zant Costumes

        }

        private void button110_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3C10, 0xFFFFFFFF); //Zant skills
            Gecko.poke32(0x356D3C14, 0xFFFFFFFF);
            Gecko.poke32(0x356D3C18, 0xFFFFFFFF);
            Gecko.poke32(0x356D3C1C, 0xFFFFFFFF);

        }

        private void button112_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3C20, Convert.ToUInt16(numericUpDown37.Value)); //Zant Damage
            Gecko.poke16(0x356D3C22, Convert.ToUInt16(numericUpDown37.Value)); //Zant Damage

        }

        private void button111_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3C24, Convert.ToUInt16(numericUpDown38.Value)); //Zant Hearts

        }

        private void button106_Click(object sender, EventArgs e)
        {

            zantcostume(0x356D3C26, comboBox14.Text); //Zant Costumes

        }

        public void zantcostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Outfit":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Standard Outfit (Master-Quest)":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Standard Outfit (Twilight)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Troupe Leader's Mask":
                    Gecko.poke08(address1, 0x0A);
                    break;
            }
        }

        private void button113_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3A20, 0x00000000); //lock Fi

        }

        private void button115_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3A20, 0x00000001); //unlock Fi

        }

        private void button116_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3A24, 0xFFFFFFFF); //Fi Costumes

        }

        private void button118_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3A28, 0xFFFFFFFF); //Fi Skill
            Gecko.poke32(0x356D3A2C, 0xFFFFFFFF);
            Gecko.poke32(0x356D3A30, 0xFFFFFFFF);
            Gecko.poke32(0x356D3A34, 0xFFFFFFFF);

        }

        private void button120_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3A38, Convert.ToUInt16(numericUpDown40.Value)); //Fi Damage
            Gecko.poke16(0x356D3A3A, Convert.ToUInt16(numericUpDown40.Value)); //Fi Damage

        }

        private void button119_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3A3C, Convert.ToUInt16(numericUpDown41.Value)); //Fi Hearts

        }


        private void button114_Click(object sender, EventArgs e)
        {

            ficostume(0x356D3A3E, comboBox15.Text); //fi Costumes

        }

        public void ficostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Outfit":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Standard Outfit (Master-Quest)":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Standard Outfit (Twilight)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Stone Mask":
                    Gecko.poke08(address1, 0x0A);
                    break;
            }
        }

        private void button121_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3B14, 0x00000000); //lock Ghira

        }

        private void button123_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3B14, 0x00000001); //unlock Ghira

        }

        private void button124_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3B18, 0xFFFFFFFF); //Ghira Costumes

        }

        private void button126_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D3B1C, 0xFFFFFFFF); //Ghira Skills
            Gecko.poke32(0x356D3B20, 0xFFFFFFFF);
            Gecko.poke32(0x356D3B24, 0xFFFFFFFF);
            Gecko.poke32(0x356D3B28, 0xFFFFFFFF);

        }

        private void button128_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3B2C, Convert.ToUInt16(numericUpDown43.Value)); //Ghira Damage
            Gecko.poke16(0x356D3B2E, Convert.ToUInt16(numericUpDown43.Value)); //Ghira Damage

        }

        private void button127_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D3B30, Convert.ToUInt16(numericUpDown44.Value)); //Ghira Hearts

        }


        private void button122_Click(object sender, EventArgs e)
        {

            ghiracostume(0x356D3B32, comboBox16.Text); //ghira Costumes

        }

        public void ghiracostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Outfit":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Standard Outfit (Master-Quest)":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Standard Outfit (Twilight)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Kamaro's mask":
                    Gecko.poke08(address1, 0x0A);
                    break;
            }
        }

        private void button129_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5C70, 0x00000000); //lock Volga

        }

        private void button131_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5C70, 0x00000003); //unlock Volga

        }

        private void button132_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5C74, 0xFFFFFFFF); //volga costumes

        }

        private void button134_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5C78, 0xFFFFFFFF); //Volga Skills
            Gecko.poke32(0x356D5C7C, 0xFFFFFFFF);
            Gecko.poke32(0x356D5C80, 0xFFFFFFFF);
            Gecko.poke32(0x356D5C84, 0xFFFFFFFF);

        }

        private void button136_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5C88, Convert.ToUInt16(numericUpDown46.Value)); //Volga Damage
            Gecko.poke16(0x356D5C8A, Convert.ToUInt16(numericUpDown46.Value)); //Volga Damage

        }

        private void button135_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5C8C, Convert.ToUInt16(numericUpDown47.Value)); //Volga Hearts

        }


        private void button130_Click(object sender, EventArgs e)
        {

            volgacostume(0x356D5C8E, comboBox17.Text); //volga costumes

        }

        public void volgacostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Outfit":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Standard Outfit (Master-Quest)":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Standard Outfit (Twilight)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Giant's Mask":
                    Gecko.poke08(address1, 0x0A);
                    break;
            }
        }

        private void button137_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5D64, 0x00000000); //lock Wizzro

        }

        private void button139_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5D64, 0x00000001); //lock Wizzro

        }

        private void button140_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5D68, 0xFFFFFFFF); //Wizzro Costumes

        }

        private void button142_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5D6C, 0xFFFFFFFF); //Wizzro Skills
            Gecko.poke32(0x356D5D70, 0xFFFFFFFF);
            Gecko.poke32(0x356D5D74, 0xFFFFFFFF);
            Gecko.poke32(0x356D5D78, 0xFFFFFFFF);

        }

        private void button144_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5D7C, Convert.ToUInt16(numericUpDown49.Value)); //Wizzro Damage
            Gecko.poke16(0x356D5D7E, Convert.ToUInt16(numericUpDown49.Value)); //Wizzro Damage

        }

        private void button143_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5D80, Convert.ToUInt16(numericUpDown50.Value)); //Wizzro hearts

        }

        private void button138_Click(object sender, EventArgs e)
        {

            wizzrocostume(0x356D5D82, comboBox18.Text); //wizzro costumes

        }

        public void wizzrocostume(uint address1, string mode)
        {
            switch (mode)
            {
                case "Standard Outfit":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Standard Outfit (Master-Quest)":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Standard Outfit (Twilight)":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Pirate's Hat":
                    Gecko.poke08(address1, 0x0A);
                    break;
            }
        }

        private void button145_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5E58, 0x00000000); //lock twimidna

        }

        private void button147_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5E58, 0x00000003); //unlock twimidna

        }

        private void button150_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5E60, 0xFFFFFFFF); //unlock twimidna
            Gecko.poke32(0x356D5E64, 0xFFFFFFFF); //unlock twimidna
            Gecko.poke32(0x356D5E68, 0xFFFFFFFF); //unlock twimidna
            Gecko.poke32(0x356D5E6C, 0xFFFFFFFF); //unlock twimidna

        }

        private void button152_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5E70, Convert.ToUInt16(numericUpDown52.Value)); //twimidna Damage
            Gecko.poke16(0x356D5E72, Convert.ToUInt16(numericUpDown52.Value)); //twimidna Damage

        }

        private void button151_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5E74, Convert.ToUInt16(numericUpDown53.Value)); //twimidna hearts

        }


        private void button153_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5F4C, 0x00000000); //lock younglink

        }

        private void button155_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5F4C, 0x00000003); //unlock younglink

        }

        private void button158_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5F54, 0xFFFFFFFF); //unlock younglink
            Gecko.poke32(0x356D5F58, 0xFFFFFFFF); //unlock younglink
            Gecko.poke32(0x356D5F5C, 0xFFFFFFFF); //unlock younglink
            Gecko.poke32(0x356D5F60, 0xFFFFFFFF); //unlock younglink

        }

        private void button160_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5F64, Convert.ToUInt16(numericUpDown55.Value)); //younglink Damage
            Gecko.poke16(0x356D5F66, Convert.ToUInt16(numericUpDown55.Value)); //younglink Damage

        }

        private void button159_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5F68, Convert.ToUInt16(numericUpDown56.Value)); //younglink hearts

        }

        private void button161_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6040, 0x00000000); //lock tingle

        }

        private void button163_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6040, 0x00000003); //unlock tingle

        }

        private void button166_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6048, 0xFFFFFFFF); //unlock tingle
            Gecko.poke32(0x356D604C, 0xFFFFFFFF); //unlock tingle
            Gecko.poke32(0x356D6050, 0xFFFFFFFF); //unlock tingle
            Gecko.poke32(0x356D6054, 0xFFFFFFFF); //unlock tingle

        }

        private void button168_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D6058, Convert.ToUInt16(numericUpDown58.Value)); //tingle Damage
            Gecko.poke16(0x356D605A, Convert.ToUInt16(numericUpDown58.Value)); //tingle Damage

        }

        private void button167_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D605C, Convert.ToUInt16(numericUpDown59.Value)); //tingle hearts

        }


        private void button169_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D631C, 0x00000000); //lock Linkle

        }

        private void button171_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D631C, 0x00000003); //unlock Linkle

        }

        private void button174_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6324, 0xFFFFFFFF); //unlock Linkle
            Gecko.poke32(0x356D6328, 0xFFFFFFFF); //unlock Linkle
            Gecko.poke32(0x356D632C, 0xFFFFFFFF); //unlock Linkle
            Gecko.poke32(0x356D6330, 0xFFFFFFFF); //unlock Linkle

        }

        private void button176_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D6334, Convert.ToUInt16(numericUpDown61.Value)); //linkle Damage
            Gecko.poke16(0x356D6336, Convert.ToUInt16(numericUpDown61.Value)); //linkle Damage

        }

        private void button175_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D6338, Convert.ToUInt16(numericUpDown62.Value)); //linkle hearts

        }


        private void button177_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6410, 0x00000000); //lock Skull Kid

        }

        private void button179_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6410, 0x00000003); //unlock Skull Kid

        }

        private void button182_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6418, 0xFFFFFFFF); //unlock Skull Kid
            Gecko.poke32(0x356D641C, 0xFFFFFFFF); //unlock Skull Kid
            Gecko.poke32(0x356D6420, 0xFFFFFFFF); //unlock Skull Kid
            Gecko.poke32(0x356D6424, 0xFFFFFFFF); //unlock Skull Kid

        }

        private void button184_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D6428, Convert.ToUInt16(numericUpDown64.Value)); //skull Damage
            Gecko.poke16(0x356D642A, Convert.ToUInt16(numericUpDown64.Value)); //skull Damage

        }

        private void button183_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D642C, Convert.ToUInt16(numericUpDown65.Value)); //skull hearts

        }


        private void button185_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6504, 0x00000000); //lock Toon-Link

        }

        private void button187_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6504, 0x00000003); //unlock Toon-Link

        }

        private void button190_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D650C, 0xFFFFFFFF); //toonlink skill
            Gecko.poke32(0x356D6510, 0xFFFFFFFF);
            Gecko.poke32(0x356D6514, 0xFFFFFFFF);
            Gecko.poke32(0x356D6518, 0xFFFFFFFF);

        }

        private void button192_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D651C, Convert.ToUInt16(numericUpDown67.Value)); //toon Damage
            Gecko.poke16(0x356D651E, Convert.ToUInt16(numericUpDown67.Value)); //toon Damage

        }

        private void button191_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D6520, Convert.ToUInt16(numericUpDown68.Value)); //toon hearts

        }


        private void button193_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D65F8, 0x00000000); //lock Tetra

        }

        private void button195_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D65F8, 0x00000003); //unlock Tetra

        }

        private void button198_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D65F8, 0xFFFFFFFF); //tetra skills
            Gecko.poke32(0x356D6604, 0xFFFFFFFF); //tetra skills
            Gecko.poke32(0x356D6608, 0xFFFFFFFF); //tetra skills
            Gecko.poke32(0x356D660C, 0xFFFFFFFF); //tetra skills

        }

        private void button200_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D6610, Convert.ToUInt16(numericUpDown70.Value)); //tetra Damage
            Gecko.poke16(0x356D6612, Convert.ToUInt16(numericUpDown70.Value)); //tetra Damage

        }

        private void button199_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D6614, Convert.ToUInt16(numericUpDown71.Value)); //tetra hearts

        }


        private void button201_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D66EC, 0x00000000); //lock King

        }

        private void button203_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D66EC, 0x00000003); //unlock King

        }

        private void button206_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D66F4, 0xFFFFFFFF); //skill King
            Gecko.poke32(0x356D66F8, 0xFFFFFFFF); //skill King
            Gecko.poke32(0x356D66FC, 0xFFFFFFFF); //skill King
            Gecko.poke32(0x356D6700, 0xFFFFFFFF); //skill King

        }

        private void button208_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D6704, Convert.ToUInt16(numericUpDown73.Value)); //king Damage
            Gecko.poke16(0x356D6706, Convert.ToUInt16(numericUpDown73.Value)); //king Damage

        }

        private void button207_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D6708, Convert.ToUInt16(numericUpDown74.Value)); //king hearts

        }

        private void button209_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D67E0, 0x00000000); //lock Medli

        }

        private void button211_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D67E0, 0x00000003); //unlock Medli

        }

        private void button214_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D67E8, 0xFFFFFFFF); //Medli Skill
            Gecko.poke32(0x356D67EC, 0xFFFFFFFF); //Medli Skill
            Gecko.poke32(0x356D67F0, 0xFFFFFFFF); //Medli Skill
            Gecko.poke32(0x356D67F4, 0xFFFFFFFF); //Medli Skill

        }

        private void button216_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D67F8, Convert.ToUInt16(numericUpDown76.Value)); //Medli Damage
            Gecko.poke16(0x356D67FA, Convert.ToUInt16(numericUpDown76.Value)); //Medli Damage

        }

        private void button215_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D67FC, Convert.ToUInt16(numericUpDown77.Value)); //medli hearts

        }

        private void button23_Click(object sender, EventArgs e)
        {

            freemode(0x356153FD, comboBox19.Text);

        }

        public void freemode(uint address1, string mode)
        {
            switch (mode)
            {
                case "Link":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Zelda":
                    Gecko.poke08(address1, 0x01);
                    break;

                case "Sheik":
                    Gecko.poke08(address1, 0x02);
                    break;

                case "Impa":
                    Gecko.poke08(address1, 0x03);
                    break;

                case "Ganondorf":
                    Gecko.poke08(address1, 0x04);
                    break;

                case "Darunia":
                    Gecko.poke08(address1, 0x05);
                    break;

                case "Ruto":
                    Gecko.poke08(address1, 0x06);
                    break;

                case "Agitha":
                    Gecko.poke08(address1, 0x07);
                    break;

                case "Midna":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Fi":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Ghirahim":
                    Gecko.poke08(address1, 0x0A);
                    break;

                case "Zant":
                    Gecko.poke08(address1, 0x0B);
                    break;

                case "Lana":
                    Gecko.poke08(address1, 0x0D);
                    break;

                case "Cia":
                    Gecko.poke08(address1, 0x2C);
                    break;

                case "Volga":
                    Gecko.poke08(address1, 0x2D);
                    break;

                case "Wizzro":
                    Gecko.poke08(address1, 0x2E);
                    break;

                case "Twili Midna":
                    Gecko.poke08(address1, 0x2F);
                    break;

                case "Young Link":
                    Gecko.poke08(address1, 0x30);
                    break;

                case "Tingle":
                    Gecko.poke08(address1, 0x31);
                    break;

                case "Ganon (Ganon-Mode)":
                    Gecko.poke08(address1, 0x32);
                    break;

                case "Cucco":
                    Gecko.poke08(address1, 0x33);
                    break;

                case "Linkle":
                    Gecko.poke08(address1, 0x34);
                    break;

                case "Skull Kid":
                    Gecko.poke08(address1, 0x35);
                    break;

                case "Toon-Link":
                    Gecko.poke08(address1, 0x36);
                    break;

                case "Tetra":
                    Gecko.poke08(address1, 0x37);
                    break;

                case "King Daphnes":
                    Gecko.poke08(address1, 0x38);
                    break;

                case "Medli":
                    Gecko.poke08(address1, 0x39);
                    break;
            }
        }
    }
}
