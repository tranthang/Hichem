/*Easy Slider*/
if (top && (typeof top.inpageedit === 'undefined' || top.inpageedit == false)) {
    $(function () {
        $('#slider img:gt(0)').hide();
        setInterval(function () {
            $('#slider :first-child').fadeOut(0)
         .next('img').fadeIn(0)
         .end().appendTo('#slider');
        },
      3000);
    });
}

/*Menu Slider*/
$(document).ready(function () {
    var imgHeight = $('#slider img')[0].height;
     $('#slider').height(imgHeight);
});