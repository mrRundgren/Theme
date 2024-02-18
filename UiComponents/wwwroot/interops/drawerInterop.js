export function open(className) {
    let aside = document.getElementById('uiComponents__Drawer');
    aside.classList.add(className);
}

function asideOutsideClickHandler(e) {
    const rect = e.target.getBoundingClientRect();
    const clickedInAside = (
        rect.top <= e.clientY &&
        e.clientY <= rect.top + rect.height &&
        rect.left <= e.clientX &&
        e.clientX <= rect.left + rect.width
    );

    if (clickedInAside === false)
        e.target.close();
}