﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using SimpleJudje.Models;

namespace SimpleJudje
{
    public class StudentRepository
    {
        private bool isDataInitialized;
        private RepositoryFilter filter;
        private RepositorySorter sorter;
        private Dictionary<string, Course> courses;
        private Dictionary<string, Student> students;

        public StudentRepository(RepositorySorter sorter, RepositoryFilter filter)
        {
            this.filter = filter;
            this.sorter = sorter;
        }

        public void LoadData(string fileName)
        {
            if (this.isDataInitialized)
            {
                
                OutputWriter.DisplayException(ExceptiionMessages.DataAlreadyInitialisedException);
                return;
            }

            this.students = new Dictionary<string, Student>();
            this.courses = new Dictionary<string, Course>();
            this.ReadData(fileName);
        }

        public void UnloadData()
        {
            if (!this.isDataInitialized)
            {
                OutputWriter.DisplayException(ExceptiionMessages.DataNotInitialisedException);
            }

            this.students = null;
            this.courses = null;
            this.isDataInitialized = false;
        }

        public void FilterAndTake(string courseName, string givenFilter, int? studentsToTake = null)
        {
            if (CourseExists(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = this.courses[courseName].StudentsByName.Count;
                }

                Dictionary<string, double> marks = this.courses[courseName].StudentsByName
                    .ToDictionary(p => p.Key, p => p.Value.MarksByCourseName[courseName]);

                filter.FilterAndTake(marks, givenFilter, studentsToTake.Value);
            }
        }

        public void OrderAndTake(string courseName, string comparison, int? studentsToTake = null)
        {
            if (CourseExists(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = this.courses[courseName].StudentsByName.Count;
                }

                Dictionary<string, double> marks = this.courses[courseName].StudentsByName
                    .ToDictionary(p => p.Key, p => p.Value.MarksByCourseName[courseName]);

                sorter.OrderAndTake(marks, comparison, studentsToTake.Value);
            }
        }

        private void ReadData(string fileName)
        {
            string path = SessionData.currentPath + "\\" + fileName;

            if (File.Exists(path))
            {
                OutputWriter.WriteMessageOnNewLine("Reading data...");

                // File exists
                string pattern = @"([A-Z][a-zA-Z#\++]*_[A-Z][a-z]{2}_\d{4})\s+([A-Za-z]+\d{2}_\d{2,4})\s([\s0-9]+)";
                Regex regex = new Regex(pattern);
                string[] allInputLines = File.ReadAllLines(path);

                for (int line = 0; line < allInputLines.Length; line++)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(allInputLines[line]) && regex.IsMatch(allInputLines[line]))
                        {
                            Match currMatch = regex.Match(allInputLines[line]);
                            string courseName = currMatch.Groups[1].Value;
                            string userName = currMatch.Groups[2].Value;
                            string scoresStr = currMatch.Groups[3].Value;

                            int[] scores = scoresStr.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse).ToArray();

                            if (scores.Any(x => x > 100 || x < 0))
                            {
                                OutputWriter.DisplayException(ExceptiionMessages.InvalidScore);
                            }

                            if (scores.Length > Course.NumberOfTasksOnExam)
                            {
                                OutputWriter.DisplayException(ExceptiionMessages.InvalidNumberOfScores);
                                continue;
                            }

                            if (!this.students.ContainsKey(userName))
                            {
                                this.students.Add(userName, new Student(userName));
                            }

                            if (!this.courses.ContainsKey(courseName))
                            {
                                this.courses.Add(courseName, new Course(courseName));
                            }
                            Course course = this.courses[courseName];
                            Student student = this.students[userName];

                            student.EnrollInCourse(course);
                            student.SetMarksInCourse(courseName, scores);

                            course.EnrollStudent(student);
                        }
                    }
                    catch (FormatException e)
                    {
                        OutputWriter.DisplayException(e.Message + $" at line: {line + 1}!");
                    }
                }

                OutputWriter.WriteMessageOnNewLine("Data read!");
            }
            else
            {
                OutputWriter.WriteMessage(ExceptiionMessages.InvalidPath);
            }
        }

        public void GetAllStudentsFromCourse(string courseName)
        {
            if (CourseExists(courseName))
            {
                foreach (var studentMarksEntry in this.courses[courseName].StudentsByName)
                {
                    this.GetStudentScoresFromCourse(courseName, studentMarksEntry.Key);
                }
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine($"Course {courseName} does not exist!");
            }
        }
        
        private bool CourseExists(string courseName)
        {
            if (this.courses.ContainsKey(courseName))
            {
                return true;
            }

            return false;
        }

        public void GetStudentScoresFromCourse(string courseName, string userName)
        {
            if (UserNameExists(userName, courseName))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, double>(userName, this.courses[courseName].StudentsByName[userName].MarksByCourseName[courseName]));
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine($"Course '{courseName}' or user '{userName}' does not exist in database!");
            }
        }

        private bool UserNameExists(string userName, string courseName)
        {
            if (this.CourseExists(courseName))
            {
                if (this.courses[courseName].StudentsByName.ContainsKey(userName))
                {
                    // User exists
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}