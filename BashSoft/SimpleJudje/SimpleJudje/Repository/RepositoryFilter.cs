using System;
using System.Collections.Generic;

namespace SimpleJudje
{
    public class RepositoryFilter
    {
        public void FilterAndTake(Dictionary<string, double> studentWithMarks, string wantedFilter, int studentsToTake)
        {
            switch (wantedFilter)
            {
                case "excellent":
                    FilterAndTake(studentWithMarks, m => m >= 5, studentsToTake);
                    break;

                case "average":
                    FilterAndTake(studentWithMarks, m => m >= 3.50 && m < 5, studentsToTake);
                    break;

                case "poor":
                    FilterAndTake(studentWithMarks, m => m < 3.50, studentsToTake);
                    break;

                default:
                    OutputWriter.DisplayException(ExceptionMessages.InvalidStudentsFIlter);
                    break;
            }
        }

        private void FilterAndTake(Dictionary<string, double> studentWithMarks, Predicate<double> givenFilter, int studentsTake)
        {
            int counterForPrinted = 0;

            foreach (var studentMark in studentWithMarks)
            {
                if (counterForPrinted == studentsTake)
                {
                    break;
                }

                if (givenFilter(studentMark.Value))
                {
                    OutputWriter.PrintStudent(new KeyValuePair<string, double>(studentMark.Key, studentMark.Value));
                    counterForPrinted++;
                }
            }
        }
    }
}