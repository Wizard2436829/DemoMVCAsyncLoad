//Language And Currency Js***
$('#selectCountry').flagStrap({
    buttonType: "btn-country",
    labelMargin: "10px",
    scrollable: false,
    scrollableHeight: "250px",
   
});

//Login Form Js***
function hideAll(){
     document.getElementById("signIn").style.display="none";
     document.getElementById("signUp").style.display="none";
     document.getElementById("forgotPassword").style.display="none";    
}
function show(elementId) { 
    hideAll();
    document.getElementById(elementId).style.display="block";
}
// Booking engine radio button js ***START***


// Navbar menu active js ***START*** Add active class to the current button (highlight it)
$(document).ready(function(){
  $('.navbar-nav li').click(function(){
    $('.navbar-nav li').removeClass("active");
    $(this).addClass("active");
});
});

// Mobile menu js
$(document).ready(function() {
    $("#my-navmenu").click(function() {
        if ($(".slidable-nav").hasClass("opened")) {
            $(".slidable-nav, .overlay").removeClass("opened");
        } else {
            $(".slidable-nav, .overlay").addClass("opened");
        }
    });
    
    $(".slidable-close, .overlay").click(function() {
        $(".slidable-nav, .overlay").removeClass("opened");
    });
});

 // scrolltop
// fadeIn fadeOut
$(window).scroll(function () {
if ($(this).scrollTop() > 400) {
$('.scrollup').fadeIn();
} else {
$('.scrollup').fadeOut();
}
});
    // scrolltop
$('.scrollup').click(function (){
$("html,body").animate({
scrollTop: 0
}, 1000);
return false;
});




