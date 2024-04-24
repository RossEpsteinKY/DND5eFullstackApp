import Image from 'next/image'
import {useRouter} from "next/router";

import {Fragment, useState} from "react";

import {ClassesService} from "../../../helpers/ClassesService";


function DisplayClassPage(props: any) {
    const router = useRouter();
    // const [openModal, setOpenModal] = useState(false);
    // const [selectedImage, setSelectedImage] = useState('');
    const [classData, setClassData] = useState(props?.classData);
    // const handleClickedImage = (image: any) => {
    //     setSelectedImage(image);
    //     setOpenModal(true);
    //console.log(props)

    console.log("class data at display", classData);



    return (
        <>
            <section className="overflow-hidden text-gray-700 ">
                        <h2 className="text-3xl dndHeader text-center tracking-tight sm:text-4xl">  {classData?.name}</h2>
                <div className="container px-5 py-2 mx-auto lg:pt-12 lg:px-32">
                    <div className="flex flex-wrap -m-1 md:-m-2">

                        <div className="flow-root border">
                            <dl className="-my-3 divide-y divide-gray-100 text-sm">
                                <div className="grid grid-cols-1 gap-1 py-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">
                                    <dt className="font-medium text-gray-900">Class Name:</dt>
                                    <dd className="text-gray-700 sm:col-span-2">{classData?.name}</dd>
                                </div>

                                <div className="grid grid-cols-1 gap-1 py-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">
                                    <dt className="font-medium text-gray-900">Hit Dice: </dt>
                                    <dd className="text-gray-700 sm:col-span-2">1d{classData?.hit_Die} Per Level</dd>
                                </div>

                                <div className="grid grid-cols-1 gap-1 py-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">
                                    <dt className="font-medium text-gray-900">Starting Proficiency Choices:</dt>
                                    <dd className="text-gray-700 sm:col-span-2">
                                        {classData?.proficiency_Choices[0].desc}
                                        {classData?.proficiency_Choices[0].from.options.map((choice: any,) => (

                                            <li>
                                                {choice.item.name}
                                            </li>
                                        ))}
                                    </dd>
                                </div>

                                <div className="grid grid-cols-1 gap-1 py-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">
                                    <dt className="font-medium text-gray-900">Starting Proficiencies:</dt>
                                    <dd className="text-gray-700 sm:col-span-2">
                                        {classData?.proficiencies.map((prof: any,) => (

                                            <li>
                                                {prof.name}
                                            </li>
                                        ))}
                                    </dd>
                                </div>

                                <div className="grid grid-cols-1 gap-1 py-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">
                                    <dt className="font-medium text-gray-900">Bio</dt>
                                    <dd className="text-gray-700 sm:col-span-2">
                                        Lorem ipsum dolor, sit amet consectetur adipisicing elit. Et facilis debitis
                                        explicabo
                                        doloremque impedit nesciunt dolorem facere, dolor quasi veritatis quia fugit
                                        aperiam
                                        aspernatur neque molestiae labore aliquam soluta architecto?
                                    </dd>
                                </div>
                            </dl>
                        </div>

                    </div>
                </div>

            </section>



        </>




    )
}

export async function getServerSideProps(context?:any) {

    const classesService: ClassesService = ClassesService.getInstance();


    const id = context.params?.classesIdx;
    const classData = await classesService.getClassData(id);


    // console.log('classData is',classData);
    return {
        props: {
            classData: classData,
        },
    }
}

export default DisplayClassPage
