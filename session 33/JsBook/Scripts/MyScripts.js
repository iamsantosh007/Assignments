document.body.setAttribute("Class","bodyClass");
let h1Element=document.querySelector(".heading");
let diVElement=document.querySelector("#My");
h1Element.textContent="Hello mumbai"; //hello world-->Hello mumbai

diVElement.classList.add("mun");
diVElement.classList.remove("bar");
diVElement.classList.toggle("hello"); //add
diVElement.classList.toggle("hello"); //remove
diVElement.classList.toggle("hello"); //add

console.log(diVElement);
alert(diVElement.classList);



var bodyElement = document.body;

for (var i = 0; i < bodyElement.children.length; i++) {
    var childElement = bodyElement.children[i];
    document.writeln(childElement.tagName);
}


