/*Memilih angka untuk ditebak*/
function NumberSelection() {
    $('a.dozen').click(function () {
        $('#bet-type').text("dozen");
        $('#bet-type').attr("data-id", "DZ");
    });
    $('a.low-or-high').click(function () {
        $('#bet-type').text("low or high");
        $('#bet-type').attr("data-id", "LH");
    });
    $('a.odd-numbers').click(function () {
        $('#bet-type').text("event or odd");
        $('#bet-type').attr("data-id", "EO");
    });
    $('a.red-or-black').click(function () {
        $('#bet-type').text("red or black");
        $('#bet-type').attr("data-id", "RB");
    });
    $('#five-number').click(function () {
        $('#bet-type').text("five number");
        $('#bet-type').attr("data-id", "FN");
    });
    $('a.column').click(function () {
        $('#bet-type').text("column");
        $('#bet-type').attr("data-id", "CO");
    });
    $('a.straight-up, a.zero-number').click(function () {
        $('#bet-type').text("straight up");
        $('#bet-type').attr("data-id", "SU");
    });
    $('a.split-bet').click(function () {
        $('#bet-type').text("split bet");
        $('#bet-type').attr("data-id", "SP");
    });
    $('a.street-bet').click(function () {
        $('#bet-type').text("street bet");
        $('#bet-type').attr("data-id", "ST");
    });

    $('#1-12').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#1, #2, #3, #4, #5, #6, #7, #8, #9, #10, #11, #12').addClass("selected");
    });
    $('#13-24').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#13, #14, #15, #16, #17, #18, #19, #20, #21, #22, #23, #24').addClass("selected");
    });
    $('#25-36').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#25, #26, #27, #28, #29, #30, #31, #32, #33, #34, #35, #36').addClass("selected");
    });
    $('#1-18').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#1, #2, #3, #4, #5, #6, #7, #8, #9, #10, #11, #12, #13, #14, #15, #16, #17, #18').addClass("selected");
    });
    $('#19-36').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#19, #20, #21, #22, #23, #24, #25, #26, #27, #28, #29, #30, #31, #32, #33, #34, #35, #36').addClass("selected");
    });
    $('#even').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#2, #4, #6, #8, #10, #12, #14, #16, #18, #20, #22, #24, #26, #28, #30, #32, #34, #36').addClass("selected");
    });
    $('#odd').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#1, #3, #5, #7, #9, #11, #13, #15, #17, #19, #21, #23, #25, #27, #29, #31, #33, #35').addClass("selected");
    });
    $('#red').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#1, #3, #5, #7, #9, #12, #14, #16, #18, #19, #21, #23, #25, #27, #30, #32, #34, #36').addClass("selected");
    });
    $('#black').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#2, #4, #6, #8, #10, #11, #13, #15, #17, #20, #22, #24, #26, #28, #29, #31, #33, #35').addClass("selected");
    });
    $('#five-number').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#0, #00, #1, #2, #3').addClass("selected");
    });
    $('#0').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#0').addClass("selected");
    });
    $('#00').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#00').addClass("selected");
    });
    $('#1').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#1').addClass("selected");
    });
    $('#1-2').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#1, #2').addClass("selected");
    });
    $('#2').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#2').addClass("selected");
    });
    $('#2-3').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#2, #3').addClass("selected");
    });
    $('#3').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#3').addClass("selected");
    });
    $('#1-3').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#1, #2, #3').addClass("selected");
    });
    $('#4').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#4').addClass("selected");
    });
    $('#4-5').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#4, #5').addClass("selected");
    });
    $('#5').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#5').addClass("selected");
    });
    $('#5-6').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#5, #6').addClass("selected");
    });
    $('#6').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#6').addClass("selected");
    });
    $('#4-6').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#4, #5, #6').addClass("selected");
    });
    $('#7').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#7').addClass("selected");
    });
    $('#7-8').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#7, #8').addClass("selected");
    });
    $('#8').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#8').addClass("selected");
    });
    $('#8-9').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#8, #9').addClass("selected");
    });
    $('#9').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#9').addClass("selected");
    });
    $('#7-9').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#7, #8, #9').addClass("selected");
    });
    $('#10').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#10').addClass("selected");
    });
    $('#10-11').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#10, #11').addClass("selected");
    });
    $('#11').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#11').addClass("selected");
    });
    $('#11-12').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#11, #12').addClass("selected");
    });
    $('#12').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#12').addClass("selected");
    });
    $('#10-12').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#10, #11, #12').addClass("selected");
    });
    $('#13').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#13').addClass("selected");
    });
    $('#13-14').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#13, #14').addClass("selected");
    });
    $('#14').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#14').addClass("selected");
    });
    $('#14-15').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#14, #15').addClass("selected");
    });
    $('#15').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#15').addClass("selected");
    });
    $('#13-15').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#13, #14, #15').addClass("selected");
    });
    $('#16').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#16').addClass("selected");
    });
    $('#16-17').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#16, #17').addClass("selected");
    });
    $('#17').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#17').addClass("selected");
    });
    $('#17-18').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#17, #18').addClass("selected");
    });
    $('#18').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#18').addClass("selected");
    });
    $('#16-18').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#16, #17, #18').addClass("selected");
    });
    $('#19').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#19').addClass("selected");
    });
    $('#19-20').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#19, #20').addClass("selected");
    });
    $('#20').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#20').addClass("selected");
    });
    $('#20-21').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#20, #21').addClass("selected");
    });
    $('#21').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#21').addClass("selected");
    });
    $('#19-21').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#19, #20, #21').addClass("selected");
    });
    $('#22').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#22').addClass("selected");
    });
    $('#22-23').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#22, #23').addClass("selected");
    });
    $('#23').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#23').addClass("selected");
    });
    $('#23-24').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#23, #24').addClass("selected");
    });
    $('#24').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#24').addClass("selected");
    });
    $('#22-24').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#22, #23, #24').addClass("selected");
    });
    $('#25').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#25').addClass("selected");
    });
    $('#25-26').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#25, #26').addClass("selected");
    });
    $('#26').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#26').addClass("selected");
    });
    $('#26-27').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#26, #27').addClass("selected");
    });
    $('#27').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#27').addClass("selected");
    });
    $('#25-27').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#25, #26, #27').addClass("selected");
    });
    $('#28').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#28').addClass("selected");
    });
    $('#28-29').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#28, #29').addClass("selected");
    });
    $('#29').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#29').addClass("selected");
    });
    $('#29-30').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#29, #30').addClass("selected");
    });
    $('#30').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#30').addClass("selected");
    });
    $('#28-30').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#28, #29, #30').addClass("selected");
    });
    $('#31').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#31').addClass("selected");
    });
    $('#31-32').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#31, #32').addClass("selected");
    });
    $('#32').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#32').addClass("selected");
    });
    $('#32-33').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#32, #33').addClass("selected");
    });
    $('#33').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#33').addClass("selected");
    });
    $('#31-33').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#31, #32, #33').addClass("selected");
    });
    $('#34').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#34').addClass("selected");
    });
    $('#34-35').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#34, #35').addClass("selected");
    });
    $('#35').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#35').addClass("selected");
        $('#bet-type').text("straight up");
    });
    $('#35-36').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#35, #36').addClass("selected");
    });
    $('#36').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#36').addClass("selected");
    });
    $('#34-36').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#34, #35, #36').addClass("selected");
    });
    $('#1st-column').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#1, #4, #7, #10, #13, #16, #19, #22, #25, #28, #31, #34').addClass("selected");
    });
    $('#2nd-column').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#2, #5, #8, #11, #14, #17, #20, #23, #26, #29, #32, #35').addClass("selected");
    });
    $('#3rd-column').click(function () {
        $('.bottom-container a').removeClass("selected");
        $('#3, #6, #9, #12, #15, #18, #21, #24, #27, #30, #33, #36').addClass("selected");
    });
}