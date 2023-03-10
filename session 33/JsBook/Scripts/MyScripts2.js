var button = document.querySelector("#myButton");
button.addEventListener("mousedown", mousePressed, false);
button.addEventListener("mouseup", mouseReleased, false);
button.addEventListener("click", mouseClicked, false);
button.addEventListener("mousemove", mouseIsMoving, false);
document.addEventListener("mousewheel", mouseWheeling, false);
document.addEventListener("DOMMouseScroll", mouseWheeling, false);
function mouseIsMoving() {
    console.log("Mouse is above button!");
}
function mousePressed() {
    console.log("Mouse is down!");
}
function mouseReleased() {
    console.log("Mouse is up!");
}
function mouseClicked() {
    console.log("Mouse is clicked!");
}
function mouseWheeling(e) {
    console.log(e);
    var scrollDirection = e.wheelDelta || -1 * e.detail;
    if (scrollDirection > 0) {
        console.log("Scrolling up! ");
    } else {
        console.log("Scrolling down! ");
    }
}