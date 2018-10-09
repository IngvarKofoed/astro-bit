import * as React from 'react';
import { RouteComponentProps, withRouter } from 'react-router-dom';
import { Person } from '../domain/Person';

interface HumanDesignChartProps extends RouteComponentProps {
  person: Person | undefined;
}

class HumanDesignChartWithRouter extends React.Component<HumanDesignChartProps> {
  private readonly basicStyle: React.CSSProperties = 
    {
      fill: '#ffffff',
      stroke: '#646464',
      strokeWidth: '0.18526436'
    } 

    private readonly gateTextStyle: React.CSSProperties = 
    {
      fill: '#000000',
      fontSize: '2.9px',
      fontFamily: 'Arial',
      fontWeight: 'bold',
      cursor: 'pointer'
    }

    private readonly definedGateTextStyle: React.CSSProperties = 
    {
      fill: '#ffffff',
      fontSize: '2.9px',
      fontFamily: 'Arial',
      fontWeight: 'bold',
      cursor: 'pointer'
    }

    private readonly gateBackgroundStyle: React.CSSProperties =
    {
      fill: '#ffffff',
      stroke: '#646464',
      strokeWidth: '0.18526436',
      cursor: 'pointer'
    }

    private readonly definedGateBackgroundStyle: React.CSSProperties =
    {
      fill: '#0000aa',
      stroke: '#0000aa',
      strokeWidth: '0.18526436',
      cursor: 'pointer'
    }

    private readonly emptyGatePathStyle: React.CSSProperties =
    {
      fill: '#ffffff',
      stroke: '#ffffff',
      strokeWidth: '0.0'
    }

    private readonly designGatePathStyle: React.CSSProperties =
    {
      fill: '#ff0000',
      stroke: '#ff0000',
      strokeWidth: '0.0'
    }

    private readonly personalityGatePathStyle: React.CSSProperties =
    {
      fill: '#000000',
      stroke: '#000000',
      strokeWidth: '0.0'
    }

    private readonly doubleDefinedGatePathStyle: React.CSSProperties =
    {
      fill: 'url(#pattern_dobble_defined_gate_definition)'
    }

