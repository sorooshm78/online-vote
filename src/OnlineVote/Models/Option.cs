namespace OnlineVote.Models
{
    public class Option
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        
        public int QuestionId {  get; set; }
        public Question Question { get; set; }

        public List<Vote> Votes { get; set; }
    }
}
