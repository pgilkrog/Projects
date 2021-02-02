import React from 'react';

import './EmployeeList.css'

interface IEmployy {
    id: string,
    name: string,
    gender: string,
    company: string,
    email: string,
    isActive: boolean,
    picture: string
}

interface Props {
    employees: IEmployy[],
    clicked: any
}

export const EmployeeList: React.FC<Props> = props => {

    const clicked = (type: string) => {
        props.clicked(type);
    }

    return (
        <div className="EmployeeTableContainer">
            {props.employees.length > 0 ?
            <table>
                <thead>
                    <tr>                        
                        <th> Picture </th>
                        <th onClick={() => clicked("name")}> Name </th>
                        <th onClick={() => clicked("gender")}> Gender </th>
                        <th onClick={() => clicked("company")}> Company </th>
                        <th onClick={() => clicked("email")}> Email </th>
                        <th onClick={() => clicked("isActive")}> Is active </th>
                    </tr>
                </thead>
                {props.employees.map(emp => (
                    <tbody key={emp.id}>
                        <tr>
                            <td> <img src={emp.picture} height="50" alt="" /> </td>
                            <td> {emp.name} </td>
                            <td> {emp.gender} </td>
                            <td> {emp.company} </td>
                            <td> {emp.email} </td>
                            <td> {emp.isActive ? 'Yes' : 'No'} </td>
                        </tr>
                    </tbody>
                ))}
            </table>
            : "Can't find any employees!"}
        </div>
    );
};
