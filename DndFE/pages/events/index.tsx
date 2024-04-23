import type { NextPage } from 'next'
import Head from 'next/head'
import Image from 'next/image'
import { FacebookProvider, Like,EmbeddedPost, Page  } from 'react-facebook';
import {FontAwesomeIcon} from "@fortawesome/react-fontawesome";
import {faAmazon, faApple, faItunes, faSpotify} from "@fortawesome/free-brands-svg-icons";
import {Dialog, Transition} from "@headlessui/react";
import {Fragment, useEffect, useState} from "react";
import {CalendarIcon, LocationMarkerIcon} from "@heroicons/react/solid";
import moment from "moment";
import {GalleryService} from "../../helpers/GalleryService";
import {EventService} from "../../helpers/EventService";

const promoImages = [
    {image: "/images/press_kit/promo_6.webp"},
    {image: "/images/press_kit/promo_7.jpg"},
    {image: "/images/press_kit/promo_1.jpeg"},
    {image: "/images/press_kit/promo_2.jpeg"},
    {image: "/images/press_kit/promo_4.jpeg"},
    {image: "/images/press_kit/promo_5.jpeg"},
    {image: "/images/press_kit/promo_3.png"},

]



const Events: NextPage = (props: any) => {


        return (
        <>
            <h2 className="text-3xl dndHeader text-center tracking-tight sm:text-4xl pt-2 pb-5">Upcoming Events</h2>

            <div>
                <div className="relative pt-5 pb-20 px-4 sm:px-6">
                    <ul role="list" className="divide-y bg-slate-200 divide-gray-400 divide-5">
                        {props.events.items?.map((event: any) => (

                            <li key={event.id}>
                                <a href={'http://maps.google.com/?q=' +  event.location } className="pt-4 block hover:bg-gray-50">
                                    <div className="px-4 py-4 sm:px-6">
                                        <div className="flex items-center justify-between">
                                            <p className="text-sm font-medium text-indigo-600 truncate">{event.summary}</p>
                                            <div className="ml-2 flex-shrink-0 flex">
                                                <p className="px-2 inline-flex text-xs leading-5 font-semibold rounded-full bg-green-100 text-green-800">
                                                    {/*{position.type}*/}
                                                </p>
                                            </div>
                                        </div>
                                        <div className="mt-2 sm:flex sm:justify-between">
                                            <div className="sm:flex">
                                                <p className="flex items-center text-sm text-gray-500">
                                                    <LocationMarkerIcon className="flex-shrink-0 mr-1.5 h-5 w-5 text-gray-400" aria-hidden="true" />
                                                    {event.location}
                                                </p>

                                            </div>
                                            <div className="mt-2 flex items-center text-sm text-gray-500 sm:mt-0">
                                                <CalendarIcon className="flex-shrink-0 mr-1.5 h-5 w-5 text-gray-400" aria-hidden="true" />
                                                <p>


                                                    <b>{event.start.dateTime == null ? "Weekends from:  " : "Date: "}</b>
                                                    {event.start.dateTime == null ? moment(event.start.date).format('MM-DD-YYYY') : moment(event.start.dateTime).format('MM-DD-YYYY')}

                                                    <b>{event.end.dateTime == null ? "   To:  " : ""}</b>
                                                    {event.start.dateTime == null ? moment(event.end.date).format('MM-DD-YYYY') : ""}

                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                            </li>
                        ))}
                    </ul>
                </div>
            </div>
        </>
    )
}

export async function getServerSideProps(context?:any, token?: string) {
    // let randomToken = uuidv4();
    let randomToken = Math.floor(Math.random() * 1000000000000000000000).toString();
    const eventService: EventService = EventService.getInstance(randomToken);
    const events = await eventService.getEvents();



    console.log("events comes backa s", events);


    return {
        props: {
            events:events,
        },
    }
}

export default Events;
