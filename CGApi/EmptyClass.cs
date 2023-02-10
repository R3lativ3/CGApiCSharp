using System;
namespace CGApi
{
	public class EmptyClass
	{
	}

	public class MailSender
	{
		public void EnviarMensaje(string usuario)
		{
			Console.WriteLine("enviado por Mail: "+usuario);
		}
	}

	public class SmsSender
	{
        public void EnviarMensaje(string usuario)
        {
            Console.WriteLine("enviado por SMS "+usuario);
        }
    }


	public class UsuarioService
	{
		MailSender mailSender;
		SmsSender smsSender;

		string[] usuarios = { "jose", "jose jose" };

		public UsuarioService()
		{
			mailSender = new MailSender();
			smsSender = new SmsSender();
		}

		public void EnviarNotificacion()
		{
			foreach(var usuario in usuarios)
			{
				smsSender.EnviarMensaje(usuario);
			}
		}
	}



}






public interface IMessageSender
{
    public void EnviarMensaje();
}