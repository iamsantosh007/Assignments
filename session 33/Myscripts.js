"use strict";
let parentLi=document.querySelector(".parentList");
let buttonDice=document.getElementById("buttonForDiceRoll");
let buttonShow=document.getElementById("buttonForShow");
let diceValue=document.querySelector(".diceValueStore");
let occurenceValue=document.querySelector(".occurenceValueStore");
let dict={
    1:0,
    2:0,
    3:0,
    4:0,
    5:0,
    6:0,
};
console.log(dict[1]);
let counter=1;

buttonDice.addEventListener("click",()=>{
        if(counter<=10){
        let x = Math.floor((Math.random() *6) + 1);
       // parentLi.innerHTML+=`<li>The Dice value in ${counter} turn is ${x}</li>`;
       diceValue.innerHTML+=`<tr>The dice value in ${counter} turn is ${x}</tr>`;
        counter++;
        dict[x]=dict[x]+1;
        }
    });

    buttonShow.addEventListener("click",()=>{
        if(counter>=10){
        for(var i=1;i<=6;i++){
            //console.log("The occurence of "+i+" is "+dict[i]+" time");
            occurenceValue.innerHTML+=`<tr>The occurence of ${i} is ${dict[i]} </tr>`;
        }
    }
    });


    
    