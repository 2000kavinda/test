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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // Get the input text from the text box
                string inputText = InputTextBox.Text;

                // Create a dictionary to map regular letters to their corresponding braille letters
                Dictionary<char, string> brailleMap = new Dictionary<char, string>()
            {
                {'a', "⠇"},
                {'b', "⠃"},
                {'c', "⠉"},
                {'d', "⠙"},
                {'e', "⠑"},
                {'f', "⠋"},
                {'g', "⠛"},
                {'h', "⠓"},
                {'i', "⠊"},
                {'j', "⠚"},
                {'k', "⠅"},
                {'l', "⠇"},
                {'m', "⠍"},
                {'n', "⠝"},
                {'o', "⠕"},
                {'p', "⠏"},
                {'q', "⠟"},
                {'r', "⠗"},
                {'s', "⠎"},
                {'t', "⠞"},
                {'u', "⠥"},
                {'v', "⠧"},
                {'w', "⠺"},
                {'x', "⠭"},
                {'y', "⠽"},
                {'z', "⠵"}
            };

                // Create a StringBuilder to store the output braille letters
                StringBuilder outputBuilder = new StringBuilder();

                // Convert each letter of the input text to its corresponding braille letter
                foreach (char c in inputText)
                {
                    // Check if the letter is in the dictionary
                    if (brailleMap.ContainsKey(c))
                    {
                        // If the letter is in the dictionary, add its braille letter to the output
                        outputBuilder.Append(brailleMap[c]);
                    }
                    else
                    {
                        // If the letter is not in the dictionary, add a space to the output
                        outputBuilder.Append(" ");
                    }
                }

                // Set the output text to the braille letters
                OutputTextBox.Text = outputBuilder.ToString();
            }
        }
    }

