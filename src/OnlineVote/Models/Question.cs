﻿using System.Text.Json.Serialization;

namespace OnlineVote.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string? Title { get; set; }   
        public int MaxChoices {  get; set; }
        public int MinChoices {  get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public State State {  get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? PublishedTime { get; set; }
        public DateTime? ExpiredTime { get; set; }
        public List<Option> Options { get; set; }
    }
}
