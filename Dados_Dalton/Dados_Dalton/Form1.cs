using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados_Dalton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Numerododado, TodososDados;  
        int Numerosorteado = 0, Somadosdados;
        //Declarando variáveis no tipo string e int
        private void Form1_Load(object sender, EventArgs e)
        {
            cbxOrdem.SelectedIndex = 0;
            //No evento Load do formulário defino que o número da lista vai ser 0 para começar com ordem decrescente na rolagem de dados
        }

        List<Panel> Historico = new List<Panel>();
        //Criei uma variável de lista de paneis, que praticamente é uma variável que possue vários registros nela sendo esses registros paineis e ao contrário de array possue tamanho expansivo
        private void CriaPanelDado()
        {
            //Método criado para criar os controles dentro do painel Resultados que servirão como histórico das rolagens anteriores
            Panel Resultados = new Panel
            {
               BackColor = Color.WhiteSmoke,
               Width = 456,
               Height = 95
            };
            Historico.Add(Resultados);//criei uma painel Resultados e defini algumas de suas propriedaes e coloquei para ela fazer parte da lista Historico
            Label Valor = new Label
            {
                Location = new Point(16, 34),
                Font = new Font("Arial Black", 9, FontStyle.Bold),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                Width = 65,
                Text = Somadosdados.ToString()
            };
            Resultados.Controls.Add(Valor);
            //neste crio um label que vai ficar no panel Resultados, ele portará como texto  a soma de todos os dados rolados mais o modificador que vai ser escolhido
            Label tipo = new Label
            {
                Location = new Point(89, 3),
                Font = new Font("Arial Black", 8, FontStyle.Bold),
                ForeColor = Color.Black,
                Height = 12,
                Text = Numerododado
            };
            Resultados.Controls.Add(tipo);
            //Esse label mostrará qual dado foi rolado se foi um d20 ou d4 ou outros possíveis
            PictureBox quadro = new PictureBox
            {
                Location = new Point(3, 3),
                Width = 80,
                Height = 77,
                BackColor = Color.Gray
            };
            Resultados.Controls.Add(quadro);
            //uma picture box feita mais por questões de estética 
            PictureBox linha = new PictureBox
            {
                Location = new Point(3, 91),
                Width = 450,
                Height = 1,
                BackColor = Color.Gray
            };
            Resultados.Controls.Add(linha);
            //É uma linha que vai ficar na parte de baixo panel Resultados
            Label Todosdados = new Label
            {
                Location = new Point(89, 18),
                Font = new Font("Arial Black", 6.25f, FontStyle.Bold),
                ForeColor = Color.Black,
                MaximumSize = new Size(370, 0),
                AutoSize = true,
                Text = TodososDados
            };
            Resultados.Controls.Add(Todosdados);
            //neste label estará contido todos os dados rolados, se por exemplo rolar dois dados e um tirei 20 e outro 1, será salvo ambas rolagens

            int definirlocal = 1;
            for (int i = Historico.Count - 1; i >= 0; i--)
            {
                if (i != Historico.Count - 1)
                {
                    definirlocal += 97;
                    Historico[i].Location = new Point(0, definirlocal);    
                }
                else
                {
                    Historico[i].Location = new Point(0, definirlocal);
                }
            }
            panHistorico.Controls.Clear();
            for (int k = 0; k < Historico.Count; k++)
            {
                panHistorico.Controls.Add(Historico[k]);
            }
            /*
              Declarei uma variável do tipo int definir local já começando por 1, o panel resultados que criei vai se juntar a  lista de panels Historico, o primeiro panel Historico
              vai ficar com o nome Historico[0] e seus sucessivos vão agregando em + 1,no código acima como não tinha definido a localização dos panels Historico, utilizei de uma variável int = 1
              e uma estrutura de laço de repetição, que dentro dela defini que a variável i vai se repetir até chegar a 0 e i vai ter o valor do número total de Historico -1, o -1 é porque a contagem de todos os paineis Historico
              partem de 0, dentro desse laço fiz a condição que se a variável i valesse um valor diferente do total de paineis do Historico - 1, somasse a variável definirlocal o valor de 97 que vai definir a localização
              de cada panel, no else pus que o ultimo registro não precisasse pular 97 pixels começando a partir do pixel 1, Tive que utilizar esta lógica para cada  panel adicionado o ultimo resultado ficasse em primeiro e os feitos anteriormente
             iam descendo na lista ao lado e para evitar problemas ainda mais complexos eu limpo panHistorico e adiciono novamente os itens dentro dele com outro laço.
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dado = Convert.ToInt32(nudTipo.Value) + 1;
            Random RolaDado = new Random();
            List<int> NumeroRolado = new List<int>();
            /* Declarei 3  variáveis, a primeira sendo ela  dado que irá pegar o valor do nudTipo e somará + 1
             * a varíavel rola dado do tipo random para sortear os números para as rolagens
             * a ultima novamente uma lista para armazenar todos os dados sorteados.
             */
            for (int i = 0; i < NudQuantidade.Value; i++)
            {
                Numerosorteado = RolaDado.Next(1, dado);
                NumeroRolado.Add(Numerosorteado);
            }
            /*Este laço vai sortear o número de vezes da quantidade escolhida pelo usuário, vai  sortear um número que seja >= 1 e o tipo do dado e cada número sorteado vai ser
             * atribuido a uma varíavel numerosorteado que vai ser adcionado na lista Numero rolado
             */
            List<int> Organiza = new List<int>();
            // Esta nova lista foi criada com a finalidade de organiza em ordem decrescente, natural e crescente, todos os numero sorteados.

            switch (cbxOrdem.SelectedIndex)
            {
                case 0:
                    Organiza = NumeroRolado.OrderByDescending(numero => numero).ToList();
                    break;
                case 1:
                    Organiza = NumeroRolado.ToList();
                    break;
                case 2:
                    Organiza = NumeroRolado.OrderBy(numero => numero).ToList();
                    break;       
            }
            // esta switch case vai mudar a ordem conforme o que está selecionado no cbxordem

            for (int k = 0; k < Organiza.Count; k++)
            {
                if (k == 0)
                {
                    TodososDados = Organiza[k].ToString();
                    Somadosdados = Organiza[k];
                }
                else
                {
                    Somadosdados += Organiza[k];
                    TodososDados += ", " + Organiza[k].ToString();
                }
            }
            /*
            este for vai ser feito até todos os elementos de organiza estarem finalizados dentro dele para sempre reniciar as varíaveis para novos valores
            quando k tiver o valor 0 o primeiro valor de organiza vai ser atribuido para duas variáveis, nos valores seguintes na varíavel somadosdados vai somando todos os elementos
            e a outra varíavel vai escrevendo todos os valores de organiza com , e espaço
            */
            Somadosdados += Convert.ToInt32(nudSoma.Value);
            //essa parte é para adcionar o modificador no somadodados

            if (nudSoma.Value == 0)
            {
                Numerododado = NudQuantidade.Value.ToString() + "d" + nudTipo.Value.ToString();
            }
            else if (nudSoma.Value > 0)
            {
                Numerododado = NudQuantidade.Value.ToString() + "d" + nudTipo.Value.ToString() + "+" + nudSoma.Value.ToString();
            }
            else
            {
                Numerododado = NudQuantidade.Value.ToString() + "d" + nudTipo.Value.ToString() + nudSoma.Value.ToString(); 
            }
            MessageBox.Show(TodososDados + "\r\n\r\n A soma de tudo é " + Somadosdados, Numerododado, MessageBoxButtons.OK);
            /*
             criei estes ifs para que a variável string numerorodado receba os textos para cada situação quando o usuários escolhe somar,subtrair e quando nenhum dos dois
              exibo uma menssage box com todoas as informações das rolagens
            */
            CriaPanelDado();
            //executo o método para salvar no histórico
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panHistorico.Controls.Clear();
            Historico.Clear();
            //Botão para apagar o histórico
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (nudTipo.Value)
            {
                case 4:
                    pcbDado.Image = Properties.Resources.d4;
                    break;
                case 6:
                    pcbDado.Image = Properties.Resources.d6;
                    break;
                case 8:
                    pcbDado.Image = Properties.Resources.d8;
                    break;
                case 10:
                    pcbDado.Image = Properties.Resources.d10;
                    break;
                case 12:
                    pcbDado.Image = Properties.Resources.d12;
                    break;
                case 20:
                    pcbDado.Image = Properties.Resources.d20;
                    break;
                case 100:
                    pcbDado.Image = Properties.Resources.d100;
                    break;
                default:
                    pcbDado.Image = Properties.Resources.dado;
                    break;
            }
            //Timer feito para tocar a imagem conforme o tipo de dado   
        }

    }
}
