import Link from 'next/link'
import {useRouter} from "next/router";
import {ClassesService} from "../../helpers/ClassesService";
import {GalleryService} from "../../helpers/GalleryService";
import {className} from "postcss-selector-parser";




function Classes(props: any) {
    const router = useRouter();

    return (
        <>

            <div className="bg-setter">
                <div className="mx-auto px-4 max-w-7xl sm:px-6 lg:px-8 pt-2">
                    <h2 className="text-3xl dndHeader text-center tracking-tight sm:text-4xl">Classes</h2>
                    <div className="space-y-12">
                        <div className="space-y-5 sm:space-y-4 md:max-w-xl lg:max-w-3xl xl:max-w-none">

                        </div>
                        <ul
                            className="space-y-8 sm:grid sm:grid-cols-2 sm:gap-x-6 sm:gap-y-12 sm:space-y-0 lg:grid-cols-5 lg:gap-x-8"
                        >
                            {props.classes?.map((_class: any,) => (
                                <div key={_class?.index}>

                                    <Link
                                        href={{
                                            pathname: `classes/${_class?.index}`,

                                        }}

                                    >
                                    <li
                                        key={_class?.index}
                                        className="col-span-1 flex flex-col divide-y divide-gray-200  bg-white text-center shadow"
                                    >


                                        <div className="flex flex- flex-col p-2">
                                            {/*<img className="mx-auto h-60 w-60 flex-shrink-0 " src={album.img} alt="" />*/}
                                            <h3 className=" mt-6 text-sm font-medium text-gray-900">{_class?.className}</h3>
                                            <img className="mx-auto h-60 w-60 flex-shrink-0 " src={_class?.img} alt="" />
                                            <div

                                                className="text-gray-500 px-3 py-2 rounded-md text-3xl font-lg m-lg-auto justify-content-end"
                                            >
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
    const classesService: ClassesService = ClassesService.getInstance();
    const classes = await classesService.getClasses();

    console.log(classes);


    //classes.results?.push(className(className));
    classes?.results.map((_class: any,) => (
        _class.className = _class.index.toUpperCase(),
        _class.img  = `/images/class_icons/${_class.className}.svg`
    ))

    //console.log(classes);
    return {
        props: {
            classes:classes?.results,
        },
    }
}

export default Classes
