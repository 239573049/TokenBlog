/** 将byte转url对象 */
export function byteToUrl(blob) {
    // 适配webview和web 
    const myBlob = new Blob([blob], {type: "image/png"});
    return (window.URL || window.webkitURL || window || {}).createObjectURL(myBlob);
}

export function clickDom(id) {
    document.getElementById(id).click();
}

/**
 * 释放url对象，因为createObjectURL创建的对象一直会存在可能会占用过多的内存，请注意释放
 */
export function revokeUrl(url) {
    (window.URL || window.webkitURL || window || {}).revokeObjectURL(url);
}

export function getToken() {
    return localStorage.getItem('token');
}

export function setToken(value) {
    localStorage.setItem('token', value);
}

export function setLocalStorage(key, value) {
    localStorage.setItem(key, value);
}

export function getLocalStorage(key) {
    return localStorage.getItem(key);
}

export function scrollHeight(id) {
    const message = document.getElementById(id);
    message.scrollTop = message.scrollHeight;
}