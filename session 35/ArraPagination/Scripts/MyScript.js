let displayCurrIndex=document.getElementById("displayCurrentIndex");
let displayName=document.getElementById("displayName");
let previousButton=document.getElementById("previous");
let nextButton=document.getElementById("next");
let currIndex=-1;
// let arrayPeoples=["one","two","three","four","five","six"];

let arrayPeoples=JSON.parse(sessionStorage.getItem("persons"));


displayCurrIndex.innerHTML=(currIndex+1)+"/"+(arrayPeoples.length);
nextButton.addEventListener("click",()=>{
    
    if(currIndex==arrayPeoples.length-1){
        currIndex=-1;
    }
currIndex++;
displayCurrIndex.innerHTML=(currIndex+1)+"/"+(arrayPeoples.length);
displayName.value=arrayPeoples[currIndex];
});

previousButton.addEventListener("click",()=>{
    
    if(currIndex==0){
        currIndex=arrayPeoples.length;
    }
currIndex--;
displayCurrIndex.innerHTML=(currIndex+1)+"/"+(arrayPeoples.length);
displayName.value=arrayPeoples[currIndex];
});
