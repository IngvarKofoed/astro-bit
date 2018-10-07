import { Person } from './Person'
import { HumanDesign, DefinedGate } from './HumanDesign';
import { PlanetType } from './PlanetType'

export const persons = [
    new Person('1', 'Louise Amstrup', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 19, 1),
            new DefinedGate(PlanetType.Earth, 33, 1),
            new DefinedGate(PlanetType.Moon, 50, 4),
            new DefinedGate(PlanetType.TrueNode, 42, 2),
            new DefinedGate(PlanetType.SouthNode, 32, 2),
            new DefinedGate(PlanetType.Mercury, 30, 2),
            new DefinedGate(PlanetType.Venus, 10, 5),
            new DefinedGate(PlanetType.Mars, 63, 5),
            new DefinedGate(PlanetType.Jupiter, 59, 4),
            new DefinedGate(PlanetType.Saturn, 17, 5),
            new DefinedGate(PlanetType.Uranus, 46, 1),
            new DefinedGate(PlanetType.Neptune, 14, 2),
            new DefinedGate(PlanetType.Pluto, 47, 6),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 27, 5),
            new DefinedGate(PlanetType.Earth, 28, 5),
            new DefinedGate(PlanetType.Moon, 42, 2),
            new DefinedGate(PlanetType.TrueNode, 51, 4),
            new DefinedGate(PlanetType.SouthNode, 57, 4),
            new DefinedGate(PlanetType.Mercury, 24, 1),
            new DefinedGate(PlanetType.Venus, 42, 1),
            new DefinedGate(PlanetType.Mars, 23, 3),
            new DefinedGate(PlanetType.Jupiter, 29, 2),
            new DefinedGate(PlanetType.Saturn, 51, 4),
            new DefinedGate(PlanetType.Uranus, 6, 4),
            new DefinedGate(PlanetType.Neptune, 14, 2),
            new DefinedGate(PlanetType.Pluto, 47, 4),
        ])),

    new Person('2', 'Ferdinand Amstrup Vestergaard', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 32, 2),
            new DefinedGate(PlanetType.Earth, 42, 2),
            new DefinedGate(PlanetType.Moon, 12, 6),
            new DefinedGate(PlanetType.TrueNode, 23, 2),
            new DefinedGate(PlanetType.SouthNode, 43, 2),
            new DefinedGate(PlanetType.Mercury, 57, 2),
            new DefinedGate(PlanetType.Venus, 44, 1),
            new DefinedGate(PlanetType.Mars, 55, 3),
            new DefinedGate(PlanetType.Jupiter, 40, 5),
            new DefinedGate(PlanetType.Saturn, 39, 4),
            new DefinedGate(PlanetType.Uranus, 30, 5),
            new DefinedGate(PlanetType.Neptune, 19, 3),
            new DefinedGate(PlanetType.Pluto, 26, 1),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 54, 6),
            new DefinedGate(PlanetType.Earth, 53, 6),
            new DefinedGate(PlanetType.Moon, 59, 5),
            new DefinedGate(PlanetType.TrueNode, 2, 6),
            new DefinedGate(PlanetType.SouthNode, 1, 6),
            new DefinedGate(PlanetType.Mercury, 11, 6),
            new DefinedGate(PlanetType.Venus, 30, 2),
            new DefinedGate(PlanetType.Mars, 51, 1),
            new DefinedGate(PlanetType.Jupiter, 47, 2),
            new DefinedGate(PlanetType.Saturn, 52, 6),
            new DefinedGate(PlanetType.Uranus, 55, 1),
            new DefinedGate(PlanetType.Neptune, 19, 5),
            new DefinedGate(PlanetType.Pluto, 26, 5),
        ])),

    new Person('3', 'Benjamin Amstrup Vestergaard', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 29, 3),
            new DefinedGate(PlanetType.Earth, 30, 3),
            new DefinedGate(PlanetType.Moon, 45, 5),
            new DefinedGate(PlanetType.TrueNode, 50, 3),
            new DefinedGate(PlanetType.SouthNode, 3, 3),
            new DefinedGate(PlanetType.Mercury, 47, 1),
            new DefinedGate(PlanetType.Venus, 29, 3),
            new DefinedGate(PlanetType.Mars, 57, 4),
            new DefinedGate(PlanetType.Jupiter, 9, 1),
            new DefinedGate(PlanetType.Saturn, 36, 1),
            new DefinedGate(PlanetType.Uranus, 60, 2),
            new DefinedGate(PlanetType.Neptune, 61, 3),
            new DefinedGate(PlanetType.Pluto, 14, 4),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 14, 1),
            new DefinedGate(PlanetType.Earth, 8, 1),
            new DefinedGate(PlanetType.Moon, 47, 4),
            new DefinedGate(PlanetType.TrueNode, 32, 6),
            new DefinedGate(PlanetType.SouthNode, 42, 6),
            new DefinedGate(PlanetType.Mercury, 43, 3),
            new DefinedGate(PlanetType.Venus, 26, 1),
            new DefinedGate(PlanetType.Mars, 26, 4),
            new DefinedGate(PlanetType.Jupiter, 26, 3),
            new DefinedGate(PlanetType.Saturn, 22, 2),
            new DefinedGate(PlanetType.Uranus, 60, 1),
            new DefinedGate(PlanetType.Neptune, 61, 3),
            new DefinedGate(PlanetType.Pluto, 34, 1),
        ])),

     new Person('4', 'Bo Vestergaard', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 61, 1),
            new DefinedGate(PlanetType.Earth, 62, 1),
            new DefinedGate(PlanetType.Moon, 11, 5),
            new DefinedGate(PlanetType.TrueNode, 39, 2),
            new DefinedGate(PlanetType.SouthNode, 38, 2),
            new DefinedGate(PlanetType.Mercury, 58, 2),
            new DefinedGate(PlanetType.Venus, 30, 1),
            new DefinedGate(PlanetType.Mars, 60, 4),
            new DefinedGate(PlanetType.Jupiter, 21, 3),
            new DefinedGate(PlanetType.Saturn, 49, 3),
            new DefinedGate(PlanetType.Uranus, 40, 5),
            new DefinedGate(PlanetType.Neptune, 1, 5),
            new DefinedGate(PlanetType.Pluto, 64, 3),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 51, 5),
            new DefinedGate(PlanetType.Earth, 57, 5),
            new DefinedGate(PlanetType.Moon, 37, 2),
            new DefinedGate(PlanetType.TrueNode, 52, 2),
            new DefinedGate(PlanetType.SouthNode, 58, 2),
            new DefinedGate(PlanetType.Mercury, 24, 1),
            new DefinedGate(PlanetType.Venus, 20, 6),
            new DefinedGate(PlanetType.Mars, 17, 5),
            new DefinedGate(PlanetType.Jupiter, 3, 4),
            new DefinedGate(PlanetType.Saturn, 55, 2),
            new DefinedGate(PlanetType.Uranus, 40, 1),
            new DefinedGate(PlanetType.Neptune, 1, 5),
            new DefinedGate(PlanetType.Pluto, 64, 1),
        ])), 

    new Person('5', 'Martin Ingvar Kofoed Jensen', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 16, 4),
            new DefinedGate(PlanetType.Earth, 9, 4),
            new DefinedGate(PlanetType.Moon, 50, 6),
            new DefinedGate(PlanetType.TrueNode, 32, 3),
            new DefinedGate(PlanetType.SouthNode, 42, 3),
            new DefinedGate(PlanetType.Mercury, 2, 1),
            new DefinedGate(PlanetType.Venus, 42, 4),
            new DefinedGate(PlanetType.Mars, 42, 5),
            new DefinedGate(PlanetType.Jupiter, 35, 2),
            new DefinedGate(PlanetType.Saturn, 33, 5),
            new DefinedGate(PlanetType.Uranus, 44, 2),
            new DefinedGate(PlanetType.Neptune, 5, 4),
            new DefinedGate(PlanetType.Pluto, 48, 3),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 40, 2),
            new DefinedGate(PlanetType.Earth, 37, 2),
            new DefinedGate(PlanetType.Moon, 36, 2),
            new DefinedGate(PlanetType.TrueNode, 57, 1),
            new DefinedGate(PlanetType.SouthNode, 51, 1),
            new DefinedGate(PlanetType.Mercury, 47, 2),
            new DefinedGate(PlanetType.Venus, 56, 6),
            new DefinedGate(PlanetType.Mars, 15, 1),
            new DefinedGate(PlanetType.Jupiter, 15, 4),
            new DefinedGate(PlanetType.Saturn, 4, 4),
            new DefinedGate(PlanetType.Uranus, 44, 1),
            new DefinedGate(PlanetType.Neptune, 5, 3),
            new DefinedGate(PlanetType.Pluto, 48, 4),
        ])),

    new Person('6', 'Nicolaj Høgbro', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 4, 3),
            new DefinedGate(PlanetType.Earth, 49, 3),
            new DefinedGate(PlanetType.Moon, 40, 3),
            new DefinedGate(PlanetType.TrueNode, 22, 5),
            new DefinedGate(PlanetType.SouthNode, 47, 5),
            new DefinedGate(PlanetType.Mercury, 64, 2),
            new DefinedGate(PlanetType.Venus, 39, 4),
            new DefinedGate(PlanetType.Mars, 9, 5),
            new DefinedGate(PlanetType.Jupiter, 18, 2),
            new DefinedGate(PlanetType.Saturn, 24, 2),
            new DefinedGate(PlanetType.Uranus, 46, 4),
            new DefinedGate(PlanetType.Neptune, 14, 2),
            new DefinedGate(PlanetType.Pluto, 6, 2),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 43, 1),
            new DefinedGate(PlanetType.Earth, 23, 1),
            new DefinedGate(PlanetType.Moon, 26, 4),
            new DefinedGate(PlanetType.TrueNode, 22, 3),
            new DefinedGate(PlanetType.SouthNode, 47, 3),
            new DefinedGate(PlanetType.Mercury, 1, 5),
            new DefinedGate(PlanetType.Venus, 50, 6),
            new DefinedGate(PlanetType.Mars, 41, 4),
            new DefinedGate(PlanetType.Jupiter, 32, 3),
            new DefinedGate(PlanetType.Saturn, 27, 3),
            new DefinedGate(PlanetType.Uranus, 18, 4),
            new DefinedGate(PlanetType.Neptune, 14, 4),
            new DefinedGate(PlanetType.Pluto, 6, 5),
        ])),

    new Person('7', 'Per Frederiksen', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 27, 3),
            new DefinedGate(PlanetType.Earth, 28, 3),
            new DefinedGate(PlanetType.Moon, 54, 3),
            new DefinedGate(PlanetType.TrueNode, 38, 1),
            new DefinedGate(PlanetType.SouthNode, 39, 1),
            new DefinedGate(PlanetType.Mercury, 21, 1),
            new DefinedGate(PlanetType.Venus, 24, 1),
            new DefinedGate(PlanetType.Mars, 49, 2),
            new DefinedGate(PlanetType.Jupiter, 19, 3),
            new DefinedGate(PlanetType.Saturn, 45, 1),
            new DefinedGate(PlanetType.Uranus, 57, 6),
            new DefinedGate(PlanetType.Neptune, 9, 2),
            new DefinedGate(PlanetType.Pluto, 46, 5),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 56, 6),
            new DefinedGate(PlanetType.Earth, 60, 6),
            new DefinedGate(PlanetType.Moon, 8, 2),
            new DefinedGate(PlanetType.TrueNode, 58, 4),
            new DefinedGate(PlanetType.SouthNode, 52, 4),
            new DefinedGate(PlanetType.Mercury, 62, 4),
            new DefinedGate(PlanetType.Venus, 29, 6),
            new DefinedGate(PlanetType.Mars, 42, 1),
            new DefinedGate(PlanetType.Jupiter, 19, 1),
            new DefinedGate(PlanetType.Saturn, 15, 1),
            new DefinedGate(PlanetType.Uranus, 57, 5),
            new DefinedGate(PlanetType.Neptune, 34, 5),
            new DefinedGate(PlanetType.Pluto, 46, 5),
        ])),

    new Person('8', 'Andreas Prößdorf', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 56, 4),
            new DefinedGate(PlanetType.Earth, 60, 4),
            new DefinedGate(PlanetType.Moon, 41, 1),
            new DefinedGate(PlanetType.TrueNode, 14, 5),
            new DefinedGate(PlanetType.SouthNode, 8, 5),
            new DefinedGate(PlanetType.Mercury, 53, 6),
            new DefinedGate(PlanetType.Venus, 40, 3),
            new DefinedGate(PlanetType.Mars, 2, 3),
            new DefinedGate(PlanetType.Jupiter, 42, 4),
            new DefinedGate(PlanetType.Saturn, 62, 3),
            new DefinedGate(PlanetType.Uranus, 50, 3),
            new DefinedGate(PlanetType.Neptune, 9, 4),
            new DefinedGate(PlanetType.Pluto, 18, 4),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 50, 2),
            new DefinedGate(PlanetType.Earth, 3, 2),
            new DefinedGate(PlanetType.Moon, 2, 6),
            new DefinedGate(PlanetType.TrueNode, 43, 4),
            new DefinedGate(PlanetType.SouthNode, 23, 4),
            new DefinedGate(PlanetType.Mercury, 48, 1),
            new DefinedGate(PlanetType.Venus, 64, 2),
            new DefinedGate(PlanetType.Mars, 15, 3),
            new DefinedGate(PlanetType.Jupiter, 51, 4),
            new DefinedGate(PlanetType.Saturn, 31, 1),
            new DefinedGate(PlanetType.Uranus, 28, 1),
            new DefinedGate(PlanetType.Neptune, 9, 5),
            new DefinedGate(PlanetType.Pluto, 48, 1),
        ])),

    new Person('9', 'David Eruner', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 10, 5),
            new DefinedGate(PlanetType.Earth, 15, 5),
            new DefinedGate(PlanetType.Moon, 24, 2),
            new DefinedGate(PlanetType.TrueNode, 34, 3),
            new DefinedGate(PlanetType.SouthNode, 20, 3),
            new DefinedGate(PlanetType.Mercury, 11, 5),
            new DefinedGate(PlanetType.Venus, 11, 5),
            new DefinedGate(PlanetType.Mars, 10, 6),
            new DefinedGate(PlanetType.Jupiter, 44, 1),
            new DefinedGate(PlanetType.Saturn, 30, 2),
            new DefinedGate(PlanetType.Uranus, 61, 1),
            new DefinedGate(PlanetType.Neptune, 54, 6),
            new DefinedGate(PlanetType.Pluto, 14, 3),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 25, 3),
            new DefinedGate(PlanetType.Earth, 46, 3),
            new DefinedGate(PlanetType.Moon, 39, 1),
            new DefinedGate(PlanetType.TrueNode, 14, 1),
            new DefinedGate(PlanetType.SouthNode, 8, 1),
            new DefinedGate(PlanetType.Mercury, 55, 3),
            new DefinedGate(PlanetType.Venus, 51, 1),
            new DefinedGate(PlanetType.Mars, 37, 6),
            new DefinedGate(PlanetType.Jupiter, 1, 1),
            new DefinedGate(PlanetType.Saturn, 37, 1),
            new DefinedGate(PlanetType.Uranus, 61, 6),
            new DefinedGate(PlanetType.Neptune, 61, 3),
            new DefinedGate(PlanetType.Pluto, 14, 4),
        ])),

    new Person('10', 'Liya Soulsound', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 31, 5),
            new DefinedGate(PlanetType.Earth, 41, 5),
            new DefinedGate(PlanetType.Moon, 7, 1),
            new DefinedGate(PlanetType.TrueNode, 20, 5),
            new DefinedGate(PlanetType.SouthNode, 34, 5),
            new DefinedGate(PlanetType.Mercury, 59, 4),
            new DefinedGate(PlanetType.Venus, 7, 6),
            new DefinedGate(PlanetType.Mars, 43, 2),
            new DefinedGate(PlanetType.Jupiter, 58, 1),
            new DefinedGate(PlanetType.Saturn, 44, 3),
            new DefinedGate(PlanetType.Uranus, 9, 5),
            new DefinedGate(PlanetType.Neptune, 10, 1),
            new DefinedGate(PlanetType.Pluto, 50, 4),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 28, 3),
            new DefinedGate(PlanetType.Earth, 27, 3),
            new DefinedGate(PlanetType.Moon, 5, 2),
            new DefinedGate(PlanetType.TrueNode, 8, 4),
            new DefinedGate(PlanetType.SouthNode, 14, 4),
            new DefinedGate(PlanetType.Mercury, 1, 2),
            new DefinedGate(PlanetType.Venus, 9, 4),
            new DefinedGate(PlanetType.Mars, 54, 1),
            new DefinedGate(PlanetType.Jupiter, 58, 5),
            new DefinedGate(PlanetType.Saturn, 1, 5),
            new DefinedGate(PlanetType.Uranus, 5, 1),
            new DefinedGate(PlanetType.Neptune, 10, 2),
            new DefinedGate(PlanetType.Pluto, 28, 1),
        ])),

    new Person('11', 'Inger Merete Hansen', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 54, 4),
            new DefinedGate(PlanetType.Earth, 53, 4),
            new DefinedGate(PlanetType.Moon, 29, 3),
            new DefinedGate(PlanetType.TrueNode, 44, 1),
            new DefinedGate(PlanetType.SouthNode, 24, 1),
            new DefinedGate(PlanetType.Mercury, 11, 4),
            new DefinedGate(PlanetType.Venus, 13, 4),
            new DefinedGate(PlanetType.Mars, 5, 1),
            new DefinedGate(PlanetType.Jupiter, 50, 4),
            new DefinedGate(PlanetType.Saturn, 26, 4),
            new DefinedGate(PlanetType.Uranus, 33, 4),
            new DefinedGate(PlanetType.Neptune, 28, 3),
            new DefinedGate(PlanetType.Pluto, 59, 3),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 51, 1),
            new DefinedGate(PlanetType.Earth, 57, 1),
            new DefinedGate(PlanetType.Moon, 1, 3),
            new DefinedGate(PlanetType.TrueNode, 50, 6),
            new DefinedGate(PlanetType.SouthNode, 3, 6),
            new DefinedGate(PlanetType.Mercury, 3, 5),
            new DefinedGate(PlanetType.Venus, 30, 6),
            new DefinedGate(PlanetType.Mars, 13, 2),
            new DefinedGate(PlanetType.Jupiter, 50, 2),
            new DefinedGate(PlanetType.Saturn, 11, 4),
            new DefinedGate(PlanetType.Uranus, 31, 6),
            new DefinedGate(PlanetType.Neptune, 28, 3),
            new DefinedGate(PlanetType.Pluto, 29, 6),
        ])),

    new Person('12', 'Rikke Amstrup', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 40, 3),
            new DefinedGate(PlanetType.Earth, 37, 3),
            new DefinedGate(PlanetType.Moon, 63, 2),
            new DefinedGate(PlanetType.TrueNode, 2, 6),
            new DefinedGate(PlanetType.SouthNode, 1, 6),
            new DefinedGate(PlanetType.Mercury, 29, 4),
            new DefinedGate(PlanetType.Venus, 4, 1),
            new DefinedGate(PlanetType.Mars, 31, 2),
            new DefinedGate(PlanetType.Jupiter, 62, 5),
            new DefinedGate(PlanetType.Saturn, 36, 6),
            new DefinedGate(PlanetType.Uranus, 47, 3),
            new DefinedGate(PlanetType.Neptune, 43, 1),
            new DefinedGate(PlanetType.Pluto, 47, 1),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 34, 6),
            new DefinedGate(PlanetType.Earth, 20, 6),
            new DefinedGate(PlanetType.Moon, 16, 3),
            new DefinedGate(PlanetType.TrueNode, 2, 4),
            new DefinedGate(PlanetType.SouthNode, 1, 4),
            new DefinedGate(PlanetType.Mercury, 1, 5),
            new DefinedGate(PlanetType.Venus, 9, 5),
            new DefinedGate(PlanetType.Mars, 6, 5),
            new DefinedGate(PlanetType.Jupiter, 31, 3),
            new DefinedGate(PlanetType.Saturn, 36, 1),
            new DefinedGate(PlanetType.Uranus, 6, 2),
            new DefinedGate(PlanetType.Neptune, 43, 4),
            new DefinedGate(PlanetType.Pluto, 47, 4),
        ])),

    new Person('13', 'Agnete Andersen', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 24, 6),
            new DefinedGate(PlanetType.Earth, 44, 6),
            new DefinedGate(PlanetType.Moon, 43, 4),
            new DefinedGate(PlanetType.TrueNode, 50, 6),
            new DefinedGate(PlanetType.SouthNode, 3, 6),
            new DefinedGate(PlanetType.Mercury, 51, 6),
            new DefinedGate(PlanetType.Venus, 25, 1),
            new DefinedGate(PlanetType.Mars, 55, 6),
            new DefinedGate(PlanetType.Jupiter, 32, 5),
            new DefinedGate(PlanetType.Saturn, 11, 3),
            new DefinedGate(PlanetType.Uranus, 33, 1),
            new DefinedGate(PlanetType.Neptune, 28, 2),
            new DefinedGate(PlanetType.Pluto, 29, 6),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 33, 4),
            new DefinedGate(PlanetType.Earth, 19, 4),
            new DefinedGate(PlanetType.Moon, 25, 4),
            new DefinedGate(PlanetType.TrueNode, 32, 5),
            new DefinedGate(PlanetType.SouthNode, 42, 5),
            new DefinedGate(PlanetType.Mercury, 40, 1),
            new DefinedGate(PlanetType.Venus, 53, 1),
            new DefinedGate(PlanetType.Mars, 24, 1),
            new DefinedGate(PlanetType.Jupiter, 32, 5),
            new DefinedGate(PlanetType.Saturn, 26, 3),
            new DefinedGate(PlanetType.Uranus, 33, 5),
            new DefinedGate(PlanetType.Neptune, 28, 1),
            new DefinedGate(PlanetType.Pluto, 59, 2),
        ])),

    new Person('14', 'Lone Thorsø', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 60, 3),
            new DefinedGate(PlanetType.Earth, 56, 3),
            new DefinedGate(PlanetType.Moon, 54, 4),
            new DefinedGate(PlanetType.TrueNode, 28, 6),
            new DefinedGate(PlanetType.SouthNode, 27, 6),
            new DefinedGate(PlanetType.Mercury, 58, 2),
            new DefinedGate(PlanetType.Venus, 13, 1),
            new DefinedGate(PlanetType.Mars, 26, 2),
            new DefinedGate(PlanetType.Jupiter, 50, 5),
            new DefinedGate(PlanetType.Saturn, 26, 5),
            new DefinedGate(PlanetType.Uranus, 33, 3),
            new DefinedGate(PlanetType.Neptune, 28, 3),
            new DefinedGate(PlanetType.Pluto, 59, 2),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 3, 1),
            new DefinedGate(PlanetType.Earth, 50, 1),
            new DefinedGate(PlanetType.Moon, 25, 6),
            new DefinedGate(PlanetType.TrueNode, 50, 6),
            new DefinedGate(PlanetType.SouthNode, 3, 6),
            new DefinedGate(PlanetType.Mercury, 42, 6),
            new DefinedGate(PlanetType.Venus, 37, 5),
            new DefinedGate(PlanetType.Mars, 49, 4),
            new DefinedGate(PlanetType.Jupiter, 50, 1),
            new DefinedGate(PlanetType.Saturn, 11, 4),
            new DefinedGate(PlanetType.Uranus, 31, 6),
            new DefinedGate(PlanetType.Neptune, 28, 2),
            new DefinedGate(PlanetType.Pluto, 29, 6),
        ])),


    new Person('15', 'Yarik Larkin', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 5, 4),
            new DefinedGate(PlanetType.Earth, 35, 4),
            new DefinedGate(PlanetType.Moon, 4, 4),
            new DefinedGate(PlanetType.TrueNode, 60, 3),
            new DefinedGate(PlanetType.SouthNode, 56, 3),
            new DefinedGate(PlanetType.Mercury, 58, 3),
            new DefinedGate(PlanetType.Venus, 11, 2),
            new DefinedGate(PlanetType.Mars, 20, 3),
            new DefinedGate(PlanetType.Jupiter, 7, 1),
            new DefinedGate(PlanetType.Saturn, 61, 3),
            new DefinedGate(PlanetType.Uranus, 58, 5),
            new DefinedGate(PlanetType.Neptune, 38, 4),
            new DefinedGate(PlanetType.Pluto, 1, 6),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 63, 2),
            new DefinedGate(PlanetType.Earth, 64, 2),
            new DefinedGate(PlanetType.Moon, 32, 2),
            new DefinedGate(PlanetType.TrueNode, 60, 1),
            new DefinedGate(PlanetType.SouthNode, 56, 1),
            new DefinedGate(PlanetType.Mercury, 63, 4),
            new DefinedGate(PlanetType.Venus, 21, 3),
            new DefinedGate(PlanetType.Mars, 35, 4),
            new DefinedGate(PlanetType.Jupiter, 31, 3),
            new DefinedGate(PlanetType.Saturn, 41, 1),
            new DefinedGate(PlanetType.Uranus, 38, 4),
            new DefinedGate(PlanetType.Neptune, 54, 2),
            new DefinedGate(PlanetType.Pluto, 43, 2),
        ])),

    new Person('16', 'Hans Henrik Nielsen', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 59, 2),
            new DefinedGate(PlanetType.Earth, 55, 2),
            new DefinedGate(PlanetType.Moon, 46, 4),
            new DefinedGate(PlanetType.TrueNode, 64, 5),
            new DefinedGate(PlanetType.SouthNode, 63, 5),
            new DefinedGate(PlanetType.Mercury, 29, 2),
            new DefinedGate(PlanetType.Venus, 47, 3),
            new DefinedGate(PlanetType.Mars, 35, 4),
            new DefinedGate(PlanetType.Jupiter, 11, 2),
            new DefinedGate(PlanetType.Saturn, 38, 3),
            new DefinedGate(PlanetType.Uranus, 4, 4),
            new DefinedGate(PlanetType.Neptune, 28, 6),
            new DefinedGate(PlanetType.Pluto, 59, 6),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 14, 6),
            new DefinedGate(PlanetType.Earth, 8, 6),
            new DefinedGate(PlanetType.Moon, 38, 3),
            new DefinedGate(PlanetType.TrueNode, 64, 1),
            new DefinedGate(PlanetType.SouthNode, 63, 1),
            new DefinedGate(PlanetType.Mercury, 44, 3),
            new DefinedGate(PlanetType.Venus, 58, 5),
            new DefinedGate(PlanetType.Mars, 53, 4),
            new DefinedGate(PlanetType.Jupiter, 58, 2),
            new DefinedGate(PlanetType.Saturn, 54, 1),
            new DefinedGate(PlanetType.Uranus, 29, 2),
            new DefinedGate(PlanetType.Neptune, 44, 3),
            new DefinedGate(PlanetType.Pluto, 40, 3),
        ])),


    new Person('17', 'Johnny Hansen', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 25, 3),
            new DefinedGate(PlanetType.Earth, 46, 3),
            new DefinedGate(PlanetType.Moon, 43, 3),
            new DefinedGate(PlanetType.TrueNode, 35, 6),
            new DefinedGate(PlanetType.SouthNode, 5, 6),
            new DefinedGate(PlanetType.Mercury, 51, 5),
            new DefinedGate(PlanetType.Venus, 36, 3),
            new DefinedGate(PlanetType.Mars, 64, 3),
            new DefinedGate(PlanetType.Jupiter, 23, 5),
            new DefinedGate(PlanetType.Saturn, 37, 5),
            new DefinedGate(PlanetType.Uranus, 64, 1),
            new DefinedGate(PlanetType.Neptune, 43, 1),
            new DefinedGate(PlanetType.Pluto, 64, 4),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 15, 1),
            new DefinedGate(PlanetType.Earth, 10, 1),
            new DefinedGate(PlanetType.Moon, 37, 1),
            new DefinedGate(PlanetType.TrueNode, 35, 3),
            new DefinedGate(PlanetType.SouthNode, 5, 3),
            new DefinedGate(PlanetType.Mercury, 52, 6),
            new DefinedGate(PlanetType.Venus, 53, 3),
            new DefinedGate(PlanetType.Mars, 6, 4),
            new DefinedGate(PlanetType.Jupiter, 35, 3),
            new DefinedGate(PlanetType.Saturn, 22, 1),
            new DefinedGate(PlanetType.Uranus, 40, 6),
            new DefinedGate(PlanetType.Neptune, 1, 5),
            new DefinedGate(PlanetType.Pluto, 64, 3),
        ])),

    new Person('18', 'Teal Swan', new Date(), new HumanDesign(
        [
            new DefinedGate(PlanetType.Sun, 36, 6),
            new DefinedGate(PlanetType.Earth, 6, 6),
            new DefinedGate(PlanetType.Moon, 18, 2),
            new DefinedGate(PlanetType.TrueNode, 16, 4),
            new DefinedGate(PlanetType.SouthNode, 9, 4),
            new DefinedGate(PlanetType.Mercury, 17, 3),
            new DefinedGate(PlanetType.Venus, 55, 5),
            new DefinedGate(PlanetType.Mars, 14, 3),
            new DefinedGate(PlanetType.Jupiter, 38, 1),
            new DefinedGate(PlanetType.Saturn, 1, 3),
            new DefinedGate(PlanetType.Uranus, 5, 3),
            new DefinedGate(PlanetType.Neptune, 10, 4),
            new DefinedGate(PlanetType.Pluto, 50, 6),
        ], 
        [
            new DefinedGate(PlanetType.Sun, 12, 4),
            new DefinedGate(PlanetType.Earth, 11, 4),
            new DefinedGate(PlanetType.Moon, 60, 5),
            new DefinedGate(PlanetType.TrueNode, 16, 1),
            new DefinedGate(PlanetType.SouthNode, 9, 1),
            new DefinedGate(PlanetType.Mercury, 45, 1),
            new DefinedGate(PlanetType.Venus, 12, 4),
            new DefinedGate(PlanetType.Mars, 44, 5),
            new DefinedGate(PlanetType.Jupiter, 38, 1),
            new DefinedGate(PlanetType.Saturn, 44, 3),
            new DefinedGate(PlanetType.Uranus, 9, 6),
            new DefinedGate(PlanetType.Neptune, 10, 3),
            new DefinedGate(PlanetType.Pluto, 50, 4),
        ])),
];