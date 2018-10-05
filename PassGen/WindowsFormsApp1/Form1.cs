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
    public partial class PassGen : Form
    {

        private int RandomSeed;
        private int constantSalt;
        private short passwordLength;
        public PassGen()
        {
            InitializeComponent();
            constantSalt =
            (
                (MousePosition.X.GetHashCode() * MousePosition.Y.GetHashCode()).GetHashCode()
                *
                (DateTime.UtcNow.GetHashCode() * DateTime.UtcNow.Millisecond.GetHashCode() * DateTime.UtcNow.Ticks.GetHashCode()).GetHashCode()
                *
                Guid.NewGuid().GetHashCode()
            );
        }
        public int RefreshRandomSeed(int salt)
        {
            RandomSeed =                                                                                                                            //Сид генератора рандомных чисел                                                                                                                                      //генерируется из:
            (
                (MousePosition.X.GetHashCode() * MousePosition.Y.GetHashCode()).GetHashCode()                                                   //Хэша позиции мыши
                *
                (DateTime.UtcNow.GetHashCode() * DateTime.UtcNow.Millisecond.GetHashCode() * DateTime.UtcNow.Ticks.GetHashCode()).GetHashCode() //Хэша даты&времени с учётом милисикунд
                *
                Guid.NewGuid().GetHashCode()                                                                                                    //Хэша Giud
                *
                (salt.GetHashCode() * constantSalt.GetHashCode()).GetHashCode()                                                                 //Соли, передаваемой в функцию и соли, генерируемой при запуске
            ).GetHashCode();
            return RandomSeed;
        }

        private void PassGen_Load(object sender, EventArgs e)
        {
            Random rand = new Random(RefreshRandomSeed(265));
            VersionTitle.Text = "v_0."+rand.Next().GetHashCode().ToString();
        }

        private void PasswordLength_Picked()
        {
            if (passwordLength > 0   && passwordLength < 10) { PasswordStrength.Text = "Short"; PasswordStrength.ForeColor = Color.DarkRed; }
            if (passwordLength >= 10 && passwordLength < 32) { PasswordStrength.Text = "Normal"; PasswordStrength.ForeColor = Color.ForestGreen; }
            if (passwordLength >= 32 && passwordLength < 128) { PasswordStrength.Text = "Long"; PasswordStrength.ForeColor = Color.DarkBlue; }
            if (passwordLength >= 128)
            {
                PasswordStrength.Text = "Wow";
                PasswordStrength.ForeColor = Color.Red;
                PasswordStrength.ForeColor = Color.OrangeRed;
                PasswordStrength.ForeColor = Color.Orange;
                PasswordStrength.ForeColor = Color.Yellow;
                PasswordStrength.ForeColor = Color.YellowGreen;
                PasswordStrength.ForeColor = Color.Green;
                PasswordStrength.ForeColor = Color.LightBlue;
                PasswordStrength.ForeColor = Color.Blue;
                PasswordStrength.ForeColor = Color.BlueViolet;
                PasswordStrength.ForeColor = Color.Violet;
            }
        }
        private void PasswordLength_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                passwordLength = Convert.ToInt16(PasswordLength.Text);
            }
            catch (Exception) { PasswordLength.Text = ""; PasswordStrength.Text = "Strength"; passwordLength = 0; PasswordStrength.ForeColor = Title.ForeColor; }
            PasswordLength_Picked();
        }

        private void PasswordLength_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                passwordLength = Convert.ToInt16(PasswordLength.SelectedItem);
            }
            catch (Exception) { PasswordLength.Text = ""; PasswordStrength.Text = "Strength"; passwordLength = 0; PasswordStrength.ForeColor = Title.ForeColor; }
            PasswordLength_Picked();
        }

        private string GeneratePassword()
        {
            Random randomCharacter = new Random(RefreshRandomSeed(MousePosition.X.GetHashCode() * MousePosition.Y.GetHashCode()).GetHashCode());
            short length;
            string password = "";
            bool AZ = PasswordSymbols.GetItemChecked(0),
                 az = PasswordSymbols.GetItemChecked(1),
                 num = PasswordSymbols.GetItemChecked(2),
                 sym = PasswordSymbols.GetItemChecked(3);
                PasswordOutput.Text += (PasswordSymbols.GetItemChecked(0).ToString() + PasswordSymbols.GetItemChecked(1).ToString() + PasswordSymbols.GetItemChecked(2).ToString() + PasswordSymbols.GetItemChecked(3).ToString());
            if ( AZ == false && az == false && num == false && sym == false) return "";
            try
            {
                length = passwordLength;
            }
            catch (Exception) { length = 0; };
            for (short i = 0; i < length; i++)
            {
                char c;
                while (true)
                {
                    c = (char)randomCharacter.Next(32, 127);
                    if (char.IsUpper(c) && AZ == true) break;
                    if (char.IsLower(c) && az == true) break;
                    if (char.IsNumber(c) && num == true) break;
                    if (char.IsSymbol(c) && sym == true) break;
                }
                password += c;
            }
            return password;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            PasswordOutput.Text = "";
            for (int i = 0; i < 15; i++)
            {
                PasswordOutput.MaxLength = passwordLength*15;
                PasswordOutput.Text += GeneratePassword();
                PasswordOutput.Text += Environment.NewLine;
                if (passwordLength > 128) PasswordOutput.Text += Environment.NewLine;
            }
            
        }
    }
}
