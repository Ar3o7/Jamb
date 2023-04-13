using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Jamb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool[] diceSelected = new bool[5];
        public int[] diceResults = new int[5];
        public int rollsRemaining = 3;
        public readonly Random _random = new Random();
        public int fr_score_single = 0;
        public int fr_maxs = 0;
        public int fr_mins = 0;
        public int fr_score_min_max = 0;
        public int fr_score_rest = 0;
        public int fr_score = 0;
        public bool button_lock = true;
        public bool start = false;

        // ---------up-column-variables----------------------
        public int up_score_single = 0;
        public int up_counter = 0;
        public int up_maxs = 0;
        public int up_mins = 0;
        public int up_score_min_max = 0;
        public int up_score_rest = 0;
        public int up_score = 0;

        // ---------do-column-variables----------------------
        public int do_score_single = 0;
        public int do_counter = 0;
        public int do_maxs = 0;
        public int do_mins = 0;
        public int do_score_min_max = 0;
        public int do_score_rest = 0;
        public int do_score = 0;

        // --------Score-Variables----------------------------
        public int score_single = 0;
        public int score_min_max = 0;
        public int score = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

      
        public int Single_dice(int[] dice, int number)
        {
            if (dice[0] == number | dice[1] == number | dice[2] == number | dice[3] == number | dice[4] == number) ;
            int sum = 0;
            {
                foreach (int element in dice)
                {
                    if (element == number)
                    {
                        sum += element;
                    }
                }
                return sum;
            }
        }

        public int Min_max(int[] dice)
        {
            int sum = 0;
            foreach (int element in dice)
            {
                sum += element;
            }
            return sum;
        }

        public int one_pair(int[] dice)
        {
            int sum = 0;

            for (int i = 0; i < dice.Length - 1; i++)
            {
                for (int j = i + 1; j < dice.Length; j++)
                {
                    if (dice[i] == dice[j])
                    {
                        int pairSum = dice[i] + dice[j];

                        if (pairSum > sum)
                        {
                            sum = pairSum;
                        }
                    }
                }
            }

            return sum + 10;
        }
        public int three_of_akind(int[] dice)
        {
            int sum = 0;
            int count = 0;

            for (int i = 1; i <= 6; i++)
            {
                count = 0;

                for (int j = 0; j < dice.Length; j++)
                {
                    if (dice[j] == i)
                    {
                        count++;
                    }
                }

                if (count >= 3)
                {
                    sum = i * 3;
                    break;
                }
            }

            if (sum > 0)
            {
                return sum + 20;
            }
            else
            {
                return 0;
            }

        }

        public int straight(int[] dice)
        {
            int[] expected1 = { 1, 2, 3, 4, 5 };
            int[] expected2 = { 2, 3, 4, 5, 6 };

            Array.Sort(dice);

            if (Enumerable.SequenceEqual(dice, expected1) || Enumerable.SequenceEqual(dice, expected2))
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }

        public int full(int[] dice)
        {
            Array.Sort(dice);
            int sum = 0;
            int count1 = 1, count2 = 0, count3 = 0, prev = dice[0];

            for (int i = 1; i < dice.Length; i++)
            {
                if (dice[i] == prev)
                {
                    count1++;
                }
                else
                {
                    if (count1 == 2 && count2 == 3)
                    {
                        sum = dice.Sum();
                        return sum + 30;
                    }
                    else if (count1 == 3 && count2 == 2)
                    {
                        sum = dice.Sum();
                        return sum + 30;
                    }

                    count3 = count2;
                    count2 = count1;
                    count1 = 1;
                }

                prev = dice[i];
            }

            if (count1 == 2 && count2 == 3)
            {
                sum = dice.Sum();
                return sum + 30;
            }
            else if (count1 == 3 && count2 == 2)
            {
                sum = dice.Sum();
                return sum + 30;
            }

            return sum;
        }


        public int poker(int[] dice)
        {
            int sum = 0;
            int[] count = new int[7];

            for (int i = 0; i < dice.Length; i++)
            {
                count[dice[i]]++;
            }

            for (int i = 1; i <= 6; i++)
            {
                if (count[i] >= 4)
                {
                    sum = i * 4 + 40;
                    break;
                }

            }

            return sum;
        }
        public int yamb(int[] dice)
        {
            int sum = 0;
            int num = 1;
            for (int i = 0; i <= 3; i++)
            {
                if (dice[i] == dice[i + 1])
                    num++;
            }
            if (num == 5)
                return sum + 50;
            else
                return sum;
        }
        public void reset()
        {
            rollsRemaining = 3;
            rollButton.Content = $"Roll";

            for (int i = 0; i <= 4; i++)
            {
                diceSelected[i] = false;
            }
            dice1.BorderThickness = new Thickness(0);
            dice2.BorderThickness = new Thickness(0);
            dice3.BorderThickness = new Thickness(0);
            dice4.BorderThickness = new Thickness(0);
            dice5.BorderThickness = new Thickness(0);
        }

        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            if (rollsRemaining <= 0) return;

            rollsRemaining--;
            rollButton.Content = $"Roll {rollsRemaining}";

            fr_single_score.Text = fr_score_single.ToString();

            if(fr_maxs != 0 & fr_mins!=0 )
            {
                fr_score_min_max = fr_maxs - fr_mins;
                fr_min_max_score.Text = fr_score_min_max.ToString();
            }

            fr_total_score.Text = fr_score_rest.ToString();

            //----------------------Up-Column-score------------------------
            up_single_score.Text = up_score_single.ToString();

            if (up_maxs != 0 & up_mins != 0)
            {
                up_score_min_max = up_maxs - up_mins;
                up_min_max_score.Text = up_score_min_max.ToString();
            }

            up_total_score.Text = up_score_rest.ToString();

            //----------------------do-Column-score------------------------
            
            do_single_score.Text = do_score_single.ToString();

            if (do_maxs != 0 & do_mins != 0)
            {
                do_score_min_max = do_maxs - do_mins;
                do_min_max_score.Text = do_score_min_max.ToString();
            }

            do_total_score.Text = do_score_rest.ToString();


            score_single = do_score_single + fr_score_single + up_score_single;
            single_score.Text = score_single.ToString();

            score_min_max = fr_score_min_max + up_score_min_max + do_score_min_max;
            min_max_score.Text = score_min_max.ToString();

            score = score_min_max + score_single + fr_score_rest + up_score_rest + do_score_rest;
            total_score.Text = score.ToString();

            start = true;
            // Roll dice
            for (int i = 0; i <= 4; i++)
            {
                if (!diceSelected[i])
                {
                    diceResults[i] = _random.Next(1, 7); ;
                }
            }
       


         
            // Show results
            ShowResult(dice1, diceResults[0]);
            ShowResult(dice2, diceResults[1]);
            ShowResult(dice3, diceResults[2]);
            ShowResult(dice4, diceResults[3]);
            ShowResult(dice5, diceResults[4]);
            button_lock = false;
        }



        private void ShowResult(Button diceButton, int result)
        {
            diceButton.Content = new Image
            {
                Source = new BitmapImage(new Uri($"/dice{result}.png", UriKind.Relative)),
                Width = 55
            };
        }

        private void Dice_Click(object sender, RoutedEventArgs e)
        {
            if(start == true)
            {
                var button = (Button)sender;
                var index = int.Parse(button.Name.Substring(4)) - 1;
                diceSelected[index] = !diceSelected[index];

                if (diceSelected[index])
                {
                    button.BorderThickness = new Thickness(2);
                    button.BorderBrush = SystemColors.HighlightBrush;
                }
                else
                {
                    button.BorderThickness = new Thickness(0);
                }
            }
            
        }

        
        private void fr_1_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int single1 = Single_dice(diceResults, 1);
                fr_score_single += single1;
                fr_1.Content = single1;
                reset();
                button_lock = true;
            }
            
        }

        private void fr_2_click(object sender, RoutedEventArgs e)
        {
            if(button_lock== false)
            {
                int single2 = Single_dice(diceResults, 2);
                fr_score_single += single2;
                fr_2.Content = single2;
                reset();
                button_lock = true;
            }
            
        }

        private void fr_3_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int single3 = Single_dice(diceResults, 3);
                fr_score_single += single3;
                fr_3.Content = single3;
                reset();
                button_lock = true;
            }
            
        }

        private void fr_4_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int single4 = Single_dice(diceResults, 4);
                fr_score_single += single4;
                fr_4.Content = single4;
                reset();
                button_lock = true;
            }
            
        }

        private void fr_5_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int single5 = Single_dice(diceResults, 5);
                fr_score_single += single5;
                fr_5.Content = single5;
                reset();
                button_lock = true;
            }
            
        }

        private void fr_6_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int single6 = Single_dice(diceResults, 6);
                fr_score_single += single6;
                fr_6.Content = single6;
                reset();
                button_lock = true;
            }
            
        }

        private void fr_min_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int min = Min_max(diceResults);
                fr_mins = min;
                fr_min.Content = min;
                reset();
                button_lock = true;
            }
            
        }

        private void fr_max_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int max = Min_max(diceResults);
                fr_maxs = max;
                fr_max.Content = max;
                reset();
                button_lock = true;
            }
            
        }

        private void fr_1Pair_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int pair = one_pair(diceResults);
                fr_score_rest += pair;
                fr_1Pair.Content = pair;
                reset();
                button_lock = true;
            }
            
        }

        private void fr_3OfK_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int three = three_of_akind(diceResults);
                fr_score_rest += three;
                fr_3OfK.Content = three;
                reset();
                button_lock = true;
            }
           
        }

        private void fr_str_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int str = straight(diceResults);
                fr_score_rest += str;
                fr_str.Content = str;
                reset();
                button_lock = true;
            }
            
        }

        private void fr_full_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int full_S = full(diceResults);
                fr_score_rest += full_S;
                fr_full.Content = full_S;
                reset();
                button_lock = true;
            }

            
        }

        private void fr_pok_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int poker_s = poker(diceResults);
                fr_score_rest += poker_s;
                fr_pok.Content = poker_s;
                reset();
                button_lock = true;
            }
            
        }

        private void fr_yamb_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int yamb_s = yamb(diceResults);
                fr_score_rest += yamb_s;
                fr_yamb.Content = yamb_s;
                reset();
                button_lock = true;
            }
            
        }
        //----------up-collum------------------------------------------
        private void up_1_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int single1 = Single_dice(diceResults, 1);
                up_score_single += single1;
                up_1.Content = single1;
                reset();
                button_lock = true;
                up_counter = 1;
            }

        }

        private void up_2_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter == 1)
            {
                int single2 = Single_dice(diceResults, 2);
                up_score_single += single2;
                up_2.Content = single2;
                reset();
                button_lock = true;
                up_counter ++;
            }
        }

        private void up_3_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter == 2)
            {
                int single3 = Single_dice(diceResults, 3);
                up_score_single += single3;
                up_3.Content = single3;
                reset();
                button_lock = true;
                up_counter++;
            }
        }

        private void up_4_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter == 3)
            {
                int single4 = Single_dice(diceResults, 4);
                up_score_single += single4;
                up_4.Content = single4;
                reset();
                button_lock = true;
                up_counter++;
            }
        }

        private void up_5_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter == 4)
            {
                int single5 = Single_dice(diceResults, 5);
                up_score_single += single5;
                up_5.Content = single5;
                reset();
                button_lock = true;
                up_counter++;
            }
        }

        private void up_6_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter == 5)
            {
                int single6 = Single_dice(diceResults, 6);
                up_score_single += single6;
                up_6.Content = single6;
                reset();
                button_lock = true;
                up_counter++;
            }
        }

        private void up_max_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter == 6)
            {
                int max = Min_max(diceResults);
                up_maxs = max;
                up_max.Content = max;
                reset();
                button_lock = true;
                up_counter++;
            }
        }

        private void up_min_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter==7)
            {
                int min =   Min_max(diceResults);
                up_mins = min;
                up_min.Content = min;
                reset();
                button_lock = true;
                up_counter++;
            }
        }

        private void up_1Pair_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter==8)
            {
                int pair = one_pair(diceResults);
                up_score_rest += pair;
                up_1Pair.Content = pair;
                reset();
                button_lock = true;
                up_counter++;
            }
        }

        private void up_3OfK_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter == 9)
            {
                int three = three_of_akind(diceResults);
                up_score_rest += three;
                up_3OfK.Content = three;
                reset();
                button_lock = true;
                up_counter++;
            }
        }

        private void up_str_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter == 10)
            {
                int str = straight(diceResults);
                up_score_rest += str;
                up_str.Content = str;
                reset();
                button_lock = true;
                up_counter++;
            }
        }

        private void up_full_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter == 11)
            {
                int full_S = full(diceResults);
                up_score_rest += full_S;
                up_full.Content = full_S;
                reset();
                button_lock = true;
                up_counter++;
            }
        }

        private void up_pok_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter == 12)
            {
                int poker_s = poker(diceResults);
                up_score_rest += poker_s;
                up_pok.Content = poker_s;
                reset();
                button_lock = true;
                up_counter++;
            }
        }

        private void up_yamb_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & up_counter == 13)
            {
                int yamb_s = yamb(diceResults);
                up_score_rest += yamb_s;
                up_yamb.Content = yamb_s;
                reset();
                button_lock = true;
                up_counter++;
            }
        }

        //----------do-collum------------------------------------------
        private void do_1_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 13)
            {
                int single1 = Single_dice(diceResults, 1);
                do_score_single += single1;
                do_1.Content = single1;
                reset();
                button_lock = true;
                do_counter = 1;
            }
        }

        private void do_2_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 12)
            {
                int single2 = Single_dice(diceResults, 2);
                do_score_single += single2;
                do_2.Content = single2;
                reset();
                button_lock = true;
                do_counter++;
            }
        }

        private void do_3_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 11)
            {
                int single3 = Single_dice(diceResults, 3);
                do_score_single += single3;
                do_3.Content = single3;
                reset();
                button_lock = true;
                do_counter++;
            }
        }

        private void do_4_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 10)
            {
                int single5 = Single_dice(diceResults, 5);
                do_score_single += single5;
                do_5.Content = single5;
                reset();
                button_lock = true;
                do_counter++;
            }
        }

        private void do_5_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 9)
            {
                int single5 = Single_dice(diceResults, 5);
                do_score_single += single5;
                do_5.Content = single5;
                reset();
                button_lock = true;
                do_counter++;
            }
        }

        private void do_6_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 8)
            {
                int single6 = Single_dice(diceResults, 6);
                do_score_single += single6;
                do_6.Content = single6;
                reset();
                button_lock = true;
                do_counter++;
            }
        }

        private void do_max_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 7)
            {
                int max = Min_max(diceResults);
                do_maxs = max;
                do_max.Content = max;
                reset();
                button_lock = true;
                do_counter++;
            }
        }

        private void do_min_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 6)
            {
                int min = Min_max(diceResults);
                do_mins = min;
                do_min.Content = min;
                reset();
                button_lock = true;
                do_counter++;
            }
        }

        private void do_1Pair_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 5)
            {
                int pair = one_pair(diceResults);
                do_score_rest += pair;
                do_1Pair.Content = pair;
                reset();
                button_lock = true;
                do_counter++;
            }
        }

        private void do_3OfK_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 4)
            {
                int three = three_of_akind(diceResults);
                do_score_rest += three;
                do_3OfK.Content = three;
                reset();
                button_lock = true;
                do_counter++;
            }
        }

        private void do_str_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 3)
            {
                int str = straight(diceResults);
                do_score_rest += str;
                do_str.Content = str;
                reset();
                button_lock = true;
                do_counter++;
            }
        }

        private void do_full_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 2)
            {
                int full_S = full(diceResults);
                do_score_rest += full_S;
                do_full.Content = full_S;
                reset();
                button_lock = true;
                do_counter++;
            }
        }

        private void do_pok_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false & do_counter == 1)
            {
                int poker_s = poker(diceResults);
                do_score_rest += poker_s;
                do_pok.Content = poker_s;
                reset();
                button_lock = true;
                do_counter++;
            }
        }

        private void do_yamb_click(object sender, RoutedEventArgs e)
        {
            if (button_lock == false)
            {
                int yamb_s = yamb(diceResults);
                do_score_rest += yamb_s;
                do_yamb.Content = yamb_s;
                reset();
                button_lock = true;
                do_counter = 1;
            }
        }
    }
}

