export class ComputerVisionService {
    private endpoint: string;
    private key: string;

    constructor() {
        this.key = localStorage.getItem('ComputerVisionKey');
        this.endpoint = localStorage.getItem('EndpointComputerVision');
    }
    public getDataOfPicture(url: string) {

    }
}
