using MonopolySimulator;

namespace MonopolySimulator
{
	public partial class Board
	{
		public Field[] fields = new Field[] 
		{
			new Field(FieldTypes.Start),
			new Field(Cities.Saloniki, Countries.Grecja, 120),
			new Field(FieldTypes.SzansaNieb),
			new Field(Cities.Ateny, Countries.Grecja, 120),
			new Field(FieldTypes.Parking),
			new Field(FieldTypes.KolejePld),
			new Field(Cities.Neapol, Countries.Wlochy, 200),
			new Field(FieldTypes.SzansaCzerw),
			new Field(Cities.Mediolan, Countries.Wlochy, 200),
			new Field(Cities.Rzym, Countries.Wlochy, 240),
			new Field(FieldTypes.Wiezienie),
			new Field(Cities.Barcelona, Countries.Hiszpania, 280),
			new Field(FieldTypes.Elektrownia),
			new Field(Cities.Sewilla, Countries.Hiszpania, 280),
			new Field(Cities.Madryt, Countries.Hiszpania, 320),
			new Field(FieldTypes.KolejeZach),
			new Field(Cities.Liverpool, Countries.Anglia, 360),
			new Field(FieldTypes.SzansaNieb),
			new Field(Cities.Glasgow, Countries.Anglia, 360),
			new Field(Cities.Londyn, Countries.Anglia, 400),
			new Field(FieldTypes.DarmowyParking),
			new Field(Cities.Rotterdam, Countries.Benelux, 440),
			new Field(FieldTypes.SzansaCzerw),
			new Field(Cities.Bruksela, Countries.Benelux, 440),
			new Field(Cities.Amsterdam, Countries.Benelux, 480),
			new Field(FieldTypes.KolejePln),
			new Field(Cities.Malmo, Countries.Szwecja, 520),
			new Field(Cities.Goteborg, Countries.Szwecja, 520),
			new Field(FieldTypes.Wodociagi),
			new Field(Cities.Sztokholm, Countries.Szwecja, 560),
			new Field(FieldTypes.DoWiezienia),
			new Field(Cities.Frankfurt, Countries.RFN, 600),
			new Field(Cities.Kolonia, Countries.RFN, 600),
			new Field(FieldTypes.SzansaNieb),
			new Field(Cities.Bonn, Countries.RFN, 640),
			new Field(FieldTypes.KolejeWsch),
			new Field(FieldTypes.SzansaCzerw),
			new Field(Cities.Innsbruck, Countries.Austria, 700),
			new Field(FieldTypes.Podatek),
			new Field(Cities.Wieden, Countries.Austria, 800)
		};

		public Dictionary<Cities, int> CityToPlayerIndex = new();
	}
}