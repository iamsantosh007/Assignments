let liparent=document.getElementById("liParent");
let textBoxName=document.getElementById("nameTextBox");
let addButton=document.getElementById("addButton");
let tableBody=document.getElementById("tableBody");
let tableBodyRemove=document.getElementById("tableBodyRemove");
let liRemoveTag;
addButton.addEventListener("click",()=>{
    tableBody.innerHTML+=`<tr id="${textBoxName.value}"><td>${textBoxName.value}</td></tr>`;
    liparent.innerHTML+=`<li id="${textBoxName.value}">${textBoxName.value}<button style="height:20px;width:20px;" onClick="DeleteSelected('${textBoxName.value}')">x</button></li>`;
    
    textBoxName.value="";
});

function DeleteSelected(input){
   liRemoveTag=document.getElementById(`${input}`);
   liRemoveTag.remove();
   tableRowRemove=document.getElementById(`${input}`);
   tableRowRemove.remove();
   tableBodyRemove.innerHTML+=`<tr><td>${input}</td></tr>`;
}