  public render() {  
    return (      
      <div>

<svg width="88.935303mm" height="149.56805mm" viewBox="0 0 88.935303 149.56805" version="1.1" id="svg8" xmlns="http://www.w3.org/2000/svg">
  <defs id="defs2">
    <pattern id="pattern_dobble_defined_gate" patternTransform="matrix(0.39746194,0,0,0.26458333,85.665854,97.12893)" />
    <pattern patternUnits="userSpaceOnUse" width="25.003106" height="3.6654607" patternTransform="matrix(0.26458333,0,0,0.26458333,90.336853,96.848297)" id="pattern_dobble_defined_gate_definition">
      <g id="g1584" transform="matrix(3.7795276,0,0,3.7795276,-341.43063,-366.04081)">
        <rect style={this.designGatePathStyle} id="pattern_double_defined_1" width="6.6154051" height="0.48491073" x="90.336853" y="96.848297" />
        <rect style={this.personalityGatePathStyle} id="pattern_double_defined_2" width="6.6154051" height="0.48491076" x="90.336853" y="97.333206" />
      </g>
    </pattern>
  </defs>
  <g id="layer1" transform="translate(-58.733631,-76.160318)">
    <rect style={this.basicStyle} id="rect3748" width="2.1523471" height="115.58605" x="101.91289" y="95.239197" />
    <rect style={this.basicStyle} id="rect3748-45" width="2.1491597" height="115.58678" x="107.51059" y="95.008743" />
    <rect style={this.basicStyle} id="rect3748-45-9" width="2.1491597" height="115.58678" x="96.291435" y="94.970909" />
    <rect style={this.getGatePathStyle(64)} id="gatepath_64" width="2.0279949" height="2.8070252" x="96.350006" y="95.059448" />
    <rect style={this.getGatePathStyle(61)} id="gatepath_61" width="2.0279946" height="2.8070252" x="101.95853" y="95.01342" />
    <rect style={this.getGatePathStyle(63)} id="gatepath_63" width="2.0279946" height="2.8070252" x="107.58092" y="95.046494" />
    <path style={this.basicStyle} id="center_head" d="m 135.1638,171.04826 -25.5737,-0.0197 12.7035,-22.28257 z" transform="matrix(0.76286304,0,0,0.85931455,9.6412338,-51.499313)" />
    <rect style={this.getGatePathStyle(47)} id="gatepath_47" width="2.0279946" height="2.8070252" x="96.350006" y="97.86647" />
    <rect style={this.getGatePathStyle(24)} id="gatepath_24" width="2.0279946" height="2.8070252" x="101.95853" y="97.820442" />
    <rect style={this.getGatePathStyle(4)} id="gatepath_4" width="2.0279946" height="2.8070252" x="107.58092" y="97.853516" />
    <rect style={this.getGatePathStyle(43)} id="gatepath_43" width="2.0279946" height="4.2126241" x="101.94199" y="117.10612" />
    <rect style={this.getGatePathStyle(17)} id="gatepath_17" width="2.0279946" height="11.392149" x="96.353294" y="105.31691" />
    <rect style={this.getGatePathStyle(11)} id="gatepath_11" width="2.0279946" height="11.392149" x="107.55537" y="105.29706" />
    <path style={this.basicStyle} id="center_ajna" d="m 135.1638,171.04826 -25.5737,-0.0197 12.7035,-22.28257 z" transform="matrix(0.76286304,0,0,-0.85931454,9.6412338,246.97949)" />
    <rect style={this.basicStyle} id="rect2418" width="15.792725" height="15.792726" x="95.102142" y="209.86064" />
    <rect style={this.basicStyle} id="rect2418-5" width="15.792725" height="15.792726" x="95.102142" y="188.37297" />
    <rect style={this.basicStyle} id="rect2418-5-0" width="15.792725" height="15.792726" x="176.25601" y="30.594126" transform="rotate(45)" />
    <path style={this.basicStyle} id="path2450" d="m 135.1638,171.04826 -25.5737,-0.0197 12.7035,-22.28257 z" transform="matrix(0.81466797,0,0,0.53975277,20.362785,80.023421)" />
    <path style={this.basicStyle} id="path2450-8" d="m 135.1638,171.04826 -25.5737,-0.0197 12.7035,-22.28257 z" transform="matrix(0,-0.86486234,0.87175287,0,-1.518279,295.37809)" />
    <rect style={this.basicStyle} id="rect3748-45-9-6" width="2.1491597" height="65.854095" x="150.60683" y="52.873547" transform="rotate(33.845459)" />
    <rect style={this.basicStyle} id="rect3748-45-9-6-7" width="2.1491597" height="65.854095" x="150.20209" y="64.005341" transform="rotate(30.944288)" />
    <rect style={this.getGatePathStyle(48)} id="gatepath_48" width="2.0279946" height="33.000889" x="150.87326" y="85.623825" transform="rotate(33.970132)" />
    <path style={this.basicStyle} id="path2450-8-1" d="m 135.1638,171.04826 -25.5737,-0.0197 12.7035,-22.28257 z" transform="matrix(0,-0.86486233,-0.87175287,0,207.92084,295.37855)" />
    <rect style={this.getGatePathStyle(1)} id="gatepath_1" width="2.0279946" height="4.2126241" x="101.94199" y="121.31875" />
    <rect style={this.getGatePathStyle(56)} id="gatepath_56" width="2.0279946" height="8.4922743" x="107.55537" y="116.68921" />
    <rect style={this.getGatePathStyle(62)} id="gatepath_62" width="2.0279946" height="8.4922743" x="96.353294" y="116.70905" />
    <rect style={this.getGatePathStyle(16)} id="gatepath_16" width="2.0279946" height="33.000889" x="150.81812" y="52.600273" transform="rotate(33.970132)" />
    <rect style={this.basicStyle} id="rect2418-5-3" width="15.792725" height="15.792726" x="95.102142" y="124.96747" />
    <ellipse style={this.getGateBackgroundStyle(64)} id="gate_background_64" cx="97.332878" cy="93.564453" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(64)} />
    <text style={this.getGateTextStyle(64)} x="95.605019" y="94.642593" id="gate_text_64" onClick={_ => this.onGateClick(64)}>64</text>
    <ellipse style={this.getGateBackgroundStyle(63)} id="gate_background_63" cx="108.64453" cy="93.535423" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(63)} />
    <ellipse style={this.getGateBackgroundStyle(61)} id="gate_background_61" cx="102.9229" cy="93.535416" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(61)} />
    <text style={this.getGateTextStyle(61)} x="101.40813" y="94.646629" id="gate_text_61" onClick={_ => this.onGateClick(61)}>61</text>
    <text style={this.getGateTextStyle(63)} x="106.94722" y="94.613564" id="gate_text_63" onClick={_ => this.onGateClick(63)}>63</text>
    <ellipse style={this.getGateBackgroundStyle(47)} id="gate_background_47" cx="97.333595" cy="101.88633" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(47)} />
    <text style={this.getGateTextStyle(47)} x="95.605736" y="102.96447" id="gate_text_47" onClick={_ => this.onGateClick(47)}>47</text>
    <ellipse style={this.getGateBackgroundStyle(24)} id="gate_background_24" cx="102.98905" cy="101.88633" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(24)} />
    <text style={this.getGateTextStyle(24)} x="101.26119" y="102.96447" id="gate_text_24" onClick={_ => this.onGateClick(24)}>24</text>
    <ellipse style={this.getGateBackgroundStyle(4)} id="gate_background_4" cx="108.66107" cy="101.83673" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(4)} />
    <text style={this.getGateTextStyle(4)} x="107.81912" y="102.91486" id="gate_text_4" onClick={_ => this.onGateClick(4)}>4</text>
    <ellipse style={this.getGateBackgroundStyle(43)} id="gate_background_43" cx="102.97253" cy="113.67683" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(43)} />
    <text style={this.getGateTextStyle(43)} x="101.31396" y="114.75497" id="gate_text_43" onClick={_ => this.onGateClick(43)}>43</text>
    <ellipse style={this.getGateBackgroundStyle(1)} id="gate_background_1" cx="102.98906" cy="126.906" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(1)} />
    <text style={this.getGateTextStyle(1)} x="102.26781" y="127.98413" id="gate_text_1" onClick={_ => this.onGateClick(1)}>1</text>
    <ellipse style={this.getGateBackgroundStyle(62)} id="gate_background_62" cx="97.718224" cy="126.8754" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(62)} />
    <text style={this.getGateTextStyle(62)} x="95.926849" y="127.93015" id="gate_text_62" onClick={_ => this.onGateClick(62)}>62</text>
    <ellipse style={this.getGateBackgroundStyle(56)} id="gate_background_56" cx="108.21072" cy="126.84035" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(56)} />
    <text style={this.getGateTextStyle(56)} x="106.41934" y="127.89511" id="gate_text_56" onClick={_ => this.onGateClick(56)}>56</text>
    <ellipse style={this.getGateBackgroundStyle(17)} id="gate_background_17" cx="99.876343" cy="107.52577" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(17)} />
    <text style={this.getGateTextStyle(17)} x="98.068947" y="108.60391" id="gate_text_17" onClick={_ => this.onGateClick(17)}>17</text>
    <ellipse style={this.getGateBackgroundStyle(11)} id="gate_background_11" cx="105.96175" cy="107.65806" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(11)} />
    <text style={this.getGateTextStyle(11)} x="104.30318" y="108.7362" id="gate_text_11" onClick={_ => this.onGateClick(11)}>11</text>
    <ellipse style={this.getGateBackgroundStyle(16)} id="gate_background_16" cx="97.671455" cy="130.75748" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(16)} />
    <text style={this.getGateTextStyle(16)} x="95.880081" y="131.81224" id="gate_text_16" onClick={_ => this.onGateClick(16)}>16</text>
    <ellipse style={this.getGateBackgroundStyle(20)} id="gate_background_20" cx="97.694847" cy="135.21552" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(20)} />
    <text style={this.getGateTextStyle(20)} x="95.903473" y="136.27026" id="gate_text_20" onClick={_ => this.onGateClick(20)}>20</text>
    <ellipse style={this.getGateBackgroundStyle(31)} id="gate_background_31" cx="97.694847" cy="138.73215" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(31)} />
    <text style={this.getGateTextStyle(31)} x="95.903473" y="139.7869" id="gate_text_31" onClick={_ => this.onGateClick(31)}>31</text>
    <ellipse style={this.getGateBackgroundStyle(48)} id="gate_background_48" cx="61.446419" cy="182.41736" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(48)} />
    <text style={this.getGateTextStyle(48)} x="59.655045" y="183.47211" id="gate_text_48" onClick={_ => this.onGateClick(48)}>48</text>
    <ellipse style={this.getGateBackgroundStyle(57)} id="gate_background_57" cx="65.468826" cy="184.70918" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(57)} />
    <text style={this.getGateTextStyle(57)} x="63.677448" y="185.76393" id="gate_text_57" onClick={_ => this.onGateClick(57)}>57</text>
  </g>
