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
    public partial class PollaplhsEpiloghs : Form
    {
        public PollaplhsEpiloghs()
        {
            InitializeComponent();
        }
        int totalQuestions = 0;

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

        string[] opt1Arr = {
          "ομοιόσταση",
          "μύκητες",
          "μύκητες",
          "μύκητες",
          "μυκητίαση",
          "μυκητίαση",
          "μυκητιάσεις",
          "τοξίνες",
          "παράσιτα",
          "παθογόνος",
          "προκαρυωτικοί",
          "τρυπανόσωμα",
          "τρυπανόσωμα",
          "τρυπανόσωμα",
          "βακτήρια",
          "έλυτρο",
          "έλυτρο",
          "τοξίνες",
          "τοξίνες",
          "τοξίνες",
          "συμπλήρωμα",
          "αμοιβάδα",
          "ανοσία",
          "εξειδίκευση",
          "αντιγόνο"
          };

        string[] op2Arr = {
          "ανάρρωση",
          "μικρόβια",
          "μικρόβια",
          "ξενιστές",
          "λοίμωξη",
          "λοίμωξη",
          "μολύνσεις",
          "ενδοτοξίνες",
          "ξενιστές",
          "ξενιστής",
          "ξενιστές",
          "τοξόπλασμα",
          "τοξόπλασμα",
          "τοξόπλασμα",
          "εκβλαστήματα",
          "τοξόπλασμα",
          "τοξόπλασμα",
          "ενδοτοξίνες",
          "ενδοτοξίνες",
          "ενδοτοξίνες",
          "καψίδιο",
          "προπερδίνη",
          "προσαρμογή",
          "προσαρμογή",
          "μικρόβιο"
          };

        string[] op3Arr = {
          "υγεία",
          "βακτήρια",
          "βακτήρια",
          "ιοί",
          "ομοιόσταση",
          "ομοιόσταση",
          "ιώσεις",
          "εξωτοξίνες",
          "παθογόνοι",
          "πρωτόζωο",
          "παθογόνοι",
          "candida albicans",
          "candida albicans",
          "candida albicans",
          "δερματόφυτα",
          "εκβλάστημα",
          "εκβλάστημα",
          "εξωτοξίνες",
          "εξωτοξίνες",
          "εξωτοξίνες",
          "έλυτρο",
          "μνήμη",
          "μνήμη",
          "μνήμη",
          "παράσιτο"
          };

        string[] op4Arr = {
          "ευεξία",
          "ιοί",
          "ιοί",
          "ενδοτοξίνες",
          "μόλυνση",
          "μόλυνση",
          "λοιμώδη νοσήματα",
          "μύκητες",
          "μικρόβια",
          "βακτήριο",
          "μολυσματικοί",
          "πλασμώδιο",
          "πλασμώδιο",
          "πλασμώδιο",
          "πλασμώδιο",
          "καψίδιο",
          "καψίδιο",
          "ιοί",
          "ιοί",
          "ανοσοσφαιρίνες",
          "πλασμοκύτταρο",
          "εξειδίκευση",
          "εξειδίκευση",
          "ανοσία",
          "πλασμώδιο"
          };

        string[] ansArr = {
           "ομοιόσταση",
           "μικρόβια",
           "βακτήρια",
           "ιοί",
           "μόλυνση",
           "λοίμωξη",
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

        private void button1_Click(object sender, EventArgs e)
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

        private void PollaplhsEpiloghs_Load(object sender, EventArgs e)
        {
            selectRandomQuestion();
            questions();
            progressBar1.Maximum = 6;
            progressBar1.Minimum = 0;
            this.progressBar1.Increment(1);
        }

        void questions()
        {
            button2.Text = opt1Arr[selectedQuestion];
            button3.Text = op2Arr[selectedQuestion];
            button4.Text = op3Arr[selectedQuestion];
            button5.Text = op4Arr[selectedQuestion];
           
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
           if(button2.Text == ansArr[selectedQuestion])
            {
                selectRandomQuestion();
                questions();
                progressBar1.Maximum = 6;
                progressBar1.Minimum = 0;
                this.progressBar1.Increment(1);
                label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                if (totalQuestions == 5)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
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
                    Form2 form2 = new Form2();
                    form2.Show();
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
                    Form2 form2 = new Form2();
                    form2.Show();
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
                    Form2 form2 = new Form2();
                    form2.Show();
                    Visible = false;
                    MessageBox.Show("Συμπληρώσατε την άσκηση!");

                }
                totalQuestions++;
            }
        }
    }
}
