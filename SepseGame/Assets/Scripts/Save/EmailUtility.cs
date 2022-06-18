using UnityEngine;
using System.ComponentModel;
using System.Net.Mail;


public class EmailUtility : MonoBehaviour
{
    public Caso Caso;
    string titleName;
    // Start is called before the first frame update
    void Start()
    {
        titleName = "Relatorio de desempenho - " + Login.nome;
        // Linhas referentes a "conexao" com o smtp de envio
        SmtpClient client = new SmtpClient("smtp.mailgun.org", 587);
        //credenciamento para permitir o envio
        client.Credentials = new System.Net.NetworkCredential(
            "Login",
            "Senha");
        client.EnableSsl = true;

        // Definir quem envia o email e o nome do email que sera enviado
        MailAddress from = new MailAddress(
            "bmdrcompany@gmail.com",
            titleName,
            System.Text.Encoding.UTF8);

        // Definir quem vai receber o email
        MailAddress to = new MailAddress("bmdrcompany@gmail.com");

        // Conteudo da mensagem.
        MailMessage message = new MailMessage(from, to);
        message.Body = $"Aluno: {Login.nome}\r\nCPF: {Login.cpf} \r\nColocar as variaveis referentes ao relatório de desempenho";
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
