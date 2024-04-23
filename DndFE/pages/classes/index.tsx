import Link from 'next/link'
import {useRouter} from "next/router";
import {ClassesService} from "../../helpers/ClassesService";
import {GalleryService} from "../../helpers/GalleryService";




function Classes(props: any) {
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
                            {props.classes?.map((_class: any,) => (
                                <div key={_class?.index}>


                                        <li key={_class?.index}>
                                            <div className="space-y-4">
                                                <div className="aspect-w-3 aspect-h-2">
                                                    <Link
                                                        href={{
                                                            // pathname: `gallery/${gallery.gallery_short_name}/displaygallery/${gallery.gallery_short_name}/display`,
                                                             pathname: `/`,
                                                            query: {
                                                                class_name: _class?.name,
                                                            }
                                                        }}
                                                    >
                                                    <h1>{_class?.name}</h1>
                                                    </Link>

                                                </div>

                                                <div className="space-y-2">
                                                    <div className="text-lg text-center leading-6 font-medium dndFont space-y-1">
                                                        {/*<h3>{gallery.gallery_name}</h3>*/}
                                                        {/*<p className="text-indigo-600">{person.role}</p>*/}
                                                    </div>
                                                </div>
                                            </div>
                                        </li>

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
    //let randomToken = Math.floor(Math.random() * 1000000000000000000000).toString();
    const classesService: ClassesService = ClassesService.getInstance();
    const classes = await classesService.getClasses();

    console.log(classes);
    return {
        props: {
            classes:classes?.results,
        },
    }
}

export default Classes
