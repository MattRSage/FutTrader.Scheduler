chrome.runtime.onMessage.addListener(function (request, sender, sendResponse) {
    // const re = new RegExp('player', 'gi');
    // const matches = document.documentElement.innerHTML.match(re);
    let active = document.getElementsByClassName('tns-item tns-slide-active')[0];
    let name = active.getElementsByClassName('name')[0].innerHTML;
    sendResponse({name: name});
    let message = {
        name: name
    };

    chrome.runtime.sendMessage(message);
})