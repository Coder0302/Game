using Heroes.Heros;
namespace Heroes.EventArgs
{
    public class AttakedEventArgs : System.EventArgs
    {
        public int AttakedHp { get; set; }
        public Hero Hero { get; set; }
    }
}