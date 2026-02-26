using System;

class Student
{
    public string Name { get; }

    private int _KoreanScore;
    private int _EnglishScore;
    private int _MathScore;

    public int KoreanScore
    {
        get { return _KoreanScore; }
        set
        {
            _KoreanScore = value;
            if (_KoreanScore > 100) _KoreanScore = 100;
            else if (_KoreanScore < 0) _KoreanScore = 0;
        }
    }

    public int EnglishScore
    {
        get { return _EnglishScore; }
        set
        {
            _EnglishScore = value;
            if (_EnglishScore > 100) _EnglishScore = 100;
            else if (_EnglishScore < 0) _EnglishScore = 0;
        }
    }

    public int MathScore
    {
        get { return _MathScore; }
        set
        {
            _MathScore = value;
            if (_MathScore > 100) _MathScore = 100;
            else if (_MathScore < 0) _MathScore = 0;
        }
    }

    public int TotalScore => _KoreanScore + _EnglishScore + _MathScore;

    public double Average => TotalScore / 3.0;

    public char Grade
    {
        get
        {
            if (Average >= 90) return 'A';
            if (Average >= 80) return 'B';
            if (Average >= 70) return 'C';
            if (Average >= 60) return 'D';
            return 'F';
        }
    }

    public Student(string name)
    {
        Name = name;
    }
}