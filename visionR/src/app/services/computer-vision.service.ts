import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { VisionResult } from '../model/vision-result';

@Injectable({
  providedIn: 'root'
})
export class ComputerVisionService {
  private endpoint: string;
    private key: string;

    constructor(
        private httpClient: HttpClient
    ) {
        this.key = localStorage.getItem('ComputerVisionKey');
        this.endpoint = localStorage.getItem('EndpointComputerVision');
    }
    public getDataOfPicture(url: string): Observable<VisionResult> {
        const header = new HttpHeaders({
            'Content-Type': 'application/json',
            'Ocp-Apim-Subscription-Key': this.key
        });
        const body = {url};
        console.log(body);
        return this.httpClient.post<VisionResult>(this.endpoint +
            '/vision/v2.0/analyze?visualFeatures=Adult,Brands,Categories,Color,Description,Faces,ImageType,Objects,Tags&language=en',
            body,
            {headers: header});
    }
}
