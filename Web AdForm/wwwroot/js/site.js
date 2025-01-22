// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


document.addEventListener("DOMContentLoaded", () => {
    var dropdownElementList = [].slice.call(document.querySelectorAll('.dropdown-toggle'))
    var dropdownList = dropdownElementList.map(function (dropdownToggleEl) {
        return new bootstrap.Dropdown(dropdownToggleEl)
    })

    dropdownList.forEach(d => d.show())
})


//function toggleAd() {
//    const ad = document.querySelector('#ad')

//    ad.classList.toggle('hide')

//    setTimeout(() => {

//    // focus fisrt input

//    ad.querySelector('#email').focus()
//    }, 1001)

//}