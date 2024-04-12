namespace OnlineVote.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public string IP {  get; set; }
        public DateTime CreatedTime { get; set; }
       
        public List<Option> Options { get; set; }   
    }
}
