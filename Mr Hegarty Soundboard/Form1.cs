using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Mr_Hegarty_Soundboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.three_two_five);
            sp.Play();
            sp.Dispose();
        }

        private void startaskquestionBtn_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.start_ask_question);
            sp.Play();
            sp.Dispose();
        }

        private void thismeansBtn_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.so_this_means);
            sp.Play();
            sp.Dispose();
        }

        private void smacklipsBtn_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.smack_lips);
            sp.Play();
            sp.Dispose();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.simple_addition);
            sp.Play();
            sp.Dispose();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.really_quickly);
            sp.Play();
            sp.Dispose();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.question_straighforward);
            sp.Play();
            sp.Dispose();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.our_brain_isnt_good);
            sp.Play();
            sp.Dispose();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.okay);
            sp.Play();
            sp.Dispose();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.number_line);
            sp.Play();
            sp.Dispose();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.basic_things);
            sp.Play();
            sp.Dispose();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.and_what_it_means);
            sp.Play();
            sp.Dispose();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.add_count_combine);
            sp.Play();
            sp.Dispose();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.example_one);
            sp.Play();
            sp.Dispose();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.count_1_from_8_get_9);
            sp.Play();
            sp.Dispose();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.brains_super_good);
            sp.Play();
            sp.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.mr_hegarty_here);
            sp.Play();
            sp.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.look_see_how_much_got);
            sp.Play();
            sp.Dispose();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.in_this_vid_talking_about);
            sp.Play();
            sp.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.imagine_we_had);
            sp.Play();
            sp.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.hope_found_useful);
            sp.Play();
            sp.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.hi_another_video);
            sp.Play();
            sp.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.help_count_things);
            sp.Play();
            sp.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.gonna_do_example);
            sp.Play();
            sp.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources.finish_summarise);
            sp.Play();
            sp.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources._35_add_27);
            sp.Play();
            sp.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sp = new SoundPlayer(stream: Properties.Resources._1_to_9);
            sp.Play();
            sp.Dispose();
        }
    }
}
