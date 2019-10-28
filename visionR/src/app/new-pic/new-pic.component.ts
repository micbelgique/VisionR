import { Component, OnInit } from '@angular/core';
import { ComputerVisionService } from '../services/computer-vision.service';
import { VisionResult } from '../model/vision-result';

@Component({
  selector: 'app-new-pic',
  templateUrl: './new-pic.component.html',
  styleUrls: ['./new-pic.component.css']
})
export class NewPicComponent implements OnInit {
  public url: string;
  public lastUrl: string;
  public dataFromVision: VisionResult;
  constructor(
    private computerVisionService: ComputerVisionService
  ) { }

  ngOnInit() {
  }
  addPicture() {
    this.computerVisionService.getDataOfPicture(this.url).subscribe(
      (result) => {
        console.log(result);
        this.dataFromVision = result;
      }
    );
    this.lastUrl = this.url;
    this.url = '';
  }

}
