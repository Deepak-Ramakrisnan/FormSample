function AddTabIndex() {
    debugger;
    setTimeout(function () {
        var popupEle = document.querySelector('.e-popup');
        popupEle.setAttribute('tabindex', '0');
        popupEle.focus();

        var elem = document.querySelector('.e-btn.e-today');
        elem.setAttribute('tabindex', '0');

        var todayDate = document.querySelector('.e-focused-date');
        todayDate.setAttribute('tabindex', '0');

        var previous = document.querySelector('.e-prev');
        previous.setAttribute('tabindex', '0');

        var next = document.querySelector('.e-next');
        next.setAttribute('tabindex', '0');

    }, 1500);

}