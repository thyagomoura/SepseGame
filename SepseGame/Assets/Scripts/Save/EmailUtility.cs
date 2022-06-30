using UnityEngine;
using System.ComponentModel;
using System.Net.Mail;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using System.Net.Mime;

public class EmailUtility : MonoBehaviour
{
    public List<Caso> Casos;
    public Caso caso;
    public Estetica pack;
    string titleName;
    string emailText;
    int numCasoCurrent;
    string txtAux;
    string[,] caso0 = new string[50, 6];
    string[,] caso1 = new string[50, 6];
    string[,] caso2 = new string[50, 6];
    string[,] caso3 = new string[50, 6];
    string[,] caso4 = new string[50, 6];
    string[,] caso5 = new string[50, 6];
    string[,] caso6 = new string[50, 6];
    string[,] caso7 = new string[50, 6];
    string[,] caso8 = new string[50, 6];
    string[,] caso9 = new string[50, 6];
    string[,] caso10 = new string[50, 6];
    string[,] caso11 = new string[50, 6];
    string[,] caso12 = new string[50, 6];

    void Start()
    {
        caso = Casos[pack.currentCase];

        titleName = "Relatorio de desempenho - " + Login.nome;

        //fazer um switch para salvar: 
        //de acordo com o numero do caso
        //pontuacao
        //acertos de sinais
        //erros de sinais
        //nao marcadas de sinais
        //acerto condutas
        //erros condutas
        numCasoCurrent = pack.currentCase;
        SelecaoCaso();


        SendEmail();
    }

    void SendEmail()
    {
        // Linhas referentes a "conexao" com o smtp de envio
        SmtpClient client = new SmtpClient("smtp.sendgrid.net", 587);

        //credenciamento para permitir o envio
        client.Credentials = new System.Net.NetworkCredential(
            "login",
            "senha");
        client.EnableSsl = true;

        // Definir quem envia o email e o nome do email que sera enviado
        MailAddress from = new MailAddress(
            "bmdrcompany@gmail.com",
            titleName,
            System.Text.Encoding.UTF8);

        // Definir quem vai receber o email
        MailAddress to = new MailAddress("bmdrcompany@gmail.com");
        MailMessage message = new MailMessage(from, to);
        message.Body = EmailTextBodyMessage();

        message.BodyEncoding = System.Text.Encoding.UTF8;
        message.Subject = titleName;
        message.SubjectEncoding = System.Text.Encoding.UTF8;


        // Metodos para envio e callback.
        client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
        string userState = titleName;
        client.SendAsync(message, userState);
    }
    private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
    {
        // Get the unique identifier for this asynchronous operation.
        string token = (string)e.UserState;

        if (e.Cancelled)
        {
            Debug.Log("Send canceled " + token);
        }
        if (e.Error != null)
        {
            Debug.Log("[ " + token + " ] " + " " + e.Error.ToString());
        }
        else
        {
            Debug.Log("Message sent.");
        }
    }

    string EmailTextBodyMessage()
    {
        int x = 0;
        emailText = $"Aluno: {Login.nome}\r\nCPF: {Login.cpf} " +
            $"\r\n\r\nCaso {1} - Pontuacao: {caso0[0, 0]}" +
            $"\r\n       Acertos:" +
            "\r\n          1." + caso0[0, 1] +
            $"\r\n       Erros:" +
            "\r\n          1." + caso0[0, 2] +
            $"\r\n       Não Marcados:" +
            "\r\n          1." + caso0[0, 3] +
            $"\r\n       Condutas Certas: " +
            "\r\n          1." + caso0[0, 4] +
            $"\r\n       Condutas Erradas: " +
            "\r\n          1." + caso0[0, 5] +
            $"\r\n\r\nCaso {2}" +
            $"\r\n\r\nCaso {3}" +
            $"\r\n\r\nCaso {4}" +
            $"\r\n\r\nCaso {5}" +
            $"\r\n\r\nCaso {6}" +
            $"\r\n\r\nCaso {7}" +
            $"\r\n\r\nCaso {8}" +
            $"\r\n\r\nCaso {9}" +
            $"\r\n\r\nCaso {10}" +
            $"\r\n\r\nCaso {11}" +
            $"\r\n\r\nCaso {12}" +
            $"\r\n\r\nCaso {13}";

        return emailText;
    }
    void SelecaoCaso()
    {
        switch (numCasoCurrent)
        {
            case 0:
                //pontuacao
                caso0[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso0);
                //erros
                SaveErros(caso0);
                //naomarcados
                SaveNaoMarcados(caso0);
                //acertocondutas
                SaveCondutasCertas(caso0);
                //erroscondutas
                SaveCondutasErrada(caso0);
                break;
            case 1:
                caso1[0, 0] = caso.pontuacao.ToString();
                break;
            case 2:
                caso2[0, 0] = caso.pontuacao.ToString();
                break;
            case 3:
                caso3[0, 0] = caso.pontuacao.ToString();
                break;
            case 4:
                caso4[0, 0] = caso.pontuacao.ToString();
                break;
            case 5:
                caso5[0, 0] = caso.pontuacao.ToString();
                break;
            case 6:
                caso6[0, 0] = caso.pontuacao.ToString();
                break;
            case 7:
                caso7[0, 0] = caso.pontuacao.ToString();
                break;
            case 8:
                caso8[0, 0] = caso.pontuacao.ToString();
                break;
            case 9:
                caso9[0, 0] = caso.pontuacao.ToString();
                break;
            case 10:
                caso10[0, 0] = caso.pontuacao.ToString();
                break;
            case 11:
                caso11[0, 0] = caso.pontuacao.ToString();
                break;
            case 12:
                caso12[0, 0] = caso.pontuacao.ToString();
                break;
            default:
                break;
        }
    }

