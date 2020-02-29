namespace thegame.Models
{
    public class Card
    {
        public string ImageLink { get; set; }
        
        public int x { get; set; }
        
        public int y { get; set; }
        
        public bool isOpened { get; set; }
        
        public bool isGuessed { get; set; }
        
        public int cardNumber { get; set; }
    }
}