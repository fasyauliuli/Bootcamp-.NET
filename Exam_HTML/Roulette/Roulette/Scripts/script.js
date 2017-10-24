var totalTaruhan;
var totalUang;
var sisaUang;
var i;
var pick = new Array();
var priceTag;
var a = new Array();

function chips(totalMoney) {
    var arrayChips = new Array();
    arrayChips[0] = 5000;
    arrayChips[1] = 1000;
    arrayChips[2] = 500;
    arrayChips[3] = 100;
    arrayChips[4] = 25;
    arrayChips[5] = 5;

    var totalMoney;
    var totalChip = new Array();
    totalChip[0] = 0;
    totalChip[1] = 0;
    totalChip[2] = 0;
    totalChip[3] = 0;
    totalChip[4] = 0;
    totalChip[5] = 0;

    while (totalMoney != 0) {
        if (totalMoney % arrayChips[0] == 0) {
            totalChip[0]++;
            totalMoney -= arrayChips[0];
        }
        else if (totalMoney % arrayChips[1] == 0) {
            totalChip[1]++;
            totalMoney -= arrayChips[1];
        }
        else if (totalMoney % arrayChips[2] == 0) {
            totalChip[2]++;
            totalMoney -= arrayChips[2];
        }
        else if (totalMoney % arrayChips[3] == 0) {
            totalChip[3]++;
            totalMoney -= arrayChips[3];
        }
        else if (totalMoney % arrayChips[4] == 0) {
            totalChip[4]++;
            totalMoney -= arrayChips[4];
        }
        else if (totalMoney % arrayChips[5] == 0) {
            totalChip[5]++;
            totalMoney -= arrayChips[5];
        }
    }

    var fiveGrand = $('#five-grand-quantity').text(totalChip[0]);
    var oneGrand = $('#one-grand-quantity').text(totalChip[1]);
    var fiveHundred = $('#five-hundred-quantity').text(totalChip[2]);
    var oneHundred = $('#one-hundred-quantity').text(totalChip[3]);
    var twentyFive = $('#twenty-five-quantity').text(totalChip[4]);
    var five = $('#five-quantity').text(totalChip[5]);

    $('.five-grand input').attr('max', totalChip[0]);
    $('.one-grand input').attr('max', totalChip[1]);
    $('.five-hundred input').attr('max', totalChip[2]);
    $('.one-hundred input').attr('max', totalChip[3]);
    $('.twenty-five input').attr('max', totalChip[4]);
    $('.five input').attr('max', totalChip[5]);

    totalUang = totalMoney;
}

function getBet() {
    var bet = new Array(6);
    bet[0] = $('.five-grand input').val();
    bet[1] = $('.one-grand input').val();
    bet[2] = $('.five-hundred input').val();
    bet[3] = $('.one-hundred input').val();
    bet[4] = $('.twenty-five input').val();
    bet[5] = $('.five input').val();

    var totalBet = (bet[0] * 5000) + (bet[1] * 1000) + (bet[2] * 500) + (bet[3] * 100) + (bet[4] * 25) + (bet[5] * 5);
    return totalBet;
}

function disableBet() {
    $('.five-grand input').attr({ "disabled": true });
    $('.one-grand input').attr({ "disabled": true });
    $('.five-hundred input').attr({ "disabled": true });
    $('.one-hundred input').attr({ "disabled": true });
    $('.twenty-five input').attr({ "disabled": true });
    $('.five input').attr({ "disabled": true });
}

$(document).ready(function () {
    NumberSelection();
    $('#start-game-button').click(function () {
        var nama = $('.new-player-window input').val();
        $('#player-name').text(nama);

        var uang = $('.new-player-window select').val();
        $('#total-money').text(uang);

        $('.new-player-window').css("display", "none");
        $('.modal-dialog').css("display", "none");

        chips(uang)
    });

    $('#start-bet').click(function () {
        $('#total-bet').html(disableBet());
        $('#total-bet').html(getBet());
        $('#start-bet').css("display", "none");
    });

    $('#start-roll').click(function () {
        var rollNumber = Math.random() * 36;
        rollNumber = Math.ceil(rollNumber);
        $('.hit-number').text(rollNumber);
    });
    
});

function getJSON(name) {
    var betTypeMap;
    $.ajax({
        type: 'GET',
        url: '/Content/JSON/bettype.json',
        async: false,
        success: function (data) {
            betTypeMap = data;
        }
    });
    return betTypeMap;

    var priceBet = betTypeMap[nama].payout * totalTaruhan;

    var pick = $('.selected').map(function () {
        return $(this).text();
    })
        .get();

    for (i = 0; i < a.length; i++){
        if (rollNumber == pick[i]) {
        }
    }

    priceTag = priceBet + totalTaruhan;

    $('.hit-number').text(rollNumber);
    $('#total-price').text(priceTag);

    return betTypeMap;
}