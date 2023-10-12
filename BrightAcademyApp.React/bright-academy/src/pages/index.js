import React, { useEffect, useState } from 'react'
import axios from 'axios';
import Axios from 'axios';
import { Inter } from 'next/font/google'
import Head from 'next/head';
import Main from '@/components/Main';



const inter = Inter({ subsets: ['latin'] })

export default function Home() {
  const [courses, setCourses] = useState([])
  useEffect(() => {
    axios
      .get('https://localhost:7263/api/Courses')
      .then(response => setCourses(response.data.data));

  }, [])

  console.log(courses);

  return (
    <>
      <Head>
        <title>Bright Academy</title>
        <meta name="description" content="Bright Academy Yazılım Eğitimleri" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="icon" href="/favicon.ico" />
      </Head>
      <Main courses={courses} />
    </>
  )
}
