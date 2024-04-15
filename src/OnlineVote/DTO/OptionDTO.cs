namespace OnlineVote.DTO
{
    public class OptionDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        
        public int QuestionId {  get; set; }
    }
}
