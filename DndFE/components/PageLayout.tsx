import NavbarComponent from "./NavbarComponent/NavbarComponent";

// @ts-ignore
export default function PageLayout ({ children, ...props}) {
    return (
        <>
            <NavbarComponent />
            <title>D&D 5th Ed Helper</title>
                {/* MAIN CONTENT */}
                <div className="py-4">
                    {children}
                </div>
                {/* /End MAIN CONTENT */}

        </>
    )
}
