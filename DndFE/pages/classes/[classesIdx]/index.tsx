import Image from 'next/image'
import {useRouter} from "next/router";
import { GalleryService } from '../../../helpers/GalleryService'
import {Fragment, useState} from "react";
import { Dialog, Transition } from '@headlessui/react';
import {ClassesService} from "../../../helpers/ClassesService";

function DisplayClassPage(props: any) {
    const router = useRouter();
    const [openModal, setOpenModal] = useState(false);
    const [selectedImage, setSelectedImage] = useState('');
    const [classData, setClassData] = useState(null);
    const handleClickedImage = (image: any) => {
        setSelectedImage(image);
        setOpenModal(true);
    }

    console.log(props)
    return (
        <>
            <section className="overflow-hidden text-gray-700 ">
                        <h2 className="text-3xl dndHeader text-center tracking-tight sm:text-4xl">  {props.classData?.name}</h2>
                <div className="container px-5 py-2 mx-auto lg:pt-12 lg:px-32">
                    <div className="flex flex-wrap -m-1 md:-m-2">






                    </div>
                </div>

            </section>



        </>




    )
}

export async function getServerSideProps(context?:any) {

    const classesService: ClassesService = ClassesService.getInstance();
    //const classes = await classesService.getClasses();

    const id = context.params?.classesIdx;
    const classData = await classesService.getClassData(id);
    // console.log('id is',id);
    // console.log('classData is',classData);
    //const classData = await classesService.getClassData(id);

    return {
        props: {
            classData: classData,
        },
    }
}

export default DisplayClassPage
