function getUsernames(threshold) {
    var url = "https://jsonmock.hackerrank.com/api/article_users?page=" + threshold;

    const https = require('https');
    const req = https.request(url, res => {
        console.log(`statusCode: ${res.statusCode}`)

        res.on('data', d => {
            process.stdout.write(d)
        })

        res.on('end', function () {
            console.log(req.data);
            console.log(str);
            // your code here if you want to use the results !
        });
    })

    req.on('error', error => {
        console.error(error)
    })

    req.end()

}

// function httpGet(url, success) {
//     const https = require('https')
//     const options = {
//         hostname: 'whatever.com',
//         port: 443,
//         path: '/todos',
//         method: 'GET'
//     }
//
//     const req = https.request(options, res => {
//         console.log(`statusCode: ${res.statusCode}`)
//
//         res.on('data', d => {
//             process.stdout.write(d)
//         })
//     })
//
//     req.on('error', error => {
//         console.error(error)
//     })
//
//     req.end()
//     //
//     // var xhttp = new XMLHttpRequest();
//     // xhttp.onreadystatechange = function () {
//     //     if (this.readyState == 4 && this.status == 200) {
//     //         // Typical action to be performed when the document is ready:
//     //         document.getElementById("demo").innerHTML = xhttp.responseText;
//     //         success(xhttp.responseText);
//     //     }
//     // };
//     // xhttp.open("GET", url, true);
//     // xhttp.send();
// }


var assert = !assert ? require('assert') : assert;
describe('ContiguosnArray', function () {
    it('Case 1: minimun length', function () {
        var threshold = [0, 1];

        var result = getUsernames(threshold);
        console.log(result);
        //assert.equal(result, 2);
    });
});
