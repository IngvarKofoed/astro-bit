namespace AstroBit.Database
{
    public static class EfEphemerisEntryExtensions
    {
        public static EphemerisEntry ToEntry(this EfEphemerisEntry entry) =>
            new EphemerisEntry(
                entry.Date,
                entry.SiderealTime,
                new Planet(PlanetType.Sun, entry.Sun, PlanetDirection.Direct),
                new Planet(PlanetType.Moon, entry.Moon, PlanetDirection.Direct),
                new Planet(PlanetType.Mercury, entry.Mercury, entry.MercuryRetrograde ? PlanetDirection.Retrograde : PlanetDirection.Direct),
                new Planet(PlanetType.Venus, entry.Venus, entry.VenusRetrograde ? PlanetDirection.Retrograde : PlanetDirection.Direct),
                new Planet(PlanetType.Mars, entry.Mars, entry.MarsRetrograde ? PlanetDirection.Retrograde : PlanetDirection.Direct),
                new Planet(PlanetType.Jupiter, entry.Jupiter, entry.JupiterRetrograde ? PlanetDirection.Retrograde : PlanetDirection.Direct),
                new Planet(PlanetType.Saturn, entry.Saturn, entry.SaturnRetrograde ? PlanetDirection.Retrograde : PlanetDirection.Direct),
                new Planet(PlanetType.Uranus, entry.Uranus, entry.UranusRetrograde ? PlanetDirection.Retrograde : PlanetDirection.Direct),
                new Planet(PlanetType.Neptune, entry.Neptune, entry.NeptuneRetrograde ? PlanetDirection.Retrograde : PlanetDirection.Direct),
                new Planet(PlanetType.Pluto, entry.Pluto, entry.PlutoRetrograde ? PlanetDirection.Retrograde : PlanetDirection.Direct),
                new Planet(PlanetType.TrueNode, entry.TrueNode, entry.TrueNodeRetrograde ? PlanetDirection.Retrograde : PlanetDirection.Direct),
                new Planet(PlanetType.MeanNode, entry.MeanNode, entry.MeanNodeRetrograde ? PlanetDirection.Retrograde : PlanetDirection.Direct),
                new Planet(PlanetType.BlackMoonLilith, entry.BlackMoonLilith, entry.BlackMoonLilithRetrograde ? PlanetDirection.Retrograde : PlanetDirection.Direct),
                new Planet(PlanetType.Chiron, entry.Chiron, entry.ChironRetrograde ? PlanetDirection.Retrograde : PlanetDirection.Direct));
    }
}
