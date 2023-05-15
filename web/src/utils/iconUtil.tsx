const Praise = (color: string = '#ffffff') => {
    return (
        <svg className="icon" viewBox="0 0 1024 1024" version="1.1" xmlns="http://www.w3.org/2000/svg" width="28" height="28" >
            <path d="M554.666667 469.333333l-42.666667-85.333333h-42.666667v256h213.333334v-170.666667h-128z m-128-42.666666V341.333333h119.466666l38.4 85.333334H725.333333v256h-298.666666v-256z m106.666666 469.333333C332.8 896 170.666667 733.866667 170.666667 533.333333S332.8 170.666667 533.333333 170.666667 896 332.8 896 533.333333 733.866667 896 533.333333 896z m0-42.666667c174.933333 0 320-145.066667 320-320S708.266667 213.333333 533.333333 213.333333 213.333333 358.4 213.333333 533.333333 358.4 853.333333 533.333333 853.333333zM341.333333 426.666667h42.666667v256H341.333333v-256z" fill={color} >
            </path>
        </svg >
    )
}

const Download = (color: string = '#ffffff') => {
    return (
        <svg className="icon" viewBox="0 0 1024 1024" version="1.1" xmlns="http://www.w3.org/2000/svg" width="21" height="21">
            <path d="M551.783587 591.158874 551.783587 249.237481 472.216413 249.237481 472.216413 591.160921 336.806397 455.740672 280.542976 512.00921 511.995395 743.448326 743.454978 512.00921 687.192579 455.740672Z" >
            </path>
            <path d="M982.400045 313.280076c-25.713638-60.794621-62.521962-115.3921-109.403712-162.27385-46.880727-46.879704-101.477182-83.691097-162.272827-109.403712-62.950727-26.626427-129.811508-40.126906-198.727087-40.126906-68.915579 0-135.778406 13.500479-198.72811 40.126906-60.794621 25.712615-115.390054 62.524009-162.269757 109.403712-46.879704 46.88175-83.687004 101.479229-109.400642 162.27385-26.624381 62.951751-40.123836 129.813554-40.123836 198.727087 0 68.915579 13.499455 135.77636 40.123836 198.72504 25.713638 60.794621 62.520939 115.390054 109.400642 162.269757 46.879704 46.87868 101.475136 83.687004 162.269757 109.399619 62.949704 26.624381 129.811508 40.122813 198.72811 40.122813s135.777383-13.498432 198.727087-40.122813c60.795645-25.712615 115.3921-62.521962 162.272827-109.399619 46.880727-46.879704 83.689051-101.475136 109.403712-162.269757 26.625404-62.949704 40.124859-129.810484 40.124859-198.72504C1022.525927 443.093631 1009.025449 376.230804 982.400045 313.280076zM679.751097 909.096017c-53.122895 22.468734-109.563348 33.861202-167.754678 33.861202-58.182121 0-114.617457-11.392468-167.738305-33.861202-51.316759-21.703301-97.407494-52.780087-136.993071-92.363617-39.585577-39.58353-70.663386-85.672218-92.368734-136.986931-22.470781-53.119825-33.864272-109.556185-33.864272-167.738305 0-58.18826 11.394515-114.63076 33.864272-167.754678 21.705348-51.316759 52.783157-97.40954 92.368734-136.995117 39.584554-39.58353 85.675288-70.660316 136.992047-92.365664 53.120848-22.468734 109.556185-33.861202 167.738305-33.861202 58.19133 0 114.631784 11.392468 167.754678 33.861202 51.316759 21.705348 97.40647 52.782134 136.988977 92.365664s70.656223 85.676311 92.360548 136.995117c22.466688 53.121871 33.858132 109.563348 33.858132 167.754678 0 58.184167-11.391445 114.620527-33.858132 167.738305-21.704324 51.316759-52.77804 97.40647-92.359524 136.986931C777.157567 856.314906 731.067856 887.392716 679.751097 909.096017z" >
            </path>
        </svg>
    )
}

export {
    Praise,
    Download
}