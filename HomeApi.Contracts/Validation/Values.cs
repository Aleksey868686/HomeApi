namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-хранилище допустымых значений для валидаторов
    /// </summary>
    public static class Values
    {
        public static string [] ValidRooms = new []
        {
            "Кухня",
            "Ванная",
            "Гостиная",
            "Туалет"
        };

        public static int[] ValidVoltage = new []
        {
            12,
            24,
            48,
            120,
            220,
            380
        };
    }
}