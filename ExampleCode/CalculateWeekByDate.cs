public int CalculateWeekByDate(){
    DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
    DateTime date1 = DateTime.Now;
    Calendar cal = dfi.Calendar;
    int wk = cal.GetWeekOfYear(date1, CalendarWeekRule.FirstFullWeek,
                                DayOfWeek.Monday);
    return wk;                                
}