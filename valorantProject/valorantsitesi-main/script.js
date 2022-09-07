var swiper = new Swiper(".slide-content", {
    slidesPerView: 3,
    spaceBetween: 25,
    loop: true,
    centerSlide: 'true',
    fade: 'true',
    grabCursor: 'true',
    pagination: {
      el: ".swiper-pagination",
      clickable: true,
      dynamicBullets: true,
    },
    navigation: {
      nextEl: ".swiper-button-next",
      prevEl: ".swiper-button-prev",
    },

    breakpoints:{
        0: {
            slidesPerView: 1,
        },
        520: {
            slidesPerView: 2,
        },
        950: {
            slidesPerView: 3,
        },
    },
    
  });
 
  // Footer ürün linkleri
  document.querySelector("#ınstagram").onclick=function()
  {
    window.location.href="https://www.instagram.com/kupastorem/"
  }
  document.querySelector("#shopier").onclick=function()
  {
    window.location.href="https://www.shopier.com/ShowProductNew/storefront.php?shop=kupastorem&sid=clhtdG1mN3RlbnZXakZNZzBfLTFfIF8g"
  }
  document.querySelector("#dolap").onclick=function()
  {
    window.location.href="https://dolap.com/profil/kupastorem"
  }



 
var myIndex = 0;
carousel();

function carousel() {
  var i;
  var x = document.getElementsByClassName("mySlides");
  for (i = 0; i < x.length; i++) {
    x[i].style.display = "none";  
  }
  myIndex++;
  if (myIndex > x.length) {myIndex = 1}    
  x[myIndex-1].style.display = "block";  
  setTimeout(carousel, 2000); // Change image every 2 seconds
}

  
  