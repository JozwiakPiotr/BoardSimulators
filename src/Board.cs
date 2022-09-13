using MonopolySimulator;

namespace MonopolySimulator
{
	public partial class Board
	{
		public 

		public Player[] players;

		public Board()
		{

		}

		public Board(Player[] players)
		{
			this.players = players;
		}

		private void Action(string decision, Player player,ref Field field)
		{
			switch(decision)
			{
				case "BUY": Buy(ref field, player); break;
				case "PAY": Pay(field, player); break;
				case "PASS": return; break;
			}
		}

		public void Roll(Player player)
		{
			player.position += Random.Shared.Next(1,7);
		}

		public void Move(Player player)
		{
			var field = fields[player.position];
			var decision = player.strategy.decide(field, player);
		}

		private void Buy(ref Field field, Player player)
		{
			player.money -= field.price;
			field.OwnerIndex = player.index;			
		}

		private void Pay(Field field, Player player)
		{
			
		}
	}
}