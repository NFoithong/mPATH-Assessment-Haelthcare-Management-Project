import { Component, OnInit } from '@angular/core';
import { PatientService } from '../../services/patient.service';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-patient-list',
  templateUrl: './patient-list.component.html',
  styleUrls: ['./patient-list.component.css']
})
export class PatientListComponent implements OnInit {
  displayedColumns: string[] = ['name', 'dob', 'gender', 'actions'];
  dataSource = new MatTableDataSource<any>();

  constructor(private patientService: PatientService) { }

  ngOnInit(): void {
    this.patientService.getPatients().subscribe((data) => {
      this.dataSource.data = data;
    });
  }

  filterPatients(event: Event): void {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
}
