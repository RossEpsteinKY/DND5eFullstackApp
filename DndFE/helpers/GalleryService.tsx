/**import {HTTPBaseService} from "./HTTPBaseService";


export class GalleryService extends HTTPBaseService {
    private static classintance?:GalleryService;
    public static getInstance(token: string) {
        if( !this.classintance ) {
            this.classintance = new GalleryService(token);
        }
        this.classintance.token = token;

        return this.classintance;
    }
    public getGalleries = () => {

        console.log(`${process.env.NEXT_PUBLIC_BASE_API_URL}/gallery/getGalleries`);
        return fetch(`${process.env.NEXT_PUBLIC_BASE_API_URL}/gallery/getGalleries`)
            .then(response => {
                // @ts-ignore
                return response?.json() || response?.redirect || {};
            });
    }

    public getGalleryImages = (galleryId:string) => {
        console.log(`tacos are: ${process.env.NEXT_PUBLIC_BASE_API_URL}/gallery/findGallery/${galleryId}`);
        return fetch(`${process.env.NEXT_PUBLIC_BASE_API_URL}/gallery/findGallery/${galleryId}`)
            .then(response => {
                // @ts-ignore
                return response?.json() || response?.redirect || {};
            });
    }


}
**/