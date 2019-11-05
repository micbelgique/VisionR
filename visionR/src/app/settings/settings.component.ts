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
  public category: string;
  constructor(
    private router: Router
  ) {
    this.endpointComputerVision = localStorage.getItem('EndpointComputerVision');
    this.computerVisionKey = localStorage.getItem('ComputerVisionKey');
    this.backendEndpoint = localStorage.getItem('BackendEndpoint');
    this.category = localStorage.getItem('Category');
  }

  ngOnInit() {
  }
  setSettings() {
    localStorage.setItem('EndpointComputerVision', this.endpointComputerVision);
    localStorage.setItem('ComputerVisionKey', this.computerVisionKey);
    localStorage.setItem('BackendEndpoint', this.backendEndpoint);
    localStorage.setItem('Category', this.category);
    this.router.navigate(['home']);
  }
}
