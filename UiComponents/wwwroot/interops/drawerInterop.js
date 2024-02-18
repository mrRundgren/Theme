export function toggleDrawer() {
    let drawer = document.getElementById('uiComponents__Drawer');
    let body = document.body;
    let state = drawer.attributes.getNamedItem("data-state");

    drawer.removeEventListener("mousedown", drawer__drawerEventListener);
    body.removeEventListener("mousedown", drawer__bodyEventListener);

    drawer.addEventListener("mousedown", drawer__drawerEventListener);
    body.addEventListener("mousedown", drawer__bodyEventListener);

    if (drawer.hasAttribute("data-state") && state.value === "open") {
        drawer.setAttribute("data-toggle", "closed");
    } else if (drawer.hasAttribute("data-state") && state.value === "closed") {
        drawer.setAttribute("data-state", "open");
    }
}

const drawer__drawerEventListener = e => {
    e.stopPropagation();
};

const drawer__bodyEventListener = e => {
    let drawer = document.getElementById('uiComponents__Drawer');
    drawer.setAttribute("data-state", "closed");
};