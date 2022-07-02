using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;
using System.Net.Mail;
using System.Linq;
using TMPro;
using UnityEngine.UI;
using System.Net.Mime;

public class EmailSend : MonoBehaviour
{
    public static string titleName;
    public static string legendaEmail;
    public static string resultado0R;
    public static string resultado1R;
    public static string resultado2R;
    public static string resultado3R;
    public static string resultado4R;
    public static string resultado5R;
    public static string resultado6R;
    public static string resultado7R;
    public static string resultado8R;
    public static string resultado9R;
    public static string resultado10R;
    public static string resultado11R;
    public static string resultado12R;
    public Estetica pack;

    // Start is called before the first frame update
    void Start()
    {
        legendaEmail = "Para entendender o relatório, cada linha significa algo, dessa forma, segue as instruções abaixo, lembrando que as linhas são separadas por (;;;;;;;;):\n" +
            "1. Primeira linha sempre será a PONTUAÇÂO\n" +
            "2. Segunda linha sempre será os ACERTOS\n" +
            "3. Terceira linha sempre será os ERROS\n" +
            "4. Quarta linha sempre será os NÂO MARCADOS\n" +
            "5. Quinta linha sempre será os ACERTOS DE CONDUTA\n" +
            "6. Sexta linha sempre será os ERROS DE CONDUTA\n" +
            "7. Sétima linha sempre será os AVISOS\n\n";

        titleName = "Relatorio de desempenho - " + Login.nome;

        if (pack.currentCase == 13)
        {
            SendEmail();
        }
    }

    // Update is called once per frame
    void SendEmail()
    {
        // Linhas referentes a "conexao" com o smtp de envio
        SmtpClient client = new SmtpClient("smtp.mailgun.org", 587);

        //credenciamento para permitir o envio
        client.Credentials = new System.Net.NetworkCredential(
            "",
            "");
        client.EnableSsl = true;

        // Definir quem envia o email e o nome do email que sera enviado
        MailAddress from = new MailAddress(
            "sepserelatorio2@gmail.com",
            titleName,
            System.Text.Encoding.UTF8);

        // Definir quem vai receber o email
        MailAddress to = new MailAddress("sepserelatorio2@gmail.com");
        MailMessage message = new MailMessage(from, to);
        message.Body = $"\nNome: {Login.nome}" +
            $"\nCPF: {Login.cpf}\n\n" +
            $"Legenda para leitura dos casos:\n {legendaEmail}" +
            $"\r\nCaso 1 \n{resultado0R}\n\n" +
            $"\r\nCaso 2: \n{resultado1R}\n\n" +
            $"\r\nCaso 3 \n{resultado2R}\n\n" +
            $"\r\nCaso 4 \n{resultado3R}\n\n" +
            $"\r\nCaso 5 \n{resultado4R}\n\n" +
            $"\r\nCaso 6 \n{resultado5R}\n\n" +
            $"\r\nCaso 7 \n{resultado6R}\n\n" +
            $"\r\nCaso 8 \n{resultado7R}\n\n" +
            $"\r\nCaso 9 \n{resultado8R}\n\n" +
            $"\r\nCaso 10 \n{resultado9R}\n\n" +
            $"\r\nCaso 11 \n{resultado10R}\n\n" +
            $"\r\nCaso 12 \n{resultado11R}\n\n" +
            $"\r\nCaso 13 \n{resultado12R}\n\n";

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
}
