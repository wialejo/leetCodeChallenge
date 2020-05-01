/**
 * @param {number[]} nums
 * @return {boolean}
 */
var canJump = function (nums) {
    var i = 0;
    while (i <= nums.length - 1) {
        if (i === nums.length - 1) {
            return true;
        } else {
             var currentValue = nums[i];
            if (nums[nums.length-1] === 0)
                return true;
            if (currentValue === 0)
                return false;
            i =  i + currentValue ;
        }
    }
    return false;
};

var assert = !assert ? require('assert') : assert;
describe('Jump Game', function () {
    it('Case 1', function () {
        var nums = [2, 3, 1, 1, 4];

        var result = canJump(nums);

        assert.equal(result, true);
    });
    it('Case 2', function () {
        var nums = [3, 2, 1, 0, 4];

        var result = canJump(nums);

        assert.equal(result, false);
    });
    it('Case 3', function () {
        var nums = [0];

        var result = canJump(nums);

        assert.equal(result, true);
    });
    it('Case 4', function () {
        var nums = [2, 0];

        var result = canJump(nums);

        assert.equal(result, true);
    });
});
