import React from 'react'


export default function login() {
    return (
        <>
            <div className='flex flex-col items-center justify-center min-h-screen py-2 bg-gray-100'>
                <div className='flex flex-col items-center justify-center w-full flex-1 px-20 text-center'>
                    <div className='bg-white rounded-2xl shadow-2xl flex w-2/3 max-w-4xl'>
                        <div className='w-3/5 p-5'>
                            <div className='text-left font-bold'>
                                <span className='text-blue-500'>Bright</span> Academy
                            </div>
                            <div className='py-10'>
                                <h2 className='text-3xl font-bold'>Oturum Aç</h2>

                            </div>
                            <div>
                                <input type="email" name='email' placeholder='Email' className='bg-gray-200 outline-none text-lg flex-1 mb-3' />
                            </div>
                            <div>
                                <input type="password" name='password' placeholder='Password' className='bg-gray-200 outline-none text-lg flex-1' />
                            </div>
                            <a href="#" className='border-2 border-white rounded-full px-12 py-2 inline-block font-semibold hover:bg-white hover:text-blue-500'>
                                Giriş Yap
                            </a>

                        </div>
                        <div className='w-2/5 bg-blue-500 text-white rounded-tr-2xl rounded-br-2xl py-36 px-12'>
                            <h2 className='text-3xl font-bold mb-2'>Merhaba Developer </h2>
                            <div className='border-2 w-10 border-white inline-block mb-2'></div>
                            <p className='mb-10'>
                                Kişisel bilgilerinizi doldurun ve bizimle yolculuğa başlayın
                            </p>
                            <button>Üye ol</button>
                        </div>




                    </div>
                </div>
            </div>
        </>
    )
}
