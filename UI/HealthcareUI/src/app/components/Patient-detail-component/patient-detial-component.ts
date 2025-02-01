import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PatientService } from '../../services/patient.service';

@Component({
  selector: 'app-patient-detail',
  templateUrl: './patient-detail.component.html',
  styleUrls: ['./patient-detail.component.css']
})
export class PatientDetailComponent implements OnInit {
  patientId: number;
  patientDetails: any;

  constructor(
    private route: ActivatedRoute,
    private patientService: PatientService
  ) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      this.patientId = +params.get('id');
      this.patientService.getPatient(this.patientId).subscribe((data) => {
        this.patientDetails = data;
      });
    });
  }
}
