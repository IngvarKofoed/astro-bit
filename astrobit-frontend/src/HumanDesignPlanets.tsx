import * as React from 'react';
import { Link } from "react-router-dom";
import { Grid, GridRow, GridColumn } from 'semantic-ui-react';
import { HumanDesign, DefinedGate } from './domain/HumanDesign';
import { PlanetType, getPlanetSymbol } from './domain/PlanetType';

export class HumanDesignPlanetsProps {
    public humanDesign: HumanDesign | undefined;
}

export class HumanDesignPlanets extends React.Component<HumanDesignPlanetsProps> {
    public render() {
        if (this.props.humanDesign !== undefined) {
            const planets = [ PlanetType.Sun, PlanetType.Earth, PlanetType.Moon, PlanetType.TrueNode, PlanetType.SouthNode, PlanetType.Mercury, PlanetType.Venus, PlanetType.Mars, PlanetType.Jupiter, PlanetType.Saturn, PlanetType.Uranus, PlanetType.Neptune, PlanetType.Pluto ];

            const designRows = planets.map(planet => <Link key={planet} to={this.getDesignGateLink(planet)}><GridRow>{this.getDesignGateString(planet)}</GridRow></Link>);
            const personalityRows = planets.map(planet => <Link key={planet} to={this.getPersonalityGateLink(planet)}><GridRow>{this.getPersonalityGateString(planet)}</GridRow></Link>);
        
            return (
                <Grid columns={2}>
                    <GridColumn>
                        <GridRow>Design</GridRow>
                        {designRows}
                    </GridColumn>
                    <GridColumn>
                        <GridRow>Personality</GridRow>
                        {personalityRows}
                    </GridColumn>
                </Grid>
            );
        }
        else {
            return (<div></div>)
        }
    }

    private getDesignGateLink(planetType: PlanetType): string {
        if (this.props.humanDesign === undefined) throw new Error();
        return this.getGateLink(planetType, this.props.humanDesign.design);
    }

    private getPersonalityGateLink(planetType: PlanetType): string {
        if (this.props.humanDesign === undefined) throw new Error();
        return this.getGateLink(planetType, this.props.humanDesign.personality);
    }

    private getGateLink(planetType: PlanetType, gates: DefinedGate[]): string {
        let gate = gates.find(x => x.planet == planetType);
        if (gate === undefined) throw new Error();

        return `/gate/${gate.gateNumber}`;
    }

    private getDesignGateString(planetType: PlanetType): string {
        if (this.props.humanDesign === undefined) throw new Error();
        return this.getGateString(planetType, this.props.humanDesign.design);
    }

    private getPersonalityGateString(planetType: PlanetType): string {
        if (this.props.humanDesign === undefined) throw new Error();
        return this.getGateString(planetType, this.props.humanDesign.personality);
    }

    private getGateString(planetType: PlanetType, gates: DefinedGate[]): string {
        let gate = gates.find(x => x.planet == planetType);
        if (gate === undefined) throw new Error();
            
        return `${getPlanetSymbol(planetType)} ${gate.gateNumber}.${gate.lineNumber}`;
    }
}  
