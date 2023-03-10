let addPersonTextbox=document.getElementById("addPersonText");
let addPersonButton=document.getElementById("addPersonButton");
let PersonSendToServer=document.getElementById("addPersonSendToServer");
let persons=[];

addPersonButton.addEventListener("click",()=>{
    
    persons.push(addPersonTextbox.value);
    addPersonTextbox.value='';
    console.log('hhhhh');
})

PersonSendToServer.addEventListener("click",()=>{
   
    sessionStorage.setItem("persons",JSON.stringify(persons));
})
