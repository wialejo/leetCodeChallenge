/**
 * @param {character[][]} grid
 * @return {number}
 */

var numIslands = function (grid) {
    var islands = 0;

    function checkEdges(row, column) {
        var maxIndexColumns = grid[row].length - 1;
        var maxIndexRows = grid.length - 1;

        if (grid[row][column] === "1") {
            grid[row][column] = "0";

            if ((column + 1) <= maxIndexColumns && grid[row][column + 1] === "1") {
                checkEdges(row, column + 1)
            }

            if ((row + 1) <= maxIndexRows && grid[row + 1][column] === "1") {
                checkEdges(row + 1, column)
            }

            if ((column - 1) >= 0 && grid[row][column - 1] === "1") {
                checkEdges(row, column - 1)
            }
            if ((row - 1) >= 0 && grid[row - 1][column] === "1") {
                checkEdges(row - 1, column)
            }
        }
    }

    for (var x = 0; x < grid.length; x++) {
        for (var y = 0; y < grid[x].length; y++) {
            if (grid[x][y] === "1") {
                islands++;

                checkEdges(x, y, grid);
            }
        }
    }
    return islands;
};

var assert = !assert ? require('assert') : assert;
describe('Number of islands ', function () {

    it('Case 1: one island at the beginning', function () {
        var grid = [["1", "1", "1", "1", "0"], ["1", "1", "0", "1", "0"], ["1", "1", "0", "0", "0"], ["0", "0", "0", "0", "0"]];


        var result = numIslands(grid);

        assert.equal(result, 1);
    });

    it('Case 2: three islands', function () {
        var grid = [["1", "1", "0", "0", "0"], ["1", "1", "0", "0", "0"], ["0", "0", "1", "0", "0"], ["0", "0", "0", "1", "1"]];


        var result = numIslands(grid);

        assert.equal(result, 3);
    });
    it('Case 3: one full island', function () {
        var grid = [["1", "1", "1"], ["0", "1", "0"], ["1", "1", "1"]];

        var result = numIslands(grid);

        assert.equal(result, 1);
    });

    it('Case 3: one island with land on top', function () {
        var grid = [["1", "1", "1", "0"], ["0", "1", "0", "0"], ["0", "1", "0", "1"], ["0", "1", "1", "1"]];

        var result = numIslands(grid);

        assert.equal(result, 1);
    });

    it('Case 3: two island with land on top', function () {
        var grid = [["1", "1", "1", "0"], ["0", "1", "0", "0"], ["0", "0", "0", "1"], ["0", "1", "1", "1"]];

        var result = numIslands(grid);

        assert.equal(result, 2);
    });
});
