function openCity(evt, cityName) {
    // Declare all variables
    var i, tabcontent, tablinks;

    // Get all elements with class="tabcontent" and hide them
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    // Get all elements with class="tablinks" and remove the class "active"
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }

    // Show the current tab, and add an "active" class to the button that opened the tab
    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " active";
}



function up() {
var counter = parseInt(document.getElementById("demo").value);
counter += 1;
document.getElementById("demo").value = counter;
    
}
function down(){
var counter = parseInt(document.getElementById("demo").value);
counter -= 1;
document.getElementById("demo").value = counter;
}





//$(document).ready(function () {
//    //$('a.login-window').click(function () {
//    //    //lấy giá trị thuộc tính href - chính là phần tử "#login-box"
//        var loginBox = $(this).attr('href');

//        //cho hiện hộp đăng nhập trong 300ms
//        $(loginBox).fadeIn(300);

//        // thêm phần tử id="over" vào sau body
//        $('body').append('<div id="over">');
//        $('#over').fadeIn(300);

//        return false;
//    });

//    // khi click đóng hộp thoại
//    $(document).on('click', "a.close, #over", function () {
//        $('#over, .login').fadeOut(300, function () {
//            $('#over').remove();
//        });
//        return false;
//    });
