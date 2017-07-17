using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GithubPracticeVS
{

    public partial class Form1 : Form
    {

        private System.Media.SoundPlayer player = null;

        private void StopSound()
        {
            if (player != null) {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }

        private void PlaySound()
        {
            string SoundFile = "";
            player = new System.Media.SoundPlayer(SoundFile);
            player.Play();
        }

        private void Subtitle() {

            System.IO.StreamReader cReader = new System.IO.StreamReader("../../Subtitle.txt", System.Text.Encoding.Default);

            string stResult = string.Empty;

            while(cReader.Peek() >= 0)
            {
                string stBuffer = cReader.ReadLine();
                stResult += stBuffer + System.Environment.NewLine;
            }
            cReader.Close();
            Console.WriteLine(stResult);

            Console.WriteLine("GithubPracticeVS");

            Console.WriteLine("Constantly asking, \"Why am l here? Why am I in this world?\"");
            Console.WriteLine("I almost feel like l was looking for a reason to die.");
            Console.WriteLine("That's why l play drums like there's no tomorrow.");
            Console.WriteLine("Everything disappears, everything fades out in this world.");
            Console.WriteLine("The next moment...");
            Console.WriteLine("...the person you love...");
            Console.WriteLine("...may not be there.");
            Console.WriteLine("It happened so many times...");
            Console.WriteLine("Everything was like a...");
            Console.WriteLine("dream, like a nightmare.");
            Console.WriteLine("The life of X JAPAN...");
            Console.WriteLine("...the life of me...");
            Console.WriteLine("...after all those years of mystery...");
            Console.WriteLine("I don't know what we are.");
            Console.WriteLine("The day I'm gonna die...");
            Console.WriteLine("I'm gonna tell myself...");
            Console.WriteLine("at least I tried everything.");

            Console.WriteLine("I did everything.");

            Console.WriteLine("Hi. This is Yoshiki, from the band X JAPAN");
            Console.WriteLine("We are playing Madison Square Garden in New York.");
            Console.WriteLine("Saturday, October 11th");

            Console.WriteLine("Join me now for Yoshiki's 20 most influential hard rock songs on Sirius XM Channel 13...");

            Console.WriteLine("It's great I mean, we always wanted to go overseas..");
            Console.WriteLine("You know, because of internet our music started spreading.");

            Console.WriteLine("Yes, it was kind of our dream to...");
            Console.WriteLine("you know");
            Console.WriteLine("come here");
            Console.WriteLine("Especially Madison Square Garden");

            Console.WriteLine("People call us like 'Visual Kei'");
            Console.WriteLine("It's like visual rock in Japan.");

            Console.WriteLine("It's crazy outfit and crazy makeup and everything");
            Console.WriteLine("But the same time we play super heavy music as well as super sooft music");

            Console.WriteLine("Almost 20 years ago, I was ready to die for X.");

            Console.WriteLine("X JAPAN's era was over.");
            Console.WriteLine("Swan sings only one time before they die.");


            Console.WriteLine("Pain...");
            Console.WriteLine("...doesn't...");
            Console.WriteLine("...age.");
            Console.WriteLine("After 30 years,");
            Console.WriteLine("40 years,");
            Console.WriteLine("still the same");

            Console.WriteLine("Everything disappears, everything fades out in this world.");
            Console.WriteLine("But the feeling of the...");

            Console.WriteLine("But the pain never disappears.");
        }

        public Form1()
        {
            InitializeComponent();
            Subtitle();
            textBox1.Text += "We are X";
        }
    }
}
