function getTwoHeaviest(stones) {
    stones = stones.sort((a, b) => {
        if (a > b) {
            return -1;
        }
        if (b > a) {
            return 1;
        }
        return 0;
    });

    var y = stones[0]; // x <= y
    var x = stones[1]; // x <= y
    return {x, y}
}

var lastStoneWeight = function (stones) {
    if (stones.length === 0)
        return 0;

    if (stones.length === 1)
        return stones[0];

    var h = getTwoHeaviest(stones);
    var x = h.x;
    var y = h.y;
    var ix = 1;
    var iy = 0;

    if (x === y) // x y  are totally totally destroyed
        stones.splice(0, 2);
    else if (x !== y) {
        stones[iy] = y - x; // y get new value
        stones.splice(ix, 1); // x totally destroyed
    }


    return lastStoneWeight(stones);
};

var assert = !assert ? require('assert') : assert;
describe('Get last stone weight ', function () {

    it('Case 1: input [2, 7, 4, 1, 8, 1] assert=1', function () {
        var stones = [2, 7, 4, 1, 8, 1];

        var result = lastStoneWeight(stones);

        assert.equal(result, 1);
    });
    it('Case 1: input [2, 8, 1, 8, 1] assert=0', function () {
        var stones = [2, 8, 1, 8, 1];

        var result = lastStoneWeight(stones);

        assert.equal(result, 0);
    });
    it('Case 1: input [1] assert=1', function () {
        var stones = [1];

        var result = lastStoneWeight(stones);

        assert.equal(result, 1);
    });
    it('Case 1: input [] assert=0', function () {
        var stones = [];

        var result = lastStoneWeight(stones);

        assert.equal(result, 0);
    });
    describe('Choose 2 heaviest', function () {
        it('Case 1: [2,7,4,1,8,1] result: x=7 y=8)', function () {
            var stones = [2, 7, 4, 1, 8, 1];

            var result = getTwoHeaviest(stones);

            assert.equal(result.x, 7);
            assert.equal(result.y, 8);
        });
        it('Case 1: [2, 3, 1, 3, 1] result: x=3 y=3)', function () {
            var stones = [2, 3, 1, 3, 1];

            var result = getTwoHeaviest(stones);

            assert.equal(result.x, 3);
            assert.equal(result.y, 3);
        });
    });
});
