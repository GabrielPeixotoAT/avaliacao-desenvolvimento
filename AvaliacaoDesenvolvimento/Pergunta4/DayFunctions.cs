namespace AvaliacaoDesenvolvimento.Pergunta4
{
    public class DayFunctions
    {
        public static bool CheckHoliday(DateTime dateTime)
        {
            // só pra resumir
            return false;
        }

        public static bool CheckWeekend(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                return true;

            return false;
        }

        public static DateTime NextBusinessDay(DateTime dueDate)
        {
            while (CheckWeekend(dueDate) || CheckHoliday(dueDate))
            {
                dueDate = dueDate.AddDays(1);
            }

            return dueDate;
        }
    }
}
