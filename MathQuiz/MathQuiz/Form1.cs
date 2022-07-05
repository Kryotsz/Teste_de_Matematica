using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // gera números randômicos
        Random randomizer = new Random();

        // armazena os números da operação de soma
        int addend1;
        int addend2;

        // armazena os números da operação de subtração
        int minuend;
        int subtrahend;

        // armazena os números da operação de multiplicação
        int multiplicand;
        int multiplier;

        // armazena os números da operação de divisão
        int dividend;
        int divisor;

        // controla o tempo restante
        int timeLeft;

        public void StartTheQuiz()
        {
            // gerar números aleatórios e armazenar nas variáveis
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // converte os números pra texto para serem mostrados nas labels de soma
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // seta o valor padrão da soma pra 0 antes de efetuar a soma
            soma.Value = 0;

            // Preencher o problema de subtração
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLable.Text = minuend.ToString();
            minusRightLable.Text = subtrahend.ToString();
            diferença.Value = 0;

            // Preencher o problema de multiplicação
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2,11);
            timesLeftLable.Text = multiplicand.ToString();
            timesRightLable.Text = multiplier.ToString();
            produto.Value = 0;

            // Preencher o problema de divisão
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLable.Text = dividend.ToString();
            dividedRightLable.Text = divisor.ToString();
            quociente.Value = 0;

            // Inicia o timer
            timeLeft = 30;
            timeLabel.Text = "30 segundos";
            timer1.Start();

            // Ao startar o quiz, habilitar os painéis de resposta
            soma.Enabled = true;
            diferença.Enabled = true;
            produto.Enabled = true;
            quociente.Enabled = true;

            // e tornar invisível os ícones de certinho
            picBox1.Visible = false;
            picBox2.Visible = false;
            picBox3.Visible = false;
            picBox4.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // quando clicar no botão start, o quiz começa
            StartTheQuiz();
            // e o botão de start é desabilitado
            startButton.Enabled = false;
        }

        private bool CheckTheAnswer()
        {
            // se a soma dos números for igual a resposta inserida, retorna true
            if ((addend1 + addend2 == soma.Value)
                && (minuend - subtrahend == diferença.Value)
                && (multiplicand * multiplier == produto.Value)
                && (dividend / divisor == quociente.Value))
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // verifica se o CheckTheAnswer é true
            if (CheckTheAnswer())
            {
                // se sim, para o timer, volta a cor pra branco e apresenta a mensagem de parabéns
                timer1.Stop();
                timeLabel.BackColor = default(Color);
                MessageBox.Show("Você acertou todas as respostas!",
                                "Parabéns!");
                // torna o botão Start disponível para ser clicado e começar outro teste
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // se o usuário ainda não acertou, o tempo continua diminuindo 1 segundo
                timeLeft = timeLeft - 1;
                // mostra na Label o tempo restante em segundos
                timeLabel.Text = timeLeft + " segundos";
                // se o tempo restante for igual ou menor a 5
                if (timeLeft <= 5)
                {
                    // a cor do background fica vermelho
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            {
                // se o tempo acabar, o timer para
                timer1.Stop();
                // a cor volta pra padrão
                timeLabel.BackColor = default(Color);
                // e apresenta uma mensagem dizendo que o tempo acabou
                timeLabel.Text = "Tempo esgotado!";
                MessageBox.Show("Você não terminou a tempo.", "Sinto muito!");
                // então, todas as respostas são mostradas
                soma.Value = addend1 + addend2;
                diferença.Value = minuend - subtrahend;
                produto.Value = multiplicand * multiplier;
                quociente.Value = dividend / divisor;
                // e o botão Start fica disponível novamente
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // seleciona a resposta inteira do painel NumericUpDown
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }
        }

        private void CheckValue(object sender, EventArgs e)
        {
            if (addend1 + addend2 == soma.Value)
            {
                soma.Enabled = false;
                picBox1.Visible = true;
            }

            if (minuend - subtrahend == diferença.Value)
            {
                diferença.Enabled = false;
                picBox2.Visible = true;
            }

            if (multiplicand * multiplier == produto.Value)
            {
                produto.Enabled = false;
                picBox3.Visible = true;
            }

            if (dividend / divisor == quociente.Value)
            {
                quociente.Enabled = false;
                picBox4.Visible = true;
            }
        }
    }
}
