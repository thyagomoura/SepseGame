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
    public int numeroAcertos, numeroErros;
    string emailText;

    void Start()
    {
        caso = Casos[pack.currentCase];

        titleName = "Relatorio de desempenho - " + Login.nome;

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
        emailText = $"Aluno: {Login.nome}\r\nCPF: {Login.cpf} " +
            $"\r\n\r\nCaso {pack.currentCase}" +
            $"\r\n\r\nAcertos: " +
            $"\r\n1. {caso.Respiratorio}" +
            $"\r\n2. {caso.PressaoArterial}" +
            $"\r\n3. {caso.Renal}" +
            $"\r\n\r\nErros " +
            $"\r\n1. {caso.Neurologico}" +
            $"\r\n2. {caso.FrequenciaCardiaca}" +
            $"\r\n\r\nNão marcados " +
            $"\r\n1. {caso.FrequenciaRespiratoria}" +
            $"\r\n2. {caso.Saturacao}" +
            $"\r\n\r\nCondutas corretas " +
            $"\r\n1. Levante o leito para 45º" +
            $"\r\n2. Aplicar soro";

        return emailText;
    }
}