</svg>


  
  </div>);
  }

  private onGateClick(gateNumber: number) {
    this.props.history.push(`/gate/${gateNumber}`)
  }

  private getGateTextStyle(gateNumber: number): React.CSSProperties {
    if (this.props.person === undefined) {
      return this.gateTextStyle;
    }

    if (this.hasGate(gateNumber)) {
      return this.definedGateTextStyle;
    }
    else {
      return this.gateTextStyle;
    }
  }

  private getGateBackgroundStyle(gateNumber: number): React.CSSProperties {
    if (this.props.person === undefined) {
      return this.gateBackgroundStyle;
    }

    if (this.hasGate(gateNumber)) {
      return this.definedGateBackgroundStyle;
    }
    else {
      return this.basicStyle;
    }
  }

  private getGatePathStyle(gateNumber: number): React.CSSProperties {
    if (this.props.person  === undefined) throw new Error();

    const designGate = this.props.person.humanDesign.design.find(x => x.gateNumber === gateNumber);
    const personalityGate = this.props.person.humanDesign.personality.find(x => x.gateNumber === gateNumber);
    
    if (designGate !== undefined && personalityGate !== undefined) {
      return this.doubleDefinedGatePathStyle;
    }
    else if (designGate !== undefined) {
      return this.designGatePathStyle;
    }
    else if (personalityGate !== undefined) {
      return this.personalityGatePathStyle;
    }
    else {
      return this.emptyGatePathStyle;
    }
  }

  private hasGate(gateNumber: number) {
    if (this.props.person  === undefined) throw new Error();

    const designGate = this.props.person.humanDesign.design.find(x => x.gateNumber === gateNumber);
    if (designGate !== undefined) return true;

    const personalityGate = this.props.person.humanDesign.personality.find(x => x.gateNumber === gateNumber);
    return personalityGate !== undefined;
  }
}


export const HumanDesignChart = withRouter(HumanDesignChartWithRouter);