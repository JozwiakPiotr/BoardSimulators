using static MonopolySimulator.Board.FieldTypes;
//City, SzansaCzerw, SzansaNieb, Parking, KolejePld, KolejeZach, KolejePln, KolejeWsch,
//Wiezienie, Elektrownia, Wodociagi, DoWiezienia, DarmowyParking, Podatek, Start

namespace MonopolySimulator
{
	public interface IStrategy
	{
		string decide(Board.Field field, Player player);
	}

	public class AlwaysBuyStrategy : IStrategy
	{
		public string decide(Board.Field field, Player player)
		{
			switch(field.fieldType)
			{
				case City:
				case KolejePld:
				case KolejeZach:
				case KolejePln:
				case KolejeWsch: 
				case Elektrownia:
				case Wodociagi:
					if(field.OwnerIndex != null)
						return "PAY";
					if(player.money >= field.price)
						return "BUY";
					return "PASS";
					break;
				case SzansaCzerw:
				case SzansaNieb: 
				case DarmowyParking: 
				case Parking:
				case DoWiezienia:
				case Podatek:
				case Wiezienie:
				case Start: 
					return "DEFAULT";
					break;
				default: return ""; break;
			}
		}
	}
}