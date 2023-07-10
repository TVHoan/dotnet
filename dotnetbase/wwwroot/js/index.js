var typingJobdescription = ["Tôi là 1 Kỹ sư phần mềm"]
var i = 0;
var speed = 50;
function typeWriter() {
    document.querySelector("#jobdescripton"
        .innerHtml = typingJobdescription[0].substring(0,i)) + "<span>\u25ae<span></span>";
    
    if (i++ != typingJobdescription[0].length) {
        setTimeout(typeWriter, speed);
    }
}
document.addEventListener("load", typeWriter);
