/**
 * @param {string} s
 * @return {boolean}
 */
var checkValidString = function (s) {

    if (s === "*")
        return true;

    if (s.length === 0)
        return true;

    if (s.length === 1)
        return false;

    var x = s.split('');

    if (x[0] === ")")
        return false;

    var left = 0;
    for (var i = 0; i < x.length; i++) {
        const character = x[i];

        if (character === ")") {
            left--;
        } else
            left++;

        if (left < 0)
            return false;
    }

    if (left === 0)
        return true;

    var rigth = 0;
    for (var j = x.length - 1; j >= 0; j--) {
        const character2 = x[j];

        if (character2 === "(") {
            rigth--;
        } else
            rigth++;

        if (rigth < 0)
            return false;

    }
    return true;
};
var assert = !assert ? require('assert') : assert;
describe('Valid Parenthesis String ', function () {

    it('Case 1: basic', function () {
        var s = "()";

        var result = checkValidString(s);

        assert.equal(result, true);
    });

    it('Case 2: start right', function () {
        var s = ")(";

        var result = checkValidString(s);

        assert.equal(result, false);
    });

    it('Case 3: asterisk right', function () {
        var s = "()(*";

        var result = checkValidString(s);

        assert.equal(result, true);
    });
    it('Case 4: asterisk start and one rigth', function () {
        var s = "*)";

        var result = checkValidString(s);

        assert.equal(result, true);
    });
    it('Case 5: asterisk start and only many rigth', function () {
        var s = "*)))";

        var result = checkValidString(s);

        assert.equal(result, false);
    });
    it('Case 6: asterisks', function () {
        var s = "())";

        var result = checkValidString(s);

        assert.equal(result, false);
    });
    it('Case 7: one empty asterisks ', function () {
        var s = "(*)";

        var result = checkValidString(s);

        assert.equal(result, true);
    });
    it('Case 8: two empty asterisk', function () {
        var s = "(*)**";

        var result = checkValidString(s);

        assert.equal(result, true);
    });
    it('Case 10: one empty asterisk and right', function () {
        var s = "(*))";

        var result = checkValidString(s);

        assert.equal(result, true);
    });
    it('Case 11: three asterisk', function () {
        var s = "(())((())()()(*)(*()(())())())()()((()())((()))(*";

        var result = checkValidString(s);

        assert.equal(result, false);
    });
});
