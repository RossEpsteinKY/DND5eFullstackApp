/* This example requires Tailwind CSS v2.0+ */
import { Fragment } from 'react'

import {useEffect, useState} from "react";
import { Disclosure, Menu, Transition } from '@headlessui/react'
import { BellIcon, MenuIcon, XIcon } from '@heroicons/react/outline'
import {useRouter} from "next/router";
import {faFacebook, faFacebookF, faInstagram, faTiktok, faYoutube} from "@fortawesome/free-brands-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";

import Link from "next/link";



// const [activeTab, setActiveTab] = useState(navigation);
//
// const navigation = [
//     { name: 'Home', href: '/', current: true},
//     { name: 'Media', href: '/media', current: false },
//     { name: 'Gallery', href: '/gallery', current: false },
//     { name: 'Presskit', href: '/press-kit', current: false },
//     { name: 'Songs', href: '/songs', current: false },
//
// ]

// @ts-ignore
function NavbarComponent({  ...props }) {

    const router = useRouter();
    
    const navigation = [
        { name: 'Home', href: '/', current: true },
        { name: 'Galleries', href: '/gallery', current: false },


    ]

    // @ts-ignore
    function classNames(...classes) {
        return classes.filter(Boolean).join(' ')
    }

    return (

        <>
            <Disclosure as="nav" className="bg-gray-800">
                {({ open }) => (
                    <>
                        <div className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
                            <div className="flex items-center justify-between h-16">
                                <div className="flex items-center">
                                    <div className="flex-shrink-0">
                                        <h1 className='dndHeader'>5th Ed D&D Helper</h1>
                                    </div>
                                    <div className="hidden  links sm:block sm:ml-6">
                                        <div className="flex space-x-4">

                                            {navigation.map((nav: any,) => (
                                                <Link
                                                    className="text-gray-300  hover:text-white block px-3 py-2 text-base font-medium"
                                                    href={nav.href} key={'main-mobile-nav-nc' + nav.name}>

                                                    <a
                                                        className={classNames(
                                                            router.pathname == nav.href ? 'text-gray-300 block px-3 py-2 rounded-md text-base font-medium app-link-active' : 'hover:text-gray-500 app-link',
                                                            'group flex items-center px-2 py-2 text-base font-medium rounded-md hover:text-blue'
                                                        )}
                                                    >

                                                        {nav.name}
                                                    </a>
                                                </Link>
                                            ))}

                                            {/*                                                                      <h1>{nav.name}</h1>  */}
                                            {/* //                                                                     className="text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium" */}
                                            {/*                                                                 ))} */}

                                            <div

                                                className="text-gray-300 px-3 py-2 rounded-md text-sm font-medium m-lg-auto justify-content-end"
                                            >
                                                <a className="text-white-300 hover:bg-gray-500 p-2" href="https://www.facebook.com/dndTheMad" ><FontAwesomeIcon icon={faFacebook}  /></a>
                                                <a className="text-white-300 hover:bg-gray-500 p-2" href="https://www.tiktok.com/@dndthemad" ><FontAwesomeIcon icon={faTiktok}  /></a>
                                                <a className="text-white-300 hover:bg-gray-500 p-2" href="https://www.youtube.com/channel/UCefE81r5B55wheMVmaxGPfA" ><FontAwesomeIcon icon={faYoutube}  /></a>
                                                <a className="text-white-300 hover:bg-gray-500 p-2" href="https://www.instagram.com/dndthemad/"><FontAwesomeIcon icon={faInstagram}  /></a>

                                            </div>


                                        </div>

                                    </div>
                                </div>
                                <div className="hidden sm:ml-6 sm:block">
                                    <div className="flex items-center">

                                        {/* Profile dropdown */}
                                        <Menu as="div" className="ml-3 relative">
                                            <div>
                                            </div>
                                            <Transition
                                                as={Fragment}
                                                enter="transition ease-out duration-100"
                                                enterFrom="transform opacity-0 scale-95"
                                                enterTo="transform opacity-100 scale-100"
                                                leave="transition ease-in duration-75"
                                                leaveFrom="transform opacity-100 scale-100"
                                                leaveTo="transform opacity-0 scale-95"
                                            >

                                            </Transition>
                                        </Menu>
                                    </div>
                                </div>
                                <div className="-mr-2 flex sm:hidden">
                                    {/* Mobile menu button */}
                                    <Disclosure.Button className="inline-flex items-center justify-center p-2 rounded-md text-gray-400 hover:text-white hover:bg-gray-700 focus:outline-none focus:ring-2 focus:ring-inset focus:ring-white">
                                        <span className="sr-only">Open main menu</span>
                                        {open ? (
                                            <XIcon className="block h-6 w-6" aria-hidden="true" />
                                        ) : (
                                            <MenuIcon className="block h-6 w-6" aria-hidden="true" />
                                        )}
                                    </Disclosure.Button>
                                </div>
                            </div>
                        </div>

                        <Disclosure.Panel className="sm:hidden">
                            <div className="px-2 pt-2 pb-3 space-y-1">
                                {/* Current: "bg-gray-900 text-white", Default: "text-gray-300 hover:bg-gray-700 hover:text-white" */}
                                <Disclosure.Button
                                    as="a"
                                    href="/"
                                    className="bg-gray-900 text-white block px-3 py-2 rounded-md text-base font-medium"
                                >
                                    Home
                                </Disclosure.Button>
                                <Disclosure.Button
                                    as="a"
                                    href="media"
                                    className="text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium"
                                >
                                    Media
                                </Disclosure.Button>
                                <Disclosure.Button
                                    as="a"
                                    href="events"
                                    className="text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium"
                                >
                                    Events
                                </Disclosure.Button>
                                <Disclosure.Button
                                    as="a"
                                    href="gallery"
                                    className="text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium"
                                >
                                    Gallery
                                </Disclosure.Button>
                                <Disclosure.Button
                                    as="a"
                                    href="presskit"
                                    className="text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium"
                                >
                                    Press Kit
                                </Disclosure.Button>
                                <Disclosure.Button
                                    as="a"
                                    href="songs"
                                    className="text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium"
                                >
                                    Songs
                                </Disclosure.Button>
                            </div>

                        </Disclosure.Panel>
                    </>
                )}
            </Disclosure>
        </>
    )
}

export default NavbarComponent;
