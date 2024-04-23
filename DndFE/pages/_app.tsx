import '../styles/globals.css'
import type { AppProps } from 'next/app'
import NavbarComponent from "../components/NavbarComponent/NavbarComponent";
import PageLayout from "../components/PageLayout";
import dynamic from "next/dynamic";
import { Suspense } from 'react';

const DynamicLayout = dynamic(() => import('../components/PageLayout'), {
    suspense: true,
})

function MyApp({ Component, pageProps }: AppProps) {


    return (

        // <PageLayout>
        //     <Component {...pageProps} />
        // </PageLayout>
        <Suspense fallback={`Loading...`}>
            <DynamicLayout>
                <Component className={"bg-setter"} {...pageProps} />
            </DynamicLayout>
        </Suspense>
    )
}

export default MyApp
