onmessage=(event)=>{
    if(event.data=="start"){
        postMessage("this message comming from the script2");
    }
}