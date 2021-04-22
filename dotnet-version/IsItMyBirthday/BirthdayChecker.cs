using System;

namespace IsItMyBirthday
{
    public static class BirthdayChecker
    {
        public static string IsItMyBirthday(DateTime myBirthday)
            => IsBirthday(myBirthday) ? "Happy Birthday!" 
            : $"Oh no, it isn't your birthday yet. {DaysUntilBirthday(myBirthday)} until there!";

        public static bool IsBirthday(DateTime birthday) => DateTime.Now.Date.Equals(birthday);
        public static int DaysUntilBirthday(DateTime birthday) => (int)birthday.Subtract(DateTime.Now).TotalDays;
    }
}