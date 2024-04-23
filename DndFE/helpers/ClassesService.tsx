import {HTTPBaseService} from "./HTTPBaseService";


export class ClassesService extends HTTPBaseService {
    private static classintance?:ClassesService;
    public static getInstance() {
        // if( !this.classintance ) {
        //     this.classintance = new GalleryService(token);
        // }
        // this.classintance.token = token;
        this.classintance = new ClassesService();
        return this.classintance;
    }
    public getClasses = () => {

        // console.log(`${process.env.NEXT_PUBLIC_BASE_API_URL}/gallery/getGalleries`);async getClasses() {
                return fetch(`${process.env.NEXT_PUBLIC_BASE_API_URL}/dynamicGetAll/classes`)
                    .then(response => {
                        // @ts-ignore
                        return response?.json() || response?.redirect || {};
                    });

    }

    public getGalleryImages = (galleryId:string) => {
        // console.log(`tacos are: ${process.env.NEXT_PUBLIC_BASE_API_URL}/gallery/findGallery/${galleryId}`);
        return fetch(`${process.env.NEXT_PUBLIC_BASE_API_URL}/gallery/findGallery/${galleryId}`)
            .then(response => {
                // @ts-ignore
                return response?.json() || response?.redirect || {};
            });
  }

}
