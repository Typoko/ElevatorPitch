var tabPanels=document.querySelectorAll(".info .tabs .tab");
var tabProjInfo=document.querySelectorAll(".projektiInfo");
var listProj=document.querySelectorAll(".projekti");

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
    listProj[projIndex].style.backgroundColor="#d5eaff";

    tabProjInfo.forEach(function(disp){
        disp.style.display="none";
    });
    tabProjInfo[projIndex].style.display="block";
}


showTab(0);
tabProjInfo.forEach(function(disp){
    disp.style.display="none";
});
openInfo(0);
