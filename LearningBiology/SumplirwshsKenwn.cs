using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LearningBiology
{
    public partial class SumplirwshsKenwn : Form
    {
        public SumplirwshsKenwn()
        {
            InitializeComponent();
        }
        string[] qArr = {
           "Η ικανότητα του οργανισμού να διατηρεί σταθερές τις συνθήκες του εσωτερικού του περιβάλλοντος παρά τις εξωτερικές μεταβολές ονομάζεται ... .",
           "Γενικά ως .... χαρακτηρίζονται εκείνοι οι οργανισμοί τους οποίους δεν μπορούμε να διακρίνουμε με γυμνό μάτι.",
           "Ποιοι οργανισμοί είναι προκαρυωτικοί.",
           "Οι .... χαρακτηρίζονται ως υποχρεωτικά ενδοκυτταρικά παράσιτα.",
           "Η είσοδος ενός παθογόνου μικροοργανισμού στον οργανισμό του ανθρώπου ονομάζεται .... .",
           "Η εγκατάσταση και ο πολλαπλασιασμός ενός παθογόνου μικροοργανισμού στον οργανισμό ονομάζεται ... .",
           "Οι ασθένειες που προκαλούνται από παθογόνους μικροοργανισμούς ονομάζονται .... .",
           "Πολλά βακτήρια απειλούν την υγεία μας μέσω των ουσιών που παράγουν. Οι ουσίες αυτές ονομάζονται ... .",
           "Πολλοί μικροοργανισμοί προκειμένου να επιβιώσουν και να αναπαραχθούν, περνούν ένα μέρος ή ολόκληρη την ζωή τους στο εσωτερικό κάποιου οργανισμού. Αυτοί οι μικροοργανισμοί ονομάζονται .... .",
           "Ο οργανισμός που φιλοξενεί τα παράσιτα ονομάζεται .... .",
           "Οι .... μικροοργανισμοί χρησιμοποιούν τον άνθρωπο ως ξενιστή τους και μπορούν να προκαλέσουν διαταραχές στην υγεία του.",
           "Το .... είναι πρωτόζωο που μεταδίδεται από τα κουνούπια και προκαλεί ελονοσία.",
           "Το .... μεταδίδεται από την μύγα τσετσέ και προκαλεί την ασθένεια του ύπνου.",
           "Το .... μεταδίδεται από τα κατοικίδια ζώα , προσβάλλει βασικά όργανα όπως τους πνεύμονες, το ήπαρ και το σπλήνα και προκαλεί αποβολές στις εγκύους.",
           "Τα .... αποτελούν μια ειδική κατηγορία μυκήτων που προσβάλλουν το δέρμα , κυρίως το τριχωτό της κεφαλής αλλά και τις μεσοδακτύλιες περιοχές.",
           "Οι ιοί αποτελούνται από ένα πρωτεϊνικό περίβλημα με χαρακτηριστική γεωμετρία, το .... .",
           "Ορισμένοι ιοί διαθέτουν και ένα περίβλημα λιποπρωτεϊνικής φύσης, το .... .",
           "Οι .... βρίσκονται στο κυτταρικό τοίχωμα ορισμένων παθογόνων βακτηρίων και είναι υπεύθυνες για συμπτώματα όπως ο πυρετός, η πτώση της πίεσης του αίματος κλπ.",
           "Οι .... εκκρίνονται από τα παθογόνα βακτήρια και με την κυκλοφορία του αίματος διασπείρονται στο εσωτερικό του ανθρώπινου οργανισμού και προσβάλλουν ανάλογα με την φύση τους, συγκεκριμένα όργανα.",
           "Τα Β-λεμφοκύτταρα συνθέτουν και παρουσιάζουν στην επιφάνεια τους ειδικές πρωτεΐνες που ονομάζονται .... .",
           "Το .... πρόκειται για ομάδα 20 πρωτεϊνών στον ορό του αίματος με αντιμικροβιακή δράση.",
           "Η .... είναι μία ομάδα 3 πρωτεϊνών στον ορό του αίματος που δρα σε συνδυασμό με τις πρωτεΐνες του συμπληρώματος για την καταστροφή των μικροβίων.",
           "Η .... είναι η ικανότητα του οργανισμού να θυμάται τα αντιγόνα με τα οποία έχει έλθει σε επαφή.",
           "Η ικανότητα του οργανισμού να αναγνωρίζει οποιαδήποτε ξένη ουσία και να αντιδρά παράγοντας εξειδικευμένα κύτταρα και κυτταρικά προϊόντα ώστε να την εξουδετερώσει ονομάζεται .... .",
           "Η ξένη ουσία που προκαλεί την ανοσοβιολογική απόκριση ονομάζεται .... ."
          };

        string[] ans2Arr = {
           "ομιοστασι",
           "μικροβια",
           "βακτιρια",
           "ιι",
           "μολινσι",
           "λιμοξι",
           "λιμοδι νοσιματα",
           "τοξινεσ",
           "παρασιτα",
           "ξενιστις",
           "παθογονι",
           "πλασμοδιο",
           "τριπανοσομα",
           "τοξοπλασμα",
           "δερματοφιτα",
           "καψιδιο",
           "ελιτρο",
           "ενδοτοξινεσ",
           "εξοτοξινεσ",
           "ανοσοσφερινεσ",
           "σιμπλιρομα",
           "προπερδινι",
           "μνιμι",
           "ανοσια",
           "αντιγονο"
          };

        string[] ansArr = {
           "ομοιόσταση",
           "μικρόβια",
           "βακτήρια",
           "ιοί",
           "μόλυνση",
           "λοίμοξη",
           "λοιμώδη νοσήματα",
           "τοξίνες",
           "παράσιτα",
           "ξενιστής",
           "παθογόνοι",
           "πλασμώδιο",
           "τρυπανόσωμα",
           "τοξόπλασμα",
           "δερματόφυτα",
           "καψίδιο",
           "έλυτρο",
           "ενδοτοξίνες",
           "εξωτοξίνες",
           "ανοσοσφαιρίνες",
           "συμπλήρωμα",
           "προπερδίνη",
           "μνήμη",
           "ανοσία",
           "αντιγόνο"
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
          "false",
          "false",
          "false",
          "false",
          "false"
          };

        string[] helpArr = {
        "H απάντηση ξεκινάει με ο..",
        "Η απάντηση ξεκινάει με μ..",
        "Η απάντηση ξεκινάει με β..",
        "Η απάντηση ξεκινάει με ι..",
        "Η απάντηση ξεκινάει με μ..",
        "Η απάντηση ξεκινάει με λ..",
        "Η απάντηση ξεκινάει με λ.. ν..",
        "Η απάντηση ξεκινάει με τ..",
        "Η απάντηση ξεκινάει με π..",
        "Η απάντηση ξεκινάει με ξ..",
        "Η απάντηση ξεκινάει με π..",
        "Η απάντηση ξεκινάει με π..",
        "Η απάντηση ξεκινάει με τ..",
        "Η απάντηση ξεκινάει με τ..",
        "Η απάντηση ξεκινάει με δ..",
        "Η απάντηση ξεκινάει με κ..",
        "Η απάντηση ξεκινάει με ε..",
        "Η απάντηση ξεκινάει με ε..",
        "Η απάντηση ξεκινάει με ε..",
        "Η απάντηση ξεκινάει με α..",
        "Η απάντηση ξεκινάει με σ..",
        "Η απάντηση ξεκινάει με π..",
        "Η απάντηση ξεκινάει με μ..",
        "Η απάντηση ξεκινάει με α..",
        "Η απάντηση ξεκινάει με α.."
        };

        string[] twoWordsArr =
        {
            "false",
            "false",
            "false",
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
            "false",
            "false",
            "false",
            "false",
            "false",
            "false"
        };

        int totalQuestions = 0;
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

        private void SumplirwshsKenwn_Load(object sender, EventArgs e)
        {
            selectRandomQuestion();
            twoWords();
            button2.Visible = true;
            progressBar1.Maximum = 5;
            progressBar1.Minimum = 0;
            this.progressBar1.Increment(1);
        }




        private void button1_Click(object sender, EventArgs e)
        {
            selectRandomQuestion();
            twoWords();
            textBox1.Text = "";
            textBox1.Enabled = true;
            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = true;
            totalTimes = 0;
            if (totalQuestions == 4)
            {
                Form2 form2 = new Form2();
                form2.Show();
                Visible = false;
                MessageBox.Show("Συμπληρώσατε την άσκηση!");

            }
            totalQuestions++;
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
                    else if (currentChar == 'τ' || currentChar == 'Τ' )
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
                    Form2 form2 = new Form2();
                    form2.Show();
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
                { if (totalQuestions == 4)
                    {
                        MessageBox.Show("Η απάντηση σου είναι λάθος ξανά . Έχασες την ευκαιρία σου. H σωστή απάντηση είναι: " + ansArr[selectedQuestion]);
                        Form2 form2 = new Form2();
                        form2.Show();
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

        void twoWords()
        {
            if (twoWordsArr[selectedQuestion] == "true")
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }
        
       

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helpArr[selectedQuestion]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Visible = false;

        }
    }
}
