namespace OnlineVote.DTO
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }   
        public int MaxChoices {  get; set; }
        public int MinChoices {  get; set; }
        public string? State {  get; set; }

        public DateTime CreatedTime { get; set; }
        public DateTime PublishedTime { get; set; }
        public DateTime ExpiredTime { get; set; }
    }
}
