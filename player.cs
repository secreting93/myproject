class Player : Unit
{
	private int _points
	private int _maxPoints;
	
	public Player(int maxPoints)
	{
		_maxPoints = maxPoints;
		_points = 0;
	}

	public void GetPoints(int points)
	{ 
		_points = points; 
	}
}