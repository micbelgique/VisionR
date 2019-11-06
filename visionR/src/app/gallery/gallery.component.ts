import { Component, OnInit } from '@angular/core';
import { BackendService } from '../services/backend.service';
import { MatBottomSheet } from '@angular/material';
import { BottomSheetDetailsComponent } from '../bottom-sheet-details/bottom-sheet-details.component';
import { CategoryGallery } from '../model/category-gallery';
import { UpdateService } from '../services/update.service';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrls: ['./gallery.component.css']
})
export class GalleryComponent implements OnInit {

  public pictures;
  public category: string;
  public categoryGalleries: CategoryGallery[];
  constructor(
    private backendService: BackendService,
    private bottomSheet: MatBottomSheet,
    private updateService: UpdateService
  ) {
    this.category = localStorage.getItem('Category');
    this.pictures = [];
    this.categoryGalleries = [];
    this.updateService.updatePicture$.subscribe(
      result => {
        if (result) {
          window.location.reload();
        }
      }
    );
   }

  ngOnInit() {
    this.backendService.getAllPictures().subscribe(
      (result) => {
        result.forEach(e => {
          if (e.visionResult.categories.find(x => x.name.includes(this.category))
          || e.visionResult.tags.find(x => x.name.includes(this.category))) {
            if (e.visionResult.categories.length > 0) {
              const categoryFull = e.visionResult.categories.find(y => y.name.includes(this.category));
              const cat = categoryFull !== undefined ? categoryFull.name : '';
              const subCategory = cat.split('_')[1];
              if (this.categoryGalleries.find(x => x.name === subCategory) === undefined && subCategory) {
                this.categoryGalleries.push({
                  name: subCategory,
                  listImages: []
                });
                this.categoryGalleries.find(x => x.name === subCategory).listImages.push(e);
              } else if (subCategory) {
                this.categoryGalleries.find(x => x.name === subCategory).listImages.push(e);
              } else {
                if (this.categoryGalleries.find(x => x.name === 'uncategorized') === undefined) {
                  this.categoryGalleries.push({
                    name: 'uncategorized',
                    listImages: []
                  });
                }
                this.categoryGalleries.find(x => x.name === 'uncategorized').listImages.push(e);
              }
            } else {
              if (this.categoryGalleries.find(x => x.name === 'uncategorized') === undefined) {
                this.categoryGalleries.push({
                  name: 'uncategorized',
                  listImages: []
                });
              }
              this.categoryGalleries.find(x => x.name === 'uncategorized').listImages.push(e);
            }
            this.pictures.push(e);
          }
        });
      }
    );
  }
  getDetails(id: number): void {
    const picture = this.pictures.find(x => x.id === id);
    this.bottomSheet.open(BottomSheetDetailsComponent, {data: picture.visionResult});
  }

}