    void SaveAcertos(string[,] x)
    {
        int contA = 0;
        for (int i = 0; i < 14; i++)
        {
            if (caso.indexesCorretos.Contains(i) && caso.selecionados.Contains(i))
            {
                txtAux = IndiceDoSinalVital(i);
                x[contA, 1] = txtAux;
                contA++;
            }
        }

    }

    void SaveErros(string[,] j)
    {
        int contE = 0;
        for (int i = 0; i < 14; i++)
        {
            if (!caso.indexesCorretos.Contains(i) && caso.selecionados.Contains(i))
            {
                txtAux = null;
                txtAux = IndiceDoSinalVital(i);
                j[contE, 2] = txtAux;
                contE++;
            }
        }
    }

    void SaveNaoMarcados(string[,] k)
    {
        int contNM = 0;
        for (int i = 0; i < 14; i++)
        {
            if (caso.indexesCorretos.Contains(i) && !caso.selecionados.Contains(i))
            {
                txtAux = null;
                txtAux = IndiceDoSinalVital(i);
                k[contNM, 3] = txtAux;
                contNM++;
            }
        }
    }

    void SaveCondutasCertas(string[,] z)
    {
        int contCC = 0;
        for (int i = 0; i < 6; i++)
        {
            if (caso.condutas[i] == caso.condutas[caso.condSelected[i]])
            {
                txtAux = null;
                txtAux = IndiceDaConduta(i);
                z[contCC, 4] = txtAux;
                contCC++;
            }
        }
    }

    void SaveCondutasErrada(string[,] b)
    {
        int contCE = 0;
        for (int i = 0; i < 6; i++)
        {
            if (caso.condutas[i] != caso.condutas[caso.condSelected[i]])
            {
                txtAux = null;
                txtAux = IndiceDaConduta(i);
                b[contCE, 5] = txtAux;
                contCE++;
            }
        }
    }

    string IndiceDoSinalVital(int contador)
    {
        switch (contador)
        {
            case 0:
                return caso.FrequenciaCardiaca;
            case 1:
                return caso.PressaoArterial;
            case 2:
                return caso.Saturacao;
            case 3:
                return caso.FrequenciaRespiratoria;
            case 4:
                return caso.Temperatura;
            case 5:
                return caso.Neurologico;
            case 6:
                return caso.Respiratorio;
            case 7:
                return caso.Cardiocirculatorio;
            case 8:
                return caso.Gastrintestinal;
            case 9:
                return caso.Renal;
            case 10:
                return caso.lab1;
            case 11:
                return caso.lab2;
            case 12:
                return caso.lab3;
            case 13:
                return caso.lab4;
            default:
                return null;
        }
    }

    string IndiceDaConduta(int contador)
    {
        switch (contador)
        {
            case 0:
                return caso.condutas[0];
            case 1:
                return caso.condutas[1];
            case 2:
                return caso.condutas[2];
            case 3:
                return caso.condutas[3];
            case 4:
                return caso.condutas[4];
            case 5:
                return caso.condutas[5];
            default:
                return null;
        }
    }
}
