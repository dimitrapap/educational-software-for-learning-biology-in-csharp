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
    public partial class PollaplhsEpiloghs3 : Form
    {
        public PollaplhsEpiloghs3()
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

        string[] op1Arr = {
           "κυτταρική",
           "κυτταρική θεωρία",
           "γένος",
           "νοητός αγώνας",
           "φυσική επιλογή",
           "βιομηχανική επανάσταση",
           "φυσικής επιλογής"
          };

        string[] op2Arr = {
           "δαρβινική",
           "δαρβινική θεωρία",
           "είδος",
           "φυσικός αγώνας",
           "εξέλιξη",
           "βιομηχανικός μελανισμός",
           "φυσικής εξέλιξης"
          };

        string[] op3Arr = {
           "φυσική",
           "θεωρία της εξέλιξης",
           "φύλο",
           "αγώνας εξέλιξης",
           "κληρονομηκότητα",
           "εσωτερική δύναμη",
           "φυσικής κλίμακας"
          };

        string[] op4Arr = {
           "λαμαρξική",
           "λαμαρξική θεωρία",
           "θέμα",
           "αγώνας επιβίωσης",
           "επιβίωση",
           "φυσική επιλογή",
           "φυσικής δύναμης"
          };

        private void button1_Click(object sender, EventArgs e)
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == ansArr[selectedQuestion])
            {
                
                label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                if (totalQuestions == 2)
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                else
                {
                    selectRandomQuestion();
                    questions();
                    progressBar1.Maximum = 3;
                    progressBar1.Minimum = 0;
                    this.progressBar1.Increment(1);
                }
                totalQuestions++;
            }
        }

        private void PollaplhsEpiloghs3_Load(object sender, EventArgs e)
        {
            selectRandomQuestion();
            questions();
            progressBar1.Maximum = 3;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == ansArr[selectedQuestion])
            {
                
                label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                if (totalQuestions == 2)
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                else
                {
                    selectRandomQuestion();
                    questions();
                    progressBar1.Maximum = 3;
                    progressBar1.Minimum = 0;
                    this.progressBar1.Increment(1);
                }
                totalQuestions++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == ansArr[selectedQuestion])
            {
               
                label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                if (totalQuestions == 2)
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                else
                {
                    selectRandomQuestion();
                    questions();
                    progressBar1.Maximum = 3;
                    progressBar1.Minimum = 0;
                    this.progressBar1.Increment(1);
                }
                totalQuestions++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == ansArr[selectedQuestion])
            {
               
                label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                if (totalQuestions == 2)
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                else
                {
                    selectRandomQuestion();
                    questions();
                    progressBar1.Maximum = 3;
                    progressBar1.Minimum = 0;
                    this.progressBar1.Increment(1);
                }
                totalQuestions++;
            }
        }
    }
}
