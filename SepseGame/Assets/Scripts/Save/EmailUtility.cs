using UnityEngine;
using System.ComponentModel;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine.UI;
using System.Net.Mime;

public class EmailUtility : MonoBehaviour
{
    public List<Caso> Casos;
    public Caso caso;
    public Estetica pack;
    string titleName;
    int numCasoCurrent;
    string txtAux;
    string[,] caso0 = new string[7, 14];
    string[,] caso1 = new string[7, 14];
    string[,] caso2 = new string[7, 14];
    string[,] caso3 = new string[7, 14];
    string[,] caso4 = new string[7, 14];
    string[,] caso5 = new string[7, 14];
    string[,] caso6 = new string[7, 14];
    string[,] caso7 = new string[7, 14];
    string[,] caso8 = new string[7, 14];
    string[,] caso9 = new string[7, 14];
    string[,] caso10 = new string[7, 14];
    string[,] caso11 = new string[7, 14];
    string[,] caso12 = new string[7, 14];
    string[,] caso13 = new string[7, 14];
    string resultsAux;
    string results0;
    string results1;
    string results2;
    string results3;
    string results4;
    string results5;
    string results6;
    string results7;
    string results8;
    string results9;
    string results10;
    string results11;
    string results12;
    string results13;
    string legendaEmail;
    void Start()
    {
        legendaEmail = "Para entendender o relatório, cada linha significa algo, dessa forma, segue as instruções abaixo:\n" +
            "1. Primeira linha sempre será a PONTUAÇÂO\n" +
            "2. Segunda linha sempre será os ACERTOS\n" +
            "3. Terceira linha sempre será os ERROS\n" +
            "4. Quarta linha sempre será os NÂO MARCADOS\n" +
            "5. Quinta linha sempre será os ACERTOS DE CONDUTA\n" +
            "6. Sexta linha sempre será os ERROS DE CONDUTA\n" +
            "7. Sétima linha sempre será os AVISOS\n\n";

        caso = Casos[pack.currentCase];

        titleName = "Relatorio de desempenho - " + Login.nome;

        numCasoCurrent = pack.currentCase;
        SelecaoCaso();

        if (numCasoCurrent == 0)
        {
            SendEmail();
        }
    }
    void SendEmail()
    {
        // Linhas referentes a "conexao" com o smtp de envio
        SmtpClient client = new SmtpClient("smtp.mailgun.org", 587);

        //credenciamento para permitir o envio
        client.Credentials = new System.Net.NetworkCredential(
            "postmaster@sandbox30329b9ee820478ea4847b2cc8f25e13.mailgun.org",
            "d9ce1d513e5157c93aad9b3bd2023a2a-77985560-4cd1dfd8");
        client.EnableSsl = true;

        // Definir quem envia o email e o nome do email que sera enviado
        MailAddress from = new MailAddress(
            "sepsegamerelatorio@gmail.com",
            titleName,
            System.Text.Encoding.UTF8);

        // Definir quem vai receber o email
        MailAddress to = new MailAddress("sepsegamerelatorio@gmail.com");
        MailMessage message = new MailMessage(from, to);
        message.Body = $"\nNome: {Login.nome}" +
            $"\nCPF: {Login.cpf}\n\n" +
            $"Legenda para leitura dos casos:\n {legendaEmail}" +
            $"\r\nCaso 1 \n{results0}\n\n" +
            $"\r\nCaso 2: \n{results1}\n\n" +
            $"\r\nCaso 3 \n{results2}\n\n" +
            $"\r\nCaso 4 \n{results3}\n\n" +
            $"\r\nCaso 5 \n{results4}\n\n" +
            $"\r\nCaso 6 \n{results5}\n\n" +
            $"\r\nCaso 7 \n{results6}\n\n" +
            $"\r\nCaso 8 \n{results7}\n\n" +
            $"\r\nCaso 9 \n{results8}\n\n" +
            $"\r\nCaso 10 \n{results9}\n\n" +
            $"\r\nCaso 11 \n{results10}\n\n" +
            $"\r\nCaso 12 \n{results11}\n\n" +
            $"\r\nCaso 13 \n{results12}\n\n";

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
                //avisos
                SaveAvisos(caso0);
                //Correcao do caso para mostrar no email
                results0 = CorrigirMatriz(caso0);
                break;
            case 1:
                //pontuacao
                caso1[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso1);
                //erros
                SaveErros(caso1);
                //naomarcados
                SaveNaoMarcados(caso1);
                //acertocondutas
                SaveCondutasCertas(caso1);
                //erroscondutas
                SaveCondutasErrada(caso1);
                //avisos
                SaveAvisos(caso1);
                //Correcao do caso para mostrar no email
                results1 = CorrigirMatriz(caso1);
                break;
            case 2:
                //pontuacao
                caso2[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso2);
                //erros
                SaveErros(caso2);
                //naomarcados
                SaveNaoMarcados(caso2);
                //acertocondutas
                SaveCondutasCertas(caso2);
                //erroscondutas
                SaveCondutasErrada(caso2);
                //avisos
                SaveAvisos(caso2);
                //Correcao do caso para mostrar no email
                results2 = CorrigirMatriz(caso2);
                break;
            case 3:
                //pontuacao
                caso3[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso3);
                //erros
                SaveErros(caso3);
                //naomarcados
                SaveNaoMarcados(caso3);
                //acertocondutas
                SaveCondutasCertas(caso3);
                //erroscondutas
                SaveCondutasErrada(caso3);
                //avisos
                SaveAvisos(caso3);
                //Correcao do caso para mostrar no email
                results3 = CorrigirMatriz(caso3);
                break;
            case 4:
                //pontuacao
                caso4[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso4);
                //erros
                SaveErros(caso4);
                //naomarcados
                SaveNaoMarcados(caso4);
                //acertocondutas
                SaveCondutasCertas(caso4);
                //erroscondutas
                SaveCondutasErrada(caso4);
                //avisos
                SaveAvisos(caso4);
                //Correcao do caso para mostrar no email
                results4 = CorrigirMatriz(caso4);
                break;
            case 5:
                //pontuacao
                caso5[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso5);
                //erros
                SaveErros(caso5);
                //naomarcados
                SaveNaoMarcados(caso5);
                //acertocondutas
                SaveCondutasCertas(caso5);
                //erroscondutas
                SaveCondutasErrada(caso5);
                //avisos
                SaveAvisos(caso5);
                //Correcao do caso para mostrar no email
                results5 = CorrigirMatriz(caso5);
                break;
            case 6:
                //pontuacao
                caso6[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso6);
                //erros
                SaveErros(caso6);
                //naomarcados
                SaveNaoMarcados(caso6);
                //acertocondutas
                SaveCondutasCertas(caso6);
                //erroscondutas
                SaveCondutasErrada(caso6);
                //avisos
                SaveAvisos(caso6);
                //Correcao do caso para mostrar no email
                results6 = CorrigirMatriz(caso6);
                break;
            case 7:
                //pontuacao
                caso7[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso7);
                //erros
                SaveErros(caso7);
                //naomarcados
                SaveNaoMarcados(caso7);
                //acertocondutas
                SaveCondutasCertas(caso7);
                //erroscondutas
                SaveCondutasErrada(caso7);
                //avisos
                SaveAvisos(caso7);
                //Correcao do caso para mostrar no email
                results7 = CorrigirMatriz(caso7);
                break;
            case 8:
                //pontuacao
                caso8[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso8);
                //erros
                SaveErros(caso8);
                //naomarcados
                SaveNaoMarcados(caso8);
                //acertocondutas
                SaveCondutasCertas(caso8);
                //erroscondutas
                SaveCondutasErrada(caso8);
                //avisos
                SaveAvisos(caso8);
                //Correcao do caso para mostrar no email
                results8 = CorrigirMatriz(caso8);
                break;
            case 9:
                //pontuacao
                caso9[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso9);
                //erros
                SaveErros(caso9);
                //naomarcados
                SaveNaoMarcados(caso9);
                //acertocondutas
                SaveCondutasCertas(caso9);
                //erroscondutas
                SaveCondutasErrada(caso9);
                //avisos
                SaveAvisos(caso9);
                //Correcao do caso para mostrar no email
                results9 = CorrigirMatriz(caso9);
                break;
            case 10:
                //pontuacao
                caso10[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso10);
                //erros
                SaveErros(caso10);
                //naomarcados
                SaveNaoMarcados(caso10);
                //acertocondutas
                SaveCondutasCertas(caso10);
                //erroscondutas
                SaveCondutasErrada(caso10);
                //avisos
                SaveAvisos(caso10);
                //Correcao do caso para mostrar no email
                results10 = CorrigirMatriz(caso10);
                break;
            case 11:
                //pontuacao
                caso11[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso11);
                //erros
                SaveErros(caso11);
                //naomarcados
                SaveNaoMarcados(caso11);
                //acertocondutas
                SaveCondutasCertas(caso11);
                //erroscondutas
                SaveCondutasErrada(caso11);
                //avisos
                SaveAvisos(caso11);
                //Correcao do caso para mostrar no email
                results11 = CorrigirMatriz(caso11);
                break;
            case 12:
                //pontuacao
                caso12[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso12);
                //erros
                SaveErros(caso12);
                //naomarcados
                SaveNaoMarcados(caso12);
                //acertocondutas
                SaveCondutasCertas(caso12);
                //erroscondutas
                SaveCondutasErrada(caso12);
                //avisos
                SaveAvisos(caso12);
                //Correcao do caso para mostrar no email
                results12 = CorrigirMatriz(caso12);
                break;
            case 13:
                //pontuacao
                caso13[0, 0] = caso.pontuacao.ToString();
                //acertos
                SaveAcertos(caso13);
                //erros
                SaveErros(caso13);
                //naomarcados
                SaveNaoMarcados(caso13);
                //acertocondutas
                SaveCondutasCertas(caso13);
                //erroscondutas
                SaveCondutasErrada(caso13);
                //avisos
                SaveAvisos(caso13);
                //Correcao do caso para mostrar no email
                results13 = CorrigirMatriz(caso13);
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
                x[1, contA] = txtAux;
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
                j[2, contE] = txtAux;
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
                k[3, contNM] = txtAux;
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
                z[4, contCC] = txtAux;
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
                b[5, contCE] = txtAux;
                contCE++;
            }
        }
    }

    void SaveAvisos(string[,] sx)
    {
        int slot = 0;
        if (!caso.abriuProtocolo)
        {
            sx[6, slot] = "O Protocolo de Sepse não foi aberto! -10 pontos";
            slot++;
        }
        if (!caso.chamouEquipe)
        {
            sx[6, slot] = "A Equipe Médica não foi acionada! -20 pontos";
            slot++;
        }
        if (!caso.apertouBotaoCorreto)
        {
            if (caso.buttonCorreto == 1)
            {
                sx[6, slot] = "O Protocolo de Sepse deveria ter sido descontinuado! -10 pontos";
                slot++;
            }
            else
            {
                sx[6, slot] = "O Protocolo de Sepse deveria ter sido continuado! -10 pontos";
                slot++;
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

    string CorrigirMatriz(string[,] res)
    {
        resultsAux = string.Join("\n",
              Enumerable.Range(0, res.GetUpperBound(0) + 1)
             .Select(x => Enumerable.Range(0, res.GetUpperBound(1) + 1)
             .Select(y => res[x, y]))
             .Select(z => string.Join($"; ", z)));

        return resultsAux;
    }
}
