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
    public partial class SwstoLathos3 : Form
    {
        public SwstoLathos3()
        {
            InitializeComponent();
        }

        string[] qArr = {
         "Ο Δαρβίνος ήταν ο πρώτος που διατύπωσε με επιστημονικούς όρους την ιδέα της εξέλιξης και επίσης υπέδειξε το μηχανισμό με τον οποίο αυτή συμβαίνει.",
         "Σήμερα η θεωρία της εξέλιξης δεν είναι αποδεκτή από το σύνολο της επιστημονικής κοινότητας.",
         "Η κυτταρική θεωρία υποστηρίζει ότι όλα τα έμβια όντα αποτελούνται απο κύτταρα και από προϊόντα κυττάρων.",
         "Η θεωρία της εξέλιξης υποστηρίζει ότι όλα τα έμβια όντα είναι προϊόντα εξέλιξης που υπέστησαν προγενέστεροι οργανισμοί.",
         "Όλοι οι οργανισμοί αναπαράγονται με την επαφή με άτομο διαφορετικού φύλου.",
         "Ο Λαμάρκ πίστευε οτι τα επίκτητα χαρακτηριστικά κληροδοτούνται στους απογόνους.",
         "Η 1η παρατήρηση του Δαρβίνου έλεγε οτι οι πληθυσμοί των διαφόρων ειδών τείνουν να μειώνονται από γενιά σε γενιά με ρυθμό γεωμετρικής προόδου.",
         "Η 2η παρατήρηση του Δαρβίνου έλεγε οτι αν εξαιρεθούν οι εποχικές διακυμάνσεις , τα μεγέθη των πληθυσμών παραμένουν σχετικά σταθερά.",
         "Η 3η παρατήρηση του Δαρβίνου έλεγε οτι τα άτομα ενός είδους είναι όμοια.",
         "Η 4η παρατήρηση του Δαρβίνου έλεγε οτι τα περισσότερα από τα χαρακτηριστικά των γονέων κληροδοτούνται στους απογόνους τους."
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
          "false"
          };
        string[] ansArr ={
        "Σ",
        "Λ",
        "Σ",
        "Σ",
        "Λ",
        "Σ",
        "Λ",
        "Σ",
        "Λ",
        "Σ"
        };

        private void button3_Click(object sender, EventArgs e)
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


        int totalQuestions = 0;
        int correctAnswer = 0;
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
                if (totalQuestions == 2)
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                totalQuestions++;
                selectRandomQuestion();
                progressBar1.Maximum = 3;
                progressBar1.Minimum = 0;
                this.progressBar1.Increment(1);
            }
            else
            {
                correctAnswer++;
            }

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
                if (totalQuestions == 2)
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                totalQuestions++;
                selectRandomQuestion();
                progressBar1.Maximum = 3;
                progressBar1.Minimum = 0;
                this.progressBar1.Increment(1);
            }
            else
            {
                correctAnswer++;
            }
        }

        private void SwstoLathos3_Load(object sender, EventArgs e)
        {
            selectRandomQuestion();
            progressBar1.Maximum = 3;
            progressBar1.Minimum = 0;
            this.progressBar1.Increment(1);
        }
    }
}
