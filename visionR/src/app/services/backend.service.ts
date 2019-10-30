import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { VisionResult } from '../model/vision-result';

@Injectable({
  providedIn: 'root'
})
export class BackendService {
  private endpoint: string;
  constructor(
    private httpClient: HttpClient
  ) {
    this.endpoint = localStorage.getItem('BackendEndpoint');
  }
  public getAllPictures(): Observable<any> {
    return this.httpClient.get(this.endpoint + 'api/picture');
  }
  public sendPicture(url: string, visionResult: VisionResult): Observable<any> {
    const body = {
      url,
      visionResult
    };
    return this.httpClient.post(this.endpoint + 'api/picture', body);
  }
}
