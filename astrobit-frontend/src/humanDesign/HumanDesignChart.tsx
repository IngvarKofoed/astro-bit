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

  private readonly whiteStyle: React.CSSProperties = 
  {
    fill: '#ffffff',
    strokeWidth: '0'
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
    <rect style={this.basicStyle} id="rect3748" width="2.125174" height="117.50294" x="101.92648" y="95.252792" />
    <rect style={this.basicStyle} id="rect3748-45" width="2.1232507" height="116.95141" x="107.52354" y="95.021698" />
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
    <rect style={this.basicStyle} id="rect3748-45-9-8" width="2.2448456" height="16.64905" x="-158.55098" y="79.743156" transform="rotate(-90)" />
    <rect style={this.basicStyle} id="rect3748-45-9-6-4-2" width="2.1491597" height="65.854095" x="139.15778" y="67.133263" transform="rotate(28.160658)" />
    <rect style={this.basicStyle} id="rect2418-5-0" width="15.792725" height="15.792726" x="176.25601" y="30.594126" transform="rotate(45)" />
    <rect style={this.basicStyle} id="rect3748-45-9-6-7-6" width="2.1491597" height="65.854095" x="-49.787411" y="168.75024" transform="matrix(-0.90774267,0.41952741,0.41952741,0.90774267,0,0)" />
    <rect style={this.basicStyle} id="rect3748-45-8-5" width="2.1491597" height="34.154049" x="73.479309" y="164.12619" transform="rotate(-14.931061)" />
    <rect style={this.basicStyle} id="rect3748-45-9-6-4" width="2.1491597" height="65.854095" x="-42.528336" y="164.61069" transform="matrix(-0.88162772,0.47194551,0.47194551,0.88162772,0,0)" />
    <path style={this.basicStyle} id="path2450" d="m 135.1638,171.04826 -25.5737,-0.0197 12.7035,-22.28257 z" transform="matrix(0.81466797,0,0,0.53975277,21.156535,82.140088)" />
    <rect style={this.getGatePathStyle(36)} id="gatepath_36" width="2.0279946" height="33.000889" x="-42.018311" y="197.7809" transform="matrix(-0.88059871,0.47386276,0.47386276,0.88059871,0,0)" />
    <rect style={this.getGatePathStyle(22)} id="gatepath_22" width="2.0279946" height="33.000889" x="-49.435696" y="197.80493" transform="matrix(-0.90712836,0.42085406,0.42085406,0.90712836,0,0)" />
    <path style={this.basicStyle} id="path2450-8" d="m 135.1638,171.04826 -25.5737,-0.0197 12.7035,-22.28257 z" transform="matrix(0,-0.86486234,0.87175287,0,-1.518279,295.37809)" />
    <rect style={this.getGatePathStyle(48)} id="gatepath_48" width="2.0279946" height="33.000889" x="139.45393" y="99.908806" transform="rotate(28.285331)" />
    <rect style={this.getGatePathStyle(16)} id="gatepath_16" width="2.0279946" height="33.000889" x="139.39879" y="66.884857" transform="rotate(28.285331)" />
    <rect style={this.basicStyle} id="rect3748-45-9-6-7-6-7" width="2.1491597" height="65.854095" x="137.28206" y="81.710266" transform="rotate(24.804754)" />
    <path style={this.basicStyle} id="path2450-8-1" d="m 135.1638,171.04826 -25.5737,-0.0197 12.7035,-22.28257 z" transform="matrix(0,-0.86486233,-0.87175287,0,207.92084,295.37855)" />
    <rect style={this.getGatePathStyle(1)} id="gatepath_1" width="2.0279946" height="4.2126241" x="101.94199" y="121.31875" />
    <rect style={this.getGatePathStyle(56)} id="gatepath_56" width="2.0279946" height="8.4922743" x="107.55537" y="116.68921" />
    <rect style={this.getGatePathStyle(62)} id="gatepath_62" width="2.0279946" height="8.4922743" x="96.353294" y="116.70905" />
    <rect style={this.getGatePathStyle(35)} id="gatepath_35" width="2.0279946" height="33.000889" x="-42.073456" y="164.75735" transform="matrix(-0.88059871,0.47386276,0.47386276,0.88059871,0,0)" />
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
    <rect style={this.getGatePathStyle(12)} id="gatepath_12" width="2.0279946" height="33.000889" x="-49.435696" y="164.80405" transform="matrix(-0.90712836,0.42085406,0.42085406,0.90712836,0,0)" />
    <rect style={this.basicStyle} id="rect2418-5-3" width="26.563988" height="16.16819" x="89.716507" y="124.77973" />
    <ellipse style={this.getGateBackgroundStyle(23)} id="gate_background_23" cx="103.08919" cy="126.70756" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(23)} />
    <text style={this.getGateTextStyle(23)} x="101.41871" y="127.78569" id="gate_text_23" onClick={_ => this.onGateClick(23)}>23</text>
    <ellipse style={this.getGateBackgroundStyle(62)} id="gate_background_62" cx="97.288277" cy="126.71004" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(62)} />
    <text style={this.getGateTextStyle(62)} x="95.496902" y="127.76479" id="gate_text_62" onClick={_ => this.onGateClick(62)}>62</text>
    <ellipse style={this.getGateBackgroundStyle(56)} id="gate_background_56" cx="108.60759" cy="126.67499" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(56)} />
    <text style={this.getGateTextStyle(56)} x="106.81622" y="127.72974" id="gate_text_56" onClick={_ => this.onGateClick(56)}>56</text>
    <ellipse style={this.getGateBackgroundStyle(17)} id="gate_background_17" cx="99.876343" cy="107.52577" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(17)} />
    <text style={this.getGateTextStyle(17)} x="98.068947" y="108.60391" id="gate_text_17" onClick={_ => this.onGateClick(17)}>17</text>
    <ellipse style={this.getGateBackgroundStyle(11)} id="gate_background_11" cx="105.96175" cy="107.65806" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(11)} />
    <text style={this.getGateTextStyle(11)} x="104.30318" y="108.7362" id="gate_text_11" onClick={_ => this.onGateClick(11)}>11</text>
    <ellipse style={this.getGateBackgroundStyle(16)} id="gate_background_16" cx="92.379791" cy="128.74002" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(16)} />
    <text style={this.getGateTextStyle(16)} x="90.588417" y="129.79478" id="gate_text_16" onClick={_ => this.onGateClick(16)}>16</text>
    <ellipse style={this.getGateBackgroundStyle(20)} id="gate_background_20" cx="92.37011" cy="135.18243" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(20)} />
    <text style={this.getGateTextStyle(20)} x="90.578735" y="136.23718" id="gate_text_20" onClick={_ => this.onGateClick(20)}>20</text>
    <ellipse style={this.getGateBackgroundStyle(31)} id="gate_background_31" cx="97.430267" cy="139.07719" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(31)} />
    <text style={this.getGateTextStyle(31)} x="95.638893" y="140.13194" id="gate_text_31" onClick={_ => this.onGateClick(31)}>31</text>
    <ellipse style={this.getGateBackgroundStyle(48)} id="gate_background_48" cx="61.446419" cy="182.41736" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(48)} />
    <text style={this.getGateTextStyle(48)} x="59.655045" y="183.47211" id="gate_text_48" onClick={_ => this.onGateClick(48)}>48</text>
    <ellipse style={this.getGateBackgroundStyle(57)} id="gate_background_57" cx="66.42794" cy="185.20528" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(57)} />
    <text style={this.getGateTextStyle(57)} x="64.636566" y="186.26003" id="gate_text_57" onClick={_ => this.onGateClick(57)}>57</text>
    <rect style={this.whiteStyle} id="white_1" width="1.988802" height="2.0842066" x="80.182915" y="156.3907" />
    <ellipse style={this.getGateBackgroundStyle(36)} id="gate_background_36" cx="145.02229" cy="182.40982" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(36)} />
    <text style={this.getGateTextStyle(36)} x="143.23093" y="183.46457" id="gate_text_36" onClick={_ => this.onGateClick(36)}>36</text>
    <ellipse style={this.getGateBackgroundStyle(35)} id="gate_background_35" cx="113.55724" cy="128.67805" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(35)} />
    <text style={this.getGateTextStyle(35)} x="111.76585" y="129.73282" id="gate_text_35" onClick={_ => this.onGateClick(35)}>35</text>
    <ellipse style={this.getGateBackgroundStyle(12)} id="gate_background_12" cx="113.60014" cy="135.2085" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(12)} />
    <text style={this.getGateTextStyle(12)} x="111.80877" y="136.26324" id="gate_text_12" onClick={_ => this.onGateClick(12)}>12</text>
    <ellipse style={this.getGateBackgroundStyle(45)} id="gate_background_45" cx="113.58889" cy="139.00789" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(45)} />
    <text style={this.getGateTextStyle(45)} x="111.79753" y="140.06264" id="gate_text_45" onClick={_ => this.onGateClick(45)}>45</text>
    <ellipse style={this.getGateBackgroundStyle(8)} id="gate_background_8" cx="103.07933" cy="139.08971" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(8)} />
    <text style={this.getGateTextStyle(8)} x="102.23737" y="140.14445" id="gate_text_8" onClick={_ => this.onGateClick(8)}>8</text>
    <ellipse style={this.getGateBackgroundStyle(33)} id="gate_background_33" cx="108.59388" cy="139.01465" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(33)} />
    <text style={this.getGateTextStyle(33)} x="106.80252" y="140.0694" id="gate_text_33" onClick={_ => this.onGateClick(33)}>33</text>
    <ellipse style={this.getGateBackgroundStyle(1)} id="gate_background_1" cx="103.07365" cy="149.48975" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(1)} />
    <text style={this.getGateTextStyle(1)} x="102.23169" y="150.54449" id="gate_text_1" onClick={_ => this.onGateClick(1)}>1</text>
    <ellipse style={this.getGateBackgroundStyle(13)} id="gate_background_13" cx="107.22938" cy="153.746" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(13)} />
    <text style={this.getGateTextStyle(13)} x="105.47619" y="154.80075" id="gate_text_13" onClick={_ => this.onGateClick(13)}>13</text>
    <ellipse style={this.getGateBackgroundStyle(25)} id="gate_background_25" cx="110.70988" cy="157.53456" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(25)} />
    <text style={this.getGateTextStyle(25)} x="109.02003" y="158.58931" id="gate_text_25" onClick={_ => this.onGateClick(25)}>25</text>
    <ellipse style={this.getGateBackgroundStyle(2)} id="gate_background_2" cx="102.98011" cy="165.20518" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(2)} />
    <text style={this.getGateTextStyle(2)} x="102.13815" y="166.25993" id="gate_text_2" onClick={_ => this.onGateClick(2)}>2</text>
    <ellipse style={this.getGateBackgroundStyle(46)} id="gate_background_46" cx="107.33409" cy="160.90215" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(46)} />
    <text style={this.getGateTextStyle(46)} x="105.66212" y="161.95689" id="gate_text_46" onClick={_ => this.onGateClick(46)}>46</text>
    <ellipse style={this.getGateBackgroundStyle(7)} id="gate_background_7" cx="98.723839" cy="153.93311" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(7)} />
    <text style={this.getGateTextStyle(7)} x="97.881874" y="154.98785" id="gate_text_7" onClick={_ => this.onGateClick(7)}>7</text>
    <ellipse style={this.getGateBackgroundStyle(15)} id="gate_background_15" cx="98.689445" cy="160.94893" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(15)} />
    <text style={this.getGateTextStyle(15)} x="96.916885" y="162.00368" id="gate_text_15" onClick={_ => this.onGateClick(15)}>15</text>
    <ellipse style={this.getGateBackgroundStyle(10)} id="gate_background_10" cx="95.386322" cy="157.30069" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(10)} />
    <text style={this.getGateTextStyle(10)} x="93.642822" y="158.35544" id="gate_text_10" onClick={_ => this.onGateClick(10)}>10</text>
    <ellipse style={this.getGateBackgroundStyle(22)} id="gate_background_22" cx="139.93011" cy="185.31723" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(22)} />
    <text style={this.getGateTextStyle(22)} x="138.13875" y="186.37198" id="gate_text_22" onClick={_ => this.onGateClick(22)}>22</text>
    <ellipse style={this.getGateBackgroundStyle(21)} id="gate_background_21" cx="120.8003" cy="166.14062" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(21)} />
    <text style={this.getGateTextStyle(21)} x="119.11045" y="167.19537" id="gate_text_21" onClick={_ => this.onGateClick(21)}>21</text>
    <ellipse style={this.getGateBackgroundStyle(5)} id="gate_background_5" cx="97.751839" cy="190.32947" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(5)} />
    <text style={this.getGateTextStyle(5)} x="96.881577" y="191.38422" id="gate_text_5" onClick={_ => this.onGateClick(5)}>5</text>
    <ellipse style={this.getGateBackgroundStyle(14)} id="gate_background_14" cx="103.14382" cy="190.36537" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(14)} />
    <text style={this.getGateTextStyle(14)} x="101.36008" y="191.42012" id="gate_text_14" onClick={_ => this.onGateClick(14)}>14</text>
    <ellipse style={this.getGateBackgroundStyle(29)} id="gate_background_29" cx="108.28403" cy="190.36047" rx="2.288415" ry="1.5634466" onClick={_ => this.onGateClick(29)} />
    <text style={this.getGateTextStyle(29)} x="106.61876" y="191.41522" id="gate_text_29" onClick={_ => this.onGateClick(29)}>29</text>
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