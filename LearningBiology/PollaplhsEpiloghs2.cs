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
    public partial class PollaplhsEpiloghs2 : Form
    {
        public PollaplhsEpiloghs2()
        {
            InitializeComponent();
        }

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

        string[] op1Arr = {
           "τροφικές αλυσίδες",
           "τροφικές αλυσίδες",
           "τροφική αλυσίδα",
           "τροφικές αλυσίδες",
           "καταναλωτές πρώτης τάξης",
           "καταναλωτές πρώτης τάξης",
           "καταναλωτές πρώτης τάξης",
           "βιολογικοί κύκλοι",
           "άνθρακας",
           "νιτροποίησης",
           "νιτροποιητική",
           "νιτροποιητική",
           "διαπνοή",
           "διαπνοηκή",
           "διαπνοή",
           "ετερότροφοι",
           "ετερότροφοι",
           "ετερότροφους",
           "βιότοπο",
           "συμπεριφορά",
           "βιότοπος"
          };

        string[] op2Arr = {
           "τροφικές επιλογές",
           "τροφικές επιλογές",
           "τροφικό πλέγμα",
           "τροφικά πλέγματα",
           "παραγωγοί",
           "παραγωγοί",
           "παραγωγοί",
           "γεωλογικοί κύκλοι",
           "φώσφορος",
           "αζωτοδέσμευσης",
           "απονιτροποιητική",
           "απονιτροποιητική",
           "εξάτμιση",
           "νιτροποιητική",
           "εξάτμιση",
           "αυτότροφοι",
           "αυτότροφοι",
           "αυτότροφους",
           "πληθυσμό",
           "βιοσυμπεριφορά",
           "πληθυσμός"
          };

        string[] op3Arr = {
           "τροφικές πυραμίδες",
           "τροφικές πυραμίδες",
           "τροφική πυραμίδα",
           "τροφική πυραμίδα",
           "καταναλωτές δεύτερης τάξης",
           "καταναλωτές δεύτερης τάξης",
           "καταναλωτές δεύτερης τάξης",
           "χημικοί κύκλοι",
           "σίδηρος",
           "απονιτροποίησης",
           "ατμοσφαιρική",
           "ατμοσφαιρική",
           "επιδερμία",
           "επιδερμική",
           "επιδερμία",
           "αποικοδομητές",
           "αποικοδομητές",
           "αποικοδομητές",
           "βιοτικό παράγοντα",
           "βιοκοινότητα",
           "βιοκοινότητα"
          };

        string[] op4Arr = {
           "τροφικές εναλλακτικές",
           "τροφικές εναλλακτικές",
           "τροφικό επίπεδο",
           "τροφικά επίπεδα",
           "καταναλωτές τρίτης τάξης",
           "καταναλωτές τρίτης τάξης",
           "καταναλωτές τρίτης τάξης",
           "βιογεωχημικοί κύκλοι",
           "ψευδάργυρος",
           "εξάτμισης",
           "βιολογική",
           "βιολογική",
           "αζωτοδέσμευσης",
           "αζωτοδεσμευτική",
           "αζωτοδέσμευση",
           "παραγωγοί",
           "παραγωγοί",
           "παραγωγούς",
           "αυτότροφο οργανισμό",
           "εξέλιξη",
           "οικοσύστημα"
          };


        private void button1_Click(object sender, EventArgs e)
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

        private void PollaplhsEpiloghs2_Load(object sender, EventArgs e)
        {
            selectRandomQuestion();
            questions();
            progressBar1.Maximum = 6;
            progressBar1.Minimum = 0;
            this.progressBar1.Increment(1);
        }

        void questions()
        {
            button2.Text = op1Arr[selectedQuestion];
            button3.Text = op2Arr[selectedQuestion];
            button4.Text = op3Arr[selectedQuestion];
            button5.Text = op4Arr[selectedQuestion];
        }
        int totalQuestions = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == ansArr[selectedQuestion])
            {
                selectRandomQuestion();
                questions();
                progressBar1.Maximum = 6;
                progressBar1.Minimum = 0;
                this.progressBar1.Increment(1);
                label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                if (totalQuestions == 5)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                totalQuestions++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == ansArr[selectedQuestion])
            {
                selectRandomQuestion();
                questions();
                progressBar1.Maximum = 6;
                progressBar1.Minimum = 0;
                this.progressBar1.Increment(1);
                label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                if (totalQuestions == 5)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                totalQuestions++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == ansArr[selectedQuestion])
            {
                selectRandomQuestion();
                questions();
                progressBar1.Maximum = 6;
                progressBar1.Minimum = 0;
                this.progressBar1.Increment(1);
                label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                if (totalQuestions == 5)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                totalQuestions++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == ansArr[selectedQuestion])
            {
                selectRandomQuestion();
                questions();
                progressBar1.Maximum = 6;
                progressBar1.Minimum = 0;
                this.progressBar1.Increment(1);
                label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                if (totalQuestions == 5)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                totalQuestions++;
            }
        }
    }
}
