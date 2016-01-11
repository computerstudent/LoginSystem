public class ForgottenPassword ()
{
	User user = new User("Benjamin Franklin");
	
	public ForgottenPassword ()
	{
		
	}
	
	public void RemindUser ()
	{
		try
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.ContentType = "application/json";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            var encoding = Encoding.ASCII;
            using (var reader = new StreamReader(response.GetResponseStream(), encoding))
            {
                // decode response and convet into json object
                JObject versions = JObject.Parse(reader.ReadToEnd());
                results = versions["values"].Children().ToList();
            }
        } catch (WebException e)
        {
            Debug.Write(e);
        }
	}
	
	public byte GenerateNewPassword ()
	{
		byte[] HashValue;

      string MessageString = "This is the original message!";

      //Create a new instance of the UnicodeEncoding class to 
      //convert the string into an array of Unicode bytes.
      UnicodeEncoding UE = new UnicodeEncoding();

      //Convert the string into an array of bytes.
     byte[] MessageBytes = UE.GetBytes(MessageString);

      //Create a new instance of the SHA1Managed class to create 
      //the hash value.
      SHA1Managed SHhash = new SHA1Managed();

      //Create the hash value from the array of bytes.
      HashValue = SHhash.ComputeHash(MessageBytes);	
      
      return HashValue;	
	}
}