using System;

class Unit
{
	public Unit(string name, float health)
	{
		Name = name;
		Health = health;
	}		
	
	public float Health {get; private set;}
	public string Name {get; private set;}
}