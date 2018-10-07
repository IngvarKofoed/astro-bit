import * as React from 'react';
import { Link } from "react-router-dom";
import { Table, TableRow, TableCell, TableBody, TableHeader, TableHeaderCell, List, ListItem } from 'semantic-ui-react';
import * as _ from 'lodash';
import { Person } from '../domain/Person';
import { getGateDescription } from '../domain/humanDesignSystem';
import { persons } from '../domain/index';

export class HumanDesignPlanetsProps {
    public person: Person | undefined;
}

export class HumanDesignGates extends React.Component<HumanDesignPlanetsProps> {
    public render() {
        if (this.props.person !== undefined) {
             const gateNumbers = _.chain(this.props.person.humanDesign.design).concat(this.props.person.humanDesign.design).map(x => x.gateNumber).uniq().sortBy(x => x).value();
             const gates = gateNumbers.map(x => this.getTableRow(x));

            return (
            <Table columns={2} >
                <TableHeader>
                    <TableRow>
                        <TableHeaderCell>Gate</TableHeaderCell>
                        <TableHeaderCell>Persons that share this gate</TableHeaderCell>
                    </TableRow>
                </TableHeader>
                <TableBody>
                    {gates}
                </TableBody>
            </Table>)
        }
        else {
            return (<div></div>)
        }
    }

    private getTableRow(gateNumber: number) {
        return (<TableRow key={gateNumber}>{this.getGateTableCell(gateNumber)}{this.gateGateSharingPeople(gateNumber)}</TableRow>)
    }

    private getGateTableCell(gateNumber: number) {
        const description = getGateDescription(gateNumber);
        return (<TableCell><Link to={'/gate/' + gateNumber}>{gateNumber} - {description.name}</Link></TableCell>)
    }

    private gateGateSharingPeople(gateNumber: number) {
        const personsWithSameGate = this.getPersonsWithSameGate(gateNumber);

        const persons = personsWithSameGate.map(person => <ListItem key={person.id}><Link to={'/' + person.id}>{person.name}</Link></ListItem>)

        return  (<TableCell><List bulleted>{persons}</List></TableCell>)
    }

    private getPersonsWithSameGate(gateNumber: number) {
        const person = this.props.person;
        if (person === undefined) throw new Error();

        return persons
            .filter(p => p.id !== person.id)
            .filter(p => 
                p.humanDesign.design.filter(x => x.gateNumber === gateNumber).length > 0 || 
                p.humanDesign.personality.filter(x => x.gateNumber === gateNumber).length > 0
        );
    }
}