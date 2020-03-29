document.addEventListener('DOMContentLoaded', function() {
    document.querySelector('button').addEventListener('click', onclick, false);

    function onclick() {
        let bgPage = chrome.extension.getBackgroundPage();
        let name = bgPage.name;
        
        let url = `http://localhost:5000/playercard/${name}`;

        loadJSON(url, gotData);
        // chrome.tabs.query(
        //     {
        //         currentWindow: true,
        //         active: true
        //     },
        //     function(tabs) {
        //         chrome.tabs.sendMessage(tabs[0].id, 'hi', getPlayerCard);
        //     }
        // )
    }

    function gotData(data) {
        const div = document.createElement('div');
        div.textContent = `${data[0].price}`;
        document.body.appendChild(div);
    }

    function getPlayerCard (res) {
        const div = document.createElement('div');
        div.textContent = `${res.name}`;
        document.body.appendChild(div);
    }

}, false);