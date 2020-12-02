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
    public partial class SumplirwshsKenwn2 : Form
    {
        public SumplirwshsKenwn2()
        {
            InitializeComponent();
        }
        int totalQuestions = 0;

        string[] qArr = {
        "Η απεικόνιση των ποιοτικών τροφικών σχέσεων που αναπτύσσονται μεταξύ των οργανισμών ενός οικοσυστήματος γίνεται με τις ..... και τα τροφικά πλέγματα.",
        "Η απεικόνιση των ποσοτικών τροφικών σχέσεων γίνεται με τις .... .",
        "Το δίκτυο αυτό που απεικονίζει το σύνολο των τροφικών σχέσεων μεταξύ των οργανισμών ενός οικοσυστήματος , ονομάζεται .... .",
        "Μια τροφική πυραμίδα αποτελείται από .... , σε κάθε ένα από τα οποία περιλαμβάνονται όλοι οι οργανισμοί που τρέφονται απέχοντας ίδιο αριθμό βημάτων από τον ήλιο.",
        "Ποιό τροφικό επίπεδο βρίσκεται στην βάση της τροφικής πυραμίδας;",
        "Ποιό είναι το δεύτερο τροφικό επίπεδο;",
        "Ποιό είναι το τρίτο τροφικό επίπεδο;",
        "Οι επαναλαμβανόμενες κυκλικές πορείες των χημικών στοιχείων στα οικοσυστήματα χαρακτηρίζονται ως.... .",
        "Ο....είναι το χημικό στοιχείο με βάση το οποίο δομούνται όλες οι οργανικές ενώσεις και συνεπώς όλα τα βιολογικά μακρομόρια.",
        "Η εισαγωγή του ατμοσφαιρικού αζώτου στις τροφικές αλυσίδες των οικοσυστημάτων γίνεται με τη διαδικασία της.... .",
        "Κατά την .... αζωτοδέσμευση το άζωτο της ατμόσφαιρας αντιδρά είτε με τους υδρατμούς, σχηματίζοντας αμμωνία , είτε με το ατμοσφαιρικό οξυγόνο σχηματίζοντας νητρικά ιόντα.",
        "Η....αζωτοδέσμευση πραγματοποιείται από ελεύθερους ή συμβιωτικούς μικροοργανισμούς.",
        "Με την .... το νερό απομακρύνεται με τη μορφή υδρατμών από οποιαδήποτε επιφάνεια.",
        "Η εξάτμιση του νερού απο την επιφάνεια των φύλλων ονομάζεται .... εξάτμιση.",
        "Η....είναι η απομάκρυνση του νερού μέσω των στομάτων, των πόρων δηλαδή της επιδερμίδας των φύλλων.",
        "Οι....είναι οι οργανισμοί που φωτοσυνθέτουν.",
        "Όλοι οι οργανισμοί των οικοσυστημάτων , οι οποίοι δεν φωτοσυνθέτουν, χαρακτηρίζονται ως .... .",
        "Στους....ανήκουν ορισμένα βακτήρια και μύκητες που τρέφονται με τη νεκρή οργανική ύλη.",
        "Οι οργανισμοί ενός οικοσυστήματος οι οποίοι ανήκουν στο ίδιο είδος αποτελούν έναν .... .",
        "Το σύνολο των διαφορετικών πληθυσμών που ζουν σε ένα οικοσύστημα, αλλά και οι σχέσεις που αναπτύσονται μεταξύ τους αποτελούν την .... του οικοσυστήματος.",
        ".... είναι η περιοχή στην οποία ζει ένας πληθυσμός ή μια βιοκοινότητα."
          };

        string[] shownArr = {
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false",
          "false"
          };

        string[] ansArr = {
           "τροφικές αλυσίδες",
           "τροφικές πυραμίδες",
           "τροφικό πλέγμα",
           "τροφικά επίπεδα",
           "παραγωγοί",
           "καταναλωτές πρώτης τάξης",
           "καταναλωτές δεύτερης τάξης",
           "βιογεωχημικοί κύκλοι",
           "άνθρακας",
           "αζωτοδέσμευσης",
           "ατμοσφαιρική",
           "βιολογική",
           "εξάτμιση",
           "επιδερμική",
           "διαπνοή",
           "παραγωγοί",
           "ετερότροφοι",
           "αποικοδομητές",
           "πληθυσμό",
           "βιοκοινότητα",
           "βιότοπος"
          };

        string[] ans2Arr = {
           "τροφικεσ αλισιδεσ",
           "τροφικεσ πιραμιδεσ",
           "τροφικο πλεγμα",
           "τροφικα επιπεδα",
           "παραγογι",
           "καταναλοτεσ προτισ ταξισ",
           "καταναλοτεσ δειτερισ ταξισ",
           "βιογεοχιμικι κικλι",
           "ανθρακας",
           "αζοτοδεσμεισισ",
           "ατμοσφερικι",
           "βιολογικι",
           "εξατμισι",
           "επιδερμικι",
           "διαπνοι",
           "παραγογι",
           "ετεροτροφι",
           "απικοδομιτεσ",
           "πλιθισμο",
           "βιοκινοτιτα",
           "βιοτοποσ"
          };

        string[] helpArr = {
        "H απάντηση ξεκινάει με τ.. α..",
        "Η απάντηση ξεκινάει με τ.. π..",
        "Η απάντηση ξεκινάει με τ.. π..",
        "Η απάντηση ξεκινάει με τ.. ε..",
        "Η απάντηση ξεκινάει με π..",
        "Η απάντηση ξεκινάει με κ.. π.. τ..",
        "Η απάντηση ξεκινάει με κ.. δ.. τ..",
        "Η απάντηση ξεκινάει με β.. κ..",
        "Η απάντηση ξεκινάει με α..",
        "Η απάντηση ξεκινάει με α..",
        "Η απάντηση ξεκινάει με α..",
        "Η απάντηση ξεκινάει με β..",
        "Η απάντηση ξεκινάει με ε..",
        "Η απάντηση ξεκινάει με ε..",
        "Η απάντηση ξεκινάει με δ..",
        "Η απάντηση ξεκινάει με π..",
        "Η απάντηση ξεκινάει με ε..",
        "Η απάντηση ξεκινάει με α..",
        "Η απάντηση ξεκινάει με π..",
        "Η απάντηση ξεκινάει με β..",
        "Η απάντηση ξεκινάει με β.."
        };

        string[] twoWordsArr =
        {
            "true",
            "true",
            "true",
            "true",
            "false",
            "false",
            "false",
            "true",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false"
        };

        string[] threeWordsArr =
        {
            "false",
            "false",
            "false",
            "false",
            "false",
            "true",
            "true",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false",
            "false"
        };
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
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

        private void SumplirwshsKenwn2_Load(object sender, EventArgs e)
        {
            selectRandomQuestion();
            twoWords();
            threeWords();
            button2.Visible = true;
            progressBar1.Maximum = 5;
            progressBar1.Minimum = 0;
            this.progressBar1.Increment(1);
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
                if (totalQuestions == 4)
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
                    Form3 form3 = new Form3();
                    form3.Show();
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
                    if (totalQuestions == 4)
                    {
                        MessageBox.Show("Η απάντηση σου είναι λάθος ξανά . Έχασες την ευκαιρία σου. H σωστή απάντηση είναι: " + ansArr[selectedQuestion]);
                        Form3 form3 = new Form3();
                        form3.Show();
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
            if (totalQuestions == 4)
            {
                Form3 form3 = new Form3();
                form3.Show();
                Visible = false;
                MessageBox.Show("Συμπληρώσατε την άσκηση!");

            }
            totalQuestions++;
            progressBar1.Maximum = 5;
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
