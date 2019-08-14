function swap_OnResize() {
  if ($(this).width() != width) {
    width = $(this).width();

    if (width <= 975) {
      document.getElementById('right_head').src = 'images/about_head.png';
    } else {
      document.getElementById('right_head').src = 'images/right_head.jpg';
    }
  }
}

window.onbeforeunload = function() {
  window.scrollTo(0, 0);
}
window.onload = swap_OnResize;
function viewOnGit(url, elementID) {
  var btn = document.createElement("SPAN"); // Create a <button> element
  btn.innerHTML = '<a href="' + url + '"><img style="height:40px;float:right;" src="images/gitcat.png" /></a>'; // Insert text
  document.getElementById(elementID).appendChild(btn);
}

var width = $(window).width();
$(window).on('resize', swap_OnResize);
