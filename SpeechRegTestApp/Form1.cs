using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace SpeechRegTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SpeechRecognitionEngine regEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        bool flag; 
        private void PbxStart_Click(object sender, EventArgs e)
        {
            PbxStart.Visible = false;
            //SpeechRegSettings();
            flag = true; 
            //regEngine.RecognizeAsync(); 
        }
        void SpeechRegSettings()
        {
            string[] speechCommands = { "Hello", "How are you" };
            Choices choices = new Choices(speechCommands);
            Grammar grammar = new Grammar(new GrammarBuilder(choices));
            regEngine.LoadGrammar(grammar);
            regEngine.SetInputToDefaultAudioDevice();
            regEngine.SpeechRecognized += SpeechRecognized;
        }
        void SpeechSynthSettings()
        {
            speechSynthesizer.SelectVoiceByHints(VoiceGender.Female); 
        }

        private void SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            PbxStart.Visible = true;
            flag = true; 
            if (e.Result.Text == "Hello")
            {
                MessageBox.Show(e.Result.Text);
                speechSynthesizer.SpeakAsync(e.Result.Text);
            }
            if (e.Result.Text == "How are you")
            {
                MessageBox.Show(e.Result.Text);
                speechSynthesizer.SpeakAsync(e.Result.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int level;
            level = cbxLevel.SelectedIndex;
            int min = 0;
            int max = 0;
            switch (level)
            {
                case 0:
                    min = 1;
                    max = 9;
                    break; 

                case 1:
                    min = 10;
                    max = 99;
                    break;

                case 2:
                    min = 100;
                    max = 999;
                    break;

                case 3:
                    min = 1000;
                    max = 9999;
                    break;
                case 4:
                    min = 10000;
                    max = 99999;
                    break;
                case 5:
                    min = 100000;
                    max = 999999;
                    break;
                case 6:
                    min = 1000000;
                    max = 9999999;
                    break;
                case 7:
                    min = 10000000;
                    max = 99999999;
                    break;
                case 8:
                    min = 100000000;
                    max = 999999999;
                    break;
                default:
                    Console.WriteLine("The level is out of range");
                    break;
            }
            RandomNumberCreater randomNumberCreater = new RandomNumberCreater();
            textBox1.Text = (randomNumberCreater.ValueCreator(min, max).ToString());
        }
    }
}
