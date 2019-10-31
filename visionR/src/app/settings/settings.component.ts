import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
  styleUrls: ['./settings.component.css']
})
export class SettingsComponent implements OnInit {

  public endpointComputerVision: string;
  public computerVisionKey: string;
  public backendEndpoint: string;
  constructor(
    private router: Router
  ) {
    this.endpointComputerVision = localStorage.getItem('EndpointComputerVision');
    this.computerVisionKey = localStorage.getItem('ComputerVisionKey');
    this.backendEndpoint = localStorage.getItem('BackendEndpoint');
  }

  ngOnInit() {
  }
  setSettings() {
    localStorage.setItem('EndpointComputerVision', this.endpointComputerVision);
    localStorage.setItem('ComputerVisionKey', this.computerVisionKey);
    localStorage.setItem('BackendEndpoint', this.backendEndpoint);
    this.router.navigate(['home']);
  }
}
