import NavbarComponent from "./NavbarComponent/NavbarComponent";

// @ts-ignore
export default function PageLayout ({ children, ...props}) {
    return (
        <>
            <NavbarComponent />
            <title>dnd The Mad Skald | Poetic Eddas for the Modern Boozer</title>
                {/* MAIN CONTENT */}
                <div className="py-4">
                    {children}
                </div>
                {/* /End MAIN CONTENT */}

        </>
    )
}
