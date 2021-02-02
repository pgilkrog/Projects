import React, { useState, useEffect, Component, createRef } from 'react';

import './SearchComponent.css'

export const SearchComponent: React.FC<any> = (props: any) => {
    const [enteredFilter, setEnteredFilter] = useState('');

    const {refInp, searching} = props;

    useEffect(() => {         
        const timer = setTimeout(() => {
          if (enteredFilter === refInp.current.value) {   
              searching(enteredFilter);
          }     
        }, 600);

        return () => {
          clearTimeout(timer);
        };
      }, [enteredFilter, refInp]);

    return (
        <div className="SearchStyle">
            <input 
                ref={props.refInp}
                autoFocus placeholder="Search..."
                type="text" 
                value={enteredFilter} 
                onChange={event => setEnteredFilter(event.target.value)} 
            />
        </div>
    )
}

class Search extends Component<any>{
  private inputRef: React.RefObject<HTMLInputElement>;
  
  state = {
      searching: ''
  }

  constructor(props: any) {
      super(props);
      this.inputRef = createRef();
  }

  searchHandler = (search: string) => {
      this.setState({searching: search})
      this.props.searching(search);
  }

  render() {
      return (
        <SearchComponent 
            refInp={this.inputRef} 
            searching={(search: string) => this.searchHandler(search)} 
        />
      )
  }
}

export default Search;