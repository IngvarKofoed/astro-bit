import * as React from 'react';
import { RouteComponentProps, withRouter } from 'react-router-dom';

 //interface ScrollToTopProps extends RouteComponentProps {
//}
 
// export class ScrollToTop extends React.Component<ScrollToTopProps> {
   // public componentDidUpdate(prevProps: ScrollToTopProps, prevState: any, snapshot: any) {
class ScrollToTopWithRouter extends React.Component<RouteComponentProps<any>> {
    public componentDidUpdate(prevProps: RouteComponentProps<any>, prevState: any, snapshot: any) {
        if (this.props.location !== prevProps.location) {
            window.scrollTo(0, 0)
        } 
    }
  
    public render() {
        return null;
    }
}

export const ScrollToTop = withRouter(ScrollToTopWithRouter);