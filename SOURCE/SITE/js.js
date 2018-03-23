function scr(){
    //alert(window.pageYOffset);
    if(window.pageYOffset>100) document.getElementById("up").style.opacity="100";
    else document.getElementById("up").style.opacity="0";
}