using System;

class NewEmailEventArgs: EventArgs
{
	public NewEmailEventArgs(string subject, string message)
	{
		this.subject = subject;
		this.message = message;
	}
	public string Subject
	{
		get
		{
			return subject;
		}
	}
	public string Message
	{
		get
		{
			return message;
		}
	}
	string subject;
	string message;
}

class EmailNotify
{
	public delegate void NewMailEventHandler(object sender, NewEmailEventArgs e);
	public event NewMailEventHandler OnNewMailHandler;
	
	protected void OnNewMail(NewEmailEventArgs e)
	{
		if (OnNewMailHandler != null)
		{
			OnNewMailHandler(this, e);
		}
	}
	
	public void NotifyMail(string subject, string message)
	{
		NewEmailEventArgs e = new NewEmailEventArgs(subject, message);
		OnNewMail(e);
	}
}

class MailWatch
{
	public MailWatch(EmailNotify emailNotify)
	{
		this.emailNotify = emailNotify;
		emailNotify.OnNewMailHandler += new EmailNotify.NewMailEventHandler(IHaveMail);
	}
	
	void IHaveMail(object sender, NewEmailEventArgs e)
	{
		Console.WriteLine("New Mail: {0}\n{1}", e.Subject, e.Message);
	}
	EmailNotify emailNotify;
}

class Test
{
	public static void Main()
	{
		EmailNotify emailNotify = new EmailNotify();
		MailWatch mailWatch = new MailWatch(emailNotify);
		emailNotify.NotifyMail("Hello!", "Welcome to Events!!");
	}
}