namespace Courses

class Course
{
	public string title;
	public Lecturer lecturer;
	public Date dates;
	public Student attendees;
	
	public Course(string title)
	{
	}

	public void printCourseTitle()
	{
		Console.WriteLine(title);
	}
}
