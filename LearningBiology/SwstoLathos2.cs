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
    public partial class SwstoLathos2 : Form
    {
        public SwstoLathos2()
        {
            InitializeComponent();
        }
        int totalQuestions = 0;
        int correctAnswer = 0;

        string[] qArr = {
          "Οι παραγωγοί χαρακτηρίζονται και ως αυτότροφοι οργανισμοί.",
          "Οι ετερότροφοι οργανισμοί διακρίνονται σε καταναλωτές και αποικοδομητές.",
          "Οι αβιοτικοί παράγοντες ενός οικοσυστήματος είναι ανεξάρτητοι από τους βιοτικούς.",
          "Ένας από τους λόγους που ένα σύστημα μπορεί να ερημοποιηθεί είναι η καταστροφή από την όξινη βροχή.",
          "Τα ερημικά οικοσυστήματα βρίσκονται εκεί όπου η βρωχόπτωση είναι πολύ υψηλή.",
          "Τα μεσογειακά οικοσυστήματα δεν μπορούν να ανακάμψουν σε λιγότερο από δέκα χρόνια γιατί οι οργανισμοί τους έχουν προσαρμοστεί στην περιοδική εμφάνιση της φωτιάς αναπτύσσοντας συγκεκριμένους μηχανισμούς αναγέννησης.",
          "Μια από τις συνέπειες της φωτιάς είναι οτι αυξάνεται η διάβρωση του εδάφους.",
          "Ρύπανση είναι η επιβάρυνση του περιβάλλοντος με κάθε παράγοντα(ρύπο) που έχει βλαπτικές επιδράσεις στους οργανισμούς.",
          "Στους ρύπους δεν ανήκουν μορφές ενέργειας όπως η θερμότητα , ο ήχος και η ακτινοβολίες.",
          "Η ρύπανση ανάλογα με το τμήμα της βιόσφαιρας που πλήττει , διακρίνεται σε ατμοσφαιρική , σε ρύπανση των υδάτων και σε ρύπανση του εδάφους.",
          "Οι οργανισμοί ενός οικοσυστήματος οι οποίοι ανήκουν στο ίδιο είδος αποτελούν έναν βιότοπο.",
          "Το σύνολο των διαφορετικών πληθυσμών που ζουν σε ένα οικοσύστημα, αλλά και οι σχέσεις που αναπτύσσονται μεταξύ τους αποτελούν την βιοκοινότητα του οικοσυστήματος.",
          "Στους καταναλωτές ανήκουν ορισμένα βακτήρια και μύκητες που τρέφονται με την νεκρή οργανική ύλη.",
          "Στους καταναλωτές ανήκουν οι μονοκύτταροι και πολυκύτταροι ζωικοί οργανισμοί.",
          "Οι επαναλαμβανόμενες κυκλικές πορείες των χημικών στοιχείων στα οικοσυστήματα χαρακτηρίζονται ως χημικοί κύκλοι.",
          "Σημαντικότερα αζωτοδεσμευτικά βακτήρια είναι αυτά που ζουν συμβιωτικά στις ρίζες των ψυχανθών σε ειδικά εξογκώματα.",
          "Με τις κατακρημνίσεις το νερό απομακρύνεται από την ατμόσφαιρα και γίνεται διαθέσιμο στα υδάτινα και χερσαία οικοσυστήματα.",
          "Τα επιφανειακά ρέοντα ύδατα δεν απομακρύνουν τα θρεπτικά συστατικά τα οποία με μακροχρόνιες διαδικασίες γίνονται διαθέσιμα στους οργανισμούς.",
          "Η ανταλλαγή του νερού μεταξύ των ωκεανών και της ατμόσφαιρας αποτελεί έναν περίπλοκο μηχανισμό καθώς περιλαμβάνει πάρα πολλές διαδικασίες.",
          "Το τμήμα του κύκλου που αφορά την ξηρά είναι πιο απλό καθώς περιλαμβάνει μόνο τις διαδικασίες της εξάτμισης και των κατακρημνίσεων.",
          "Το τμήμα του κύκλου που αφορά την ξηρά είναι πιο περίπλοκο διότι οι πιθανές πορείες του νερού είναι περισσότερες."
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
        string[] ansArr ={
        "Σ",
        "Σ",
        "Λ",
        "Σ",
        "Λ",
        "Λ",
        "Σ",
        "Σ",
        "Λ",
        "Σ",
        "Λ",
        "Σ",
        "Λ",
        "Σ",
        "Λ",
        "Σ",
        "Σ",
        "Λ",
        "Λ",
        "Λ",
        "Σ"
        };
        private void button3_Click(object sender, EventArgs e)
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (ansArr[selectedQuestion] == "Σ")
            {
                if (correctAnswer == 0)
                {
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                }
                else
                {
                    correctAnswer = 0;
                }
                if (totalQuestions == 5)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                totalQuestions++;
                selectRandomQuestion();
                progressBar1.Maximum = 6;
                progressBar1.Minimum = 0;
                this.progressBar1.Increment(1);
            }
            else
            {
                correctAnswer++;
            }

        }

        private void SwstoLathos2_Load(object sender, EventArgs e)
        {
            selectRandomQuestion();
            progressBar1.Maximum = 6;
            progressBar1.Minimum = 0;
            this.progressBar1.Increment(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ansArr[selectedQuestion] == "Λ")
            {
                if (correctAnswer == 0)
                {
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                }
                else
                {
                    correctAnswer = 0;
                }
                if (totalQuestions == 5)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                totalQuestions++;
                selectRandomQuestion();
                progressBar1.Maximum = 6;
                progressBar1.Minimum = 0;
                this.progressBar1.Increment(1);
            }
            else
            {
                correctAnswer++;
            }
        }
    }
}
