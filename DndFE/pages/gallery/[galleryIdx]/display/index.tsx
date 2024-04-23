import Image from 'next/image'
import {useRouter} from "next/router";
import { GalleryService } from '../../../../helpers/GalleryService'
import {Fragment, useState} from "react";
import { Dialog, Transition } from '@headlessui/react';

function DisplayGalleryPage(props: any) {
    const router = useRouter();
    const [openModal, setOpenModal] = useState(false);
    const [selectedImage, setSelectedImage] = useState('');

    const handleClickedImage = (image: any) => {
        setSelectedImage(image);
        setOpenModal(true);
    }


    console.log(props)
    return (
        <>
            <section className="overflow-hidden text-gray-700 ">
                        <h2 className="text-3xl dndHeader text-center tracking-tight sm:text-4xl">  {props.gallery?.gallery_name}</h2>
                <div className="container px-5 py-2 mx-auto lg:pt-12 lg:px-32">
                    <div className="flex flex-wrap -m-1 md:-m-2">


                                {props.galleryImages?.map((gallery: any,) => (
                                    <div key={gallery.thumb_url}  className="flex flex-wrap  w-1/4">
                                    <div className="w-full p-1 md:p-2">
                                    <a onClick={() => handleClickedImage(gallery.image_url)}>

                                        <Image width="250%" height="250%" className="block object-cover object-center w-full h-full rounded-lg headerShadow"
                                         src={gallery.thumb_url} alt={props.gallery?.gallery_name} />
                                    </a>
                                    </div>
                                    </div>
                                ))}





                    </div>
                </div>
                <Transition.Root show={openModal} as={Fragment}>
                    <Dialog as="div" className="relative z-10" onClose={setOpenModal}>
                        <Transition.Child
                            as={Fragment}
                            enter="ease-out duration-300"
                            enterFrom="opacity-0"
                            enterTo="opacity-100"
                            leave="ease-in duration-200"
                            leaveFrom="opacity-100"
                            leaveTo="opacity-0"
                        >
                            <div className="fixed inset-0 bg-gray-500 bg-opacity-75 transition-opacity" />
                        </Transition.Child>

                        <div className="fixed inset-0 z-10 overflow-y-auto">
                            <div className="flex min-h-full items-end justify-center p-4 text-center sm:items-center sm:p-0">
                                <Transition.Child
                                    as={Fragment}
                                    enter="ease-out duration-300"
                                    enterFrom="opacity-0 translate-y-4 sm:translate-y-0 sm:scale-95"
                                    enterTo="opacity-100 translate-y-0 sm:scale-100"
                                    leave="ease-in duration-200"
                                    leaveFrom="opacity-100 translate-y-0 sm:scale-100"
                                    leaveTo="opacity-0 translate-y-4 sm:translate-y-0 sm:scale-95"
                                >
                                    <Dialog.Panel className="relative transform overflow-hidden rounded-lg  text-left transition-all max-h-fit  ">

                                        <div className="object-center ">
                                            <img alt={selectedImage} className="max-h-50 max-w-50 min-h-screen max-h-screen object-scale-down" src={selectedImage} />
                                        </div>

                                    </Dialog.Panel>
                                </Transition.Child>
                            </div>
                        </div>
                    </Dialog>
                </Transition.Root>
            </section>



        </>




    )
}

export async function getServerSideProps(context?:any, token?: string) {
    // let randomToken = uuidv4();
    let randomToken = Math.floor(Math.random() * 1000000000000000000000).toString();
    const galleryService: GalleryService = GalleryService.getInstance(randomToken);

    const id = context.params?.galleryIdx;

    console.log('id is',id);
    const galleryImages = await galleryService.getGalleryImages(id);

    return {
        props: {
            galleryImages:galleryImages,
            gallery: context.query
        },
    }
}

export default DisplayGalleryPage
