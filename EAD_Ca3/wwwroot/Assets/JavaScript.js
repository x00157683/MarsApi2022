const calendarBtn = document.querySelector('.rz-calendar button');

calendarBtn.addEventListener('click', () => {
    const datePicker = document.querySelector('div[id^=\'popup\'] + .rz-datepicker');
    //example width preference
    datePicker.style.width = "600px";
});