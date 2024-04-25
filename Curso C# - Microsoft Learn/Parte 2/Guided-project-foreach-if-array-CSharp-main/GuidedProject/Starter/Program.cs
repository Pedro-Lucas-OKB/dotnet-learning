﻿using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] studentsScores = new int[10];

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (var name in studentNames) {
    string currentStudent = name;

    if(currentStudent == "Sophia"){
        studentsScores = sophiaScores;
    } else if(currentStudent == "Andrew"){
        studentsScores = andrewScores;
    } else if(currentStudent == "Emma"){
        studentsScores = emmaScores;
    } else if(currentStudent == "Logan"){
        studentsScores = loganScores;
    }else if (currentStudent == "Becky")
        studentsScores = beckyScores;
    else if (currentStudent == "Chris")
        studentsScores = chrisScores;
    else if (currentStudent == "Eric")
        studentsScores = ericScores;
    else if (currentStudent == "Gregor")
        studentsScores = gregorScores;
    else
    continue;

    int sumAssignmentsScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;

    foreach (var score in studentsScores) {
        gradedAssignments++;
        
        if (gradedAssignments > examAssignments) {
            sumAssignmentsScores += (score / 10);
        } else sumAssignmentsScores += score;

    }

    currentStudentGrade = (decimal)sumAssignmentsScores / examAssignments;

    if (currentStudentGrade >= 97) {
        currentStudentLetterGrade = "A+";

    } else if (currentStudentGrade >= 93) {
        currentStudentLetterGrade = "A";

    } else if (currentStudentGrade >= 90) {
        currentStudentLetterGrade = "A-";

    } else if (currentStudentGrade >= 87) {
        currentStudentLetterGrade = "B+";

    } else if (currentStudentGrade >= 83) {
        currentStudentLetterGrade = "B";

    } else if (currentStudentGrade >= 80) {
        currentStudentLetterGrade = "B-";

    } else if (currentStudentGrade >= 77) {
        currentStudentLetterGrade = "C+";

    } else if (currentStudentGrade >= 73) {
        currentStudentLetterGrade = "C";

    } else if (currentStudentGrade >= 70) {
        currentStudentLetterGrade = "C-";
        
    } else if (currentStudentGrade >= 67) {
        currentStudentLetterGrade = "D+";

    } else if (currentStudentGrade >= 67) {
        currentStudentLetterGrade = "D";

    } else if (currentStudentGrade >= 60) {
        currentStudentLetterGrade = "D-";

    } else {
        currentStudentLetterGrade = "F";
    } 

    Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
