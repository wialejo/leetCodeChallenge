
/**
 * @param {string[]} S
 * @param {string[]} T
 * @return {boolean}
 */
var backspaceCompare = function (S, T) {
    while (S.includes("#") || T.includes("#")) {

        var exp = new RegExp('[a-z]#')
        S = S.replace(exp, '');
        T = T.replace(exp, '');

        if (S.startsWith("#")) {
            S = S.replace("#", "");
        }
        if (T.startsWith("#")) {
            T = T.replace("#", "");
        }
    }
    return S === T;
};

var backSpaceRemove = function (T) {
    while (T.includes("#")) {
        T = T.replace(new RegExp('[a-z]#'), '');

        if (T.startsWith("#")) {
            T = T.replace("#", "");
        }
    }
    return T;
}

var assert = !assert ? require('assert') : assert;
describe('Backspace String Compare ', function () {
    it('Case 1: S = "ab#c", T = "ad#c"', function () {
        var S = "ab#c", T = "ad#c"

        var result = backspaceCompare(S, T);

        assert.equal(result, true);
    });

    it('Case 1: S = "ab##", T = "c#d#"', function () {
        var S = "ab##", T = "c#d#";

        var result = backspaceCompare(S, T);

        assert.equal(result, true);
    });

    it('Case 1: S = "a#c", T = "b"', function () {
        var S = "a#c", T = "b";

        var result = backspaceCompare(S, T);

        assert.equal(result, false);
    });

    it('Case 1: S = "a#c", T = "b"', function () {
        var S = "a##c", T = "#a#c";

        var result = backspaceCompare(S, T);

        assert.equal(result, true);
    });

    describe('backspace ', function () {
        it('Case 1: input = as#xxsa###v#c# resul = ax', function () {
            var S = "as#xxsa###v#c#";

            var result = backSpaceRemove(S);

            assert.equal(result, "ax");
        });
        it('Case 1: input = c#d# resul = ""', function () {
            var S = "c#d#";

            var result = backSpaceRemove(S);

            assert.equal(result, "");
        });

        it('Case 1: input = assa##v#c# resul = "as"', function () {
            var S = "assa##v#c#";

            var result = backSpaceRemove(S);

            assert.equal(result, "as");
        });
        it('Case 1: input = a#v#c# resul = "as"', function () {
            var S = "a#v#c#";

            var result = backSpaceRemove(S);

            assert.equal(result, "");
        });
        it('Case 1: input = a#c resul = "c"', function () {
            var S = "a#c";

            var result = backSpaceRemove(S);

            assert.equal(result, "c");
        });
        it('Case 1: input = a##c resul = "c"', function () {
            var S = "a##c";

            var result = backSpaceRemove(S);

            assert.equal(result, "c");
        });
        it('Case 1: input = #a#c resul = "c"', function () {
            var S = "#a#c";

            var result = backSpaceRemove(S);

            assert.equal(result, "c");
        });
        it('Case 1: input = bxj##tw resul = "btw"', function () {
            var S = "bxj##tw";

            var result = backSpaceRemove(S);

            assert.equal(result, "btw");
        });
        it('Case 1: input = bxo#j##tw resul = "btw"', function () {
            var S = "bxo#j##tw";

            var result = backSpaceRemove(S);

            assert.equal(result, "btw");
        });
        it('Case 1: input = c##vnvr resul = "vnvr"', function () {
            var S = "c##vnvr";

            var result = backSpaceRemove(S);

            assert.equal(result, "vnvr");
        });
        it('Case 1: input = c##vn#nvr resul = "vnvr"', function () {
            var S = "c##vn#nvr";

            var result = backSpaceRemove(S);

            assert.equal(result, "vnvr");
        });
    });

});
