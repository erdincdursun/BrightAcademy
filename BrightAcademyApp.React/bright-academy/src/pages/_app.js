import Footer from '@/components/Footer'
import Header from '@/components/Header'
import Main from '@/components/Main'
import axios from 'axios'
import '@/styles/globals.css'

export default function App({ Component, pageProps }) {
  return (
    <>
      <Header />
      <Component {...pageProps} />
      <Main />
      <Footer />
    </>
  )
}

