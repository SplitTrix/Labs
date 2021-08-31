using System;

class Lab3B {
    public static void Main (string[] args) {
        float fQualityPoints = 0f;
        float fTotalHours = 0f;

        for (int i = 0; i < 4; i++) {
            float fCourseHour = 0f;
            float fCourseGrade = 0f;
            Console.Write($"Course {i + 1} hours: ");
            fCourseHour = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Grade for course {i + 1}: ");
            fCourseGrade = Convert.ToSingle(Console.ReadLine());

            fQualityPoints += (fCourseHour * fCourseGrade);
            fTotalHours += fCourseHour;
        }
        
        Console.WriteLine("Total quality points is: " + fQualityPoints);
        Console.WriteLine("Your GPA for this semester is " + (fQualityPoints / fTotalHours));
    }
}