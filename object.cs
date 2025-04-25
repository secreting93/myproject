class Object
{
	private string _title;
	private string _description;
	
	public Object(string Title, string Description)
	{
		_title = Title;
		_description = Description;
	}
	
	public string GetInfo()
	{
		return "Название"_title + " Описание" _description;
	}
	
}