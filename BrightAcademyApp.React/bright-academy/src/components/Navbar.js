import Link from 'next/link'
import React from 'react'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faArrowRightToBracket } from '@fortawesome/free-solid-svg-icons'




export default function Navbar() {
    return (
        <header className="text-white body-font">
            <div className="container mx-auto flex flex-wrap p-2 flex-col md:flex-row items-center" style={{ backgroundColor: '#4e2dc6' }} >
                <a className="flex title-font font-medium items-center text-gray-900 mb-4 md:mb-0">
                    <img src='/images/logo.jpg' style={{ width: '150px', height: '70px' }} />
                </a>
                <nav className="md:mr-auto md:ml-4 md:py-1 md:pl-4 md:border-l md:border-gray-400	flex flex-wrap items-center text-base justify-center">
                    <Link href={"/"} className="mr-5 hover:text-gray-900">Ana Sayfa</Link>
                    <Link href={"/course"} className="mr-5 hover:text-gray-900">Eğitimler</Link>
                    <Link href={"/about"} className="mr-5 hover:text-gray-900">Hakkında</Link>
                    <Link href={"/contact"} className="mr-5 hover:text-gray-900">İletişim</Link>

                </nav>
                <button style={{ margin: '5px', border: '2px solid white', borderRadius: '12px' }} ><Link href={"/register"}><span style={{ margin: '20px', padding: '2px' }}>Kaydol</span> </Link>

                </button>
                <button style={{ margin: '5px', border: '2px solid white', borderRadius: '12px' }} ><Link href={"/login"}> <span style={{ margin: '20px', padding: '2px' }}>Giriş Yap</span>  </Link>
                </button>
            </div>
        </header>
    )
}
