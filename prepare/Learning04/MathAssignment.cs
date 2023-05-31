using System;

public class MathAssigment : Assignment
{
    private string _section = "";
    private string _problems = "";

    public MathAssigment(string studentName, string topic, string section, string problems): base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    public string GetHomeWorkList(){
        return $"Section {_section} Problems {_problems}";
    }
}