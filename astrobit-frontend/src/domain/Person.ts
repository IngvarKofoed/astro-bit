import { HumanDesign } from './HumanDesign'

export class Person {
    constructor (
        public readonly id: string,
        public readonly name: string,
        public readonly birthDate: Date,
        public readonly humanDesign: HumanDesign)
    {
    }
}