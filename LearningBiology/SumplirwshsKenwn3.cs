using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningBiology
{
    public partial class SumplirwshsKenwn3 : Form
    {
        public SumplirwshsKenwn3()
        {
            InitializeComponent();
        }
        string[] qArr = {
          "Η .... θεωρία η οποία υποστηρίζει ότι όλα τα έμβια όντα αποτελούνται από κύτταρα και απο προϊόντα κυττάρων.",
          "Η .... υποστηρίζει ότι όλα τα έμβια όντα είναι προϊόν εξέλιξης που υπέστησαν προγενέστεροι οργανισμοί.",
          "Το .... περιλαμβάνει το σύνολο των διαφορετικών πληθυσμών.",
          "Για να παραμείνει σταθερό το μέγεθος ενός πληθυσμού παρά την τάση για αύξηση μερικά άτομα δεν επιβιώνουν ή δεν αναπαράγονται. Συνεπώς μεταξύ των οργανισμών ενός πληθυσμού διεξάγεται ένας .... .",
          "Η διαδικασία με την οποία οι οργανισμοί που είναι περισσότερο προσαρμοσμένοι στο περιβάλλον τους επιβιώνουν και αναπαράγονται περισσότερο από τους λιγότερο προσαρμοσμένους , ονομάστηκε απο τον Δαρβίνο .... .",
          "Το φαινόμενο το οποίο συσχετίστηκε με τη βιομηχανική ρύπανση ονομάστηκε .... .",
          "Οι καμηλοπαρδάλεις δημιουργήθηκαν από οργανισμούς κατώτερων βαθμίδων διαμέσου της .... ."
          };

        string[] shownArr = {
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false"
          };

        string[] ansArr = {
           "κυτταρική",
           "θεωρία της εξέλιξης",
           "είδος",
           "αγώνας επιβίωσης",
           "φυσική επιλογή",
           "βιομηχανικός μελανισμός",
           "φυσικής κλίμακας"
          };

        string[] ans2Arr = {
           "κιταρικι",
           "θεορια τισ εξελιξισ",
           "ιδοσ",
           "αγονασ επιβιοσισ",
           "φισικι επιλογι",
           "βιομιχανικος μελανισμοσ",
           "φισικισ κλιμακασ"
          };

        string[] helpArr = {
        "H απάντηση ξεκινάει με κ..",
        "Η απάντηση ξεκινάει με θ.. τ.. ε..",
        "Η απάντηση ξεκινάει με ε..",
        "Η απάντηση ξεκινάει με α.. ε..",
        "Η απάντηση ξεκινάει με φ.. ε..",
        "Η απάντηση ξεκινάει με β.. μ..",
        "Η απάντηση ξεκινάει με φ.. κ.."
        };

        string[] twoWordsArr =
        {
            "false",
            "false",
            "false",
            "true",
            "true",
            "true",
            "true"
        };

        string[] threeWordsArr =
        {
            "false",
            "true",
            "false",
            "false",
            "false",
            "false",
            "false"
        };

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            Visible = false;
        }

        int selectedQuestion;

        void selectRandomQuestion()
        {
            Random rnd = new Random();
            selectedQuestion = rnd.Next(1, qArr.Length);
            if (shownArr[selectedQuestion] == "false")
            {
                presentSelectedQuestion();
                shownArr[selectedQuestion] = "true";
            }
            else
            {
                selectRandomQuestion();
            }

        }

        void presentSelectedQuestion()
        {
            label1.Text = qArr[selectedQuestion];
        }
        int totalTimes = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            int l = word.Length;
            string simplifiedWord = "";
            char currentChar;
            char nextChar;
            for (int i = 0; i < l; i++)
            {
                currentChar = word[i];
                if (i < l - 1)
                {
                    nextChar = word[i + 1];
                    if (currentChar == 'α' || currentChar == 'Α')
                    {
                        if (nextChar == 'ι' || nextChar == 'ί' || nextChar == 'Ι' || nextChar == 'Ί')
                        {
                            currentChar = 'ε';
                            i = i + 1;
                        }
                    }
                    else if (currentChar == 'ε' || currentChar == 'Ε' || currentChar == 'ο' || currentChar == 'Ο' || currentChar == 'υ' || currentChar == 'Υ')
                    {
                        if (nextChar == 'ι' || nextChar == 'ί' || nextChar == 'Ι' || nextChar == 'Ί')
                        {
                            currentChar = 'ι';
                            i = i + 1;
                        }
                    }
                    else if (currentChar == 'τ' || currentChar == 'Τ')
                    {
                        if (nextChar == 'τ' || nextChar == 'Τ')
                        {
                            currentChar = 'τ';
                            i = i + 1;
                        }
                    }
                }

                switch (currentChar)
                {
                    case 'α':
                    case 'Α':
                    case 'ά':
                    case 'Ά':
                        currentChar = 'α';
                        break;
                    case 'β':
                    case 'Β':
                        currentChar = 'β';
                        break;
                    case 'γ':
                    case 'Γ':
                        currentChar = 'γ';
                        break;
                    case 'δ':
                    case 'Δ':
                        currentChar = 'δ';
                        break;
                    case 'ζ':
                    case 'Ζ':
                        currentChar = 'ζ';
                        break;
                    case 'θ':
                    case 'Θ':
                        currentChar = 'θ';
                        break;
                    case 'κ':
                    case 'Κ':
                        currentChar = 'κ';
                        break;
                    case 'λ':
                    case 'Λ':
                        currentChar = 'λ';
                        break;
                    case 'μ':
                    case 'Μ':
                        currentChar = 'μ';
                        break;
                    case 'ν':
                    case 'Ν':
                        currentChar = 'ν';
                        break;
                    case 'ξ':
                    case 'Ξ':
                        currentChar = 'ξ';
                        break;
                    case 'π':
                    case 'Π':
                        currentChar = 'π';
                        break;
                    case 'ρ':
                    case 'Ρ':
                        currentChar = 'ρ';
                        break;
                    case 'σ':
                    case 'Σ':
                    case 'ς':
                        currentChar = 'σ';
                        break;
                    case 'τ':
                    case 'Τ':
                        currentChar = 'τ';
                        break;
                    case 'φ':
                    case 'Φ':
                        currentChar = 'φ';
                        break;
                    case 'χ':
                    case 'Χ':
                        currentChar = 'χ';
                        break;
                    case 'ψ':
                    case 'Ψ':
                        currentChar = 'Ψ';
                        break;
                    case 'ε':
                    case 'έ':
                    case 'Ε':
                    case 'Έ':
                        currentChar = 'ε';
                        break;
                    case 'η':
                    case 'ή':
                    case 'Η':
                    case 'Ή':
                    case 'ι':
                    case 'ί':
                    case 'Ι':
                    case 'Ί':
                    case 'ΐ':
                    case 'ϊ':
                    case 'Ϊ':
                    case 'υ':
                    case 'ύ':
                    case 'ΰ':
                    case 'ϋ':
                    case 'Υ':
                    case 'Ύ':
                    case 'Ϋ':
                        currentChar = 'ι';
                        break;
                    case 'ο':
                    case 'Ο':
                    case 'ό':
                    case 'Ό':
                    case 'ω':
                    case 'ώ':
                    case 'Ω':
                    case 'Ώ':
                        currentChar = 'ο';
                        break;

                }
                simplifiedWord = simplifiedWord + currentChar;

            }
            if (simplifiedWord == ans2Arr[selectedQuestion])
            {
                if (totalQuestions == 2)
                {

                    if (totalTimes == 0)
                    {
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 2);
                    }
                    if (totalTimes == 1)
                    {
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                    }
                    totalTimes = 0;
                    MessageBox.Show("Η απάντηση που έδωσες είναι σωστή");
                    Form4 form4 = new Form4();
                    form4.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");
                }
                else
                {
                    MessageBox.Show("Η απάντηση που έδωσες είναι σωστή! Προχώρα στην επόμενη ερώτηση");

                    button1.Visible = true;
                    if (totalTimes == 0)
                    {
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 2);
                    }
                    if (totalTimes == 1)
                    {
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                    }
                    totalTimes = 0;
                }
            }
            else
            {
                totalTimes++;
                if (totalTimes == 1)
                {
                    MessageBox.Show("Η απάντηση που έδωσες είναι λάθος! Προσπάθησε ξανα! Αν θες βοήθεια πάτα το κουμπί Βοήθεια. ΠΡΟΣΟΧΗ!! ΕΧΕΙΣ ΜΙΑ ΑΚΟΜΑ ΕΥΚΑΙΡΙΑ");
                    button3.Visible = true;
                }
                if (totalTimes == 2)
                {
                    if (totalQuestions == 2)
                    {
                        MessageBox.Show("Η απάντηση σου είναι λάθος ξανά . Έχασες την ευκαιρία σου. H σωστή απάντηση είναι: " + ansArr[selectedQuestion]);
                        Form4 form4 = new Form4();
                        form4.Show();
                        Visible = false;
                        MessageBox.Show("Συμπληρώσατε την άσκηση!");

                    }
                    else
                    {
                        MessageBox.Show("Η απάντηση σου είναι λάθος ξανά . Έχασες την ευκαιρία σου , πήγαινε στην επόμενη ερώτηση. H σωστή απάντηση είναι: " + ansArr[selectedQuestion]);
                        button1.Visible = true;
                        textBox1.Enabled = false;
                        button2.Visible = false; ;
                        totalTimes = 0;
                    }
                }

            }
        }

        private void SumplirwshsKenwn3_Load(object sender, EventArgs e)
        {
            selectRandomQuestion();
            button2.Visible = true;
            twoWords();
            threeWords();
            progressBar1.Maximum = 3;
            progressBar1.Minimum = 0;
            this.progressBar1.Increment(1);
        }
        int totalQuestions = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            selectRandomQuestion();
            twoWords();
            threeWords();
            textBox1.Text = "";
            textBox1.Enabled = true;
            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = true;
            totalTimes = 0;
            if (totalQuestions == 2)
            {
                Form4 form4 = new Form4();
                form4.Show();
                Visible = false;
                MessageBox.Show("Συμπληρώσατε την άσκηση!");
            }
            totalQuestions++;
            progressBar1.Maximum = 3;
            progressBar1.Minimum = 0;
            this.progressBar1.Increment(1);
        }
        void twoWords()
        {
            if (twoWordsArr[selectedQuestion] == "true")
            {
                label4.Visible = true;
                label5.Visible = false;
            }
            else
            {
                label4.Visible = false;
                label5.Visible = false;
            }
        }
        void threeWords()
        {
            if (threeWordsArr[selectedQuestion] == "true")
            {
                label4.Visible = false;
                label5.Visible = true;
            }
            else
            {
                label4.Visible = false;
                label5.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helpArr[selectedQuestion]);
        }
    }
}
