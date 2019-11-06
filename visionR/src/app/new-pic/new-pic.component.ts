import { Component, OnInit } from '@angular/core';
import { ComputerVisionService } from '../services/computer-vision.service';
import { VisionResult } from '../model/vision-result';
import { BackendService } from '../services/backend.service';
import { UpdateService } from '../services/update.service';

@Component({
  selector: 'app-new-pic',
  templateUrl: './new-pic.component.html',
  styleUrls: ['./new-pic.component.css']
})
export class NewPicComponent implements OnInit {
  public url: string;
  public lastUrl: string;
  public dataFromVision: VisionResult;
  public isCategory: boolean;
  public isAdult: boolean;
  public category: string;
  constructor(
    private computerVisionService: ComputerVisionService,
    private backendService: BackendService,
    private updateService: UpdateService
  ) {
    this.isCategory = false;
    this.isAdult = true;
    this.category = localStorage.getItem('Category');
   }

  ngOnInit() {
  }
  addPicture() {
    this.computerVisionService.getDataOfPicture(this.url).subscribe(
      (result) => {
        this.dataFromVision = result;
        this.dataFromVision.categories.forEach( e => {
          if (e.name.includes(this.category)) {
            this.isCategory = true;
          }
        });
        if (!this.isCategory) {
          this.dataFromVision.tags.forEach(e => {
            if (e.name === this.category) {
              this.isCategory = true;
            }
          });
        }
        this.isAdult = this.dataFromVision.adult.isAdultContent ? true : this.dataFromVision.adult.isRacyContent ? true : false;
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
        this.updateService.updateGallery(true);
      }
    );
    this.cancel();
  }
  cancel() {
    this.lastUrl = null;
    this.dataFromVision = null;
    this.isCategory = false;
  }
}
