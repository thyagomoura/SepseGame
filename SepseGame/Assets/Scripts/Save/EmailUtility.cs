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

    void Start()
    {
        caso = Casos[pack.currentCase];

        titleName = "Relatorio de desempenho - " + Login.nome;
        // Linhas referentes a "conexao" com o smtp de envio
        SmtpClient client = new SmtpClient("smtp.mailgun.org", 587);
        //credenciamento para permitir o envio
        client.Credentials = new System.Net.NetworkCredential(
            "postmaster@sandbox8817461d51f14c9cbc0017e85b3afad4.mailgun.org",
            "ea1571d3f7d71cc46dfd7e988c3e70db-4f207195-e33bb4f3");
        client.EnableSsl = true;

        // Definir quem envia o email e o nome do email que sera enviado
        MailAddress from = new MailAddress(
            "stryard.dxt@gmail.com",
            titleName,
            System.Text.Encoding.UTF8);

        // Definir quem vai receber o email
        MailAddress to = new MailAddress("stryard.dxt@gmail.com");

        // Conteudo da mensagem.
        var contentID = "Image";

        var inlineLogo = new Attachment(@"D:\Projetos\Sepse Game\SepseGame\SepseGame\Assets\Sprites\Personagens\BasePersonagensFemininos.png");
        inlineLogo.ContentId = contentID;
        inlineLogo.ContentDisposition.Inline = true;
        inlineLogo.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
        
        MailMessage message = new MailMessage(from, to);
        message.Body = $"Aluno: {Login.nome}\r\nCPF: {Login.cpf} \r\nColocar as variaveis referentes ao relatório de desempenho \r\nCorretos exemplo1: {caso.FrequenciaCardiaca} ";
        message.BodyEncoding = System.Text.Encoding.UTF8;
        message.Subject = titleName;
        message.SubjectEncoding = System.Text.Encoding.UTF8;
        message.Attachments.Add(inlineLogo);

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
