import { Component, OnInit } from '@angular/core';
import { BackendService } from '../services/backend.service';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrls: ['./gallery.component.css']
})
export class GalleryComponent implements OnInit {

  public pictures;
  constructor(
    private backendService: BackendService
  ) { }

  ngOnInit() {
    this.backendService.getAllPictures().subscribe(
      (result) => {
        this.pictures = result;
      }
    );
  }

}
