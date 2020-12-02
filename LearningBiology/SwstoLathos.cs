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
    public partial class SwstoLathos : Form
    {
        public SwstoLathos()
        {
            InitializeComponent();
        }

        string[] qArr = {
          "Τα αντιβιοτικά είναι χημικές ουσίες με αντιμικροβιακή δράση που παράγονται απο βακτήρια , μύκητες και φυτά.",
          "Τα αντιβιοτικά βλάπτουν τα κύτταρα του ανθρώπου.",
          "Τα αντιβιοτικά είναι αποτελεσματικά έναντι των ιών.",
          "Το δέρμα εμποδίζει αποτελεσματικά την είσοδο των μικροβίων στον οργανισμό.",
          "Τα Τ-λεμφοκύτταρα διαφοροποιούνται και ωριμάζουν στο μυελό των οστών.",
          "Η πρωτογενής ανοσοβιολογική απόκριση ενεργοποιείται κατά την πρώτη επαφή του οργανισμού με ένα αντιγόνο.",
          "Η εξειδίκευση είναι η ικανότητα του οργανισμού να θυμάται τα αντιγόνα με τα οποία έχει έλθει σε επαφή.",
          "Η δράση των βοηθητικών και των κυτταροτοξικών Τ-λεμφοκυττάρων αποτελεί την κυτταρική ανοσία.",
          "Η δευτερογενής ανοσοβιολογική απόκριση ενεργοποιείται κατά την επαφή του οργανισμού με το ίδιο αντιγόνο για δεύτερη (ή επόμενη) φορά.",
          "Τα πρωτόζωα είναι προκαρυωτικοί οργανισμοί.",
          "Οι μύκητες είναι ευκαρυωτικοί μονοκύτταροι ή πολυκύταρροι οργανισμοί .",
          "Η ιστολυτική αμοιβάδα προκαλεί αμοιβαδοειδή δυσεντερία.",
          "Τα φαγοκύτταρα αποτελούν μια κατηγορία ερυθρών αιμοσφαιριών.",
          "Τα πρωτογενή λεμφικά όργανα είναι οι λεμφαδένες, ο σπλήνας , οι αμυγδαλές και ο λεμφικός ιστός κατά το μήκος του γαστρεντερικού σωλήνα.",
          "Τα πρωτογενή λεμφικά όργανα είναι ο μυελός των οστών και ο θύμος αδένας.",
          "Η περιοχή του μορίου του αντισώματος που συνδέεται με την αντιγόνο ονομάζεται σταθερή περιοχή.",
          "Τα Β-λεμφοκύτταρα μνήμης ενεργοποιούνται αμέσως μετά από επόμενη έκθεση του οργανισμού στο ίδιο αντιγόνο.",
          "Τα αντιβιοτικά προκαλούν διαταραχές στη λειτουργία της πλασματικής μεμβράνης.",
          "Μια ασθένεια ΔΕΝ οφείλεται σε έναν παθογόνο μικροοργανισμό όταν ο μικροοργανισμός αυτός μπορεί να απομονώθει και να καλλιεργηθεί στο εργαστήριο."
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
          "false"
          };
        string[] ansArr={
        "Σ",
        "Λ",
        "Λ",
        "Σ",
        "Λ",
        "Σ",
        "Λ",
        "Σ",
        "Σ",
        "Λ",
        "Σ",
        "Σ",
        "Λ",
        "Λ",
        "Σ",
        "Λ",
        "Σ",
        "Σ",
        "Λ"
        };
        int totalQuestions = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
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

        private void SwstoLathos_Load(object sender, EventArgs e)
        {
            selectRandomQuestion();
            progressBar1.Maximum = 6;
            progressBar1.Minimum = 0;
            this.progressBar1.Increment(1);

        }
        int correctAnswer = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(ansArr[selectedQuestion] == "Σ")
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
                    Form2 form2 = new Form2();
                    form2.Show();
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
                    Form2 form2 = new Form2();
                    form2.Show();
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
