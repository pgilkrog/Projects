 import { Component } from '@angular/core';
 import { fadeInItems } from '@angular/material';

 @Component({
  selector: 'app-education-list',
  templateUrl: './education-list.component.html',
  styleUrls: ['./education-list.component.css']
 })

export class EducationListComponent {
  educations = [
    {
      id: 1,
      title: '2016-2018: Datamatiker',
      content: 'Som datamatiker lære man at designe og programmere it-systemer samt arbejde med databaser. På uddannelsen får du indsigt' +
      ' i programmering og konstruktion af it-systemer, og du vil lære at kode i bl.a. Java og C# og designe databaser, så de opfylder' +
      ' kravene til godt databasedesign. Samtidig vil du få en forståelse for, hvordan en virksomhed fungerer, og hvordan man kan indføre' +
      ' nye IT-systemer i en virksomhed. Sidst på uddannelsen kan du specialisere dig inden for et bestemt område, eksempelvis spil-' +
      ' eller softwareudvikling til mobile platforme. Som færdiguddannet kan du bl.a. få job som programmør, systemudvikler, webudvikler,' +
      ' netværksadministrator, IT-konsulent eller spiludvikler.',
      show: true
    },
    {
      id: 2,
      title: '2014-2015: Software Ingeniør på Aalborg Universitet',
      content: 'Gik på uddannelsen i lidt over et år, hvor man lærte at programmere i c og C#.' +
      ' Jeg skiftede over til datamatiker uddannelsen i stedet for.',
      show: false
    },
    {
      id: 3,
      title: '2012-2014: STX, Matematisk naturfaglig studieretning',
      content: 'På Aalborg City Gymnasium har du mulighed for at tage en studentereksamen på to år i stedet for de normale tre år.' +
      ' En studentereksamen fra Aalborg City Gymnasium giver dig nøjagtig de samme muligheder, som hvis du havde gået på en' +
      ' almindelig 3-årig STX, den eneste forskel er, at det hos Aalborg City Gymnasium tager ét år mindre.',
      show: false
    },
    {
      id: 4,
      title: '2010-2012: Grundforløb til It-supporter',
      content: 'Lærte grundlæggende ting om computere og server opsætning. Kunne ikke finde en praktikplads, så jeg valgte at tage' +
      ' en studenter eksamen, for at blive programmør/udvikler.',
      show: false
    },
    {
      id: 5,
      title: '2008-2010: Web-Integrator',
      content: 'På webudvikleruddannelsen lærer du om alle de elementer, der indgår i at bygge dynamiske og avancerede websites' +
      ' eller andre internetløsninger: kodning i HTML, CSS og JavaScript, objektorienteret programmering, strukturering af ' +
      ' arbejdsprocesser, navigationsdesign, billedbehandling og integration af (relations)databaser, animationer, grafik,' +
      '  tekst osv. Du kommer også til at arbejde med e-handel/webshops, applikationsudvikling og opsætning af webservere,' +
      ' herunder tilpasning og vedligeholdelse af præfabrikeret CMS-software.',
      show: false
    },
    { id: 6,
      title: '1997-2008: Folkeskole(10 klasse)',
      content: '10 klasse: Bavnebakke Skolen' +
      '7-9 klasse: Suldrup Skole' +
      '6 klasse: Kirketerp Skolen ' +
      '0-5 klasse: Nibe Skole',
      show: false
    }
];
  tempEdu = this.educations[0];

  setShow(item: any) {
    item.show = !item.show;
    this.tempEdu.show = !this.tempEdu.show;

    this.tempEdu = item;
  }
}
