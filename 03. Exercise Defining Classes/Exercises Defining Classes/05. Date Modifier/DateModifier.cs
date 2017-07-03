namespace _05.Date_Modifier
{
    using System;
    using System.Globalization;

    internal class DateModifier
    {
        public DateModifier(string firstDate, string secondDate)
        {
            this.FirstDate = firstDate;
            this.SecondDate = secondDate;
        }

        public string FirstDate { get; set; }

        public string SecondDate { get; set; }

        public string CalculateDifferenceInDays()
        {
            DateTime firsDateTime = DateTime.ParseExact(this.FirstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime secondDateTime = DateTime.ParseExact(this.SecondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            TimeSpan span = firsDateTime - secondDateTime;

            return Math.Abs(span.TotalDays).ToString();
        }
    }
}