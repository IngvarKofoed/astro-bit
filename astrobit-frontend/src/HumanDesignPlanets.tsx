import * as React from 'react';
import { Link } from "react-router-dom";
import { Grid, GridRow, GridColumn, Header } from 'semantic-ui-react';
import { DefinedGate } from './domain/HumanDesign';
import { PlanetType, getPlanetSymbol } from './domain/PlanetType';
import { HumanDesignChart } from './humanDesign/HumanDesignChart';
import { Person } from './domain/Person';

export class HumanDesignPlanetsProps {
    public person: Person | undefined;
}

export class HumanDesignPlanets extends React.Component<HumanDesignPlanetsProps> {
    public render() {
        if (this.props.person !== undefined) {
            const planets = [ PlanetType.Sun, PlanetType.Earth, PlanetType.Moon, PlanetType.TrueNode, PlanetType.SouthNode, PlanetType.Mercury, PlanetType.Venus, PlanetType.Mars, PlanetType.Jupiter, PlanetType.Saturn, PlanetType.Uranus, PlanetType.Neptune, PlanetType.Pluto ];

            const designRows = planets.map(planet => <Link key={planet} to={this.getDesignGateLink(planet)}><GridRow>{this.getDesignGateString(planet)}</GridRow></Link>);
            const personalityRows = planets.map(planet => <Link key={planet} to={this.getPersonalityGateLink(planet)}><GridRow>{this.getPersonalityGateString(planet)}</GridRow></Link>);
        
            return (
                <Grid columns='equal'>
                    <GridRow>
                        <GridColumn>
                            <Header as='h3'>Design</Header>
                            <Grid columns={1}><GridColumn>{designRows}</GridColumn></Grid>
                        </GridColumn>
                        <GridColumn width={8}>
                            <HumanDesignChart person={this.props.person} />
                        </GridColumn>
                        <GridColumn>
                            <Header as='h3'>Personality</Header>
                            <Grid columns={1}><GridColumn>{personalityRows}</GridColumn></Grid>
                        </GridColumn>
                    </GridRow>
                </Grid>
            );
        }
        else {
            return (<div></div>)
        }
    }

    private getDesignGateLink(planetType: PlanetType): string {
        if (this.props.person === undefined) throw new Error();
        return this.getGateLink(planetType, this.props.person.humanDesign.design);
    }

    private getPersonalityGateLink(planetType: PlanetType): string {
        if (this.props.person === undefined) throw new Error();
        return this.getGateLink(planetType, this.props.person.humanDesign.personality);
    }

    private getGateLink(planetType: PlanetType, gates: DefinedGate[]): string {
        let gate = gates.find(x => x.planet == planetType);
        if (gate === undefined) throw new Error();

        return `/gate/${gate.gateNumber}`;
    }

    private getDesignGateString(planetType: PlanetType): string {
        if (this.props.person === undefined) throw new Error();
        return this.getGateString(planetType, this.props.person.humanDesign.design);
    }

    private getPersonalityGateString(planetType: PlanetType): string {
        if (this.props.person === undefined) throw new Error();
        return this.getGateString(planetType, this.props.person.humanDesign.personality);
    }

    private getGateString(planetType: PlanetType, gates: DefinedGate[]): string {
        let gate = gates.find(x => x.planet == planetType);
        if (gate === undefined) throw new Error();
            
        return `${getPlanetSymbol(planetType)} ${gate.gateNumber}.${gate.lineNumber}`;
    }
}  
