namespace AIQuestions
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> _questionsDic = new Dictionary<string, string>();
        List<string> _questionsList = new List<string>();
        string _question = string.Empty;
        Random r = new Random();
        int score;
        
        public Form1()
        {
            InitializeComponent();
            txtSigns.Text = "(     )     p     q     ^     ∨";
            labAnswer.Text = "";
            fillDic();
            getRandomQuestion();
            txtAnswer.Focus();
        }

        private void getRandomQuestion()
        {
            txtAnswer.Text = string.Empty;
            _question = _questionsList[r.Next(0, _questionsList.Count - 1)];
            txtQuestion.Text = _question;

            //labStatus.Text = "Status";
            //labStatus.ForeColor = Color.Black;
        }

        private void fillDic()
        {
            _questionsDic.Add("P^T","P");
            _questionsDic.Add("P∨F","P");
            _questionsDic.Add("P∨T","T");
            _questionsDic.Add("P^F","F");
            _questionsDic.Add("P∨P","P");
            _questionsDic.Add("P^P","P");
            _questionsDic.Add("P∨~P","T");
            _questionsDic.Add("P^~P","F");
            _questionsDic.Add("~(P^Q)","~p∨~Q");
            _questionsDic.Add("~(P∨Q)","~p^~Q");
            _questionsDic.Add("p^(p∨q)","p");
            _questionsDic.Add("p∨(p^q)","p");
            _questionsDic.Add("p^q","q^p");
            _questionsDic.Add("p∨q","q∨p");
            _questionsDic.Add("(p∨q)^r","(r^p)∨(r^q)");
            _questionsDic.Add("(p^q)∨r","(r∨p)^(r∨q)");
            _questionsDic.Add("(p^q)^r","p^(q^r)");
            _questionsDic.Add("(p∨q)∨r","p∨(q∨r)");

            _questionsDic.Add("~p∨~Q","~(P^Q)");
            _questionsDic.Add("~p^~Q","~(P∨Q)");
            _questionsDic.Add("q^p","p^q");
            _questionsDic.Add("q∨p","p∨q");
            _questionsDic.Add("(r^p)∨(r^q)","(p∨q)^r");
            _questionsDic.Add("(r∨p)^(r∨q)","(p^q)∨r");
            _questionsDic.Add("p^(q^r)","(p^q)^r");
            _questionsDic.Add("p∨(q∨r)","(p∨q)∨r");

            _questionsList =_questionsDic.Keys.ToList();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string answer = _questionsDic[_question];
            if (answer.Trim().ToLower() == txtAnswer.Text.Trim().ToLower())
            {
                score += 1;
                labScore.Text = $"Score = {score}";
                labStatus.Text = "Right";
                labStatus.ForeColor = Color.Green;
                labScore.ForeColor = Color.Green;
                labAnswer.Text = "";
                getRandomQuestion();
            }
            else
            {
                score -= 1;
                labScore.Text = $"Score = {score}";
                labStatus.Text = "Wrong";
                labStatus.ForeColor = Color.Red;
                labScore.ForeColor = Color.Red;
                labAnswer.Text = $"The Answer is : {answer}";
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            score -= 1;
            labScore.Text = $"Score = {score}";
            labScore.ForeColor = Color.Red;
            getRandomQuestion();
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string answer = _questionsDic[_question];
                if (answer.Trim().ToLower() == txtAnswer.Text.Trim().ToLower())
                {
                    score += 1;
                    labScore.Text = $"Score = {score}";
                    labStatus.Text = "Right";
                    labStatus.ForeColor = Color.Green;
                    labScore.ForeColor = Color.Green;
                    labAnswer.Text = "";
                    getRandomQuestion();
                }
                else
                {
                    score -= 1;
                    labScore.Text = $"Score = {score}";
                    labStatus.Text = "Wrong";
                    labStatus.ForeColor = Color.Red;
                    labScore.ForeColor = Color.Red;
                    labAnswer.Text = $"The Answer is : {answer}";
                }
            }
        }
    }
}