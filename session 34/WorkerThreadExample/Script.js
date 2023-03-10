let button=document.getElementById("getMessage");
const workerThread=new Worker("./Script2.js");

button.addEventListener("click",event=>{
    //console.log('button clicked');
    workerThread.postMessage("start");
});

workerThread.onmessage=(e)=>{
    console.log(e.data);
}
