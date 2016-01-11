public class User
{
	public string name;
	public string password;
	
	public User (string name)
	{
		this.name = name;
	}
	
	public string getName ()
	{
		return this.name;
	}
	
	public string getPassword ()
	{
		return this.password;
	}	
}