var tabPanels=document.querySelectorAll(".info .tabs .tab");
var tabProjInfo=document.querySelectorAll(".projektiInfo");
var listProj=document.querySelectorAll(".projektiNimi");
var listProjNuol=document.querySelectorAll(".projektiNuoli");
var listProjCanvas=document.querySelectorAll(".arrowCanvas");



function showTab(buttonIndex){
    tabPanels.forEach(function(node){
        node.style.display="none";
    });
    tabPanels[buttonIndex].style.display="block";
}

function openInfo(projIndex){
    listProj.forEach(function(proj){
        proj.style.backgroundColor="#f5faff";
    });
    listProjNuol.forEach(function(proj){
        proj.style.backgroundColor="#f5faff";
    });
    listProj[projIndex].style.backgroundColor="#d5eaff";
    listProjNuol[projIndex].style.backgroundColor="#d5eaff";


    tabProjInfo.forEach(function(disp){
        disp.style.display="none";
    });
    tabProjInfo[projIndex].style.display="block";

    rotateArrow(projIndex);
}

function drawArrows(){
    listProjCanvas.forEach(function(canv){
        var ctx = canv.getContext("2d");
        ctx.beginPath();
        ctx.moveTo(5, 0);
        ctx.lineTo(10, 9);
        ctx.lineTo(0, 9);
        ctx.closePath();
        ctx.lineWidth = 1;
        ctx.strokeStyle = '#666666';
        ctx.stroke();
        ctx.fillStyle = "#B5CAFF";
        ctx.fill();        
    });    
}

function rotateArrow(arrowIndex){
    listProjCanvas.forEach(function(canv){
        canv.style.transform = "rotate(0deg)";
    });
    listProjCanvas[arrowIndex].style.transform = "rotate(90deg)";
}


showTab(0);
tabProjInfo.forEach(function(disp){
    disp.style.display="none";
});
drawArrows();
openInfo(0);


