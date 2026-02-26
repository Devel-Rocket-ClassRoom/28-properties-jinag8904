using System;

Student[] students =
{
    new Student("김철수") { KoreanScore = 85, EnglishScore = 90, MathScore = 95 },
    new Student("이영희") { KoreanScore = 75, EnglishScore = 80, MathScore = 70 },
    new Student("박민수") { KoreanScore = 110, EnglishScore = 120, MathScore = 0 }
};

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"=== 성적표: {students[i].Name} ===");
    Console.WriteLine($"국어: {students[i].KoreanScore}, 영어: {students[i].EnglishScore}, 수학: {students[i].MathScore}");
    Console.WriteLine($"총점: {students[i].TotalScore}");
    Console.WriteLine($"평균: {students[i].Average:F2}");
    Console.WriteLine($"학점: {students[i].Grade}");
    Console.WriteLine();
}