/**
 * @param {string} s
 * @param {number[][]} shift
 * @return {string}
 */
var stringShift = function (s, shift) {
    var word = s.split('');
    for (var i = 0; i < shift.length; i++) {
        var move = shift[i];
        var direction = move[0];
        var amount = move[1];

        function RightShift() {
            var endIndex = word.length-1;
            var character = word[endIndex];
            word.splice(endIndex, 1);
            word.unshift(character);
        }
        function LeftShift() {
            var character = word[0];
            word.splice(0, 1);
            word.push(character);
        }

        if (direction === 0) {
            for (var m = 0; m < amount; m++) {
                LeftShift()
            }
        }
        if (direction === 1) {
            for (var n = 0; n < amount; n++) {
                RightShift()
            }
        }

    }
    return word.join('');
};
var assert = !assert ? require('assert') : assert;
describe('Perform String Shifts ', function () {
    it('Case 1: shift to left by 1', function () {
        var s = "abc", shift = [[0, 1]]

        var result = stringShift(s, shift);

        assert.equal(result, "bca");
    });
    it('Case 2: shift to left by 2', function () {
        var s = "abc", shift = [[0, 2]]

        var result = stringShift(s, shift);

        assert.equal(result, "cab");
    });
    it('Case 3: shift to right by 1', function () {
        var s = "abc", shift = [[1,1]]

        var result = stringShift(s, shift);

        assert.equal(result, "cab");
    });
    it('Case 4: shift to right by 2', function () {
        var s = "abc", shift = [[1,2]]

        var result = stringShift(s, shift);

        assert.equal(result, "bca");
    });
    it('Case 5: two shift to right by 1', function () {
        var s = "abc", shift = [[1,1],[1,1]]

        var result = stringShift(s, shift);

        assert.equal(result, "bca");
    });
    it('Case 6: Multiple shift', function () {
        var s = "abcdefg", shift = [[1,1],[1,1],[0,2],[1,3]]

        var result = stringShift(s, shift);

        assert.equal(result, "efgabcd");
    });
    it('Case 7: Multiple Shift', function () {
        var s = "abcdefgxasfra", shift = [[1,1],[1,1],[0,2],[1,3],[0,2],[1,3],[0,2],[1,3],[1,1],[0,2],[1,3],[1,1],[0,2],[1,3]]

        var result = stringShift(s, shift);

        assert.equal(result, "efgxasfraabcd");
    });
});
