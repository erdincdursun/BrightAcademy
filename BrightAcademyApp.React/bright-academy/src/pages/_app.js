import Footer from '@/components/Footer'
import Navbar from '@/components/Navbar';
import '@/styles/globals.css'
import { Route, Routes } from 'react-router-dom';
import CourseDetail from './courseDetail';



export default function App({ Component, pageProps }) {

  return (
    <>
      <Navbar />
      <Component {...pageProps} />
      <Footer />
    </>
  )
}

