﻿using System;

namespace PostDeleteActionTester
{
    public class InsertUpdateLoadtestViewModel
    {
        public Guid Id { get; set; }
        public string AgentCity { get; set; }
        public string AgentCountry { get; set; }
        public string CustomerName { get; set; }
        public string EngineerName { get; set; }
        public string LoadtestTypeShortDescription { get; set; }
        public string ProjectName { get; set; }
        public string ScenarioUriOne { get; set; }
        public string ScenarioUriTwo { get; set; }
        public string ScenarioUriThree { get; set; }
        public StartDate StartDate { get; set; }
        public int UserCount { get; set; }
        public int DurationSec { get; set; }
    }
}
