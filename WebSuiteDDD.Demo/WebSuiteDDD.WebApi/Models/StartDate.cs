﻿namespace WebSuiteDDD.WebApi.Models
{
    public class StartDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string Timezone { get; set; }
    }
}