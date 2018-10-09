import * as React from 'react';
import { match, RouteComponentProps } from 'react-router-dom';
import { Header, Dropdown, DropdownProps } from 'semantic-ui-react'
import * as _ from 'lodash';
import { persons } from './domain';
import { Person } from './domain/Person';
import { HumanDesignPlanets } from './HumanDesignPlanets';
import { HumanDesignGates } from './person/HumanDesignGates';

interface HomeMatchProps{
    id: string | undefined;
  }
  
interface HomeProps extends RouteComponentProps {
    match: match<HomeMatchProps>;
}

class HomeState {
    constructor(public selectedPerson: Person | undefined) {
    }
  }

export class Home extends React.Component<HomeProps, HomeState>  {
    state: Readonly<HomeState> = {
        selectedPerson: this.getInitialPerson()
    }; 

    constructor(props: HomeProps) {
        super(props);
    }    

    public render() {
        let personOptions = _.map(persons, x => ({
          key: x.id,
          value: x.id,
          text: x.name
        }));
    
        return (<div>
            <Dropdown placeholder='Select Person' fluid search selection options={personOptions} onChange={this.personSelected.bind(this)} value={this.state.selectedPerson !== undefined ? this.state.selectedPerson.id : undefined} />
            <Header as='h1'>{this.state.selectedPerson !== undefined ? this.state.selectedPerson.name : ''}</Header>            
            <Header as='h2'>Human Design Chart</Header>
            <HumanDesignPlanets person={this.state.selectedPerson} />
            <Header as='h2'>All gates (design and personality) listed in order</Header>
            <HumanDesignGates person={this.state.selectedPerson} />
        </div>);
    }    

    public componentDidUpdate(prevProps: RouteComponentProps<any>, prevState: any, snapshot: any) {
        if (this.props.match.params.id !== prevProps.match.params.id) {
            var selectedPerson = persons.find(x => x.id === this.props.match.params.id);    
            if (selectedPerson !== undefined) {
                this.setState(new HomeState(selectedPerson));
              }
        } 
    }

    private getInitialPerson() {
        return persons
            .filter(x => x.id === this.props.match.params.id)[0];
    }

    private personSelected(event: React.SyntheticEvent<HTMLElement>, dropdown: DropdownProps) {
        var selectedPerson = persons.find(x => x.id === dropdown.value);
        if (selectedPerson !== undefined) {
            this.props.history.push(`/${selectedPerson.id}`);
            this.setState(new HomeState(selectedPerson));
        }
    }
}