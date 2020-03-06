using System;
					
public class StringFormat
{
	public delegate void Print(int value);
	
	public static void Main()
	{
	
		 string qualificationString = null;
		qualificationString = String.Format("{0}{1}('Name' = \"Shadab\")",
          qualificationString,
          qualificationString != null ? " OR " : "shadab");
		   qualificationString = String.Format(
        "({0}) AND ('Name' = \"Test\") AND (('Age' = $NULL$) OR ('Date' <= $TIMESTAMP$))",
        qualificationString);
		 Console.WriteLine(qualificationString);
	}

}
