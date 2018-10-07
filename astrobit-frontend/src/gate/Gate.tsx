import * as React from 'react';
import { match, Link } from 'react-router-dom';
import { Header, List, ListItem } from 'semantic-ui-react';
import * as _ from 'lodash';
import { getGateDescription } from '../domain/humanDesignSystem';
import { persons } from '../domain/index';

interface GateRouterProps {
  gateNumber: string | undefined;
}

interface GateProps {
  match: match<GateRouterProps>;
}


export class Gate extends React.Component<GateProps> {

  public render() {
    if (this.props.match.params.gateNumber === undefined) throw new Error();

    const gateNumber = parseInt(this.props.match.params.gateNumber);
    const description = getGateDescription(gateNumber);

    const paragraphs = description.paragraphs.map((x, i) => <p key={'para' + i}>{x}</p>);
    const affirmations = description.affirmations.map((x, i) => <ListItem key={'aff' + i}>{x}</ListItem>);
    const assignments = description.assignments.map((x, i) => <ListItem key={'ass' + i}>{x}</ListItem>);

    const personsWithSameGate = this.getPersonsWithSameGate(gateNumber);

    const persons = personsWithSameGate.map((x, i) => <p key={'per' + i}><Link to={'/' + x.id} >{x.name}</Link></p>);

    return (
      <div>
        <Header as='h1'>Gate {gateNumber}</Header>
        {paragraphs}
        
        <Header as='h3'>Affirmations</Header>
        <List bulleted>
          {affirmations}
        </List>
        
        <Header as='h3'>Assignments</Header>
        <List ordered>
          {assignments}
        </List>
        <Header as='h3'>People who have this gate</Header>
        {persons}
      </div>)
    }

    private getPersonsWithSameGate(gateNumber: number) {
      return persons.filter(person => 
        person.humanDesign.design.filter(x => x.gateNumber === gateNumber).length > 0 || 
        person.humanDesign.personality.filter(x => x.gateNumber === gateNumber).length > 0
      );
    }
}