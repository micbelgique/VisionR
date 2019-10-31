import { Component, OnInit } from '@angular/core';
import { BackendService } from '../services/backend.service';
import { MatBottomSheet } from '@angular/material';
import { BottomSheetDetailsComponent } from '../bottom-sheet-details/bottom-sheet-details.component';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrls: ['./gallery.component.css']
})
export class GalleryComponent implements OnInit {

  public pictures;
  constructor(
    private backendService: BackendService,
    private bottomSheet: MatBottomSheet
  ) { }

  ngOnInit() {
    this.backendService.getAllPictures().subscribe(
      (result) => {
        this.pictures = result;
      }
    );
  }
  getDetails(id: number): void {
    const picture = this.pictures.find(x => x.id === id);
    this.bottomSheet.open(BottomSheetDetailsComponent, {data: picture.visionResult});
  }

}
