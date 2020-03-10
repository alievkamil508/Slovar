using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum Direction
        {
            FromAbove,
            FromLeft,
            FromDiagonal
        }

        private struct Node
        {
            public int distance;
            public Direction direction;
        }

        
        private Node[,] MakeEditGraph(string string1, string string2)
        {
            
            int num_cols = string1.Length + 1;
            int num_rows = string2.Length + 1;
            Node[,] nodes = new Node[num_rows, num_cols];

            
            for (int r = 0; r < num_rows; r++)
            {
                nodes[r, 0].distance = r;
                nodes[r, 0].direction = Direction.FromAbove;
            }

            
            for (int c = 0; c < num_cols; c++)
            {
                nodes[0, c].distance = c;
                nodes[0, c].direction = Direction.FromLeft;
            }

            
            char[] chars1 = string1.ToCharArray();
            char[] chars2 = string2.ToCharArray();
            for (int c = 1; c < num_cols; c++)
            {
               
                for (int r = 1; r < num_rows; r++)
                {
                    
                    int distance1 = nodes[r - 1, c].distance + 1;
                    int distance2 = nodes[r, c - 1].distance + 1;
                    int distance3 = int.MaxValue;
                    if (chars1[c - 1] == chars2[r - 1])
                    {
                       
                        distance3 = nodes[r - 1, c - 1].distance;
                    }

                    
                    if ((distance1 <= distance2) && (distance1 <= distance3))
                    {
                        
                        nodes[r, c].distance = distance1;
                        nodes[r, c].direction = Direction.FromAbove;
                    }
                    else if (distance2 <= distance3)
                    {
                       
                        nodes[r, c].distance = distance2;
                        nodes[r, c].direction = Direction.FromLeft;
                    }
                    else
                    {
                        
                        nodes[r, c].distance = distance3;
                        nodes[r, c].direction = Direction.FromDiagonal;
                    }
                }
            }

            

            return nodes;
        }

        
        private void DumpArray(Node[,] nodes)
        {
            int num_rows = nodes.GetUpperBound(0) + 1;
            int num_cols = nodes.GetUpperBound(1) + 1;

            Console.WriteLine("**********");
           
            for (int r = 0; r < num_rows; r++)
            {
                for (int c = 0; c < num_cols; c++)
                {
                    string txt = "";
                    switch (nodes[r, c].direction)
                    {
                        case Direction.FromAbove:
                            txt = "v";
                            break;
                        case Direction.FromLeft:
                            txt = "-";
                            break;
                        case Direction.FromDiagonal:
                            txt = "\\";
                            break;
                    }
                    txt += nodes[r, c].distance.ToString();
                    Console.Write(string.Format("{0,3}", txt));
                }
                Console.WriteLine();
            }
            Console.WriteLine("**********");
        }

        
        private void DumpPath(Stack<int> row, Stack<int> col)
        {
            Console.WriteLine("**********");
            int[] rows = row.ToArray();
            int[] cols = col.ToArray();
            for (int i = 0; i < row.Count; i++)
            {
                Console.Write("(" + rows[i] + ", " + cols[i] + ") ");
            }
            Console.WriteLine();
            Console.WriteLine("**********");
        }

        
        private string[] Words;

       
        private void Form1_Load(object sender, EventArgs e)
        {
            Words = File.ReadAllLines("Words.txt");
            txtWord.Text = "";

            
            AutoCompleteStringCollection word_source =
                new AutoCompleteStringCollection();
            word_source.AddRange(Words);
            txtAuto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAuto.AutoCompleteCustomSource = word_source;
            txtAuto.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

       
        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            lstGuesses.Items.Clear();
            string word = txtWord.Text;
            if (word.Length == 0) return;

           
            string[] words;
            int[] values;
            FindBestMatches(word, 10, out words, out values);

           
            for (int i = 0; i < words.Length; i++)
            {
                lstGuesses.Items.Add(values[i].ToString() +
                    '\t' + words[i]);
            }
        }

        
        private void FindBestMatches(string word, int num_matches, out string[] words, out int[] values)
        {
            
            string start_char = word.Substring(0, 1).ToUpper();
            int start_index = Array.BinarySearch(Words, start_char);
            List<string> match_words = new List<string>();
            List<int> match_values = new List<int>();
            for (int i = start_index + 1; i < Words.Length; i++)
            {
                
                string test_word = Words[i];
                if (test_word.Substring(0, 1).ToUpper() != start_char) break;

               
                int max_length = Math.Min(test_word.Length, word.Length);
                string short_word = test_word.Substring(0, max_length);

                
                Node[,] nodes = MakeEditGraph(word, short_word);

                
                int x = nodes.GetUpperBound(0);
                int y = nodes.GetUpperBound(1);
                match_words.Add(test_word);
                match_values.Add(nodes[x, y].distance);
            }

           
            string[] match_words_array = match_words.ToArray();
            int[] match_values_array = match_values.ToArray();
            Array.Sort(match_values_array, match_words_array);

            
            int max = Math.Min(num_matches, match_values_array.Length);
            words = new string[max];
            Array.Copy(match_words_array, words, max);
            values = new int[max];
            Array.Copy(match_values_array, values, max);
        }

        private void lstGuesses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
