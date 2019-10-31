import { Component, OnInit } from '@angular/core';
import { ComputerVisionService } from '../services/computer-vision.service';
import { VisionResult } from '../model/vision-result';
import { BackendService } from '../services/backend.service';

@Component({
  selector: 'app-new-pic',
  templateUrl: './new-pic.component.html',
  styleUrls: ['./new-pic.component.css']
})
export class NewPicComponent implements OnInit {
  public url: string;
  public lastUrl: string;
  public dataFromVision: VisionResult;
  public isAnimal: boolean;
  constructor(
    private computerVisionService: ComputerVisionService,
    private backendService: BackendService
  ) {
    this.isAnimal = false;
   }

  ngOnInit() {
  }
  addPicture() {
    this.computerVisionService.getDataOfPicture(this.url).subscribe(
      (result) => {
        console.log(result);
        this.dataFromVision = result;
        this.dataFromVision.tags.forEach(element => {
          if (element.name === 'animal') {
            this.isAnimal = true;
          }
        });
      }
    );
    this.lastUrl = this.url;
    this.url = '';
    this.dataFromVision = null;
  }
  addToTheGallery() {
    this.backendService.sendPicture(this.lastUrl, this.dataFromVision).subscribe(
      (result) => {
        console.log(result);
      }
    );
    this.cancel();
  }
  cancel() {
    this.lastUrl = null;
    this.dataFromVision = null;
  }
}
