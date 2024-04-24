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
            <section className="overflow-hidden text-gray-700  justify-center items-center ">
                        <h2 className="text-3xl dndHeader text-center tracking-tight sm:text-4xl pb-3">  {classData?.name}</h2>
                {/*<div className="container px-5 py-2 mx-auto lg:pt-12 lg:px-32">*/}
                {/*    <div className="flex flex-wrap -m-1 md:-m-2">*/}

                {/*        /!*<div className="flow-root border center">*!/*/}
                {/*        /!*    <dl className="-my-1 divide-y divide-gray-100 text-sm">*!/*/}
                {/*        /!*        <div className="center grid grid-cols-4 gap-1 py-3 even:bg-gray-50 sm:grid-cols-8 sm:gap-8">*!/*/}
                {/*        /!*            <dt className="font-medium text-gray-900">Class Name:</dt>*!/*/}
                {/*        /!*            <dd className="text-gray-700 sm:col-span-2">{classData?.name}</dd>*!/*/}
                {/*        /!*        </div>*!/*/}
                {/*        */}
                {/*        /!*        <div className="grid grid-cols-1 gap-1 py-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">*!/*/}
                {/*        /!*            <dt className="font-medium text-gray-900">Hit Dice: </dt>*!/*/}
                {/*        /!*            <dd className="text-gray-700 sm:col-span-2">1d{classData?.hit_Die} Per Level</dd>*!/*/}
                {/*        /!*        </div>*!/*/}
                {/*        */}
                {/*        /!*        <div className="grid grid-cols-1 gap-1 py-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">*!/*/}
                {/*        /!*            <dt className="font-medium text-gray-900">Starting Proficiency Choices:</dt>*!/*/}
                {/*        /!*            <dd className="text-gray-700 sm:col-span-2">*!/*/}
                {/*        /!*                {classData?.proficiency_Choices[0].desc}*!/*/}
                {/*        /!*                {classData?.proficiency_Choices[0].from.options.map((choice: any,) => (*!/*/}
                {/*        */}
                {/*        /!*                    <li>*!/*/}
                {/*        /!*                        {choice.item.name}*!/*/}
                {/*        /!*                    </li>*!/*/}
                {/*        /!*                ))}*!/*/}
                {/*        /!*            </dd>*!/*/}
                {/*        /!*        </div>*!/*/}
                {/*        */}
                {/*        /!*        <div className="grid grid-cols-1 gap-1 py-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">*!/*/}
                {/*        /!*            <dt className="font-medium text-gray-900">Starting Proficiencies:</dt>*!/*/}
                {/*        /!*            <dd className="text-gray-700 sm:col-span-2">*!/*/}
                {/*        /!*                {classData?.proficiencies.map((prof: any,) => (*!/*/}
                {/*        */}
                {/*        /!*                    <li>*!/*/}
                {/*        /!*                        {prof.name}*!/*/}
                {/*        /!*                    </li>*!/*/}
                {/*        /!*                ))}*!/*/}
                {/*        /!*            </dd>*!/*/}
                {/*        /!*        </div>*!/*/}
                {/*        */}
                {/*        /!*        <div className="grid grid-cols-1 gap-1 py-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">*!/*/}
                {/*        /!*            <dt className="font-medium text-gray-900">Saving Throws</dt>*!/*/}
                {/*        /!*            <dd className="text-gray-700 sm:col-span-2">*!/*/}
                {/*        /!*                <dd className="text-gray-700 sm:col-span-2">*!/*/}
                {/*        /!*                    {classData?.saving_Throws.map((save: any,) => (*!/*/}
                {/*        */}
                {/*        /!*                        <li>*!/*/}
                {/*        /!*                            {save.name}*!/*/}
                {/*        /!*                        </li>*!/*/}
                {/*        /!*                    ))}*!/*/}
                {/*        /!*                </dd>*!/*/}
                {/*        /!*            </dd>*!/*/}
                {/*        /!*        </div>*!/*/}
                {/*        /!*    </dl>*!/*/}
                {/*        /!*</div>*!/*/}

                {/*    </div>*/}
                {/*</div>*/}
                <div className="flex justify-center items-center flow-root rounded-lg border border-gray-100 py-3 ml-10 mr-10 shadow-sm">
                    <dl className="-my-3 divide-y divide-gray-100 text-sm">
                        <div className="text-center  gap-1 p-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">

                            <div className="sm:col-span-2">
                                <div className="font-medium text-gray-900 dndHeader">
                                    Class Name
                                </div>
                            <div className="text-gray-700 sm:col-span-2">{classData?.name}</div></div>
                        </div>

                        <div className="text-center  gap-1 p-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">

                            <div className="sm:col-span-2">
                                <div className="font-medium text-gray-900 dndHeader">
                                   Hit Dice
                                </div>
                                <div className="text-gray-700 sm:col-span-2">1d{classData?.hit_Die} Per Level</div></div>
                        </div>

                        <div className="text-center  gap-1 p-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">

                            <div className="sm:col-span-2">
                                <div className="font-medium text-gray-900 dndHeader">
                                    Proficiency Choices
                                </div>
                                <div className="text-gray-700 sm:col-span-2">

                                    <i>Choose {classData?.proficiency_Choices[0].choose} from the following:</i>
                                    <ul className="lg:columns-3 pt-3">
                                            {classData?.proficiency_Choices[0].from.options.map((choice: any,) => (

                                                <li className="w-full">
                                                    {choice.item.name}
                                                </li>
                                            ))}
                                    </ul>
                                </div>
                            </div>
                        </div>

                        <div className="text-center  gap-1 p-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">

                            <div className="sm:col-span-2">
                                <div className="font-medium text-gray-900 dndHeader">
                                    Starting Proficiencies
                                </div>
                                <div className="text-gray-700 sm:col-span-2">


                                    <ul className="lg:columns-3 pt-3">
                                        {classData?.proficiencies.map((prof: any,) => (

                                            <li className="w-full">
                                                {prof.name}
                                            </li>
                                        ))}
                                    </ul>
                                </div>
                            </div>
                        </div>

                        <div className="text-center  gap-1 p-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">

                            <div className="sm:col-span-2">
                                <div className="font-medium text-gray-900 dndHeader">
                                    Starting Equipment
                                </div>
                                <div className="text-gray-700 sm:col-span-2">

                                    <div className="font-medium text-gray-900">
                                        <i>Choose {classData?.starting_Equipment_Options[0].choose} from the following:</i>
                                    </div>
                                    <ul className="lg:columns-3 pt-3">
                                        {classData?.starting_Equipment_Options.map((equipment: any,) => (


                                            <li className="w-full pt-8 lg:pt-0">
                                                {equipment.desc}
                                            </li>
                                        ))}
                                    </ul>
                                </div>
                            </div>
                        </div>


                        <div className="text-center  gap-1 p-3 even:bg-gray-50 sm:grid-cols-3 sm:gap-4">

                            <div className="sm:col-span-2">
                                <div className="dndHeader font-medium text-gray-900">
                                    Multiclassing
                                </div>

                                <ul className="lg:columns-1 pt-3">
                                    <div className=" text-gray-900 ">
                                        <b>Ability Scores Required:</b>
                                    </div>

                                    {classData?.multi_Classing.prerequisites?.length >= 1?(
                                        <div>
                                            {classData?.multi_Classing.prerequisites?.map((prereq: any,) => (


                                                <li className="w-full pt-8 lg:pt-2">
                                                    {prereq.minimum_Score} {prereq.ability_Score.name} required to multiclass.
                                                </li>
                                            ))}
                                        </div>
                                    ) : <div><i>No Required Minimum Ability Scores</i></div>}

                                </ul>
                                <br/>
                                <ul className="lg:columns-1 pt-3">
                                    <div className=" text-gray-900 ">
                                        <b>Proficiencies Required:</b>
                                    </div>

                                    {classData?.multi_Classing.proficiencies?.length >= 1?(
                                        <div>
                                        {classData?.multi_Classing.proficiencies.map((prof: any,) => (


                                            <li className="w-full pt-8 lg:pt-2">
                                                Proficiency with <b><i>{prof.name}</i></b> required to multiclass.
                                            </li>
                                        ))}
                                        </div>
                                    ) : <div><i>No Required Proficiencies</i></div>}

                                    {/*{classData?.multi_Classing.proficiencies.map((prof: any,) => (*/}


                                    {/*    <li className="w-full pt-8 lg:pt-2">*/}
                                    {/*        Proficiency with <b><i>{prof.name}</i></b> required to multiclass.*/}
                                    {/*    </li>*/}
                                    {/*))}*/}
                                </ul>


                            </div>
                        </div>

                    </dl>
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
