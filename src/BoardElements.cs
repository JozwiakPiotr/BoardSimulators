using MonopolySimulator;

namespace MonopolySimulator
{
	public class Player
	{
		public readonly int index;
		public decimal money;
		public int position;
		public IStrategy strategy;
		public bool inGame;

		public Player(int index, IStrategy strategy)
		{
			this.index = index;
			this.strategy = strategy;
			position = 0;
			money = 3000;
			inGame = true;
		}
	}

	public partial class Board
	{
		public struct Field
		{
			public FieldTypes fieldType;
			public Cities? city;
			public Countries? country;
			public decimal price;
			public int? OwnerIndex = null;

			public Field(Cities? city, Countries? country, decimal price) : this()
			{
				fieldType = FieldTypes.City;
				this.city = city;
				this.country = country;
				this.price = price;
			}

			public Field(FieldTypes type, decimal price) : this()
			{
				fieldType = type;
				this.price = price;
				city = null;
				country = null;
			}

			public Field(FieldTypes type) : this()
			{
				fieldType = type;
				price = 0;
				city = null;
				country = null;
			}
		}

		public struct Szansa
		{
			string text;
			Action<T>[] availableActions;

		}

		public enum FieldTypes
		{
			City, SzansaCzerw, SzansaNieb, Parking, KolejePld, KolejeZach, KolejePln, KolejeWsch,
			Wiezienie, Elektrownia, Wodociagi, DoWiezienia, DarmowyParking, Podatek, Start
		}

		public enum Cities
		{
			Saloniki, Ateny,
			Mediolan, Neapol, Rzym,
			Barcelona, Sewilla, Madryt,
			Liverpool, Glasgow, Londyn,
			Rotterdam, Bruksela, Amsterdam,
			Malmo, Goteborg, Sztokholm,
			Frankfurt, Kolonia, Bonn,
			Innsbruck, Wieden
		}

		public enum Countries
		{
			Grecja, Wlochy, Hiszpania, Anglia, Benelux, Szwecja, RFN, Austria
		}
	}
}