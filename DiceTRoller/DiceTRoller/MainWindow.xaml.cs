using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace DiceTRoller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Character character;
        bool validity = false;
        public MainWindow()
        {
            InitializeComponent();
            character = new Character();
        }

        /// <summary>
        /// Save new character information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveNewBtn_Click(object sender, RoutedEventArgs e)
        {
            if (CheckValidity() == false)
            {
                MessageBox.Show("Please check your inputs and fix the errors. Ability scores should only be numbers, " +
                    "and a level for the character must be selected.");
                return;
            }

            character.char_name = CharacterNameTxtBx.Text;
            character.char_lvl = CharacterLvlComboBx.SelectedIndex;
            character.char_str = Int32.Parse(StrScoreTxtBx.Text);
        }

        /// <summary>
        /// Check that all input boxes have valid items
        /// </summary>
        /// <returns></returns>
        private bool CheckValidity()
        {
            if (CharacterNameTxtBx.Text.Length > 1) //check for input
            {
                if (Int32.TryParse(StrScoreTxtBx.Text, out int str))
                {
                    if (Int32.TryParse(DexScoreTxtBx.Text, out int dex))
                    {
                        if (Int32.TryParse(ConScoreTxtBx.Text, out int con))
                        {
                            if (Int32.TryParse(IntScoreTxtBx.Text, out int intel))
                            {
                                if (Int32.TryParse(WisScoreTxtBx.Text, out int wis))
                                {
                                    if (Int32.TryParse(ChaScoreTxtBx.Text, out int cha))
                                    {
                                        if (Int32.TryParse(ProfModTxtBx.Text, out int profMod))
                                        {
                                            return true;
                                        }
                                        MessageBox.Show("Your Charisma score should be a number.");
                                        return false;
                                    }
                                    MessageBox.Show("Your Wisdom score should be a number.");
                                    return false;
                                }
                                MessageBox.Show("Your Intelligence score should be a number.");
                                return false;
                            }
                            MessageBox.Show("Your Constitution score should be a number.");
                            return false;
                        }
                        MessageBox.Show("Your Dexterity score should be a number.");
                        return false;
                    }
                    MessageBox.Show("Your Strength score should be a number.");
                    return false;
                }
                MessageBox.Show("Please enter a character name.");
                return false;
            }
            MessageBox.Show("Please check that all boxes have data in them. Remember, scores need to be in numbers (0-9) and a character level must be chosen.");
            return false;
        }

        private void EditSavedBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SavedCharacterComboBox.SelectedIndex < 1)
            {
                MessageBox.Show("You have to select a character before you can edit their data. If you have no characters saved, please check 'New Character'.");
                return;
            }

            if (CheckValidity() == false)
            {
                MessageBox.Show("Oops! Check that all the boxes have data filled!");
                return;
            }

            if(NewCharacterRBtn.IsChecked == true)
            {
                MessageBox.Show("Can't edit a saved character while inputting new character information!");
                return;
            }

            //TO DO:
            //Add logic for updating the character saved

        }

        /// <summary>
        /// Disables saved character buttons
        /// Clears text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCharacterRBtn_Checked(object sender, RoutedEventArgs e)
        {
            //disable saved character combo box
            SavedCharacterComboBox.SelectedIndex = -1;
            SavedCharacterComboBox.IsEnabled = false;

            //allow text box editing
            CharacterNameTxtBx.IsEnabled = true;
            CharacterLvlComboBx.IsEnabled = true;
            StrScoreTxtBx.IsEnabled = true;
            DexScoreTxtBx.IsEnabled = true;
            ConScoreTxtBx.IsEnabled = true;
            IntScoreTxtBx.IsEnabled = true;
            WisScoreTxtBx.IsEnabled = true;
            ChaScoreTxtBx.IsEnabled = true;
            ProfModTxtBx.IsEnabled = true;

            //clear text boxes and combo box
            CharacterNameTxtBx.Text = "Character Name";
            CharacterLvlComboBx.SelectedIndex = -1;
            StrScoreTxtBx.Text = "Str";
            DexScoreTxtBx.Text = "Dex";
            ConScoreTxtBx.Text = "Con";
            IntScoreTxtBx.Text = "Int";
            WisScoreTxtBx.Text = "Wis";
            ChaScoreTxtBx.Text = "Cha";
            ProfModTxtBx.Text = "Proficiency";
        }

        /// <summary>
        /// Deletes saved character information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
