import Link from 'next/link'
import {useRouter} from "next/router";
import {GalleryService} from "../../helpers/GalleryService";

function Gallery(props: any) {
    const router = useRouter();

    return (
        <>

            <div className="bg-setter">
                <div className="mx-auto px-4 max-w-7xl sm:px-6 lg:px-8 pt-2">
                    <h2 className="text-3xl dndHeader text-center tracking-tight sm:text-4xl">Galleries</h2>
                    <div className="space-y-12">
                        <div className="space-y-5 sm:space-y-4 md:max-w-xl lg:max-w-3xl xl:max-w-none">

                        </div>
                        <ul
                            className="space-y-12 sm:grid sm:grid-cols-2 sm:gap-x-6 sm:gap-y-12 sm:space-y-0 lg:grid-cols-3 lg:gap-x-8"
                        >
                            {props.galleries?.map((gallery: any,) => (
                                <div key={gallery.id}>
                                    {/*<Link href=(pathname:`/gallery/${gallery.id}/display`,})>*/}
                                    <Link
                                        href={{
                                            pathname: `gallery/${gallery.gallery_short_name}/display`,
                                            query: {
                                                gallery_name: gallery.gallery_name,
                                            }
                                        }}

                                    >
                                        <li key={gallery.name}>
                                            <div className="space-y-4">
                                                <div className="aspect-w-3 aspect-h-2">
                                                    <img className="gallery-thumb object-cover  object-fit h-96 w-96 shadow-lg rounded-lg rounded-md" src={gallery.gallery_main_image} alt="" />
                                                </div>

                                                <div className="space-y-2">
                                                    <div className="text-lg text-center leading-6 font-medium dndFont space-y-1">
                                                        <h3>{gallery.gallery_name}</h3>
                                                        {/*<p className="text-indigo-600">{person.role}</p>*/}
                                                    </div>
                                                </div>
                                            </div>
                                        </li>
                                    </Link>
                                </div>

                            ))}
                        </ul>
                    </div>
                </div>
            </div>
        </>
    )
}

export async function getServerSideProps(context?:any, token?: string) {
    // let randomToken = uuidv4();
    let randomToken = Math.floor(Math.random() * 1000000000000000000000).toString();
    const galleryService: GalleryService = GalleryService.getInstance(randomToken);
    const galleries = await galleryService.getGalleries();

    console.log(galleries);

    return {
        props: {
            galleries:galleries,
        },
    }
}

export default Gallery
