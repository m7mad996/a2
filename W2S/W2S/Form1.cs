using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W2S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* ComboBox */
        private void Form1_Load(object sender, EventArgs e)
        {

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            Keyword.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Keyword.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //
            data.Add("a (á)");
            data.Add("a (â)");
            data.Add("a (à)");
            data.Add("a (ā)");
            data.Add("a (ä)");
            data.Add("a (ã)");
            data.Add("a (ǎ)");
            data.Add("a (ȧ)");
            data.Add("a (ẚ)");
            data.Add("a (ạ)");
            data.Add("a (ą)");
            data.Add("Alpha");
            data.Add("And");
            data.Add("Add");
            data.Add("At (@)");
            data.Add("Angstrom");
            data.Add("Angle (∠)");
            data.Add("Angle (∡)");
            data.Add("Angle (∟)");
            //
            data.Add("Angle (θ)");
            data.Add("Theta");
            //
            data.Add("Angle (ϕ)");
            data.Add("Phi");
            //
            data.Add("Angle (⦜)");
            data.Add("Right Angle");
            //
            data.Add("Anticlockwise Rotation (↺)");
            data.Add("Counterclockwise Rotation (↺)");
            //
            data.Add("Anticlockwise Rotation (↶)");
            data.Add("Counterclockwise Rotation (↶)");
            //
            data.Add("Approximately Equal To");
            data.Add("Beta");
            //
            data.Add("Belongs To");
            data.Add("Element Of");
            //
            data.Add("Because");
            data.Add("Since");
            //
            data.Add("Celsius");
            data.Add("Chi");
            data.Add("Caret");
            //
            data.Add("Clockwise Rotation (↻)");
            data.Add("Clockwise Rotation (↷)");
            //
            data.Add("Correct");
            data.Add("Check");
            data.Add("Tick");
            //
            data.Add("Club (♣)");
            data.Add("Delta (∆)");
            data.Add("Delta (δ)");
            data.Add("Degree");
            data.Add("Divide");
            data.Add("Diamond (♦)");
            //
            data.Add("Down Arrow");
            data.Add("Down Arrow (⇓)");
            data.Add("Down Arrow (⬇)");
            //
            data.Add("Down Left Arrow (↙)");
            data.Add("Left Down Arrow (↙)");
            //
            data.Add("Down Left Arrow (⇙)");
            data.Add("Left Down Arrow (⇙)");
            //
            data.Add("Down Right Arrow (↘)");
            data.Add("Right Down Arrow (↘)");
            //
            data.Add("Down Right Arrow (⇘)");
            data.Add("Right Down Arrow (⇘)");
            //
            data.Add("Down Up Arrow (↕)");
            data.Add("Up Down Arrow (↕)");
            //
            data.Add("Down Up Arrow (⇕)");
            data.Add("Up Down Arrow (⇕)");
            //
            data.Add("Dot (●)");
            data.Add("Point (●)");
            data.Add("Full Stop (●)");
            //
            data.Add("Does Not Belong To");
            data.Add("Not Element Of");
            //
            data.Add("Dislike");
            data.Add("Not OK");
            //
            data.Add("e (é)");
            data.Add("e (ê)");
            data.Add("e (è)");
            data.Add("e (ē)");
            data.Add("e (ë)");
            data.Add("e (ẽ)");
            data.Add("e (ě)");
            data.Add("e (ė)");
            data.Add("e (ẻ)");
            data.Add("e (ẹ)");
            data.Add("e (ę)");
            data.Add("Equivalent To");
            data.Add("Epsilon");
            data.Add("Empty Set");
            //
            data.Add("Eta");
            data.Add("Efficiency");
            //
            data.Add("Erosion");
            data.Add("Symmetric Difference");
            //
            data.Add("Exclusive Or");
            data.Add("XOR");
            //
            data.Add("For All");
            data.Add("Fahrenheit");
            data.Add("Fuck You!");
            data.Add("Gamma");
            data.Add("Greater Than");
            data.Add("Greater Than Greater Than");
            data.Add("Greater Than or Equal To");
            data.Add("Half");
            data.Add("Heart (♥)");
            data.Add("i (í)");
            data.Add("i (î)");
            data.Add("i (ì)");
            data.Add("i (ī)");
            data.Add("i (ï)");
            data.Add("Infinity");
            data.Add("Iota");
            data.Add("Integral");
            data.Add("Implies");
            data.Add("Intersection");
            data.Add("Kappa");
            data.Add("Loop");
            data.Add("Lambda");
            data.Add("Less Than");
            data.Add("Less Than or Equal To");
            data.Add("Less Than Less Than");
            data.Add("Left Arrow");
            data.Add("Left Arrow (⇐)");
            //
            data.Add("Left Right Arrow (↔)");
            data.Add("Right Left Arrow (↔)");
            //
            data.Add("Left Right Arrow (⇔)");
            data.Add("Right Left Arrow (⇔)");
            //
            data.Add("Left Right Arrow (⬌)");
            data.Add("Right Left Arrow (⬌)");
            //
            data.Add("Left Up Arrow (↖)");
            data.Add("Up Left Arrow (↖)");
            //
            data.Add("Left Up Arrow (⇖)");
            data.Add("Up Left Arrow (⇖)");
            //
            data.Add("Like");
            data.Add("OK");
            //
            data.Add("LOL");
            data.Add("LMFAO");
            data.Add("Mu");
            data.Add("More Than");
            data.Add("More Than or Equal To");
            data.Add("More Than More Than");
            //
            data.Add("Multiply (×)");
            data.Add("Product (×)");
            //
            data.Add("Multiply (•)");
            data.Add("Product (•)");
            //
            data.Add("Nu");
            data.Add("Not");
            data.Add("Not Equal To");
            data.Add("Not Subset");
            data.Add("Not Superset");
            data.Add("o (ó)");
            data.Add("o (ô)");
            data.Add("o (ò)");
            data.Add("o (ō)");
            data.Add("o (ö)");
            data.Add("o (õ)");
            data.Add("Omega i");
            data.Add("Omega ii");
            //
            data.Add("Or");
            data.Add("Such That (|)");
            //
            data.Add("Omicron");
            data.Add("One Third");
            data.Add("Proportion");
            data.Add("Percent");
            data.Add("Perpendicular");
            data.Add("Plus or Minus");
            data.Add("Power (^)");
            data.Add("Pi");
            data.Add("Psi");
            data.Add("Peace");
            data.Add("Pointing Finger");
            data.Add("Quarter");
            //
            data.Add("Root (√)");
            data.Add("Square Root");
            //
            data.Add("Root (∛)");
            data.Add("Cube Root");
            //
            data.Add("Root (∜)");
            data.Add("Quad Root");
            //
            data.Add("Rho");
            data.Add("Reversed Caret");
            data.Add("Rotation (↻)");
            data.Add("Rotation (↺)");
            //
            data.Add("Right Arrow (⇒)");
            data.Add("So");
            //
            data.Add("Right Arrow");
            data.Add("Right Arrow (➔)");
            data.Add("Right Arrow (➤)");
            //
            data.Add("Right Arrow (⇛)");
            data.Add("Result (⇛)");
            data.Add("Such That (⇛)");
            data.Add("Which Gives (⇛)");
            //
            data.Add("Right Arrow (⇶)");
            data.Add("Result (⇶)");
            data.Add("Such That (⇶)");
            data.Add("Which Gives (⇶)");
            //
            data.Add("Right Up Arrow (↗)");
            data.Add("Up Right Arrow (↗)");
            //
            data.Add("Right Up Arrow (⇗)");
            data.Add("Up Right Arrow (⇗)");
            //
            data.Add("Subtract");
            data.Add("Subset");
            data.Add("Sigma i");
            data.Add("Sigma ii");
            data.Add("Summation of");
            data.Add("Strict Subset");
            data.Add("Superset");
            data.Add("Strict Superset");
            data.Add("Spade (♠)");
            //
            data.Add("Smile i");
            data.Add(":)");
            //
            data.Add("Smile ii");
            data.Add(":D");
            //
            data.Add("Tau");
            data.Add("Tilde");
            data.Add("Tone (Single)");
            data.Add("Tone (Double)");
            data.Add("Therefore");
            data.Add("Two Third");
            data.Add("Three Quarters");
            data.Add("There Exists");
            data.Add("There Does Not Exists");
            data.Add("u (ú)");
            data.Add("u (û)");
            data.Add("u (ù)");
            data.Add("u (ū)");
            data.Add("u (ü)");
            data.Add("Union");
            data.Add("Upsilon");
            data.Add("Up Arrow");
            data.Add("Up Arrow (⇑)");
            data.Add("Up Arrow (⬆)");
            //
            data.Add("Wink");
            data.Add(";)");
            //
            data.Add("Xi");
            data.Add("XD");
            data.Add("Zeta");            
            data.Add("0↑");
            data.Add("1↑");
            //
            data.Add("2↑");
            data.Add("Square");
            //
            data.Add("3↑");
            data.Add("Cube");
            //
            data.Add("4↑");
            data.Add("5↑");
            data.Add("6↑");
            data.Add("7↑");
            data.Add("8↑");
            data.Add("9↑");
            data.Add("n↑");
            data.Add("e↑");
            data.Add("i↑");
            data.Add("x↑");
            data.Add("t↑");
            data.Add("0↓");
            data.Add("1↓");
            data.Add("2↓");
            data.Add("3↓");
            data.Add("4↓");
            data.Add("5↓");
            data.Add("6↓");
            data.Add("7↓");
            data.Add("8↓");
            data.Add("9↓");
            data.Add("n↓");
            data.Add("e↓");
            data.Add("i↓");
            data.Add("x↓");
            data.Add("t↓");

            Keyword.AutoCompleteCustomSource = data;

        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        /* Clear All */
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control crt in this.Controls)
            {
                if (crt.GetType() == typeof(TextBox) || crt.GetType() == typeof(ComboBox))
                    crt.Text = "";
            }
            Keyword.Focus();
        }

        /* Get Result */
        private void button1_Click_1(object sender, EventArgs e)
        {
            //
            string strKeyword = Keyword.Text;
            int KeywordLength = strKeyword.Length;

            if (KeywordLength == 0)
                MessageBox.Show("Keyword not entered !!!");
            else {

            //A

            if (Keyword.Text == "At (@)")
                Result.Text = "@";

            else if (Keyword.Text == "a (á)")
                Result.Text = "á";

            else if (Keyword.Text == "a (â)")
                Result.Text = "â";

            else if (Keyword.Text == "a (à)")
                Result.Text = "à";

            else if (Keyword.Text == "a (ā)")
                Result.Text = "ā";

            else if (Keyword.Text == "a (ä)")
                Result.Text = "ä";

            else if (Keyword.Text == "a (ã)")
                Result.Text = "ã";

            else if (Keyword.Text == "a (ǎ)")
                Result.Text = "ǎ";

            else if (Keyword.Text == "a (ȧ)")
                Result.Text = "ȧ";

            else if (Keyword.Text == "a (ẚ)")
                Result.Text = "ẚ";

            else if (Keyword.Text == "a (ạ)")
                Result.Text = "ạ";

            else if (Keyword.Text == "a (ą)")
                Result.Text = "ą";

            else if (Keyword.Text == "Alpha")
                Result.Text = "α";

            else if (Keyword.Text == "Add")
                Result.Text = "+";

            else if (Keyword.Text == "And")
                Result.Text = "&";

            else if (Keyword.Text == "Angstrom")
                Result.Text = "Å";

            else if (Keyword.Text == "Approximately Equal To")
                Result.Text = "≈";

            else if (Keyword.Text == "Angle (θ)" || Keyword.Text == "Theta")
                Result.Text = "θ";

            else if (Keyword.Text == "Angle (ϕ)" || Keyword.Text == "Phi")
                Result.Text = "ϕ";

            else if (Keyword.Text == "Angle (∠)")
                Result.Text = "∠";

            else if (Keyword.Text == "Angle (∡)")
                Result.Text = "∡";

            else if (Keyword.Text == "Angle (∟)")
                Result.Text = "∟";

            else if (Keyword.Text == "Angle (⦜)" || Keyword.Text == "Right Angle")
                Result.Text = "⦜";

            else if (Keyword.Text == "Anticlockwise Rotation (↺)" || Keyword.Text == "Counterclockwise Rotation (↺)" || Keyword.Text == "Rotation (↺)")
                Result.Text = "↺";

            else if (Keyword.Text == "Anticlockwise Rotation (↶)" || Keyword.Text == "Counterclockwise Rotation (↶)")
                Result.Text = "↶";

            //B

            else if (Keyword.Text == "Beta")
                Result.Text = "β";

            else if (Keyword.Text == "Because" || Keyword.Text == "Since")
                Result.Text = "∵";

            else if (Keyword.Text == "Belongs To" || Keyword.Text == "Element Of")
                Result.Text = "∈";

            //C

            else if (Keyword.Text == "Correct" || Keyword.Text == "Check" || Keyword.Text == "Tick")
                Result.Text = "✓";

            else if (Keyword.Text == "Celsius")
                Result.Text = "℃";

            else if (Keyword.Text == "Chi")
                Result.Text = "χ";

            else if (Keyword.Text == "Caret")
                Result.Text = "^";

            else if (Keyword.Text == "Club (♣)")
                Result.Text = "♣";

            else if (Keyword.Text == "Clockwise Rotation (↻)" || Keyword.Text == "Rotation (↻)")
                Result.Text = "↻";

            else if (Keyword.Text == "Clockwise Rotation (↷)")
                Result.Text = "↷";

            //D

            else if (Keyword.Text == "Degree")
                Result.Text = "°";

            else if (Keyword.Text == "Delta (∆)")
                Result.Text = "∆";

            else if (Keyword.Text == "Delta (δ)")
                Result.Text = "δ";

            else if (Keyword.Text == "Divide")
                Result.Text = "÷";

            else if (Keyword.Text == "Dot (●)" || Keyword.Text == "Point (●)" || Keyword.Text == "Full Stop (●)")
                Result.Text = "●";

            else if (Keyword.Text == "Diamond (♦)")
                Result.Text = "♦";

            else if (Keyword.Text == "Does Not Belong To" || Keyword.Text == "Not Element Of")
                Result.Text = "∉";

            else if (Keyword.Text == "Down Arrow")
                Result.Text = "↓";

            else if (Keyword.Text == "Down Arrow (⇓)")
                Result.Text = "⇓";

            else if (Keyword.Text == "Down Arrow (⬇)")
                Result.Text = "⬇";

            else if (Keyword.Text == "Down Left Arrow (↙)" || Keyword.Text == "Left Down Arrow (↙)")
                Result.Text = "↙";

            else if (Keyword.Text == "Down Left Arrow (⇙)" || Keyword.Text == "Left Down Arrow (⇙)")
                Result.Text = "⇙";

            else if (Keyword.Text == "Down Right Arrow (↘)" || Keyword.Text == "Right Down Arrow (↘)")
                Result.Text = "↘";

            else if (Keyword.Text == "Down Right Arrow (⇘)" || Keyword.Text == "Right Down Arrow (⇘)")
                Result.Text = "⇘";

            else if (Keyword.Text == "Down Up Arrow (↕)" || Keyword.Text == "Up Down Arrow (↕)")
                Result.Text = "↕";

            else if (Keyword.Text == "Down Up Arrow (⇕)" || Keyword.Text == "Up Down Arrow (⇕)")
                Result.Text = "⇕";

            else if (Keyword.Text == "Dislike" || Keyword.Text == "Not OK")
                Result.Text = "👎";

            //E

            else if (Keyword.Text == "e (é)")
                Result.Text = "é";

            else if (Keyword.Text == "e (ê)")
                Result.Text = "ê";

            else if (Keyword.Text == "e (è)")
                Result.Text = "è";

            else if (Keyword.Text == "e (ē)")
                Result.Text = "ē";

            else if (Keyword.Text == "e (ë)")
                Result.Text = "ë";

            else if (Keyword.Text == "e (ẽ)")
                Result.Text = "ẽ";

            else if (Keyword.Text == "e (ě)")
                Result.Text = "ě";

            else if (Keyword.Text == "e (ė)")
                Result.Text = "ė";

            else if (Keyword.Text == "e (ẻ)")
                Result.Text = "ẻ";

            else if (Keyword.Text == "e (ẹ)")
                Result.Text = "ẹ";

            else if (Keyword.Text == "e (ę)")
                Result.Text = "ę";

            else if (Keyword.Text == "Equivalent To")
                Result.Text = "⇔";

            else if (Keyword.Text == "Eta" || Keyword.Text == "Efficiency")
                Result.Text = "η";

            else if (Keyword.Text == "Epsilon")
                Result.Text = "ɛ";

            else if (Keyword.Text == "Empty Set")
                Result.Text = "Ø";

            else if (Keyword.Text == "Exclusive Or" || Keyword.Text == "XOR")
                    Result.Text = "⊕";

            else if (Keyword.Text == "Erosion" || Keyword.Text == "Symmetric Difference")
                    Result.Text = "⊖";

            //F

            else if (Keyword.Text == "For All")
                Result.Text = "∀";

            else if (Keyword.Text == "Fahrenheit")
                Result.Text = "℉";

            else if (Keyword.Text == "Fuck You!")
                Result.Text = "🖕";

            //G

            else if (Keyword.Text == "Gamma")
                Result.Text = "γ";

            else if (Keyword.Text == "Greater Than" || Keyword.Text == "More Than")
                Result.Text = ">";

            else if (Keyword.Text == "Greater Than Greater Than" || Keyword.Text == "More Than More Than")
                Result.Text = "≫";

            else if (Keyword.Text == "Greater Than or Equal To" || Keyword.Text == "More Than or Equal To")
                Result.Text = "≥";

            //H

            else if (Keyword.Text == "Half")
                Result.Text = "½";

            else if (Keyword.Text == "Heart (♥)")
                Result.Text = "♥";

            //I

            else if (Keyword.Text == "i (í)")
                Result.Text = "í";

            else if (Keyword.Text == "i (î)")
                Result.Text = "î";

            else if (Keyword.Text == "i (ì)")
                Result.Text = "ì";

            else if (Keyword.Text == "i (ī)")
                Result.Text = "ī";

            else if (Keyword.Text == "i (ï)")
                Result.Text = "ï";

            else if (Keyword.Text == "Infinity")
                Result.Text = "∞";

            else if (Keyword.Text == "Iota")
                Result.Text = "ι";

            else if (Keyword.Text == "Integral")
                Result.Text = "ʃ";

            else if (Keyword.Text == "Implies")
                Result.Text = "⇒";

            else if (Keyword.Text == "Intersection")
                Result.Text = "∩";

            //K

            else if (Keyword.Text == "Kappa")
                Result.Text = "κ";

            //L

            else if (Keyword.Text == "Loop")
                Result.Text = "⌘";

            else if (Keyword.Text == "Lambda")
                Result.Text = "λ";

            else if (Keyword.Text == "Less Than")
                Result.Text = "<";

            else if (Keyword.Text == "Less Than or Equal To")
                Result.Text = "≤";

            else if (Keyword.Text == "Less Than Less Than")
                Result.Text = "≪";

            else if (Keyword.Text == "Left Arrow")
                Result.Text = "←";

            else if (Keyword.Text == "Left Arrow (⇐)")
                Result.Text = "⇐";

            else if (Keyword.Text == "Left Right Arrow (↔)" || Keyword.Text == "Right Left Arrow (↔)")
                Result.Text = "↔";

            else if (Keyword.Text == "Left Right Arrow (⇔)" || Keyword.Text == "Right Left Arrow (⇔)")
                Result.Text = "⇔";

            else if (Keyword.Text == "Left Right Arrow (⬌)" || Keyword.Text == "Right Left Arrow (⬌)")
                Result.Text = "⬌";

            else if (Keyword.Text == "Left Up Arrow (↖)" || Keyword.Text == "Up Left Arrow (↖)")
                Result.Text = "↖";

            else if (Keyword.Text == "Left Up Arrow (⇖)" || Keyword.Text == "Up Left Arrow (⇖)")
                Result.Text = "⇖";

            else if (Keyword.Text == "LOL")
                Result.Text = "😂";

            else if (Keyword.Text == "LMFAO")
                Result.Text = "🤣";

            else if (Keyword.Text == "Like" || Keyword.Text == "OK")
                Result.Text = "👍";

            //M

            else if (Keyword.Text == "Mu")
                Result.Text = "μ";

            else if (Keyword.Text == "Multiply (×)" || Keyword.Text == "Product (×)")
                Result.Text = "×";

            else if (Keyword.Text == "Multiply (•)" || Keyword.Text == "Product (•)")
                Result.Text = "•";

            //N

            else if (Keyword.Text == "Nu")
                Result.Text = "ν";

            else if (Keyword.Text == "Not")
                Result.Text = "¬";

            else if (Keyword.Text == "Not Equal To")
                Result.Text = "≠";

            else if (Keyword.Text == "Not Subset")
                Result.Text = "⊄";

            else if (Keyword.Text == "Not Superset")
                Result.Text = "⊅";

            //O

            else if (Keyword.Text == "o (ó)")
                Result.Text = "ó";

            else if (Keyword.Text == "o (ô)")
                Result.Text = "ô";

            else if (Keyword.Text == "o (ò)")
                Result.Text = "ò";

            else if (Keyword.Text == "o (ō)")
                Result.Text = "ō";

            else if (Keyword.Text == "o (ö)")
                Result.Text = "ö";

            else if (Keyword.Text == "o (õ)")
                Result.Text = "õ";

            else if (Keyword.Text == "Omega i")
                Result.Text = "ω";

            else if (Keyword.Text == "Omega ii")
                Result.Text = "Ω";

            else if (Keyword.Text == "Or" || Keyword.Text == "Such That (|)")
                Result.Text = "|";

            else if (Keyword.Text == "Omicron")
                Result.Text = "ο";

            else if (Keyword.Text == "One Third")
                Result.Text = "⅓";

            //P

            else if (Keyword.Text == "Proportion")
                Result.Text = "∝";

            else if (Keyword.Text == "Pi")
                Result.Text = "π";

            else if (Keyword.Text == "Psi")
                Result.Text = "ψ";

            else if (Keyword.Text == "Power (^)")
                Result.Text = "^";

            else if (Keyword.Text == "Percent")
                Result.Text = "%";

            else if (Keyword.Text == "Plus or Minus")
                Result.Text = "±";

            else if (Keyword.Text == "Perpendicular")
                Result.Text = "⊥";

            else if (Keyword.Text == "Peace")
                Result.Text = "✌";

            else if (Keyword.Text == "Pointing Finger")
                Result.Text = "👉";

            //Q

            else if (Keyword.Text == "Quarter")
                Result.Text = "¼";

            //R

            else if (Keyword.Text == "Root (√)" || Keyword.Text == "Square Root")
                Result.Text = "√";

            else if (Keyword.Text == "Root (∛)" || Keyword.Text == "Cube Root")
                Result.Text = "∛";

            else if (Keyword.Text == "Root (∜)" || Keyword.Text == "Quad Root")
                Result.Text = "∜";

            else if (Keyword.Text == "Reversed Caret")
                Result.Text = "∨";

            else if (Keyword.Text == "Rho")
                Result.Text = "ρ";

            else if (Keyword.Text == "Right Arrow")
                Result.Text = "→";

            else if (Keyword.Text == "Right Arrow (⇒)" || Keyword.Text == "So")
                Result.Text = "⇒";

            else if (Keyword.Text == "Right Arrow (⇛)" || Keyword.Text == "Result (⇛)" || Keyword.Text == "Which Gives (⇛)" || Keyword.Text == "Such That (⇛)")
                Result.Text = "⇛";

            else if (Keyword.Text == "Right Arrow (⇶)" || Keyword.Text == "Result (⇶)" || Keyword.Text == "Which Gives (⇶)" || Keyword.Text == "Such That (⇶)")
                Result.Text = "⇶";

            else if (Keyword.Text == "Right Arrow (➔)")
                Result.Text = "➔";

            else if (Keyword.Text == "Right Arrow (➤)")
                Result.Text = "➤";

            else if (Keyword.Text == "Right Up Arrow (↗)" || Keyword.Text == "Up Right Arrow (↗)")
                Result.Text = "↗";

            else if (Keyword.Text == "Right Up Arrow (⇗)" || Keyword.Text == "Up Right Arrow (⇗)")
                Result.Text = "⇗";

            //S

            else if (Keyword.Text == "Subtract")
                Result.Text = "-";

            else if (Keyword.Text == "Subset")
                Result.Text = "⊆";

            else if (Keyword.Text == "Strict Subset")
                Result.Text = "⊂";

            else if (Keyword.Text == "Superset")
                Result.Text = "⊇";

            else if (Keyword.Text == "Strict Superset")
                Result.Text = "⊃";

            else if (Keyword.Text == "Sigma i" || Keyword.Text == "Summation of")
                Result.Text = "Σ";

            else if (Keyword.Text == "Sigma ii")
                Result.Text = "σ";

            else if (Keyword.Text == "Spade (♠)")
                Result.Text = "♠";

            else if (Keyword.Text == "Smile i" || Keyword.Text == ":)")
                Result.Text = "🙂";

            else if (Keyword.Text == "Smile ii" || Keyword.Text == ":D")
                Result.Text = "😀";

            //T

            else if (Keyword.Text == "Tilde")
                Result.Text = "~";

            else if (Keyword.Text == "There Exists")
                Result.Text = "∃";

            else if (Keyword.Text == "There Does Not Exists")
                Result.Text = "∄";           

            else if (Keyword.Text == "Two Third")
                Result.Text = "⅔";

            else if (Keyword.Text == "Three Quarters")
                Result.Text = "¾";

            else if (Keyword.Text == "Tone (Single)")
                Result.Text = "♪";

            else if (Keyword.Text == "Tone (Double)")
                Result.Text = "♫";

            else if (Keyword.Text == "Therefore")
                Result.Text = "∴";

            else if (Keyword.Text == "Tau")
                Result.Text = "τ";

            //U

            else if (Keyword.Text == "u (ú)")
                Result.Text = "ú";

            else if (Keyword.Text == "u (û)")
                Result.Text = "û";

            else if (Keyword.Text == "u (ù)")
                Result.Text = "ù";

            else if (Keyword.Text == "u (ū)")
                Result.Text = "ū";

            else if (Keyword.Text == "u (ü)")
                Result.Text = "ü";

            else if (Keyword.Text == "Union")
                Result.Text = "∪";

            else if (Keyword.Text == "Upsilon")
                Result.Text = "υ";

            else if (Keyword.Text == "Up Arrow")
                Result.Text = "↑";

            else if (Keyword.Text == "Up Arrow (⇑)")
                Result.Text = "⇑";

            else if (Keyword.Text == "Up Arrow (⬆)")
                Result.Text = "⬆";

            //W
            else if (Keyword.Text == "Wink" || Keyword.Text == ";)")
                Result.Text = "😉";

            //X

            else if (Keyword.Text == "Xi")
                Result.Text = "ξ";

            else if (Keyword.Text == "XD")
                Result.Text = "😝";

            //Z

            else if (Keyword.Text == "Zeta")
                Result.Text = "ζ";

            //↑

            else if (Keyword.Text == "0↑")
                Result.Text = "⁰";

            else if (Keyword.Text == "1↑")
                Result.Text = "¹";

            else if (Keyword.Text == "2↑" || Keyword.Text == "Square")
                Result.Text = "²";

            else if (Keyword.Text == "3↑" || Keyword.Text == "Cube")
                Result.Text = "³";

            else if (Keyword.Text == "4↑")
                Result.Text = "⁴";

            else if (Keyword.Text == "5↑")
                Result.Text = "⁵";

            else if (Keyword.Text == "6↑")
                Result.Text = "⁶";

            else if (Keyword.Text == "7↑")
                Result.Text = "⁷";

            else if (Keyword.Text == "8↑")
                Result.Text = "⁸";

            else if (Keyword.Text == "9↑")
                Result.Text = "⁹";

            else if (Keyword.Text == "n↑")
                Result.Text = "ⁿ";

            else if (Keyword.Text == "e↑")
                Result.Text = "ᵉ";

            else if (Keyword.Text == "i↑")
                Result.Text = "ⁱ";

            else if (Keyword.Text == "x↑")
                Result.Text = "ˣ";

            else if (Keyword.Text == "t↑")
                Result.Text = "ᵗ";

            //↓

            else if (Keyword.Text == "0↓")
                Result.Text = "₀";

            else if (Keyword.Text == "1↓")
                Result.Text = "₁";

            else if (Keyword.Text == "2↓")
                Result.Text = "₂";

            else if (Keyword.Text == "3↓")
                Result.Text = "₃";

            else if (Keyword.Text == "4↓")
                Result.Text = "₄";

            else if (Keyword.Text == "5↓")
                Result.Text = "₅";

            else if (Keyword.Text == "6↓")
                Result.Text = "₆";

            else if (Keyword.Text == "7↓")
                Result.Text = "₇";

            else if (Keyword.Text == "8↓")
                Result.Text = "₈";

            else if (Keyword.Text == "9↓")
                Result.Text = "₉";

            else if (Keyword.Text == "n↓")
                Result.Text = "ₙ";

            else if (Keyword.Text == "e↓")
                Result.Text = "ₑ";

            else if (Keyword.Text == "i↓")
                Result.Text = "ᵢ";

            else if (Keyword.Text == "x↓")
                Result.Text = "ₓ";

            else if (Keyword.Text == "t↓")
                Result.Text = "ₜ";

            else { Result.Text = " "; MessageBox.Show("Keyword not found !!!"); }

            }

            if (Keyword.Text != "")
            {
                Clipboard.SetText(Result.Text);
            }

            Keyword.Focus();
        }

//

        /* Message Box */
        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("PS: Output results rendering blank or distorted (in app or document) may be fixed by changing their font or text size inside the utilized document.\n\nIf you like this program, then kindly consider supporting my work by donating to my PayPal account: M7mad.dev96@gmail.com\n\nDeveloped By Mohammad Mashmoushi\nCivil Engineer");
        }

        /* Link Label */
        private void label3_Click(object sender, EventArgs e) { }

        /* ''Word2Symbol'' Title */
        private void label4_Click(object sender, EventArgs e) { }

        private void Keyword_SelectedIndexChanged(object sender, EventArgs e) { }

    }
}
//