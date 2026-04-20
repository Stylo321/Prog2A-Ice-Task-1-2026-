public class Course
{
    private int _grade;

    public int Grade
    {
        get { return _grade; }
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("Grade must be between 0 and 100.");

            _grade = value;
        }
    }

    public bool IsPass
    {
        get { return _grade >= 50; }
    }
}