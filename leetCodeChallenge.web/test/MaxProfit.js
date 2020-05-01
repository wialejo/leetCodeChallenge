var assert =  !assert ? require('assert') : assert;

var maxProfit = function(prices) {
    return prices.reduce(function(a, c, i, arr){
        var dif = arr[i+1] - c;
        let sum = (dif > 0 ) ? dif : 0;
        a = a + sum;
        return a;
    }, 0);
};

describe('Best Time to Buy and Sell Stock II (By Didier)', function() {
    it('Case 1: input [7,1,5,3,6,4] max profit = 7', function() {
        var prices = [7,1,5,3,6,4];
        assert.equal(maxProfit(prices), 7);
    });

    it('Case 2: input [1,2,3,4,5] max profit = 4', function() {
        var prices = [1,2,3,4,5];
        assert.equal(maxProfit(prices), 4);
    });
});
