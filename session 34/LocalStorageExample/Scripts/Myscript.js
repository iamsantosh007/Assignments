const player=[
    {srNo:1,name:"santosh",address:"boisar"},
    {srNo:2,name:"patro",address:"palghar"},
    {srNo:3,name:"Ravi",address:"virar"}
];
const tableClass=document.querySelector(".table");
const tableBody=document.querySelector(".tableBody");

let html='';
localStorage.setItem("players",JSON.stringify(player));
const retriveResult=JSON.parse(localStorage.getItem("player"));
//console.log(retriveResult);
//const retriveResult=localStorage.getItem("player");
retriveResult.forEach(element => {
    html+=`<tr>
    <th scope="row">${element.srNo}</th>
    <td>${element.name}</td>
    <td>${element.address}</td>
    
  </tr>`
});
tableBody.innerHTML=html;