
var assert = !assert ? require('assert') : assert;
describe('Leftmost Column with at Least a One', function () {

    it('Case 1: ', function () {
        var grid = [[0, 0], [1, 1]]


        var result = numIslands(grid);

        assert.equal(result, 1);
    });
});
