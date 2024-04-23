import type { NextPage } from 'next'
import Head from 'next/head'
import Image from 'next/image'
import styles from '../styles/Home.module.css'
import NavbarComponent from "../components/NavbarComponent/NavbarComponent";
import {Feed} from "@knocklabs/client";

const Home: NextPage = () => {

    //keeps app alive
    const http = require("http");
    setInterval(function() {
        http.get("/");
    }, 300000); // every 5 minutes (300000)


    return (
    <>


        <div className="bg-setter pb-2" >


            <div className="max-w-7xl mx-auto">
                <div className="text-center">
                    <div className="mt-3 max-w-2xl mx-auto text-xl text-slate-800 sm:mt-4 dndFont ">

                    <h2 className="text-3xl tracking-tight headerShadow text-slate-1000 sm:text-4xl dndFont ">My 5th Edition D&D Test App</h2>
                    </div>




                </div>

            </div>


        </div>
    </>
    )

}

export default Home
