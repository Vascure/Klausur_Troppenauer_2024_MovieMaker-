using System;

public class Movie
{
  

    public string _Title {get;}

	public string _Director { get; }

	public bool IsRented { get; set; }

    public Movie(string Title, string Director, bool IsRented)
    {
        _Title = Title;
        _Director = Director;
    }

    public string Get_Title()
    {
        return _Title;
    }

    public string getDirector() {
		return _Director;
	}

    public bool rent (string Title, string Director)

	{
        
		this.IsRented = true;
		if (!IsRented)
		{
			
			throw new Exception("This movie is already rented, please choose another one.");
	return true;	
		}
		else Console.WriteLine("Cool, you are now in the temporary possession of this movie!");

        return false;
    }


	
	
}
