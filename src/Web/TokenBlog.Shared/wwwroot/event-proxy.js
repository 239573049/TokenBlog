function addOnmouseenter (id,DotNet,methode) {
    document.getElementById(id).onmouseenter = function () {
        DotNet.invokeMethodAsync(methode);
    };
}

function addOnmouseleave (id,DotNet,methode) {
    document.getElementById(id).onmouseleave = function () {
        DotNet.invokeMethodAsync(methode);
    };
}

export {
    addOnmouseenter,
    addOnmouseleave
}