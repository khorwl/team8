namespace thegame.Controllers
{
    public interface IGame
    {
        int GetScore();

        void Flip(int x, int y);
    }
}