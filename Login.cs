public class Login ()
{
	public bool userLoggedIn = false;
	
	public Login()
	{
		userLoggedIn = false;
	}
	
	public void LoginUser (int id, string password)
	{
		if (id == this.id)
		{
			if (decryptPassword(password))
			{
				userLoggedIn = true;
			}
		}
	}
	
	public void LogoutUser ()
	{
		userLoggedIn = false;
	}
}