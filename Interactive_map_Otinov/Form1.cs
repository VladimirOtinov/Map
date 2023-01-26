using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interactive_map_Otinov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PanelWithOptions.Visible = false;

            Checkpoint.Visible = false;
            label1.Visible = false;

            Drinks.Visible = false;
            DrinksLabel.Visible = false;

            EnergyBars.Visible = false;
            EnergyLabel.Visible = false;

            Toilet.Visible = false;
            ToiletLabel.Visible = false;

            Info.Visible = false;
            InfoLabel.Visible = false;

            Medecine.Visible = false;
            medicalLabel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void finish_Click(object sender, EventArgs e)
        {
            PanelWithOptions.Visible = true;

            Checkpoint.Visible = true;
            label1.Visible = false;

            Checkpoint.Text = "Финиш";

            Drinks.Visible = false;
            DrinksLabel.Visible = false;

            EnergyBars.Visible = false;
            EnergyLabel.Visible = false;

            Toilet.Visible = false;
            ToiletLabel.Visible = false;

            Info.Visible = false;
            InfoLabel.Visible = false;

            Medecine.Visible = false;
            medicalLabel.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Drinks_Click(object sender, EventArgs e)
        {

        }

        private void Checkpoint_Click(object sender, EventArgs e)
        {

        }

        private void DrinksLabel_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e) 
        /* случайно кликнул, поэтому название не поменял, 
         * это первый чек (МЦК Лужники), прошу понять и простить*/
        {
            PanelWithOptions.Visible = true;
            Checkpoint.Visible = true;
            label1.Visible = true;

            Checkpoint.Text = "МЦК Лужники";
            label1.Text = "Особенности:";

            Drinks.Visible = true;
            DrinksLabel.Visible = true;

            EnergyBars.Visible = true;
            EnergyLabel.Visible = true;

            Toilet.Visible = false;
            ToiletLabel.Visible = false;

            Info.Visible = false;
            InfoLabel.Visible = false;

            Medecine.Visible = false;
            medicalLabel.Visible = false;

            Medecine.Location = new Point(11, 481);
            medicalLabel.Location = new Point(108, 481);
        }


        private void check2_Click(object sender, EventArgs e)
        {
            PanelWithOptions.Visible = true;
            Checkpoint.Visible = true;
            label1.Visible = true;

            Checkpoint.Text = "Новодевичей монастырь";
            label1.Text = "Особенности:";

            Drinks.Visible = true;
            DrinksLabel.Visible = true;

            EnergyBars.Visible = true;
            EnergyLabel.Visible = true;

            Toilet.Visible = true;
            ToiletLabel.Visible = true;

            Info.Visible = true;
            InfoLabel.Visible = true;

            Medecine.Visible = true;
            medicalLabel.Visible = true;

            Medecine.Location = new Point(11, 481);
            medicalLabel.Location = new Point(108, 481);
        }

        private void check3_Click(object sender, EventArgs e)
        {
            PanelWithOptions.Visible = true;
            Checkpoint.Visible = true;
            label1.Visible = true;

            Checkpoint.Text = "Метро Киевская";
            label1.Text = "Особенности:";

            Drinks.Visible = true;
            DrinksLabel.Visible = true;

            EnergyBars.Visible = true;
            EnergyLabel.Visible = true;

            Toilet.Visible = true;
            ToiletLabel.Visible = true;

            Info.Visible = false;
            InfoLabel.Visible = false;

            Medecine.Visible = false;
            medicalLabel.Visible = false;

            Medecine.Location = new Point(11, 481);
            medicalLabel.Location = new Point(108, 481);

        }

        private void check4_Click(object sender, EventArgs e)
        {
            PanelWithOptions.Visible = true;
            Checkpoint.Visible = true;
            label1.Visible = true;

            Checkpoint.Text = "МИД";
            label1.Text = "Особенности:";

            Drinks.Visible = true;
            DrinksLabel.Visible = true;

            EnergyBars.Visible = true;
            EnergyLabel.Visible = true;

            Toilet.Visible = true;
            ToiletLabel.Visible = true;

            Info.Visible = false;
            InfoLabel.Visible = false;

            Medecine.Visible = true;
            medicalLabel.Visible = true;

            Medecine.Location = new Point(11, 403);
            medicalLabel.Location = new Point(108, 402);
        }

        private void check5_Click(object sender, EventArgs e)
        {
            PanelWithOptions.Visible = true;
            Checkpoint.Visible = true;
            label1.Visible = true;

            Checkpoint.Text = "Парк Горького";
            label1.Text = "Особенности:";

            Drinks.Visible = true;
            DrinksLabel.Visible = true;

            EnergyBars.Visible = true;
            EnergyLabel.Visible = true;

            Toilet.Visible = true;
            ToiletLabel.Visible = true;

            Info.Visible = true;
            InfoLabel.Visible = true;

            Medecine.Visible = false;
            medicalLabel.Visible = false;

            Medecine.Location = new Point(11, 481);
            medicalLabel.Location = new Point(108, 481);
        }

        private void check6_Click(object sender, EventArgs e)
        {
            PanelWithOptions.Visible = true;
            Checkpoint.Visible = true;
            label1.Visible = true;

            Checkpoint.Text = "Здания РАН";
            label1.Text = "Особенности:";

            Drinks.Visible = true;
            DrinksLabel.Visible = true;

            EnergyBars.Visible = true;
            EnergyLabel.Visible = true;

            Toilet.Visible = true;
            ToiletLabel.Visible = true;

            Info.Visible = false;
            InfoLabel.Visible = false;

            Medecine.Visible = false;
            medicalLabel.Visible = false;

            Medecine.Location = new Point(11, 481);
            medicalLabel.Location = new Point(108, 481);
        }

        private void check7_Click(object sender, EventArgs e)
        {
            PanelWithOptions.Visible = true;
            Checkpoint.Visible = true;
            label1.Visible = true;

            Checkpoint.Text = "Метро Воробевы горы";
            label1.Text = "Особенности:";

            Drinks.Visible = true;
            DrinksLabel.Visible = true;

            EnergyBars.Visible = true;
            EnergyLabel.Visible = true;

            Toilet.Visible = true;
            ToiletLabel.Visible = true;

            Info.Visible = true;
            InfoLabel.Visible = true;

            Medecine.Visible = true;
            medicalLabel.Visible = true;

            Medecine.Location = new Point(11, 481);
            medicalLabel.Location = new Point(108, 481);
        }

        private void check8_Click(object sender, EventArgs e)
        {
            PanelWithOptions.Visible = true;
            Checkpoint.Visible = true;
            label1.Visible = true;

            Checkpoint.Text = "Стадион Лужники";
            label1.Text = "Особенности:";

            Drinks.Visible = true;
            DrinksLabel.Visible = true;

            EnergyBars.Visible = true;
            EnergyLabel.Visible = true;

            Toilet.Visible = true;
            ToiletLabel.Visible = true;

            Info.Visible = true;
            InfoLabel.Visible = true;

            Medecine.Visible = true;
            medicalLabel.Visible = true;

            Medecine.Location = new Point(11, 481);
            medicalLabel.Location = new Point(108, 481);
        }

        private void LongWay_Click(object sender, EventArgs e)
        {
            PanelWithOptions.Visible = true;
            Checkpoint.Text = "Race start";
            label1.Text = "Самбо полный марафон";
            Checkpoint.Visible = true;
            label1.Visible = true;

            Drinks.Visible = false;
            DrinksLabel.Visible = false;

            EnergyBars.Visible = false;
            EnergyLabel.Visible = false;

            Toilet.Visible = false;
            ToiletLabel.Visible = false;

            Info.Visible = false;
            InfoLabel.Visible = false;

            Medecine.Visible = false;
            medicalLabel.Visible = false;
        }

        private void MidWay_Click(object sender, EventArgs e)
        {
            PanelWithOptions.Visible = true;
            Checkpoint.Text = "Race start";
            label1.Text = "Джанго полу-марафон";
            Checkpoint.Visible = true;
            label1.Visible = true;

            Drinks.Visible = false;
            DrinksLabel.Visible = false;

            EnergyBars.Visible = false;
            EnergyLabel.Visible = false;

            Toilet.Visible = false;
            ToiletLabel.Visible = false;

            Info.Visible = false;
            InfoLabel.Visible = false;

            Medecine.Visible = false;
            medicalLabel.Visible = false;
        }

        private void ShortWay_Click(object sender, EventArgs e)
        {
            PanelWithOptions.Visible = true;
            Checkpoint.Text = "Race start";
            label1.Text = "Капоэира 5 километров веселый забег";
            Checkpoint.Visible = true;
            label1.Visible = true;

            Drinks.Visible = false;
            DrinksLabel.Visible = false;

            EnergyBars.Visible = false;
            EnergyLabel.Visible = false;

            Toilet.Visible = false;
            ToiletLabel.Visible = false;

            Info.Visible = false;
            InfoLabel.Visible = false;

            Medecine.Visible = false;
            medicalLabel.Visible = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            PanelWithOptions.Visible = false;
            Checkpoint.Visible = false;
            label1.Visible = false;

            Drinks.Visible = false;
            DrinksLabel.Visible = false;

            EnergyBars.Visible = false;
            EnergyLabel.Visible = false;

            Toilet.Visible = false;
            ToiletLabel.Visible = false;

            Info.Visible = false;
            InfoLabel.Visible = false;

            Medecine.Visible = false;
            medicalLabel.Visible = false;
        }
    }
}
