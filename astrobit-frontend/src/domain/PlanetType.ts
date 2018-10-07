
export enum PlanetType {
    Sun = 1,
    Earth = 2,
    Moon = 3,
    Mercury = 4,
    Venus = 5,
    Mars = 6,
    Jupiter = 7,
    Saturn = 8,
    Uranus = 9,
    Neptune = 10,
    Pluto = 11,
    TrueNode = 12,
    MeanNode = 13,
    SouthNode = 14,
    BlackMoonLilith = 15,
    Chiron = 16
}


export function getPlanetSymbol(planetType: PlanetType): string {
    switch (planetType)
    {
        case PlanetType.Sun:
            return '☉';

        case PlanetType.Earth:
            return '⊕';

        case PlanetType.Moon:
            return '☽';

        case PlanetType.Mercury:
            return '☿';

        case PlanetType.Venus:
            return '♀︎';

        case PlanetType.Mars:
            return '♂︎';

        case PlanetType.Jupiter:
            return '♃';

        case PlanetType.Saturn:
            return '♄';

        case PlanetType.Uranus:
            return '♅';

        case PlanetType.Neptune:
            return '♆';

        case PlanetType.Pluto:
            return '♇';

        case PlanetType.TrueNode:
            return '☊';

        case PlanetType.MeanNode:
            return '☊';

        case PlanetType.SouthNode:
            return '☋';

        case PlanetType.BlackMoonLilith:
            return '⚸';

        case PlanetType.Chiron:
            return '⚷';

        default:
            throw new Error();
    }
}