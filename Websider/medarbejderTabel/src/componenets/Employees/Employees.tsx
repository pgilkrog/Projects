import React, { useMemo, useReducer} from 'react';

import data from '../../customData/generated.json';
import {EmployeeList} from './EmployeeList/EmployeeList';
import Search from '../Search/SearchComponent';

const employeeReducer = (currentEmployees: any, action: any) => {
    switch(action.type){
        case 'SET':
            return action.employees;
        case 'SEARCH':
            return [...data].filter((emp: any) => emp.name.includes(action.search) || emp.company.toLowerCase().includes(action.search));
        case 'SORT':
            return [...currentEmployees].sort(function(a, b) {
                if(a[action.sort] < b[action.sort]) { return -1 }
                if(a[action.sort] > b[action.sort]) { return 1 }
                return 0;
            })
        // case 'SORT_Email':
        //     return [...currentEmployees].sort(function(a, b) {
        //         if(a.email < b.email) { return -1 }
        //         if(a.email > b.email) { return 1 }
        //         return 0;
        //     })
        // case 'SORT_COM':
        //     return [...currentEmployees].sort(function(a, b) {
        //         if(a.company < b.company) { return -1 }
        //         if(a.company > b.company) { return 1 }
        //         return 0;
        //     })
        // case 'SORT_GEN':
        //     return [...currentEmployees].sort(function(a, b) {
        //         if(a.gender < b.gender) { return -1 }
        //         if(a.gender > b.gender) { return 1 }
        //         return 0;
        //     })
        // case 'SORT_ACT':
        //     return [...currentEmployees].sort(function(a, b) {
        //         if(a.isActive) { return -1 }
        //         if(!a.isActive) { return 1 }
        //         return 0;
        //     })
        default:
            console.log("Should never reach");
    }
}

export const Employees: React.FC = () => {
    const [employees, dispatch] = useReducer(employeeReducer, []);

    const searchEmployees = (searchString: string) => {
        if(searchString){
            dispatch({ type: 'SEARCH', search: searchString })
        } else {
            dispatch({ type: 'SET', employees: data})
        }
    }

    const employeeList = useMemo(() => {
        
        const sortEmployees = (type: string) => {
            dispatch({ type: 'SORT', sort: type });
        }

        return <EmployeeList 
                    employees={employees} 
                    clicked={(type: string) => sortEmployees(type)} />
    }, [employees])

    return ( 
        <div>
            <Search searching={(search: string) => searchEmployees(search)} />
            {employeeList}
        </div>
    )
}

  
  
  
  


  