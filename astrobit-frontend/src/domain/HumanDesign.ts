import { PlanetType } from './PlanetType';

export class HumanDesign {
    constructor(
        public readonly design: Array<DefinedGate>,
        public readonly personality: Array<DefinedGate>)
        {
        } 
}

export class DefinedGate {
    constructor(
        public readonly planet: PlanetType, 
        public readonly gateNumber: number, 
        public readonly lineNumber: number)
        {}
}

