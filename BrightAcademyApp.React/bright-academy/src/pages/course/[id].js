import axios from 'axios';
import { useRouter } from 'next/router';
import React, { useEffect, useState } from 'react'

export default function CourseDetail() {
    const [course, setCourses] = useState();
    const router = useRouter();
    const { id } = router.query;


    useEffect(() => {
        const getData = async () => {
            try {
                const response = await fetch('https://localhost:7263/api/Courses');
                const data = await response.json();
                setCourses(data.data && data.data.find((c) => c.id === Number(id)));
            } catch (err) {
                console.log(err);
            }
        };
        getData();
    }, [id]);
    console.log(course);

    return (
        <>
            <section className="text-gray-600 body-font">
                <div className="container px-5 py-24 mx-auto flex flex-col">
                    <div className="lg:w-4/6 mx-auto">
                        <div className="rounded-lg h-64 overflow-hidden">
                            <img alt="content" className="object-cover object-center h-full w-full" src={`/images/${course?.imageUrl}`} />
                        </div>
                        <div className="flex flex-col sm:flex-row mt-10">
                            <div className="sm:w-1/3 text-center sm:pr-8 sm:py-8">
                                <div className="w-20 h-20 rounded-full inline-flex items-center justify-center bg-gray-200 text-gray-400">
                                    <svg fill="none" stroke="currentColor" strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" className="w-10 h-10" viewBox="0 0 24 24">
                                        <path d="M20 21v-2a4 4 0 00-4-4H8a4 4 0 00-4 4v2"></path>
                                        <circle cx="12" cy="7" r="4"></circle>
                                    </svg>
                                </div>
                                <div className="flex flex-col items-center text-center justify-center">
                                    <h2 className="font-medium title-font mt-4 text-gray-900 text-lg">Eğitmen : {course?.traniners[0].firstName} {course?.traniners[0].lastName} </h2>
                                    <div className="w-12 h-1 bg-indigo-500 rounded mt-2 mb-4"></div>
                                    <p className="text-base">Eğitimi : {course?.traniners[0].education}</p>
                                </div>
                            </div>
                            <div className="sm:w-2/3 sm:pl-8 sm:py-8 sm:border-l border-gray-200 sm:border-t-0 border-t mt-4 pt-4 sm:mt-0 text-center sm:text-left">
                                <p className="leading-relaxed text-lg mb-4" style={{ fontWeight: 'bold' }}>{course?.name}</p>
                                <p className="leading-relaxed text-lg mb-4"><span style={{ color: 'red', fontSize: '20px' }}>Eğitim içeriği :</span> {course?.educationTitle}</p>
                                <p className="leading-relaxed text-lg mb-4"><span style={{ color: 'blue', fontSize: '20px' }}>Eğitim Saati :</span> {course?.courseHours} saat</p>



                                <button class="flex mt-16 text-white bg-indigo-500 border-0 py-2 px-8 focus:outline-none hover:bg-indigo-600 rounded text-lg">Eğitimi Satın Al</button>

                            </div>
                        </div>
                    </div>
                </div >
            </section >
        </>
    )
}
