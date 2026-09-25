using System;

class WritingAssignment : Assignment
{
    // private string _studentName;
    // private string _topic;
    private string _textbookSection;
    private string _problems;

    public WritingAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _studentName = studentName;
        _topic = topic;
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Student: {_studentName}, Topic: {_topic}, Textbook Section: {_textbookSection}, Problems: {_problems}";
    }
}